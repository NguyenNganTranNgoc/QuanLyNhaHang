using System;

namespace QuanLyNhaHang.Models
{
    public class ChiTietHoaDon
    {
        public int MaCTHD { get; set; }
        public int MaHD { get; set; }
        public int MaMA { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public string TenMA { get; set; }
        public string? DVT { get; internal set; }
    }
} 