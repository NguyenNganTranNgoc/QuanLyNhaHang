using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhaHang.Controllers;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang
{
    public partial class FormQuanLyBanAn : Form
    {
        private List<BanAnUC> danhSachBanAn;
        private bool isUpdated;
        private int currentBanId;
        private int currentMaCTHD;
        private bool isLoadDone;
        private bool isNewBill;
        private int currentMaHD;
        private BanAnController _banAnController;
        private HoaDonController _hoaDonController;
        private MonAnController _monAnController;
        private List<ChiTietHoaDon> dsMonAnNew;
        private decimal totalMoney;

        public FormQuanLyBanAn()
        {
            InitializeComponent();
            _banAnController = new BanAnController();
            _hoaDonController = new HoaDonController();
            _monAnController = new MonAnController();
            isLoadDone = false;
            LoadDanhSachBanAn();
        }

        public void LoadDanhSachBanAn()
        {
            danhSachBanAn = new List<BanAnUC>();
            var danhSachBan = _banAnController.LayDanhSachBanAn();

            foreach (var ban in danhSachBan)
            {
                int hoaDonId = 0;
                if (ban.TrangThai == "Bận")
                {
                    hoaDonId = _hoaDonController.LayHoaDonChuaThanhToan(ban.MaBan);
                }

                BanAnUC banAn = new BanAnUC
                {
                    Id = ban.MaBan,
                    SoBan = ban.SoBan,
                    LoaiBan = ban.LoaiBan,
                    TrangThai = ban.TrangThai,
                    HoaDonId = hoaDonId,
                    ParentForm = this
                };
                danhSachBanAn.Add(banAn);
            }

            panelCTBanAn.Visible = false;
            DisplayDanhSachBanAn(danhSachBanAn);
        }

        private void DisplayDanhSachBanAn(List<BanAnUC> danhSachBanAn)
        {
            panelBan.Controls.Clear();
            foreach (BanAnUC banAn in danhSachBanAn)
            {
                banAn.LoadDuLieu();
                banAn.Dock = DockStyle.Top;
                panelBan.Controls.Add(banAn);
            }
        }

        private void FormQuanLyBanAn_Load(object sender, EventArgs e)
        {
        }

        internal void BanClicked(int id)
        {
            var banAn = danhSachBanAn.FirstOrDefault(ban => ban.Id == id);
            txtTenBan.Text = "Bàn " + (banAn.SoBan < 10 ? "0" + banAn.SoBan : banAn.SoBan);
            panelGoiMon.Visible = banAn.TrangThai == "Trống";
            panelCTMon.Visible = false;
            lbDVT.Text = "";
            lbGiaMon.Text = "";
            btnGoiMon.Text = "GỌI MÓN";
            panelThanhToan.Visible = panelDsMon.Visible = banAn.TrangThai == "Bận";
            if (banAn.TrangThai == "Bận")
            {
                LoadBillMon(banAn.HoaDonId);
                currentMaHD = (int)banAn.HoaDonId;
            }
            LoadDSChonMon();
            currentBanId = id;
            isNewBill = banAn.TrangThai == "Trống";
            panelCTBanAn.Visible = true;
            cbbMon.SelectedIndex = -1;
        }

        private void LoadDSChonMon()
        {
            var dsMon = _monAnController.LayDanhSachMonAn();
            cbbMon.DataSource = dsMon;
            cbbMon.DisplayMember = "TenMA";
            cbbMon.ValueMember = "MaMA";
            isLoadDone = true;
        }

        private void LoadBillMon(int? hoaDonId)
        {
            if (hoaDonId == null)
            {
                return;
            }

            var chiTietHoaDon = _hoaDonController.LayChiTietHoaDon((int)hoaDonId);
            dgvMon.DataSource = chiTietHoaDon;
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvMon.Rows)
            {
                if (row.Cells["Gia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal gia = Convert.ToDecimal(row.Cells["Gia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    tongTien += gia * soLuong;
                    totalMoney = tongTien;
                }
            }
            txtTongTien.Text = "Tổng tiền: " + tongTien.ToString("F1") + " VNĐ";
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            dgvMon.AutoGenerateColumns = false;
            if (btnGoiMon.Text == "GỌI MÓN")
            {
                panelDsMon.Visible = true;
                

                btnGoiMon.Text = "XÁC NHẬN";
                isNewBill = true;

                btnThemMon.Visible = true;
                lbDVT.Text = "";
                lbGiaMon.Text = "";
                nbrSoluong.Value = 0;
                cbbMon.SelectedIndex = -1;
            }
            else
            {
                if(dgvMon.Rows.Count < 1)
                {
                    MessageBox.Show("Vui lòng chọn món ăn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var hoaDon = new HoaDon
                {
                    MaBan = currentBanId,
                    MaNV = Se.Default.MaNV, // Giả sử nhân viên có mã 1
                    MaKH = 1, // Giả sử khách hàng có mã 1
                    NgayLap = DateTime.Now,
                    TongTien = 0,
                    TrangThai = "Chưa thanh toán",
                    MaKM = null, // Giả sử không áp dụng khuyến mãi
                    GiamGia = 0
                };

                var maHoaDon = _hoaDonController.TaoHoaDon(hoaDon);
                MessageBox.Show("Tạo hóa đơn thành công! "+ maHoaDon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (maHoaDon > 0)
                {
                    foreach (DataGridViewRow row in dgvMon.Rows)
                    {
                        if (row.Cells["MaMA"].Value != null && row.Cells["SoLuong"].Value != null)
                        {
                            var chiTietHoaDon = new ChiTietHoaDon
                            {
                                MaHD = maHoaDon,
                                MaMA = Convert.ToInt32(row.Cells["MaMA"].Value),
                                SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                                DonGia = Convert.ToDecimal(row.Cells["Gia"].Value),
                                
                            };

                            _hoaDonController.ThemChiTietHoaDon(maHoaDon, chiTietHoaDon);
                        }
                    }

                    TinhTongTien();
                    _hoaDonController.CapNhatTongTien(currentMaHD, totalMoney);
                    _banAnController.CapNhatTrangThaiBan(currentBanId, "Bận");

                    LoadDanhSachBanAn();
                    panelCTBanAn.Visible = false;
                }
            }
        }

        private void dgvMon_Click(object sender, EventArgs e)
        {
            if (dgvMon.CurrentRow != null)
            {
                currentMaCTHD = Convert.ToInt32(dgvMon.CurrentRow.Cells["MaCTHD"].Value);
                panelCTMon.Visible = true;
                btnLuu.Visible = true;
                btnXoa.Visible = true;
                btnThemMon.Visible = false;
            }
        }
        
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if(panelCTMon.Visible == false)
            {
                panelCTMon.Visible = true;
                btnLuu.Visible = false;
                btnXoa.Visible = false;
                return;
            } 
            if(isNewBill)
            {     
                if(dsMonAnNew == null)
                {
                    dsMonAnNew = new List<ChiTietHoaDon>();
                } 
                    
                var chiTietMonAn = new ChiTietHoaDon
                {
                    MaHD = currentMaHD,
                    MaMA = cbbMon.SelectedValue != null ? Convert.ToInt32(cbbMon.SelectedValue) : 0,
                    TenMA = cbbMon.Text,
                    SoLuong = nbrSoluong.Value > 0 ? (int)nbrSoluong.Value : 0,
                    DonGia = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue)).Gia,
                    DVT = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue)).DonViTinh
                };
                //Nếu món ăn chưa tồn tại thì thêm mới
                if (dsMonAnNew.FirstOrDefault(x => x.MaMA == chiTietMonAn.MaMA) == null)
                {
                    dsMonAnNew.Add(chiTietMonAn);
                }
                else
                {
                    //Nếu món ăn đã có thì cập nhật số lượng
                    var chiTietMonAnUpdate = dsMonAnNew.FirstOrDefault(x => x.MaMA == chiTietMonAn.MaMA);
                    if (chiTietMonAnUpdate != null)
                    {
                        chiTietMonAnUpdate.SoLuong += (int)nbrSoluong.Value;
                    }
                }
                dgvMon.DataSource = null; // Đặt lại DataSource để cập nhật
                dgvMon.DataSource = dsMonAnNew;
                return;
            }

            if (cbbMon.SelectedValue != null && nbrSoluong.Value > 0)
            {
                var monAn = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue));
                

                if (monAn != null)
                {
                    //Nếu món ăn đã có thì cập nhật số lượng
                    var chiTietHoaDon = _hoaDonController.LayChiTietHoaDon(currentMaHD);
                    var chiTietMonAn = chiTietHoaDon.FirstOrDefault(x => x.MaMA == monAn.MaMA);
                    if (chiTietMonAn != null)
                    {
                        chiTietMonAn.SoLuong += (int)nbrSoluong.Value;
                        _hoaDonController.CapNhatChiTietHoaDon(chiTietMonAn);
                        LoadBillMon(currentMaHD);
                    }
                    else
                    {
                        // Nếu món ăn chưa có thì thêm mới
                        var chiTietHoaDonNew = new ChiTietHoaDon
                        {
                            MaHD = currentMaHD,
                            MaMA = monAn.MaMA,
                            SoLuong = (int)nbrSoluong.Value,
                            DonGia = monAn.Gia

                        };
                        if (_hoaDonController.ThemChiTietHoaDon(currentMaHD, chiTietHoaDonNew))
                        {
                            LoadBillMon(currentMaHD);
                        }
                    }
                    TinhTongTien();
                    _hoaDonController.CapNhatTongTien(currentMaHD, totalMoney);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvMon.CurrentRow != null)
            {
               if(isNewBill)
                {
                    //Update item in dsMonAnNew
                    var chiTietMonAn = dsMonAnNew.FirstOrDefault(x => x.MaMA == currentMaCTHD);
                    if (chiTietMonAn != null)
                    {
                        chiTietMonAn.SoLuong = (int)nbrSoluong.Value;
                        chiTietMonAn.DonGia = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue)).Gia;
                        chiTietMonAn.DVT = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue)).DonViTinh;
                        chiTietMonAn.TenMA = cbbMon.Text;
                        dgvMon.DataSource = null; // Đặt lại DataSource để cập nhật
                        dgvMon.DataSource = dsMonAnNew;
                    }
                    else
                    {
                        MessageBox.Show("Món ăn không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    return;
                }
                var chiTietHoaDon = new ChiTietHoaDon
                {
                    MaCTHD = currentMaCTHD,
                    MaHD = currentMaHD,
                    MaMA = cbbMon.SelectedValue != null ? Convert.ToInt32(cbbMon.SelectedValue) : 0,
                    DonGia = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue)).Gia,
                    SoLuong = nbrSoluong.Value > 0 ? (int)nbrSoluong.Value : 0,
                };

                if (_hoaDonController.CapNhatChiTietHoaDon(chiTietHoaDon))
                {
                    TinhTongTien();
                    _hoaDonController.CapNhatTongTien(currentMaHD, totalMoney);
                    LoadBillMon(currentMaHD);
                }
                panelCTMon.Visible = false;
                btnLuu.Visible = false;
                btnXoa.Visible = false;
                btnThemMon.Visible = true;
            }
        }

        private void cbbMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoadDone && cbbMon.SelectedValue != null)
            {
                var monAn = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue));
                if (monAn != null)
                {
                    lbDVT.Text = monAn.DonViTinh;
                    lbGiaMon.Text = monAn.Gia.ToString("N0") + " VNĐ";
                }
            }
        }

        private void cbbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadDone && cbbMon.SelectedValue != null)
            {
                var monAn = _monAnController.LayMonAnTheoMa(Convert.ToInt32(cbbMon.SelectedValue));
                if (monAn != null)
                {
                    lbDVT.Text = monAn.DonViTinh;
                    lbGiaMon.Text = monAn.Gia.ToString("N0") + " VNĐ";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMon.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (_hoaDonController.XoaChiTietHoaDon(currentMaCTHD))
                    {
                        TinhTongTien();
                        _hoaDonController.CapNhatTongTien(currentMaHD, totalMoney);
                        LoadBillMon(currentMaHD);
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FormBill formBill = new FormBill(currentMaHD, false, this, null);
            formBill.ShowDialog();
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            // Xử lý hiển thị thông tin chi tiết
            FormThongTinBanAn formThongTin = new FormThongTinBanAn(currentBanId, this);
            formThongTin.ShowDialog();
        }

        private void btnThemBanAn_Click(object sender, EventArgs e)
        {
            FormThongTinBanAn formThongTin = new FormThongTinBanAn(0, this);
            formThongTin.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelCTBanAn.Visible = false;
        }
    }
}
