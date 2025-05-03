using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraReports.UI;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang.Controllers;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang
{
    public partial class FormBill : Form
    {
        private int _currentBillId;
        private bool _isShow;
        private FormQuanLyBanAn _parentFormQLBA;
        private FormQuanLyHoaDon formQuanLyHoaDon;
        private int _formType;
        private decimal _totalAmount;
        private decimal _totalDiscountAmount;
        private HoaDonController _hoaDonController;
        private KhachHangController _khachHangController;
        private KhuyenMaiController _khuyenMaiController;
        private BanAnController _banAnController;
        private ThongKeController _thongKeController;
        private NhanVienController _nhanVienController;

        public FormBill(int currentMaHD, bool isShow, FormQuanLyBanAn parentFornQLBA, FormQuanLyHoaDon formQuanLyHoaDon)
        {
            InitializeComponent();
            _currentBillId = currentMaHD;
            _isShow = isShow;
            _parentFormQLBA = parentFornQLBA;
            this.formQuanLyHoaDon = formQuanLyHoaDon;

            _hoaDonController = new HoaDonController();
            _khachHangController = new KhachHangController();
            _khuyenMaiController = new KhuyenMaiController();
            _banAnController = new BanAnController();
            _thongKeController = new ThongKeController();
            _nhanVienController = new NhanVienController();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            panelNewType.Visible = false;
            panelOldType.Visible = _isShow ? false : true;
            panelChooseType.Visible = !_isShow;
            panelShow.Visible = _isShow;
            btnLuuLai.Visible = !_isShow;
            cbbKhachHang.Enabled = !_isShow;
            cbbKhuyenMai.Enabled = !_isShow;
            LoadDSKhachHang();
            LoadKhuyenMai();
            LoadBill();
        }

        private void LoadKhuyenMai()
        {
            var danhSachKhuyenMai = _khuyenMaiController.LayDanhSachKhuyenMai();
            cbbKhuyenMai.DisplayMember = "TenKM";
            cbbKhuyenMai.ValueMember = "MaKM";
            cbbKhuyenMai.DataSource = danhSachKhuyenMai;
        }

        private void LoadDSKhachHang()
        {
            var danhSachKhachHang = _khachHangController.LayDanhSachKhachHang();
            cbbKhachHang.DataSource = danhSachKhachHang;
            cbbKhachHang.DisplayMember = "HoTen";
            cbbKhachHang.ValueMember = "MaKH";
        }

        private void LoadBill()
        {
            var hoaDon = _hoaDonController.LayHoaDonTheoMa(_currentBillId);
            if (hoaDon != null)
            {
                _totalAmount = hoaDon.TongTien;
                _totalDiscountAmount = hoaDon.TongTien;
                var khachHang = _khachHangController.LayKhachHangTheoMa(hoaDon.MaKH);
                var nhanVien = _nhanVienController.LayNhanVienTheoMa(hoaDon.MaNV);
                lbMaHD.Text = hoaDon.MaHD.ToString();
                lbTenKH.Text = khachHang.HoTen;
                lbSDT.Text = khachHang.SDT;
                lbDiaChi.Text = khachHang.DiaChi;
                lbTenNhanVien.Text = nhanVien.HoTen;
                lbNgayLap.Text = hoaDon.NgayLap?.ToString("dd/MM/yyyy");
                txtTongTien.Text = "Tổng tiền: " + hoaDon.TongTien.ToString("F0") + " VNĐ";
                lbTrangThai.Text = hoaDon.TrangThai;

                if (hoaDon.MaKM.HasValue)
                {
                    cbbKhuyenMai.SelectedValue = hoaDon.MaKM.Value;
                }
                else
                {
                    cbbKhuyenMai.Text = "KHÔNG ÁP DỤNG KHUYẾN MÃI";
                }

                var chiTietHoaDon = _hoaDonController.LayChiTietHoaDon(hoaDon.MaHD);
                dgvMon.DataSource = chiTietHoaDon;
            }
        }

        private void cbChooseType_CheckedChanged(object sender, EventArgs e)
        {
            panelNewType.Visible = cbChooseType.Checked;
            panelOldType.Visible = !cbChooseType.Checked;
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (panelOldType.Visible)
            {
                var hoaDon = new HoaDon
                {
                    MaHD = _currentBillId,
                    MaKH = Convert.ToInt32(cbbKhachHang.SelectedValue),
                    TrangThai = "Đã thanh toán"
                };

                if (_hoaDonController.CapNhatHoaDon(hoaDon))
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                var khachHang = new KhachHang
                {
                    HoTen = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text
                };

                var maKH = _khachHangController.ThemKhachHangVaLayMa(khachHang);
                MessageBox.Show("Thêm khách hàng thành công!" + maKH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (maKH>0)
                {
                    var hoaDon = new HoaDon
                    {
                        MaHD = _currentBillId,
                        MaKH = maKH,
                        TrangThai = "Đã thanh toán"
                    };

                    if (_hoaDonController.CapNhatHoaDon(hoaDon))
                    {
                        MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //Cập nhật mã khuyến mãi
            if (cbbKhuyenMai.SelectedIndex != 0)
            {
                var khuyenMai = _khuyenMaiController.LayKhuyenMaiTheoMa(Convert.ToInt32(cbbKhuyenMai.SelectedValue));
                if (khuyenMai != null)
                {
                    _hoaDonController.CapNhatKhuyenMai(_currentBillId, khuyenMai.MaKM);
                }
                //Lấy giá trị khuyến mãi);
                var khuyenMaiValue = _totalAmount * (khuyenMai.GiamGiaPhanTram / 100) + khuyenMai.GiamGiaTienMat;
                _hoaDonController.CapNhatGiamGia(_currentBillId, khuyenMaiValue);
            }
            else
            {
                _hoaDonController.CapNhatKhuyenMai(_currentBillId, 0);
            }
            
            _hoaDonController.CapNhatTongTien(_currentBillId, _totalAmount);
            
            var maBan = _hoaDonController.LayMaBanTheoMaHD(_currentBillId);
            if (maBan > 0)
            {
                _banAnController.CapNhatTrangThaiBan(maBan, "Trống");
            }

            _thongKeController.CapNhatThongKe(_currentBillId);

            if (formQuanLyHoaDon != null)
            {
                formQuanLyHoaDon.LoadHoaDon();
            }

            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnLuuLai_Click(sender, e);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Xử lý in hóa đơn
            // Create a new instance of the Bill report  
            BillReport bill = new BillReport();

            // Load the bill data using the stored procedure  
            DataTable billData = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InHoaDonBH", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHD", _currentBillId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(billData);
                }
            }

            // Assign the data source to the Bill report  
            bill.DataSource = billData;

            // Show the report preview  
            ReportPrintTool printTool = new ReportPrintTool(bill);
            printTool.ShowPreview();
        }

        private void RecalculateTotalWithDiscount()
        {
            if (cbbKhuyenMai.SelectedIndex != 0)
            {
                var khuyenMai = _khuyenMaiController.LayKhuyenMaiTheoMa(Convert.ToInt32(cbbKhuyenMai.SelectedValue));
                if (khuyenMai != null)
                {
                    _totalDiscountAmount = _totalAmount * (1 - khuyenMai.GiamGiaPhanTram / 100) - khuyenMai.GiamGiaTienMat;
                    txtTongTien.Text = "Tổng tiền: " + _totalDiscountAmount.ToString("F0") + " VNĐ";
                    _totalDiscountAmount = _totalAmount - _totalDiscountAmount;
                }
            }
            else
            {
                _totalDiscountAmount = 0;
                txtTongTien.Text = "Tổng tiền: " + _totalAmount.ToString("F0") + "VNĐ";
            }
        }

        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateTotalWithDiscount();
        }
        
    }
}
