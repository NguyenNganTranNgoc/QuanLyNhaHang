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
    public partial class FormQuanLyNhanVien : Form
    {
        private NhanVienController _nhanVienController;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            _nhanVienController = new NhanVienController();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            var danhSachNhanVien = _nhanVienController.LayDanhSachNhanVien();
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            if (dgvNhanVien.CurrentRow.Index >= 0)
            {
                var nhanVien = new NhanVien
                {
                    MaNV = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["MaNV"].Value),
                    HoTen = txtTenNV.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cbGioiTinh.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSoDienThoai.Text,
                    ChucVu = txtChucVu.Text
                };

                if (_nhanVienController.CapNhatNhanVien(nhanVien))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow.Index >= 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int maNV = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                    if (_nhanVienController.XoaNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var danhSachNhanVien = _nhanVienController.TimKiemNhanVien(txtTimKiem.Text);
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            panelCT.Visible = true;
            btnThem.Visible = true;
            btnCapNhat.Visible = btnXoa.Visible = false;
            ClearForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            var nhanVien = new NhanVien
            {
                HoTen = txtTenNV.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cbGioiTinh.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSoDienThoai.Text,
                ChucVu = txtChucVu.Text
            };

            if (_nhanVienController.ThemNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNhanVien();
                panelCT.Visible = false;
                btnThem.Visible = true;
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtChucVu.Text))
            {
                MessageBox.Show("Chức vụ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SDT"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
            }
            panelCT.Visible = true;
            btnThem.Visible = false;
            btnCapNhat.Visible = btnXoa.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelCT.Visible = false;
        }

        private void ClearForm()
        {
            txtTenNV.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cbGioiTinh.SelectedIndex = -1;
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtChucVu.Text = "";
        }
    }
}
