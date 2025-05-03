using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhaHang.Controllers;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang
{
    public partial class FormKhuyenMai : Form
    {
        private KhuyenMaiController _khuyenMaiController;

        public FormKhuyenMai()
        {
            InitializeComponent();
            _khuyenMaiController = new KhuyenMaiController();
        }

        // Ham duoc goi khi form duoc load, goi ham LoadDanhSachKhuyenMai de tai danh sach khuyen mai
        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhuyenMai();
        }

        // Ham tai danh sach khuyen mai tu database va hien thi len DataGridView
        private void LoadDanhSachKhuyenMai()
        {
            var danhSachKhuyenMai = _khuyenMaiController.LayDanhSachKhuyenMai();
            dgvKhuyenMai.DataSource = danhSachKhuyenMai;
            dgvKhuyenMai.AllowUserToAddRows = false; // Khong cho phep them dong moi
            dgvKhuyenMai.AllowUserToDeleteRows = false; // Khong cho phep xoa dong
            dgvKhuyenMai.ReadOnly = true; // Chi doc
        }

        // Ham xu ly su kien khi nhan nut "Them moi", hien panel nhap thong tin va reset form
        private void btnThem1_Click(object sender, EventArgs e)
        {
            panelCT.Visible = true;
            btnThem.Visible = true;
            btnCapNhat.Visible = btnXoa.Visible = false;
            ClearForm();
        }

        // Ham xoa trang cac truong nhap lieu tren form
        private void ClearForm()
        {
            txtTenKM.Clear();
            txtMoTa.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            nudGiamGiaPhanTram.Value = 0;
            nudGiamGiaTienMat.Value = 0;
            txtDieuKienApDung.Clear();
            txtTenKM.Focus();
            panelCT.Visible = true;
            btnThem.Visible = true;
            btnCapNhat.Visible = btnXoa.Visible = false;
            dgvKhuyenMai.ClearSelection();
        }

        // Ham xu ly su kien khi nhan nut "Them", them khuyen mai moi vao database
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap()) // Kiem tra du lieu nhap hop le
            {
                return;
            }

            var khuyenMai = new KhuyenMai
            {
                TenKM = txtTenKM.Text,
                MoTa = txtMoTa.Text,
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                GiamGiaPhanTram = nudGiamGiaPhanTram.Value,
                GiamGiaTienMat = nudGiamGiaTienMat.Value,
                DieuKienApDung = txtDieuKienApDung.Text,
                TrangThai = cbTrangThai.Checked
            };

            if (_khuyenMaiController.ThemKhuyenMai(khuyenMai) > 0)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachKhuyenMai(); // Tai lai danh sach khuyen mai
                panelCT.Visible = false;
                btnThem.Visible = true;
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ham xu ly su kien khi nhan nut "Cap nhat", cap nhat thong tin khuyen mai trong database
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap()) // Kiem tra du lieu nhap hop le
            {
                return;
            }
            if (dgvKhuyenMai.CurrentRow.Index >= 0) // Kiem tra dong duoc chon
            {
                var khuyenMai = new KhuyenMai
                {
                    MaKM = Convert.ToInt32(dgvKhuyenMai.CurrentRow.Cells["MaKM"].Value),
                    TenKM = txtTenKM.Text,
                    MoTa = txtMoTa.Text,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value,
                    GiamGiaPhanTram = nudGiamGiaPhanTram.Value,
                    GiamGiaTienMat = nudGiamGiaTienMat.Value,
                    DieuKienApDung = txtDieuKienApDung.Text,
                    TrangThai = cbTrangThai.Checked
                };

                if (_khuyenMaiController.CapNhatKhuyenMai(khuyenMai))
                {
                    MessageBox.Show("Cập nhật khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhuyenMai(); // Tai lai danh sach khuyen mai
                }
                else
                {
                    MessageBox.Show("Cập nhật khuyến mãi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            panelCT.Visible = false;
            btnThem.Visible = true;
        }

        // Ham xu ly su kien khi nhan nut "Xoa", xoa khuyen mai khoi database
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.CurrentRow.Index >= 0) // Kiem tra dong duoc chon
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa khuyến mãi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int maKM = Convert.ToInt32(dgvKhuyenMai.CurrentRow.Cells["MaKM"].Value);
                    if (_khuyenMaiController.XoaKhuyenMai(maKM))
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachKhuyenMai(); // Tai lai danh sach khuyen mai
                    }
                    else
                    {
                        MessageBox.Show("Xóa khuyến mãi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            panelCT.Visible = false;
            btnThem.Visible = true;
        }

        // Ham kiem tra du lieu nhap vao co hop le hay khong
        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenKM.Text)) // Kiem tra ten khuyen mai khong duoc de trong
            {
                MessageBox.Show("Tên khuyến mãi không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value) // Kiem tra ngay bat dau khong duoc lon hon ngay ket thuc
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Ham xu ly su kien khi click vao DataGridView, hien thi thong tin khuyen mai len form
        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.CurrentRow.Index >= 0) // Kiem tra dong duoc chon
            {
                DataGridViewRow row = dgvKhuyenMai.CurrentRow;
                txtTenKM.Text = row.Cells["TenKM"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                nudGiamGiaPhanTram.Value = Convert.ToDecimal(row.Cells["GiamGiaPhanTram"].Value);
                nudGiamGiaTienMat.Value = Convert.ToDecimal(row.Cells["GiamGiaTienMat"].Value);
                txtDieuKienApDung.Text = row.Cells["DieuKienApDung"].Value.ToString();
                cbTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            }
        }

        // Ham xu ly su kien khi tim kiem, loc danh sach khuyen mai theo tu khoa
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text;
            var danhSachKhuyenMai = _khuyenMaiController.TimKiemKhuyenMai(searchText);
            dgvKhuyenMai.DataSource = danhSachKhuyenMai;
        }

        // Ham xu ly su kien khi click vao cell trong DataGridView, hien thi thong tin chi tiet len form
        private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhuyenMai.CurrentRow.Index >= 0) // Kiem tra dong duoc chon
            {
                DataGridViewRow row = dgvKhuyenMai.CurrentRow;
                txtTenKM.Text = row.Cells["TenKM"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                nudGiamGiaPhanTram.Value = Convert.ToDecimal(row.Cells["GiamGiaPhanTram"].Value ?? 0);
                nudGiamGiaTienMat.Value = Convert.ToDecimal(row.Cells["GiamGiaTienMat"].Value ?? 0);
                txtDieuKienApDung.Text = row.Cells["DieuKienApDung"].Value.ToString();
            }
            panelCT.Visible = true;
            btnThem.Visible = false;
        }

        // Ham xu ly su kien khi nhan nut "Dong", an panel nhap thong tin va reset form
        private void btClose_Click(object sender, EventArgs e)
        {
            ClearForm();
            panelCT.Visible = false;
        }
    }
}
