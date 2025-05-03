using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class BanAnController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<BanAn> LayDanhSachBanAn()
        {
            var danhSachBanAn = new List<BanAn>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM BanAn";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachBanAn.Add(new BanAn
                    {
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        SoBan = Convert.ToInt32(reader["SoBan"]),
                        LoaiBan = reader["LoaiBan"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSachBanAn;
        }

        public BanAn LayBanAnTheoMa(int maBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM BanAn WHERE MaBan = @MaBan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", maBan);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new BanAn
                    {
                        MaBan = Convert.ToInt32(reader["MaBan"]),
                        SoBan = Convert.ToInt32(reader["SoBan"]),
                        LoaiBan = reader["LoaiBan"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                }
            }
            return null;
        }

        public bool ThemBanAn(BanAn banAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BanAn (SoBan, LoaiBan, TrangThai) VALUES (@SoBan, @LoaiBan, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoBan", banAn.SoBan);
                command.Parameters.AddWithValue("@LoaiBan", banAn.LoaiBan);
                command.Parameters.AddWithValue("@TrangThai", banAn.TrangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatBanAn(BanAn banAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE BanAn SET SoBan = @SoBan, LoaiBan = @LoaiBan, TrangThai = @TrangThai WHERE MaBan = @MaBan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", banAn.MaBan);
                command.Parameters.AddWithValue("@SoBan", banAn.SoBan);
                command.Parameters.AddWithValue("@LoaiBan", banAn.LoaiBan);
                command.Parameters.AddWithValue("@TrangThai", banAn.TrangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaBanAn(int maBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM BanAn WHERE MaBan = @MaBan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", maBan);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatTrangThaiBan(int maBan, string trangThai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE BanAn SET TrangThai = @TrangThai WHERE MaBan = @MaBan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBan", maBan);
                command.Parameters.AddWithValue("@TrangThai", trangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool KiemTraSoBanTonTai(string soBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM BanAn WHERE SoBan = @SoBan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoBan", soBan);
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }
    }
} 