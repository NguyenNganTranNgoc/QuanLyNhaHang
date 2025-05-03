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
    public partial class FormNguyenLieyuMoi : Form
    {
        private NguyenLieuController _nguyenLieuController;
        private FormKhoNguyenLieu _formKhoNguyenLieu;

        public FormNguyenLieyuMoi(FormKhoNguyenLieu formKhoNguyenLieu)
        {
            InitializeComponent();
            _nguyenLieuController = new NguyenLieuController();
            _formKhoNguyenLieu = formKhoNguyenLieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNguyenLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDVT.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nguyenLieu = new NguyenLieu
            {
                TenNL = txtTenNguyenLieu.Text,
                DonViTinh = txtDVT.Text,
                SoLuongTon = 0,
                DonGia = 0
            };

            if (_nguyenLieuController.ThemNguyenLieu(nguyenLieu))
            {
                MessageBox.Show("Thêm nguyên liệu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _formKhoNguyenLieu.LoadDuLieuKho();
                Close();
            }
            else
            {
                MessageBox.Show("Thêm nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNguyenLieyuMoi_Load(object sender, EventArgs e)
        {
            // Không cần xử lý
        }
    }
}
