using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class DatBanTruocController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<DatBanTruoc> LayDanhSachDatBanTruoc()
        {
            var danhSachDatBan = new List<DatBanTruoc>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DatBanTruoc ORDER BY ThoiGianDat DESC";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachDatBan.Add(new DatBanTruoc
                    {
                        MaDB = Convert.ToInt32(reader["MaDB"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        ThoiGianDat = Convert.ToDateTime(reader["ThoiGianDat"]),
                        ThoiGianDen = Convert.ToDateTime(reader["ThoiGianDen"]),
                        SoNguoi = Convert.ToInt32(reader["SoNguoi"]),
                        GhiChu = reader["GhiChu"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSachDatBan;
        }

        public DatBanTruoc LayDatBanTruocTheoMa(int maDB)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DatBanTruoc WHERE MaDB = @MaDB";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDB", maDB);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new DatBanTruoc
                    {
                        MaDB = Convert.ToInt32(reader["MaDB"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        ThoiGianDat = Convert.ToDateTime(reader["ThoiGianDat"]),
                        ThoiGianDen = Convert.ToDateTime(reader["ThoiGianDen"]),
                        SoNguoi = Convert.ToInt32(reader["SoNguoi"]),
                        GhiChu = reader["GhiChu"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                }
            }
            return null;
        }

        public int ThemDatBanTruoc(DatBanTruoc datBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DatBanTruoc (MaKH, MaBan, ThoiGianDat, ThoiGianDen, " +
                             "SoNguoi, GhiChu, TrangThai) " +
                             "OUTPUT INSERTED.MaDB " +
                             "VALUES (@MaKH, @MaBan, @ThoiGianDat, @ThoiGianDen, " +
                             "@SoNguoi, @GhiChu, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", datBan.MaKH);
                command.Parameters.AddWithValue("@MaBan", datBan.MaBan);
                command.Parameters.AddWithValue("@ThoiGianDat", datBan.ThoiGianDat);
                command.Parameters.AddWithValue("@ThoiGianDen", datBan.ThoiGianDen);
                command.Parameters.AddWithValue("@SoNguoi", datBan.SoNguoi);
                command.Parameters.AddWithValue("@GhiChu", datBan.GhiChu);
                command.Parameters.AddWithValue("@TrangThai", datBan.TrangThai);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public bool CapNhatDatBanTruoc(DatBanTruoc datBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE DatBanTruoc SET MaKH = @MaKH, MaBan = @MaBan, " +
                             "ThoiGianDat = @ThoiGianDat, ThoiGianDen = @ThoiGianDen, " +
                             "SoNguoi = @SoNguoi, GhiChu = @GhiChu, TrangThai = @TrangThai " +
                             "WHERE MaDB = @MaDB";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDB", datBan.MaDB);
                command.Parameters.AddWithValue("@MaKH", datBan.MaKH);
                command.Parameters.AddWithValue("@MaBan", datBan.MaBan);
                command.Parameters.AddWithValue("@ThoiGianDat", datBan.ThoiGianDat);
                command.Parameters.AddWithValue("@ThoiGianDen", datBan.ThoiGianDen);
                command.Parameters.AddWithValue("@SoNguoi", datBan.SoNguoi);
                command.Parameters.AddWithValue("@GhiChu", datBan.GhiChu);
                command.Parameters.AddWithValue("@TrangThai", datBan.TrangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaDatBanTruoc(int maDB)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM DatBanTruoc WHERE MaDB = @MaDB";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDB", maDB);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<DatBanTruoc> LayDanhSachDatBanTruocTheoKhachHang(int maKH)
        {
            var danhSachDatBan = new List<DatBanTruoc>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DatBanTruoc WHERE MaKH = @MaKH ORDER BY ThoiGianDat DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", maKH);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachDatBan.Add(new DatBanTruoc
                    {
                        MaDB = Convert.ToInt32(reader["MaDB"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        ThoiGianDat = Convert.ToDateTime(reader["ThoiGianDat"]),
                        ThoiGianDen = Convert.ToDateTime(reader["ThoiGianDen"]),
                        SoNguoi = Convert.ToInt32(reader["SoNguoi"]),
                        GhiChu = reader["GhiChu"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSachDatBan;
        }

        public List<DatBanTruoc> LayDanhSachDatBanTruocTheoBan(int maBan)
        {
            var danhSachDatBan = new List<DatBanTruoc>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DatBanTruoc WHERE MaBan = @MaBan ORDER BY ThoiGianDat DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", maBan);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachDatBan.Add(new DatBanTruoc
                    {
                        MaDB = Convert.ToInt32(reader["MaDB"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        ThoiGianDat = Convert.ToDateTime(reader["ThoiGianDat"]),
                        ThoiGianDen = Convert.ToDateTime(reader["ThoiGianDen"]),
                        SoNguoi = Convert.ToInt32(reader["SoNguoi"]),
                        GhiChu = reader["GhiChu"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSachDatBan;
        }

        public List<DatBanTruoc> LayDanhSachDatBanTruocTheoNgay(DateTime ngay)
        {
            var danhSachDatBan = new List<DatBanTruoc>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DatBanTruoc WHERE CONVERT(date, ThoiGianDen) = @Ngay " +
                             "ORDER BY ThoiGianDen ASC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ngay", ngay.Date);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachDatBan.Add(new DatBanTruoc
                    {
                        MaDB = Convert.ToInt32(reader["MaDB"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        ThoiGianDat = Convert.ToDateTime(reader["ThoiGianDat"]),
                        ThoiGianDen = Convert.ToDateTime(reader["ThoiGianDen"]),
                        SoNguoi = Convert.ToInt32(reader["SoNguoi"]),
                        GhiChu = reader["GhiChu"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSachDatBan;
        }

        public bool KiemTraBanDaDatTruoc(int maBan, DateTime thoiGianDen)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM DatBanTruoc WHERE MaBan = @MaBan " +
                             "AND CONVERT(date, ThoiGianDen) = @Ngay " +
                             "AND TrangThai = 'Chưa đến'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", maBan);
                command.Parameters.AddWithValue("@Ngay", thoiGianDen.Date);
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }
    }
} 