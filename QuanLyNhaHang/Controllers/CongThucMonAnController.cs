using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class CongThucMonAnController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<CongThucMonAn> LayDanhSachCongThucTheoMonAn(int maMA)
        {
            var danhSachCongThuc = new List<CongThucMonAn>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CongThucMonAn WHERE MaMA = @MaMA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", maMA);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachCongThuc.Add(new CongThucMonAn
                    {
                        MaCT = Convert.ToInt32(reader["MaCT"]),
                        MaMA = Convert.ToInt32(reader["MaMA"]),
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        SoLuong = Convert.ToDecimal(reader["SoLuong"]),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        GhiChu = reader["GhiChu"].ToString()
                    });
                }
            }
            return danhSachCongThuc;
        }

        public bool ThemCongThuc(CongThucMonAn congThuc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CongThucMonAn (MaMA, MaNL, SoLuong, DonViTinh, GhiChu) " +
                             "VALUES (@MaMA, @MaNL, @SoLuong, @DonViTinh, @GhiChu)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", congThuc.MaMA);
                command.Parameters.AddWithValue("@MaNL", congThuc.MaNL);
                command.Parameters.AddWithValue("@SoLuong", congThuc.SoLuong);
                command.Parameters.AddWithValue("@DonViTinh", congThuc.DonViTinh);
                command.Parameters.AddWithValue("@GhiChu", congThuc.GhiChu);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatCongThuc(CongThucMonAn congThuc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE CongThucMonAn SET MaMA = @MaMA, MaNL = @MaNL, " +
                             "SoLuong = @SoLuong, DonViTinh = @DonViTinh, GhiChu = @GhiChu " +
                             "WHERE MaCT = @MaCT";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCT", congThuc.MaCT);
                command.Parameters.AddWithValue("@MaMA", congThuc.MaMA);
                command.Parameters.AddWithValue("@MaNL", congThuc.MaNL);
                command.Parameters.AddWithValue("@SoLuong", congThuc.SoLuong);
                command.Parameters.AddWithValue("@DonViTinh", congThuc.DonViTinh);
                command.Parameters.AddWithValue("@GhiChu", congThuc.GhiChu);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaCongThuc(int maCT)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CongThucMonAn WHERE MaCT = @MaCT";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCT", maCT);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaTatCaCongThucTheoMonAn(int maMA)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CongThucMonAn WHERE MaMA = @MaMA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", maMA);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<CongThucMonAn> LayDanhSachCongThucTheoNguyenLieu(int maNL)
        {
            var danhSachCongThuc = new List<CongThucMonAn>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CongThucMonAn WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", maNL);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachCongThuc.Add(new CongThucMonAn
                    {
                        MaCT = Convert.ToInt32(reader["MaCT"]),
                        MaMA = Convert.ToInt32(reader["MaMA"]),
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        SoLuong = Convert.ToDecimal(reader["SoLuong"]),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        GhiChu = reader["GhiChu"].ToString()
                    });
                }
            }
            return danhSachCongThuc;
        }
    }
} 