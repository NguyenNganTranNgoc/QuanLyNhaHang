using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class HoaDonController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<HoaDon> LayDanhSachHoaDon()
        {
            var danhSachHoaDon = new List<HoaDon>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoaDon.*, NhanVien.HoTen AS TenNV, KhachHang.HoTen AS TenKH FROM HoaDon " +
                             "INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV " +
                             "INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachHoaDon.Add(new HoaDon
                    {
                        MaHD = Convert.ToInt32(reader["MaHD"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = reader["MaBan"] != DBNull.Value ? Convert.ToInt32(reader["MaBan"]) : (int?)null,
                        MaKM = reader["MaKM"] != DBNull.Value ? Convert.ToInt32(reader["MaKM"]) : (int?)null,
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        TrangThai = reader["TrangThai"].ToString(),
                        GiamGia = reader["GiamGia"] != DBNull.Value ? Convert.ToDecimal(reader["GiamGia"]) : (decimal?)null,
                        NhanVien = reader["TenNV"].ToString(),
                        KhachHang = reader["TenKH"].ToString()
                    });
                }
            }
            return danhSachHoaDon;
        }

        public HoaDon LayHoaDonTheoMa(int maHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoaDon.*, NhanVien.HoTen AS TenNV, KhachHang.HoTen as TenKH FROM HoaDon " +
                             "INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV " +
                             "INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH " +
                             "WHERE HoaDon.MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new HoaDon
                    {
                        MaHD = Convert.ToInt32(reader["MaHD"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = reader["MaBan"] != DBNull.Value ? Convert.ToInt32(reader["MaBan"]) : (int?)null,
                        MaKM = reader["MaKM"] != DBNull.Value ? Convert.ToInt32(reader["MaKM"]) : (int?)null,
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        TrangThai = reader["TrangThai"].ToString(),
                        NhanVien = reader["TenNV"].ToString(),
                        KhachHang = reader["TenKH"].ToString(),
                    };
                }
            }
            return null;
        }

        public int TaoHoaDon(HoaDon hoaDon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HoaDon (MaNV, MaKH, NgayLap, TongTien, TrangThai, MaBan, MAKM, GiamGia) " +
                             "VALUES (@MaNV, @MaKH, @NgayLap, @TongTien, @TrangThai, @MaBan, @MaKM, @GiamGia); " +
                             "SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNV", hoaDon.MaNV);
                command.Parameters.AddWithValue("@MaKH", hoaDon.MaKH);
                command.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);
                command.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                command.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThai);
                command.Parameters.AddWithValue("@MaBan", hoaDon.MaBan ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@MaKM", hoaDon.MaKM ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@GiamGia", hoaDon.GiamGia ?? (object)DBNull.Value);
                connection.Open();
                hoaDon.MaHD = Convert.ToInt32(command.ExecuteScalar());
                return hoaDon.MaHD;
            }
        }

        public bool CapNhatHoaDon(HoaDon hoaDon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE HoaDon SET MaKH = @MaKH, MaKM = @MaKM, TongTien = @TongTien, TrangThai = @TrangThai " +
                             "WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", hoaDon.MaHD);
                command.Parameters.AddWithValue("@MaKH", hoaDon.MaKH);
                command.Parameters.AddWithValue("@MaKM", hoaDon.MaKM ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                command.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaHoaDon(int maHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ThemChiTietHoaDon(int maHD, ChiTietHoaDon chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ChiTietHoaDon (MaHD, MaMA, SoLuong, DonGia) " +
                             "VALUES (@MaHD, @MaMon, @SoLuong, @DonGia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                command.Parameters.AddWithValue("@MaMon", chiTiet.MaMA);
                command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                command.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaChiTietHoaDon(int maCTHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ChiTietHoaDon WHERE MaCTHD = @MaCTHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCTHD", maCTHD);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<ChiTietHoaDon> LayChiTietHoaDon(int maHD)
        {
            var danhSachChiTiet = new List<ChiTietHoaDon>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ChiTietHoaDon.*, MonAn.TenMA, MonAn.DonViTinh FROM ChiTietHoaDon " +
                             "INNER JOIN MonAn ON ChiTietHoaDon.MaMA = MonAn.MaMA " +
                             "WHERE ChiTietHoaDon.MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachChiTiet.Add(new ChiTietHoaDon
                    {
                        MaCTHD = Convert.ToInt32(reader["MaCTHD"]),
                        MaHD = Convert.ToInt32(reader["MaHD"]),
                        MaMA = Convert.ToInt32(reader["MaMA"]),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        TenMA = reader["TenMA"].ToString(),
                        DVT = reader["DonViTinh"].ToString()
                    });
                }
            }
            return danhSachChiTiet;
        }

        public bool ApDungKhuyenMai(int maHD, int maKM)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE HoaDon SET MaKM = @MaKM WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                command.Parameters.AddWithValue("@MaKM", maKM);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ThanhToanHoaDon(int maHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE HoaDon SET TrangThai = 'Đã thanh toán' WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public int LayMaBanTheoMaHD(int maHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaBan FROM HoaDon WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                connection.Open();
                var result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        internal void CapNhatTongTien(int maHoaDon, decimal tongTien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE HoaDon
                    SET TongTien = @TongTien
                    WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TongTien", tongTien);
                command.Parameters.AddWithValue("@MaHD", maHoaDon);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        internal bool CapNhatChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE ChiTietHoaDon
                    SET MaMA = @MaMon, 
                        SoLuong = @SoLuong, 
                        DonGia = @DonGia
                    WHERE MaCTHD = @MaCTHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCTHD", chiTietHoaDon.MaCTHD);
                command.Parameters.AddWithValue("@MaMon", chiTietHoaDon.MaMA);
                command.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);
                command.Parameters.AddWithValue("@DonGia", chiTietHoaDon.DonGia);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        internal object TimKiemHoaDon(string filterText)
        {
            var danhSachHoaDon = new List<HoaDon>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT HoaDon.*, NhanVien.HoTen AS TenNV, KhachHang.HoTen AS TenKH 
                    FROM HoaDon
                    INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV
                    INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH
                    WHERE HoaDon.MaHD LIKE @FilterText
                       OR NhanVien.HoTen LIKE @FilterText
                       OR KhachHang.HoTen LIKE @FilterText
                       OR HoaDon.TrangThai LIKE @FilterText";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FilterText", $"%{filterText}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachHoaDon.Add(new HoaDon
                    {
                        MaHD = Convert.ToInt32(reader["MaHD"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaKM = reader["MaKM"] != DBNull.Value ? Convert.ToInt32(reader["MaKM"]) : (int?)null,
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        TrangThai = reader["TrangThai"].ToString(),
                        NhanVien = reader["TenNV"].ToString(),
                        KhachHang = reader["TenKH"].ToString()
                    });
                }
            }
            return danhSachHoaDon;
        }

        internal int LayHoaDonChuaThanhToan(int maBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT TOP 1 MaHD 
                        FROM HoaDon 
                        WHERE MaBan = @MaBan 
                        AND TrangThai = N'Chưa thanh toán' 
                        ORDER BY NgayLap DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", maBan);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Nếu có kết quả, trả về MaHD
                        return reader.GetInt32(0);
                    }
                    else
                    {
                        // Nếu không có kết quả, trả về 0
                        return 0;
                    }
                }
            }
        }

        internal void CapNhatGiamGia(int currentBillId, decimal totalDiscountAmount)
        {
            //Cập nhật cột GiamGia
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE HoaDon
                    SET GiamGia = @GiamGia
                    WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GiamGia", totalDiscountAmount);
                command.Parameters.AddWithValue("@MaHD", currentBillId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        internal void CapNhatKhuyenMai(int currentBillId, int maKM)
        {
            if (maKM != 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE HoaDon
                        SET MaKM = @MaKM
                        WHERE MaHD = @MaHD";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaKM", maKM);
                    command.Parameters.AddWithValue("@MaHD", currentBillId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE HoaDon
                        SET MaKM = NULL
                        WHERE MaHD = @MaHD";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHD", currentBillId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        internal object LayNhanVienTheoMa(int? maNV)
        {
            throw new NotImplementedException();
        }
    }
} 