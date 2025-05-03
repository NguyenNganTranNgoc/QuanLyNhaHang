using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class ChiTietPhieuNhapController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap(int maPN)
        {
            var danhSachChiTiet = new List<ChiTietPhieuNhap>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPN);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachChiTiet.Add(new ChiTietPhieuNhap
                    {
                        MaCTPN = Convert.ToInt32(reader["MaCTPN"]),
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        SoLuong = Convert.ToDecimal(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
                    });
                }
            }
            return danhSachChiTiet;
        }

        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ChiTietPhieuNhap (MaPN, MaNL, SoLuong, DonGia, ThanhTien) " +
                             "VALUES (@MaPN, @MaNL, @SoLuong, @DonGia, @ThanhTien)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", chiTiet.MaPN);
                command.Parameters.AddWithValue("@MaNL", chiTiet.MaNL);
                command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                command.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);
                command.Parameters.AddWithValue("@ThanhTien", chiTiet.ThanhTien);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ChiTietPhieuNhap SET MaPN = @MaPN, MaNL = @MaNL, " +
                             "SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien WHERE MaCTPN = @MaCTPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCTPN", chiTiet.MaCTPN);
                command.Parameters.AddWithValue("@MaPN", chiTiet.MaPN);
                command.Parameters.AddWithValue("@MaNL", chiTiet.MaNL);
                command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                command.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);
                command.Parameters.AddWithValue("@ThanhTien", chiTiet.ThanhTien);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaChiTietPhieuNhap(int maCTPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ChiTietPhieuNhap WHERE MaCTPN = @MaCTPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCTPN", maCTPN);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaTatCaChiTietPhieuNhap(int maPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPN);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public decimal TinhTongTienChiTietPhieuNhap(int maPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(ThanhTien) FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPN);
                connection.Open();
                object result = command.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhapTheoNguyenLieu(int maNL)
        {
            var danhSachChiTiet = new List<ChiTietPhieuNhap>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietPhieuNhap WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", maNL);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachChiTiet.Add(new ChiTietPhieuNhap
                    {
                        MaCTPN = Convert.ToInt32(reader["MaCTPN"]),
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        SoLuong = Convert.ToDecimal(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
                    });
                }
            }
            return danhSachChiTiet;
        }

        internal object TinhTongTien(int currentPNK)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(ThanhTien) FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", currentPNK);
                connection.Open();
                object result = command.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        internal List<ChiTietPhieuNhap> LayChiTietPhieuNhap(int maPhieuNhap)
        {
            var danhSachChiTiet = new List<ChiTietPhieuNhap>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPhieuNhap);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachChiTiet.Add(new ChiTietPhieuNhap
                    {
                        MaCTPN = Convert.ToInt32(reader["MaCTPN"]),
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        SoLuong = Convert.ToDecimal(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
                    });
                }
            }
            return danhSachChiTiet;
        }
    }
}