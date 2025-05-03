using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Fields;
using QuanLyNhaHang.Controllers;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang
{
    public partial class FormPhieuNhapKho : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;
        private PhieuNhapKhoController _phieuNhapKhoController;
        private ChiTietPhieuNhapController _chiTietPhieuNhapController;
        private NguyenLieuController _nguyenLieuController;
        private bool _newPNK;
        private bool _isNewCTPN;
        private int _currentPNK;
        private bool _isSaved;

        public FormPhieuNhapKho()
        {
            InitializeComponent();
            _phieuNhapKhoController = new PhieuNhapKhoController();
            _chiTietPhieuNhapController = new ChiTietPhieuNhapController();
            _nguyenLieuController = new NguyenLieuController();
        }

        private void FormPhieuNhapKho_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuNhapKho();
            LoadComboBoxNL();
            ClearForm();
            panelCT.Visible = false;
            panelCTMon.Visible = false;
            _isNewCTPN = false;
            _isSaved = true;
        }

        private void LoadComboBoxNL()
        {
            var danhSachNguyenLieu = _nguyenLieuController.LayDanhSachNguyenLieu();
            cbbNL.DisplayMember = "TenNL";
            cbbNL.ValueMember = "MaNL";
            cbbNL.DataSource = danhSachNguyenLieu;
        }

        private void LoadDanhSachPhieuNhapKho()
        {
            var danhSachPhieuNhap = _phieuNhapKhoController.LayDanhSachPhieuNhapKho();
            dgvPhieuNhapKho.DataSource = danhSachPhieuNhap;
            dgvPhieuNhapKho.AllowUserToAddRows = false;
            dgvPhieuNhapKho.AllowUserToDeleteRows = false;
            dgvPhieuNhapKho.ReadOnly = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var danhSachPhieuNhap = _phieuNhapKhoController.TimKiemPhieuNhapKho(txtTimKiem.Text);
            dgvPhieuNhapKho.DataSource = danhSachPhieuNhap;
        }

        private void dgvPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isSaved)
            {
                var isAccept = AlertWarning.Show("Bạn đang cập nhật 1 phiếu nhập kho, bạn sẽ mất dữ liệu trước đó. Tiếp tục?");
                if (isAccept == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    _isSaved = true;
                    _chiTietPhieuNhapController.XoaChiTietPhieuNhap(_currentPNK);
                    _phieuNhapKhoController.XoaPhieuNhapKho(_currentPNK);
                }
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhapKho.Rows[e.RowIndex];
                txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                txtNhaCungCap.Text = row.Cells["NhaCungCap"].Value.ToString();
                int maPhieuNhap = Convert.ToInt32(row.Cells["MaPN"].Value);
                
                var chiTietPhieuNhap = _chiTietPhieuNhapController.LayChiTietPhieuNhap(maPhieuNhap);
                dgvChiTietPhieuNhapKho.AutoGenerateColumns = false;
                dgvChiTietPhieuNhapKho.DataSource = chiTietPhieuNhap;
                dgvChiTietPhieuNhapKho.AllowUserToAddRows = false;
                dgvChiTietPhieuNhapKho.AllowUserToDeleteRows = false;
                dgvChiTietPhieuNhapKho.ReadOnly = true;

                txtTongTien.Text = "Tổng tiền nhập:" + row.Cells["TongTien"].Value.ToString();
                _currentPNK = maPhieuNhap;
                txtTenNV.Enabled = true;
                dtpNgayNhap.Enabled = true;
                btnXoaPN.Visible = true;
                panelCT.Visible = true;
            }
        }

        private void dgvChiTietPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietPhieuNhapKho.Rows[e.RowIndex];
                cbbNL.SelectedValue = row.Cells["MaNL"].Value;
                nbrSoluong.Value = Convert.ToInt64(row.Cells["SoLuong"].Value);
                nbrGiaNhap.Value = Convert.ToInt64(row.Cells["DonGia"].Value);
                txtDVT.Text = _nguyenLieuController.LayDonViTinh(row.Cells["MaNL"].Value.ToString());
            }
            panelCTMon.Visible = true;
            _isNewCTPN = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var chiTietPhieuNhap = new ChiTietPhieuNhap
            {
                MaPN = _currentPNK,
                MaNL = Convert.ToInt32(cbbNL.SelectedValue),
                SoLuong = Convert.ToInt32(nbrSoluong.Value),
                DonGia = Convert.ToDecimal(nbrGiaNhap.Value)
            };

            if (_isNewCTPN)
            {
                if (_chiTietPhieuNhapController.ThemChiTietPhieuNhap(chiTietPhieuNhap))
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                chiTietPhieuNhap.MaCTPN = Convert.ToInt32(dgvChiTietPhieuNhapKho.CurrentRow.Cells["MaCTPN"].Value);
                if (_chiTietPhieuNhapController.CapNhatChiTietPhieuNhap(chiTietPhieuNhap))
                {
                    MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDGVCTPN(_currentPNK);
            var tongTien = _chiTietPhieuNhapController.TinhTongTien(_currentPNK);
            txtTongTien.Text = "Tổng tiền nhập: " + tongTien.ToString() + " VNĐ";
            panelCTMon.Visible = false;
        }

        private void LoadDGVCTPN(int currentPNK)
        {
            var chiTietPhieuNhap = _chiTietPhieuNhapController.LayChiTietPhieuNhap(currentPNK);
            dgvChiTietPhieuNhapKho.DataSource = chiTietPhieuNhap;
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            panelCTMon.Visible = true;
            _isNewCTPN = true;
        }

        private void btnThemPNK_Click(object sender, EventArgs e)
        {
            panelCT.Visible = true;
            _newPNK = true;
            btnXoaPN.Visible = false;
            PhieuNhapKho pnK = new PhieuNhapKho()
            {
                NgayNhap = DateTime.Now,
                MaNV = Se.Default.MaNV,
                NhaCungCap = "",
                GhiChu = ""
            };
            txtTenNV.Text = Se.Default.TenNV;
            txtTenNV.Enabled = dtpNgayNhap.Enabled = false;
           _currentPNK = _phieuNhapKhoController.ThemPhieuNhapKho(pnK);
            _isSaved = false;
        }

        private void ClearForm()
        {
            txtTenNV.Text = "";
            txtNhaCungCap.Text = "";
            txtGhiChu.Text = "";
            txtTongTien.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            dgvChiTietPhieuNhapKho.DataSource = null;
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            var phieuNhapKho = new PhieuNhapKho
            {
                MaPN = _currentPNK,
                MaNV = Se.Default.MaNV,
                NgayNhap = dtpNgayNhap.Value,
                NhaCungCap = txtNhaCungCap.Text,
                TongTien = decimal.Parse(txtTongTien.Text.Split(':')[1].Trim().Split(' ')[0]),
                GhiChu = txtGhiChu.Text
            };
            //Update Kho Nguyen Liệu
            _phieuNhapKhoController.CapNhatKhoNguyenLieu(dgvChiTietPhieuNhapKho);
            if (_phieuNhapKhoController.CapNhatPhieuNhapKho(phieuNhapKho))
            {
                MessageBox.Show("Lưu phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhieuNhapKho();
                ClearForm();
                panelCT.Visible = false;
            }
            else
            {
                MessageBox.Show("Lưu phiếu nhập kho thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhapKho.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int maCTPN = Convert.ToInt32(dgvChiTietPhieuNhapKho.CurrentRow.Cells["MaCTPN"].Value);
                    if (_chiTietPhieuNhapController.XoaChiTietPhieuNhap(maCTPN))
                    {
                        MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGVCTPN(_currentPNK);
                        var tongTien = _chiTietPhieuNhapController.TinhTongTien(_currentPNK);
                        txtTongTien.Text = "Tổng tiền nhập: " + tongTien.ToString() + " VNĐ";
                    }
                    else
                    {
                        MessageBox.Show("Xóa nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (!_isSaved)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn hủy phiếu nhập kho này?", "Xác nhận hủy", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _chiTietPhieuNhapController.XoaChiTietPhieuNhap(_currentPNK);
                    _phieuNhapKhoController.XoaPhieuNhapKho(_currentPNK);
                }
            }
            panelCT.Visible = false;
            panelCTMon.Visible = false;
        }

        private void cbbNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNL.SelectedValue != null)
            {
                txtDVT.Text = _nguyenLieuController.LayDonViTinh(cbbNL.SelectedValue.ToString());
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập kho này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (_phieuNhapKhoController.XoaPhieuNhapKho(_currentPNK))
                {
                    MessageBox.Show("Xóa phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachPhieuNhapKho();
                    ClearForm();
                    panelCT.Visible = false;
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập kho thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
