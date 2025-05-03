using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class MonAnController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<MonAn> LayDanhSachMonAn()
        {
            var danhSachMonAn = new List<MonAn>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MonAn";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachMonAn.Add(new MonAn
                    {
                        MaMA = Convert.ToInt32(reader["MaMA"]),
                        TenMA = reader["TenMA"].ToString(),
                        AnhMA = reader["AnhMA"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        Gia = Convert.ToDecimal(reader["Gia"]),
                        DanhMuc = reader["DanhMuc"].ToString(),
                        TrangThaiMon = reader["TrangThaiMon"].ToString()
                    });
                }
            }
            return danhSachMonAn;
        }

        public MonAn LayMonAnTheoMa(int maMA)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MonAn WHERE MaMA = @MaMA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", maMA);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new MonAn
                    {
                        MaMA = Convert.ToInt32(reader["MaMA"]),
                        TenMA = reader["TenMA"].ToString(),
                        AnhMA = reader["AnhMA"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        Gia = Convert.ToDecimal(reader["Gia"]),
                        DanhMuc = reader["DanhMuc"].ToString(),
                        TrangThaiMon = reader["TrangThaiMon"].ToString()
                    };
                }
            }
            return null;
        }

        public bool ThemMonAn(MonAn monAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MonAn (TenMA, AnhMA, DonViTinh, Gia, DanhMuc, TrangThaiMon) " +
                             "VALUES (@TenMA, @AnhMA, @DonViTinh, @Gia, @DanhMuc, @TrangThaiMon)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenMA", monAn.TenMA);
                command.Parameters.AddWithValue("@AnhMA", monAn.AnhMA ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonViTinh", monAn.DonViTinh);
                command.Parameters.AddWithValue("@Gia", monAn.Gia);
                command.Parameters.AddWithValue("@DanhMuc", monAn.DanhMuc);
                command.Parameters.AddWithValue("@TrangThaiMon", monAn.TrangThaiMon);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatMonAn(MonAn monAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE MonAn SET TenMA = @TenMA, AnhMA = @AnhMA, DonViTinh = @DonViTinh, " +
                             "Gia = @Gia, DanhMuc = @DanhMuc, TrangThaiMon = @TrangThaiMon " +
                             "WHERE MaMA = @MaMA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", monAn.MaMA);
                command.Parameters.AddWithValue("@TenMA", monAn.TenMA);
                command.Parameters.AddWithValue("@AnhMA", monAn.AnhMA ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DonViTinh", monAn.DonViTinh);
                command.Parameters.AddWithValue("@Gia", monAn.Gia);
                command.Parameters.AddWithValue("@DanhMuc", monAn.DanhMuc);
                command.Parameters.AddWithValue("@TrangThaiMon", monAn.TrangThaiMon);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaMonAn(int maMA)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM MonAn WHERE MaMA = @MaMA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", maMA);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<MonAn> TimKiemMonAn(string tuKhoa)
        {
            var danhSachMonAn = new List<MonAn>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MonAn WHERE TenMA LIKE @TuKhoa OR DanhMuc LIKE @TuKhoa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachMonAn.Add(new MonAn
                    {
                        MaMA = Convert.ToInt32(reader["MaMA"]),
                        TenMA = reader["TenMA"].ToString(),
                        AnhMA = reader["AnhMA"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        Gia = Convert.ToDecimal(reader["Gia"]),
                        DanhMuc = reader["DanhMuc"].ToString(),
                        TrangThaiMon = reader["TrangThaiMon"].ToString()
                    });
                }
            }
            return danhSachMonAn;
        }

        public bool CapNhatTrangThaiMonAn(int maMA, string trangThai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE MonAn SET TrangThaiMon = @TrangThai WHERE MaMA = @MaMA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMA", maMA);
                command.Parameters.AddWithValue("@TrangThai", trangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        internal object LayDanhMuc()
        {
            //Get all categories identity of MonAn
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT DanhMuc FROM MonAn";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<string> danhMucList = new List<string>();
                while (reader.Read())
                {
                    danhMucList.Add(reader["DanhMuc"].ToString());
                }
                return danhMucList;
            }
        }

        internal bool KiemTraDuLieuNhap(MonAn monAn)
        {
            return !string.IsNullOrEmpty(monAn.TenMA) &&
                   !string.IsNullOrEmpty(monAn.DonViTinh) &&
                   monAn.Gia > 0 &&
                   !string.IsNullOrEmpty(monAn.DanhMuc) &&
                   !string.IsNullOrEmpty(monAn.TrangThaiMon);
        }
    }
} 