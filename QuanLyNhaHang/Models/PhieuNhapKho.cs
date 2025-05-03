using System;

namespace QuanLyNhaHang.Models
{
    public class PhieuNhapKho
    {
        public int MaPN { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
        public string NhaCungCap { get; set; }
        public string GhiChu { get; set; }
        public string TenNV { get; internal set; }
    }
} 