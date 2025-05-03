using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class KhachHangController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<KhachHang> LayDanhSachKhachHang()
        {
            var danhSachKhachHang = new List<KhachHang>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachKhachHang.Add(new KhachHang
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        HoTen = reader["HoTen"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        DiaChi = reader["DiaChi"].ToString()
                    });
                }
            }
            return danhSachKhachHang;
        }

        public KhachHang LayKhachHangTheoMa(int? maKH)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", maKH);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new KhachHang
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        HoTen = reader["HoTen"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        DiaChi = reader["DiaChi"].ToString()
                    };
                }
            }
            return null;
        }

        public int ThemKhachHangVaLayMa(KhachHang khachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KhachHang (HoTen, SDT, DiaChi) OUTPUT INSERTED.MaKH " +
                               "VALUES (@HoTen, @SDT, @DiaChi)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", khachHang.HoTen);
                command.Parameters.AddWithValue("@SDT", khachHang.SDT);
                command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public bool CapNhatKhachHang(KhachHang khachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE KhachHang SET HoTen = @HoTen, SDT = @SDT, DiaChi = @DiaChi WHERE MaKH = @MaKH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", khachHang.MaKH);
                command.Parameters.AddWithValue("@HoTen", khachHang.HoTen);
                command.Parameters.AddWithValue("@SDT", khachHang.SDT);
                command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaKhachHang(int maKH)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", maKH);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<KhachHang> TimKiemKhachHang(string tuKhoa)
        {
            var danhSachKhachHang = new List<KhachHang>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang WHERE HoTen LIKE @TuKhoa OR SDT LIKE @TuKhoa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachKhachHang.Add(new KhachHang
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        HoTen = reader["HoTen"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        DiaChi = reader["DiaChi"].ToString()
                    });
                }
            }
            return danhSachKhachHang;
        }
    }
}
