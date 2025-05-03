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
    public partial class FormQuanLyHoaDon : Form
    {
        private HoaDonController _hoaDonController;

        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            _hoaDonController = new HoaDonController();
        }

        // Ham xu ly su kien khi form duoc load
        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        // Ham load danh sach hoa don tu database len DataGridView
        public void LoadHoaDon()
        {
            var danhSachHoaDon = _hoaDonController.LayDanhSachHoaDon();
            dgvHoaDon.AutoGenerateColumns = false; // Khong tu dong tao cot
            dgvHoaDon.DataSource = danhSachHoaDon;
        }

        // Ham xu ly su kien khi text trong o tim kiem thay doi
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                LoadHoaDon();
                return;
            }

            var danhSachHoaDon = _hoaDonController.TimKiemHoaDon(filterText);
            dgvHoaDon.DataSource = danhSachHoaDon;
        }

        // Ham xu ly su kien khi nguoi dung click vao mot dong trong DataGridView
        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = dgvHoaDon.SelectedRows[0];
            int currentBillId = Convert.ToInt32(selectedRow.Cells["MaHD"].Value);
            string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();
            
            FormBill formBill = new FormBill(currentBillId, trangThai == "Đã thanh toán", null, this);
            formBill.ShowDialog();
        }
    }
}
