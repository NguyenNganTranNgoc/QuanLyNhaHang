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
    public partial class FormQuanLyKhachHang : Form
    {
        private KhachHangController _khachHangController;

        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            _khachHangController = new KhachHangController();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }

        private void LoadDanhSachKhachHang()
        {
            var danhSachKhachHang = _khachHangController.LayDanhSachKhachHang();
            dgvKhachHang.DataSource = danhSachKhachHang;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return;
            }

            if (dgvKhachHang.CurrentRow.Index >= 0)
            {
                var khachHang = new KhachHang
                {
                    MaKH = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["MaKH"].Value),
                    HoTen = txtTenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSoDienThoai.Text
                };

                if (_khachHangController.CapNhatKhachHang(khachHang))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow.Index >= 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int maKH = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["MaKH"].Value);
                    if (_khachHangController.XoaKhachHang(maKH))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var danhSachKhachHang = _khachHangController.TimKiemKhachHang(txtTimKiem.Text);
            dgvKhachHang.DataSource = danhSachKhachHang;
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

            var khachHang = new KhachHang
            {
                HoTen = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSoDienThoai.Text
            };

            if (_khachHangController.ThemKhachHangVaLayMa(khachHang) > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachKhachHang();
                panelCT.Visible = false;
                btnThem.Visible = true;
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return true;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvKhachHang.CurrentRow;
                txtTenKH.Text = row.Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SDT"].Value.ToString();
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
            txtDiaChi.Text = txtSoDienThoai.Text = txtTenKH.Text = "";
        }
    }
}
