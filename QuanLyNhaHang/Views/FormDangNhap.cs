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
    public partial class FormDangNhap : Form
    {
        private TaiKhoanController _taiKhoanController;
        private NhanVienController _nhanVienController;

        public FormDangNhap()
        {
            InitializeComponent();
            _taiKhoanController = new TaiKhoanController();
            _nhanVienController = new NhanVienController();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            var taiKhoan = _taiKhoanController.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (taiKhoan != null)
            {
                if (btnLuuDangNhap.Checked)
                {
                    Se.Default.MaNV = taiKhoan.MaNV;
                    MessageBox.Show("Đăng nhập thành công. Đã lưu đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                Se.Default.TenNV = _nhanVienController.LayNhanVienTheoMa(taiKhoan.MaNV).HoTen;
                Se.Default.Save();
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // Xử lý khi form đăng nhập được load
        }
    }
}
