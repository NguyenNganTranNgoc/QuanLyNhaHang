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
    public partial class FormThongKe : Form
    {
        private ThongKeController _thongKeController;

        public FormThongKe()
        {
            InitializeComponent();
            _thongKeController = new ThongKeController();
        }

        private void btnTK1_Click(object sender, EventArgs e)
        {
            // Load ThongKeMonAn
            ThongKeMonAn();
        }

        private void ThongKeMonAn()
        {
            try
            {
                var danhSachThongKe = _thongKeController.LayThongKeMonAn();
                dgvThongKe.DataSource = danhSachThongKe;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTK2_Click(object sender, EventArgs e)
        {
            // Load ThongKeDoanhThu
            ThongKeDoanhThu();
        }

        private void ThongKeDoanhThu()
        {
            try
            {
                var danhSachThongKe = _thongKeController.LayThongKeDoanhThu();
                dgvThongKe.DataSource = danhSachThongKe;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
