using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class TaiKhoanController
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public TaiKhoan DangNhap(string taiKhoan, string matKhau)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TaiKhoan
                            {
                                TenTaiKhoan = reader["TaiKhoan"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                MaNV = Convert.ToInt32(reader["MaNV"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool DoiMatKhau(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE TaiKhoan SET MatKhau = @MatKhauMoi WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhauCu";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@MatKhauCu", matKhauCu);
                    command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO TaiKhoan (TaiKhoan, MatKhau, MaNV) VALUES (@TaiKhoan, @MatKhau, @MaNV)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan.TenTaiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                    command.Parameters.AddWithValue("@MaNV", taiKhoan.MaNV);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool XoaTaiKhoan(string taiKhoan)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool KiemTraQuyen(string taiKhoan, string quyen)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM PhanQuyen WHERE TaiKhoan = @TaiKhoan AND Quyen = @Quyen";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@Quyen", quyen);

                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public List<string> LayDanhSachQuyen(string taiKhoan)
        {
            var danhSachQuyen = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT Quyen FROM PhanQuyen WHERE TaiKhoan = @TaiKhoan";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachQuyen.Add(reader["Quyen"].ToString());
                        }
                    }
                }
            }
            return danhSachQuyen;
        }
    }
} 