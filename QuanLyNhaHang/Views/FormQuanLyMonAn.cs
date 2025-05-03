using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.Controllers;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang
{
    public partial class FormQuanLyMonAn : Form
    {
        private string _currentPath;
        private MonAnController _monAnController;

        public FormQuanLyMonAn()
        {
            InitializeComponent();
            _monAnController = new MonAnController();
        }

        private void FormQuanLyMonAn_Load(object sender, EventArgs e)
        {
            LoadDanhSachMon();
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            var danhMuc = _monAnController.LayDanhMuc();
            cbbDanhMuc.DataSource = danhMuc;
        }

        private void LoadDanhSachMon()
        {
            var danhSachMon = _monAnController.LayDanhSachMonAn();
            dgvMonAn.DataSource = danhSachMon;

            foreach (DataGridViewRow row in dgvMonAn.Rows)
            {
                var anhMAValue = row.Cells["AnhMA"].Value?.ToString();
                if (!string.IsNullOrEmpty(anhMAValue) && File.Exists(anhMAValue))
                {
                    row.Cells["ImageMA"].Value = Image.FromFile(anhMAValue);
                }
                else
                {
                    row.Cells["ImageMA"].Value = Properties.Resources.photo;
                }
            }
        }

        private void dgvMonAn_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvMonAn.CurrentRow;
                txtTenMon.Text = row.Cells["TenMA"].Value.ToString();
                txtGiaMon.Text = row.Cells["Gia"].Value.ToString();
                txtDVT.Text = row.Cells["DonViTinh"].Value.ToString();
                cbbDanhMuc.Text = row.Cells["DanhMuc"].Value.ToString();
                cbbTinhTrang.Text = row.Cells["TrangThaiMon"].Value.ToString();
                if (row.Cells["AnhMA"].Value != null && File.Exists(row.Cells["AnhMA"].Value.ToString()))
                {
                    pbAvatar.BackgroundImage = Image.FromFile(row.Cells["AnhMA"].Value.ToString());
                    _currentPath = row.Cells["AnhMA"].Value.ToString();
                }
                else
                {
                    pbAvatar.BackgroundImage = Properties.Resources.photo;
                }
                btnCapNhat.Visible = btnXoa.Visible = true;
                btnThem.Visible = false;
                panelCT.Visible = true;
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    pbAvatar.BackgroundImage = Image.FromFile(selectedFilePath);
                    _currentPath = selectedFilePath;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var monAn = new MonAn
            {
                TenMA = txtTenMon.Text,
                Gia = decimal.Parse(txtGiaMon.Text),
                DonViTinh = txtDVT.Text,
                DanhMuc = cbbDanhMuc.Text,
                TrangThaiMon = cbbTinhTrang.Text,
                AnhMA = _currentPath
            };

            if (!_monAnController.KiemTraDuLieuNhap(monAn))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_monAnController.ThemMonAn(monAn))
            {
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMon();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelCT.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow.Index >= 0)
            {
                var monAn = new MonAn
                {
                    MaMA = Convert.ToInt32(dgvMonAn.CurrentRow.Cells["MaMA"].Value),
                    TenMA = txtTenMon.Text,
                    Gia = decimal.Parse(txtGiaMon.Text),
                    DonViTinh = txtDVT.Text,
                    DanhMuc = cbbDanhMuc.Text,
                    TrangThaiMon = cbbTinhTrang.Text,
                    AnhMA = _currentPath
                };

                if (!_monAnController.KiemTraDuLieuNhap(monAn))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_monAnController.CapNhatMonAn(monAn))
                {
                    MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachMon();
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                panelCT.Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.CurrentRow.Index >= 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int maMA = Convert.ToInt32(dgvMonAn.CurrentRow.Cells["MaMA"].Value);
                    if (_monAnController.XoaMonAn(maMA))
                    {
                        MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachMon();
                    }
                    else
                    {
                        MessageBox.Show("Xóa món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            panelCT.Visible = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var ketQua = _monAnController.TimKiemMonAn(txtTimKiem.Text);
            dgvMonAn.DataSource = ketQua;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            panelCT.Visible = true;
            btnCapNhat.Visible = btnXoa.Visible = false;
            btnThem.Visible = true;
            ClearForm();
        }

        private void ClearForm()
        {
            txtTenMon.Clear();
            txtGiaMon.Clear();
            txtDVT.Clear();
            cbbDanhMuc.SelectedIndex = -1;
            cbbTinhTrang.SelectedIndex = -1;
            pbAvatar.BackgroundImage = Properties.Resources.photo;
            _currentPath = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelCT.Visible = false;
        }
    }
}
