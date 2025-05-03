using System;

namespace QuanLyNhaHang.Models
{
    public class ThongKeDoanhThu
    {
        public int MaTK { get; set; }
        public DateTime Ngay { get; set; }
        public int SoHoaDon { get; set; }
        public decimal TongDoanhThu { get; set; }
        public int TongKhachHang { get; set; }
        public decimal DoanhThuThapNhat { get; set; }
        public decimal DoanhThuCaoNhat { get; set; }
        public decimal DoanhThuTrungBinh { get; set; }
    }
} 