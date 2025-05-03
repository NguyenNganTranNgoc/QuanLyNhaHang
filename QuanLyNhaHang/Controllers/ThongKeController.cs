using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class ThongKeController
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<ThongKeDoanhThu> LayThongKeDoanhThuTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var result = new List<ThongKeDoanhThu>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT Ngay, COUNT(MaHD) AS SoHoaDon, SUM(TongTien) AS TongDoanhThu,  
                                 COUNT(DISTINCT MaKH) AS TongKhachHang, MIN(TongTien) AS DoanhThuThapNhat,  
                                 MAX(TongTien) AS DoanhThuCaoNhat, AVG(TongTien) AS DoanhThuTrungBinh  
                                 FROM HoaDon  
                                 WHERE NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc  
                                 GROUP BY Ngay";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new ThongKeDoanhThu
                            {
                                Ngay = reader.GetDateTime(0),
                                SoHoaDon = reader.GetInt32(1),
                                TongDoanhThu = reader.GetDecimal(2),
                                TongKhachHang = reader.GetInt32(3),
                                DoanhThuThapNhat = reader.GetDecimal(4),
                                DoanhThuCaoNhat = reader.GetDecimal(5),
                                DoanhThuTrungBinh = reader.GetDecimal(6)
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<ThongKeMonAn> LayThongKeMonAnBanChay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var result = new List<ThongKeMonAn>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT MaMA, Ngay, SUM(SoLuong) AS SoLuongBan, SUM(SoLuong * DonGia) AS DoanhThu  
                                 FROM ChiTietHoaDon  
                                 JOIN HoaDon ON ChiTietHoaDon.MaHD = HoaDon.MaHD  
                                 WHERE NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc  
                                 GROUP BY MaMA, Ngay";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new ThongKeMonAn
                            {
                                MaMA = reader.GetInt32(0),
                                Ngay = reader.GetDateTime(1),
                                SoLuongBan = reader.GetInt32(2),
                                DoanhThu = reader.GetDecimal(3)
                            });
                        }
                    }
                }
            }
            return result;
        }

        public decimal LayTongDoanhThuTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT SUM(TongTien)  
                                 FROM HoaDon  
                                 WHERE NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    return (decimal)command.ExecuteScalar();
                }
            }
        }

        public int LayTongSoHoaDonTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT COUNT(MaHD)  
                                 FROM HoaDon  
                                 WHERE NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public List<MonAn> LayTopMonAnBanChay(int top)
        {
            var result = new List<MonAn>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT TOP (@Top) MonAn.MaMA, MonAn.TenMA, SUM(ChiTietHoaDon.SoLuong) AS SoLuongBan  
                                 FROM ChiTietHoaDon  
                                 JOIN MonAn ON ChiTietHoaDon.MaMA = MonAn.MaMA  
                                 GROUP BY MonAn.MaMA, MonAn.TenMA  
                                 ORDER BY SoLuongBan DESC";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Top", top);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new MonAn
                            {
                                MaMA = reader.GetInt32(0),
                                TenMA = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<HoaDon> LayDanhSachHoaDonTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var result = new List<HoaDon>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT *  
                                 FROM HoaDon  
                                 WHERE NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new HoaDon
                            {
                                MaHD = reader.GetInt32(0),
                                MaKH = reader.IsDBNull(1) ? null : reader.GetInt32(1),
                                MaNV = reader.IsDBNull(2) ? null : reader.GetInt32(2),
                                MaBan = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                                NgayLap = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                                TongTien = reader.GetDecimal(5),
                                TrangThai = reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return result;
        }

        internal void CapNhatThongKe(int currentBillId)
        {
            // Implement logic to update statistics based on the current bill
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Get bill details
                DateTime ngayLap;
                decimal tongTien;
                List<Tuple<int, int>> monAnList = new List<Tuple<int, int>>(); // MaMA, SoLuong

                // Get bill date and total amount
                string query = "SELECT NgayLap, TongTien FROM HoaDon WHERE MaHD = @MaHD";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHD", currentBillId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ngayLap = reader.GetDateTime(reader.GetOrdinal("NgayLap"));
                            tongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                        }
                        else
                        {
                            return; // Bill not found
                        }
                    }
                }

                // Get food items in the bill
                query = "SELECT MaMA, SoLuong FROM ChiTietHoaDon WHERE MaHD = @MaHD";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHD", currentBillId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maMA = reader.GetInt32(reader.GetOrdinal("MaMA"));
                            int soLuong = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                            monAnList.Add(new Tuple<int, int>(maMA, soLuong));
                        }
                    }
                }

                // Update daily revenue statistics
                DateTime ngay = ngayLap.Date;
                query = @"
        IF EXISTS (SELECT 1 FROM ThongKeDoanhThu WHERE Ngay = @Ngay)
        BEGIN
            UPDATE ThongKeDoanhThu 
            SET 
                SoHoaDon = SoHoaDon + 1,
                TongDoanhThu = TongDoanhThu + @TongTien,
                TongKhachHang = TongKhachHang + 1,
                DoanhThuThapNhat = CASE WHEN @TongTien < DoanhThuThapNhat THEN @TongTien ELSE DoanhThuThapNhat END,
                DoanhThuCaoNhat = CASE WHEN @TongTien > DoanhThuCaoNhat THEN @TongTien ELSE DoanhThuCaoNhat END,
                DoanhThuTrungBinh = (TongDoanhThu + @TongTien) / (SoHoaDon + 1)
            WHERE Ngay = @Ngay
        END
        ELSE
        BEGIN
            INSERT INTO ThongKeDoanhThu (Ngay, SoHoaDon, TongDoanhThu, TongKhachHang, 
                                       DoanhThuThapNhat, DoanhThuCaoNhat, DoanhThuTrungBinh)
            VALUES (@Ngay, 1, @TongTien, 1, @TongTien, @TongTien, @TongTien)
        END";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    command.Parameters.AddWithValue("@TongTien", tongTien);
                    command.ExecuteNonQuery();
                }

                // Update food item statistics
                foreach (var monAn in monAnList)
                {
                    int maMA = monAn.Item1;
                    int soLuong = monAn.Item2;

                    // Get food price
                    decimal donGia = 0;
                    query = "SELECT Gia FROM MonAn WHERE MaMA = @MaMA";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaMA", maMA);
                        donGia = (decimal)command.ExecuteScalar();
                    }

                    decimal doanhThu = soLuong * donGia;

                    query = @"
            IF EXISTS (SELECT 1 FROM ThongKeMonAn WHERE MaMA = @MaMA AND Ngay = @Ngay)
            BEGIN
                UPDATE ThongKeMonAn 
                SET 
                    SoLuongBan = SoLuongBan + @SoLuong,
                    DoanhThu = DoanhThu + @DoanhThu
                WHERE MaMA = @MaMA AND Ngay = @Ngay
            END
            ELSE
            BEGIN
                INSERT INTO ThongKeMonAn (MaMA, Ngay, SoLuongBan, DoanhThu)
                VALUES (@MaMA, @Ngay, @SoLuong, @DoanhThu)
            END";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaMA", maMA);
                        command.Parameters.AddWithValue("@Ngay", ngay);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);
                        command.Parameters.AddWithValue("@DoanhThu", doanhThu);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public DataTable LayThongKeMonAn()
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT MaMA AS [Mã Món Ăn], 
                                                    (SELECT TenMA FROM MonAn WHERE MonAn.MaMA = ThongKeMonAn.MaMA) AS [Tên Món Ăn], 
                                                    Ngay AS [Ngày], 
                                                    SUM(SoLuongBan) AS [Số Lượng Bán], 
                                                    SUM(DoanhThu) AS [Doanh Thu]  
                                             FROM ThongKeMonAn  
                                             GROUP BY MaMA, Ngay";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        
        public DataTable LayThongKeDoanhThu()
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = @"SELECT Ngay AS [Ngày], 
                                    SoHoaDon AS [Số Hóa Đơn], 
                                    TongDoanhThu AS [Tổng Doanh Thu],  
                                    TongKhachHang AS [Tổng Khách Hàng], 
                                    DoanhThuCaoNhat AS [Hóa đơn Cao Nhất],  
                                    DoanhThuThapNhat AS [Hóa đơn Thấp Nhất], 
                                    DoanhThuTrungBinh AS [Giá trị Trung Bình]  
                             FROM ThongKeDoanhThu";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
} 