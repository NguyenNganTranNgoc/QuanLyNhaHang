using System;

namespace QuanLyNhaHang.Models
{
    public class NguyenLieu
    {
        public int MaNL { get; set; }
        public string TenNL { get; set; }
        public string DonViTinh { get; set; }
        public decimal SoLuongTon { get; set; }
        public decimal DonGia { get; set; }
        public DateTime HanSuDung { get; set; }
        public string NhaCungCap { get; set; }
    }
} 