using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class NhanVienController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<NhanVien> LayDanhSachNhanVien()
        {
            var danhSachNhanVien = new List<NhanVien>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachNhanVien.Add(new NhanVien
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"] as DateTime?,
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        ChucVu = reader["ChucVu"].ToString()
                    });
                }
            }
            return danhSachNhanVien;
        }

        public NhanVien LayNhanVienTheoMa(int? maNV)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNV", maNV);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new NhanVien
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"] as DateTime?,
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        ChucVu = reader["ChucVu"].ToString()
                    };
                }
            }
            return null;
        }

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, SDT, ChucVu) " +
                               "VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @ChucVu)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", (object)nhanVien.NgaySinh ?? DBNull.Value);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                command.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatNhanVien(NhanVien nhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                               "DiaChi = @DiaChi, SDT = @SDT, ChucVu = @ChucVu WHERE MaNV = @MaNV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                command.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", (object)nhanVien.NgaySinh ?? DBNull.Value);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                command.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaNhanVien(int maNV)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNV", maNV);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<NhanVien> TimKiemNhanVien(string tuKhoa)
        {
            var danhSachNhanVien = new List<NhanVien>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien WHERE HoTen LIKE @TuKhoa OR ChucVu LIKE @TuKhoa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachNhanVien.Add(new NhanVien
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"] as DateTime?,
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        ChucVu = reader["ChucVu"].ToString()
                    });
                }
            }
            return danhSachNhanVien;
        }
    }
}
