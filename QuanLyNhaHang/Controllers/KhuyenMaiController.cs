using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class KhuyenMaiController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            var danhSachKhuyenMai = new List<KhuyenMai>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhuyenMai ORDER BY NgayBatDau DESC";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachKhuyenMai.Add(new KhuyenMai
                    {
                        MaKM = Convert.ToInt32(reader["MaKM"]),
                        TenKM = reader["TenKM"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        GiamGiaPhanTram = Convert.ToDecimal(reader["GiamGiaPhanTram"]),
                        GiamGiaTienMat = Convert.ToDecimal(reader["GiamGiaTienMat"]),
                        DieuKienApDung = reader["DieuKienApDung"].ToString(),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    });
                }
            }
            return danhSachKhuyenMai;
        }

        public KhuyenMai LayKhuyenMaiTheoMa(int maKM)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhuyenMai WHERE MaKM = @MaKM";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKM", maKM);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new KhuyenMai
                    {
                        MaKM = Convert.ToInt32(reader["MaKM"]),
                        TenKM = reader["TenKM"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        GiamGiaPhanTram = Convert.ToDecimal(reader["GiamGiaPhanTram"]),
                        GiamGiaTienMat = Convert.ToDecimal(reader["GiamGiaTienMat"]),
                        DieuKienApDung = reader["DieuKienApDung"].ToString(),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    };
                }
            }
            return null;
        }

        public int ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KhuyenMai (TenKM, MoTa, NgayBatDau, NgayKetThuc, " +
                             "GiamGiaPhanTram, GiamGiaTienMat, DieuKienApDung, TrangThai) " +
                             "OUTPUT INSERTED.MaKM " +
                             "VALUES (@TenKM, @MoTa, @NgayBatDau, @NgayKetThuc, " +
                             "@GiamGiaPhanTram, @GiamGiaTienMat, @DieuKienApDung, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenKM", khuyenMai.TenKM);
                command.Parameters.AddWithValue("@MoTa", khuyenMai.MoTa);
                command.Parameters.AddWithValue("@NgayBatDau", khuyenMai.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", khuyenMai.NgayKetThuc);
                command.Parameters.AddWithValue("@GiamGiaPhanTram", khuyenMai.GiamGiaPhanTram);
                command.Parameters.AddWithValue("@GiamGiaTienMat", khuyenMai.GiamGiaTienMat);
                command.Parameters.AddWithValue("@DieuKienApDung", khuyenMai.DieuKienApDung);
                command.Parameters.AddWithValue("@TrangThai", khuyenMai.TrangThai);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public bool CapNhatKhuyenMai(KhuyenMai khuyenMai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE KhuyenMai SET TenKM = @TenKM, MoTa = @MoTa, " +
                             "NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, " +
                             "GiamGiaPhanTram = @GiamGiaPhanTram, GiamGiaTienMat = @GiamGiaTienMat, " +
                             "DieuKienApDung = @DieuKienApDung, TrangThai = @TrangThai " +
                             "WHERE MaKM = @MaKM";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKM", khuyenMai.MaKM);
                command.Parameters.AddWithValue("@TenKM", khuyenMai.TenKM);
                command.Parameters.AddWithValue("@MoTa", khuyenMai.MoTa);
                command.Parameters.AddWithValue("@NgayBatDau", khuyenMai.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", khuyenMai.NgayKetThuc);
                command.Parameters.AddWithValue("@GiamGiaPhanTram", khuyenMai.GiamGiaPhanTram);
                command.Parameters.AddWithValue("@GiamGiaTienMat", khuyenMai.GiamGiaTienMat);
                command.Parameters.AddWithValue("@DieuKienApDung", khuyenMai.DieuKienApDung);
                command.Parameters.AddWithValue("@TrangThai", khuyenMai.TrangThai);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaKhuyenMai(int maKM)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM KhuyenMai WHERE MaKM = @MaKM";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKM", maKM);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<KhuyenMai> LayDanhSachKhuyenMaiDangHoatDong()
        {
            var danhSachKhuyenMai = new List<KhuyenMai>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhuyenMai WHERE TrangThai = 1 AND " +
                             "GETDATE() BETWEEN NgayBatDau AND NgayKetThuc " +
                             "ORDER BY NgayBatDau DESC";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachKhuyenMai.Add(new KhuyenMai
                    {
                        MaKM = Convert.ToInt32(reader["MaKM"]),
                        TenKM = reader["TenKM"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        GiamGiaPhanTram = Convert.ToDecimal(reader["GiamGiaPhanTram"]),
                        GiamGiaTienMat = Convert.ToDecimal(reader["GiamGiaTienMat"]),
                        DieuKienApDung = reader["DieuKienApDung"].ToString(),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    });
                }
            }
            return danhSachKhuyenMai;
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string tuKhoa)
        {
            var danhSachKhuyenMai = new List<KhuyenMai>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhuyenMai WHERE TenKM LIKE @TuKhoa OR MoTa LIKE @TuKhoa " +
                             "ORDER BY NgayBatDau DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachKhuyenMai.Add(new KhuyenMai
                    {
                        MaKM = Convert.ToInt32(reader["MaKM"]),
                        TenKM = reader["TenKM"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        GiamGiaPhanTram = Convert.ToDecimal(reader["GiamGiaPhanTram"]),
                        GiamGiaTienMat = Convert.ToDecimal(reader["GiamGiaTienMat"]),
                        DieuKienApDung = reader["DieuKienApDung"].ToString(),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    });
                }
            }
            return danhSachKhuyenMai;
        }

        public bool ApDungKhuyenMaiChoMonAn(int maKM, int maMA)
        {
            // TODO: Implement logic to apply promotion to dish
            return true;
        }

        public bool HuyApDungKhuyenMai(int maADKM)
        {
            // TODO: Implement logic to cancel promotion application
            return true;
        }

        public List<KhuyenMai> LayKhuyenMaiDangApDung()
        {
            // TODO: Implement logic to get active promotions
            return new List<KhuyenMai>();
        }

        public List<MonAn> LayDanhSachMonAnApDungKhuyenMai(int maKM)
        {
            // TODO: Implement logic to get list of dishes with promotion
            return new List<MonAn>();
        }
    }
} 