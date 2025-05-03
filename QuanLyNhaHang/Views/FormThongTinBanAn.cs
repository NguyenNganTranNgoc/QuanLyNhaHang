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
    public partial class FormThongTinBanAn : Form
    {
        private int _currentBanId;
        private FormQuanLyBanAn _parentFormQLBA;
        private BanAnController _banAnController;

        public FormThongTinBanAn(int currentBanId, FormQuanLyBanAn formQuanLyBanAn)
        {
            InitializeComponent();
            _currentBanId = currentBanId;
            _parentFormQLBA = formQuanLyBanAn;
            _banAnController = new BanAnController();
        }

        private void LoadBanAn()
        {
            btnXoa.Visible = _currentBanId != 0;
            if (_currentBanId != 0)
            {
                var banAn = _banAnController.LayBanAnTheoMa(_currentBanId);
                if (banAn != null)
                {
                    txtSoBan.Text = banAn.SoBan.ToString();
                    cbbLoaiBan.Text = banAn.LoaiBan;
                    txtTrangThai.Text = banAn.TrangThai;
                    btnXoa.Visible = banAn.TrangThai == "Trống";
                }
                txtTenBan.Text = "Mã bàn: " + _currentBanId;
            }
            else
            {
                txtTenBan.Text = "Thêm bàn mới";
                txtTrangThai.Text = "Trống";
            }
        }

        private bool IsSoBanExists(string soBan)
        {
            return _banAnController.KiemTraSoBanTonTai(soBan);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (IsSoBanExists(txtSoBan.Text) && _currentBanId == 0)
            {
                MessageBox.Show("Số bàn đã tồn tại, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var banAn = new BanAn
            {
                MaBan = _currentBanId,
                SoBan = int.Parse(txtSoBan.Text),
                LoaiBan = cbbLoaiBan.Text,
                TrangThai = txtTrangThai.Text
            };

            if (_currentBanId != 0)
            {
                if (_banAnController.CapNhatBanAn(banAn))
                {
                    MessageBox.Show("Cập nhật bàn ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật bàn ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (_banAnController.ThemBanAn(banAn))
                {
                    MessageBox.Show("Thêm bàn ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm bàn ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _parentFormQLBA.LoadDanhSachBanAn();
            this.Close();
        }

        private void FormThongTinBanAn_Load(object sender, EventArgs e)
        {
            LoadBanAn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_currentBanId != 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (_banAnController.XoaBanAn(_currentBanId))
                    {
                        MessageBox.Show("Xóa bàn ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _parentFormQLBA.LoadDanhSachBanAn();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bàn ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
