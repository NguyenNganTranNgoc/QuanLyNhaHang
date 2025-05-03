using System;

namespace QuanLyNhaHang.Models
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int? MaKH { get; set; }
        public int? MaNV { get; set; }
        public int? MaBan { get; set; }
        public DateTime? NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public decimal? GiamGia { get; set; }
        public int? MaKM { get; set; }
        public string KhachHang { get; set; }
        public string NhanVien { get; set; }
    }
} 