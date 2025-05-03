using System;

namespace QuanLyNhaHang.Models
{
    public class DatBanTruoc
    {
        public int MaDB { get; set; }
        public int MaKH { get; set; }
        public int MaBan { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public int SoNguoi { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }
    }
} 