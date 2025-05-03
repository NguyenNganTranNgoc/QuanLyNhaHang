using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;
using Guna.UI2.WinForms;

namespace QuanLyNhaHang.Controllers
{
    public class PhieuNhapKhoController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<PhieuNhapKho> LayDanhSachPhieuNhapKho()
        {
            var danhSachPhieuNhap = new List<PhieuNhapKho>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PhieuNhapKho ORDER BY NgayNhap DESC";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachPhieuNhap.Add(new PhieuNhapKho
                    {
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        TongTien = reader["TongTien"] != DBNull.Value ? Convert.ToDecimal(reader["TongTien"]) : 0,
                        GhiChu = reader["GhiChu"] != DBNull.Value ? reader["GhiChu"].ToString() : string.Empty,
                        NhaCungCap = reader["NhaCungCap"] != DBNull.Value ? reader["NhaCungCap"].ToString() : string.Empty,
                        TenNV = new NhanVienController().LayNhanVienTheoMa((int?)reader["MaNV"]).HoTen
                    });
                }
            }
            return danhSachPhieuNhap;
        }

        public PhieuNhapKho LayPhieuNhapKhoTheoMa(int maPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PhieuNhapKho WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPN);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new PhieuNhapKho
                    {
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        GhiChu = reader["GhiChu"].ToString()
                    };
                }
            }
            return null;
        }

        public int ThemPhieuNhapKho(PhieuNhapKho phieuNhap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PhieuNhapKho (NgayNhap, MaNV, TongTien, GhiChu) " +
                             "OUTPUT INSERTED.MaPN " +
                             "VALUES (@NgayNhap, @MaNV, @TongTien, @GhiChu)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayNhap);
                command.Parameters.AddWithValue("@MaNV", phieuNhap.MaNV);
                command.Parameters.AddWithValue("@TongTien", phieuNhap.TongTien);
                command.Parameters.AddWithValue("@GhiChu", phieuNhap.GhiChu);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public bool CapNhatPhieuNhapKho(PhieuNhapKho phieuNhap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PhieuNhapKho SET NgayNhap = @NgayNhap, MaNV = @MaNV, " +
                             "TongTien = @TongTien, GhiChu = @GhiChu, NhaCungCap = @NhaCungCap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", phieuNhap.MaPN);
                command.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayNhap);
                command.Parameters.AddWithValue("@MaNV", phieuNhap.MaNV);
                command.Parameters.AddWithValue("@TongTien", phieuNhap.TongTien);
                command.Parameters.AddWithValue("@GhiChu", phieuNhap.GhiChu);
                command.Parameters.AddWithValue("@NhaCungCap", phieuNhap.NhaCungCap);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaPhieuNhapKho(int maPN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //Xóa các chi tiết phiếu nhập kho liên quan trước
                string deleteCTPNQuery = "DELETE FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand deleteCTPNCommand = new SqlCommand(deleteCTPNQuery, connection);
                deleteCTPNCommand.Parameters.AddWithValue("@MaPN", maPN);
                deleteCTPNCommand.ExecuteNonQuery();

                string query = "DELETE FROM PhieuNhapKho WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPN);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<PhieuNhapKho> TimKiemPhieuNhapKho(string filter)
        {
            var danhSachPhieuNhap = new List<PhieuNhapKho>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PhieuNhapKho WHERE " +
                               "CONVERT(VARCHAR, NgayNhap, 120) LIKE @Filter OR " +
                               "CAST(TongTien AS VARCHAR) LIKE @Filter OR " +
                               "GhiChu LIKE @Filter " +
                               "ORDER BY NgayNhap DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Filter", $"%{filter}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachPhieuNhap.Add(new PhieuNhapKho
                    {
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        GhiChu = reader["GhiChu"].ToString()
                    });
                }
            }
            return danhSachPhieuNhap;
        }

        public decimal TinhTongTienNhapKho(DateTime tuNgay, DateTime denNgay)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(TongTien) FROM PhieuNhapKho " +
                             "WHERE NgayNhap BETWEEN @TuNgay AND @DenNgay";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuNgay", tuNgay);
                command.Parameters.AddWithValue("@DenNgay", denNgay);
                connection.Open();
                object result = command.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        internal void CapNhatKhoNguyenLieu(int maPN)
        {
           //Update NguyenLieu bằng chi tiết phieus nhập của maPN

        }

        internal void CapNhatKhoNguyenLieu(Guna2DataGridView dgvChiTietPhieuNhapKho)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in dgvChiTietPhieuNhapKho.Rows)
                {
                    if (row.Cells["MaNL"].Value != null)
                    {
                        string query = "UPDATE NguyenLieu SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaNL = @MaNL";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(row.Cells["SoLuong"].Value));
                        command.Parameters.AddWithValue("@MaNL", row.Cells["MaNL"].Value.ToString());
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
} 