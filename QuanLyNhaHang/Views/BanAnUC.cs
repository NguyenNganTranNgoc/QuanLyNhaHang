using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang.Controllers;

namespace QuanLyNhaHang
{
    public partial class BanAnUC : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;
        private HoaDonController _hoaDonController;
        public int Id { get; internal set; }
        public string LoaiBan { get; internal set; }
        public int HoaDonId { get; internal set; }
        public string TrangThai { get; internal set; }
        public int SoBan { get; internal set; }
        public FormQuanLyBanAn ParentForm { get; internal set; }
        
        public BanAnUC()
        {
            InitializeComponent();
            _hoaDonController = new HoaDonController();
        }

        // Su kien khi chuot di vao Label txtTenBan
        private void txtTenBan_MouseHover(object sender, EventArgs e)
        {

        }

        // Su kien khi chuot roi khoi Label txtTenBan
        private void txtTenBan_MouseLeave(object sender, EventArgs e)
        {

        }

        // Ham load du lieu cho control BanAn
        internal void LoadDuLieu()
        {
            // Hien thi so ban
            txtTenBan.Text = (SoBan < 10 ? "0" + SoBan : SoBan) + "";
            // Hien thi loai ban
            lbLoaiBan.Text = "Loại bàn: " + LoaiBan;
            // Thay doi anh nen tuy thuoc vao trang thai
            BackgroundImage = TrangThai == "Trống" ? Properties.Resources.table_01 : Properties.Resources.table_02;
            // Hien thi hoa don
            lbHD.Visible = HoaDonId != 0;
            // Neu co HoaDonId, lay thong tin hoa don tu database
            if (HoaDonId != 0)
            {
                lbHD.Text = "HĐ: " + _hoaDonController.LayHoaDonTheoMa(HoaDonId).TongTien.ToString();
            }
        }

        // Su kien khi click vao Label txtTenBan
        private void txtTenBan_Click(object sender, EventArgs e)
        {
            // Goi ham xu ly su kien click cua form cha
            ParentForm.BanClicked(Id);
        }

        // Su kien khi control BanAn duoc load
        private void BanAn_Load(object sender, EventArgs e)
        {

        }

        // Su kien khi click vao Label lbTrangThai
        private void lbTrangThai_Click(object sender, EventArgs e)
        {

        }
    }

}
