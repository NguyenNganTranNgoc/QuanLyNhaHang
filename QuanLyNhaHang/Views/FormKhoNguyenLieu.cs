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
    public partial class FormKhoNguyenLieu : Form
    {
        private NguyenLieuController _nguyenLieuController;

        public FormKhoNguyenLieu()
        {
            InitializeComponent();
            _nguyenLieuController = new NguyenLieuController();
        }

        private void FormKhoNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadDuLieuKho();
        }

        public void LoadDuLieuKho()
        {
            var danhSachNguyenLieu = _nguyenLieuController.LayDanhSachNguyenLieu();
            dgvKho.DataSource = danhSachNguyenLieu;

            dgvKho.Columns["MaNL"].HeaderText = "Mã nguyên liệu";
            dgvKho.Columns["TenNL"].HeaderText = "Tên nguyên liệu";
            dgvKho.Columns["SoLuongTon"].HeaderText = "Số lượng";
            dgvKho.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvKho.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvKho.Columns["DonGia"].Visible = false;
            dgvKho.Columns["NhaCungCap"].HeaderText = "Nhà cung cấp";
            dgvKho.Columns["NhaCungCap"].Visible = false;
            dgvKho.Columns["HanSuDung"].HeaderText = "Hạn sử dụng";
            dgvKho.Columns["HanSuDung"].Visible = false;
            dgvKho.Columns["MaNL"].Width = 100;
            dgvKho.Columns["TenNL"].Width = 200;
            dgvKho.Columns["SoLuongTon"].Width = 100;
            dgvKho.Columns["DonViTinh"].Width = 100;
            dgvKho.Columns["DonGia"].Width = 100;
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AllowUserToDeleteRows = false;
            dgvKho.ReadOnly = true;
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            FormNguyenLieyuMoi formNguyenLieyuMoi = new FormNguyenLieyuMoi(this);
            formNguyenLieyuMoi.ShowDialog();
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }
    }
}
