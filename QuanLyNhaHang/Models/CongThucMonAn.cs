using System;

namespace QuanLyNhaHang.Models
{
    public class CongThucMonAn
    {
        public int MaCT { get; set; }
        public int MaMA { get; set; }
        public int MaNL { get; set; }
        public decimal SoLuong { get; set; }
        public string GhiChu { get; set; }
        public object DonViTinh { get; internal set; }
    }
} 