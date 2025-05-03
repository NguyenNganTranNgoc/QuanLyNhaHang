using System;

namespace QuanLyNhaHang.Models
{
    public class KhuyenMai
    {
        public int MaKM { get; set; }
        public string TenKM { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal GiamGiaPhanTram { get; set; }
        public decimal GiamGiaTienMat { get; set; }
        public string DieuKienApDung { get; set; }
        public bool TrangThai { get; set; }
    }
} 