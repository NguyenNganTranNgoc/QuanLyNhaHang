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
    public partial class FormMain : Form
    {
        private NhanVienController _nhanVienController;

        public FormMain()
        {
            InitializeComponent();
            _nhanVienController = new NhanVienController();
        }

        // Xu ly su kien khi nhan nut "Ban An"
        private void btnBanAn_Click(object sender, EventArgs e)
        {
            FormQuanLyBanAn formQuanLyBanAn = new FormQuanLyBanAn();
            showChildForm(formQuanLyBanAn);
        }

        // Hien thi form con trong panel chinh
        private void showChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            childForm.Show();
        }

        // Xu ly su kien khi form chinh duoc load
        private void FormMain_Load(object sender, EventArgs e)
        {
            var nhanVien = _nhanVienController.LayNhanVienTheoMa(Se.Default.MaNV);
            if (nhanVien != null)
            {
                btnDangXuat.Text = $"Đăng xuất ({nhanVien.HoTen})";
            }
            showChildForm(new FormQuanLyBanAn());
        }

        // Xu ly su kien khi nhan nut "Hoa Don"
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            showChildForm(new FormQuanLyHoaDon());
        }

        // Xu ly su kien khi nhan nut "Mon An"
        private void btnMonAn_Click(object sender, EventArgs e)
        {
            showChildForm(new FormQuanLyMonAn());
        }

        // Xu ly su kien khi nhan nut "Khach Hang"
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            showChildForm(new FormQuanLyKhachHang());
        }

        // Xu ly su kien khi nhan nut "Nhan Vien"
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showChildForm(new FormQuanLyNhanVien());
        }

        // Xu ly su kien khi nhan nut "Ton Kho" (chua xu ly)
        private void btnTonKho_Click(object sender, EventArgs e)
        {
            showChildForm(new FormKhoNguyenLieu());
        }

        // Xu ly su kien khi nhan nut "Thong Ke"
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showChildForm(new FormThongKe());
        }

        // Xu ly su kien khi nhan nut "Khuyen Mai"
        private void tnKhuyenMai_Click(object sender, EventArgs e)
        {
            showChildForm(new FormKhuyenMai());
        }

        // Xu ly su kien khi nhan nut "Nguyen Lieu"
        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            showChildForm(new FormKhoNguyenLieu());
        }

        // Xu ly su kien khi nhan nut "Phieu Nhap Kho"
        private void btnPhieuNhapKho_Click(object sender, EventArgs e)
        {
            showChildForm(new FormPhieuNhapKho());
        }

        // Xu ly su kien khi nhan nut "Dang Xuat"
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Se.Default.MaNV = 0;
                Se.Default.Save();
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();
                this.Hide();
            }
        }
    }
}
