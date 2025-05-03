using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Controllers
{
    public class NguyenLieuController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyNhaHang"].ConnectionString;

        public List<NguyenLieu> LayDanhSachNguyenLieu()
        {
            var danhSachNguyenLieu = new List<NguyenLieu>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NguyenLieu";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                  
                    danhSachNguyenLieu.Add(new NguyenLieu
                    {
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        TenNL = reader["TenNL"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        NhaCungCap = reader["NhaCungCap"].ToString()
                    });
                }
            }
            return danhSachNguyenLieu;
        }

        public NguyenLieu LayNguyenLieuTheoMa(int maNL)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NguyenLieu WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", maNL);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new NguyenLieu
                    {
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        TenNL = reader["TenNL"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        HanSuDung = Convert.ToDateTime(reader["HanSuDung"]),
                        NhaCungCap = reader["NhaCungCap"].ToString()
                    };
                }
            }
            return null;
        }

        public bool ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NguyenLieu (TenNL, DonViTinh, SoLuongTon, DonGia) " +
                             "VALUES (@TenNL, @DonViTinh, @SoLuongTon, @DonGia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNL);
                command.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
                command.Parameters.AddWithValue("@SoLuongTon", nguyenLieu.SoLuongTon);
                command.Parameters.AddWithValue("@DonGia", nguyenLieu.DonGia);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatNguyenLieu(NguyenLieu nguyenLieu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NguyenLieu SET TenNL = @TenNL, DonViTinh = @DonViTinh, " +
                             "SoLuongTon = @SoLuongTon, DonGia = @DonGia WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNL);
                command.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNL);
                command.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
                command.Parameters.AddWithValue("@SoLuongTon", nguyenLieu.SoLuongTon);
                command.Parameters.AddWithValue("@DonGia", nguyenLieu.DonGia);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaNguyenLieu(int maNL)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM NguyenLieu WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", maNL);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<NguyenLieu> TimKiemNguyenLieu(string tuKhoa)
        {
            var danhSachNguyenLieu = new List<NguyenLieu>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NguyenLieu WHERE TenNL LIKE @TuKhoa OR NhaCungCap LIKE @TuKhoa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachNguyenLieu.Add(new NguyenLieu
                    {
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        TenNL = reader["TenNL"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                    });
                }
            }
            return danhSachNguyenLieu;
        }

        public bool CapNhatSoLuongTon(int maNL, decimal soLuong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NguyenLieu SET SoLuongTon = @SoLuongTon WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", maNL);
                command.Parameters.AddWithValue("@SoLuongTon", soLuong);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<NguyenLieu> LayNguyenLieuSapHetHan()
        {
            var danhSachNguyenLieu = new List<NguyenLieu>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NguyenLieu WHERE HanSuDung <= DATEADD(day, 7, GETDATE())";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachNguyenLieu.Add(new NguyenLieu
                    {
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        TenNL = reader["TenNL"].ToString(),
                        DonViTinh = reader["DonViTinh"].ToString(),
                        SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        HanSuDung = Convert.ToDateTime(reader["HanSuDung"]),
                        NhaCungCap = reader["NhaCungCap"].ToString()
                    });
                }
            }
            return danhSachNguyenLieu;
        }

        public bool NhapKhoNguyenLieu(PhieuNhapKho phieuNhap, List<ChiTietPhieuNhap> chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert PhieuNhapKho
                        string insertPhieuNhapQuery = "INSERT INTO PhieuNhapKho (MaNV, NgayNhap, TongTien, NhaCungCap, GhiChu) " +
                                                      "VALUES (@MaNV, @NgayNhap, @TongTien, @NhaCungCap, @GhiChu); SELECT SCOPE_IDENTITY();";
                        SqlCommand cmdPhieuNhap = new SqlCommand(insertPhieuNhapQuery, connection, transaction);
                        cmdPhieuNhap.Parameters.AddWithValue("@MaNV", phieuNhap.MaNV);
                        cmdPhieuNhap.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayNhap);
                        cmdPhieuNhap.Parameters.AddWithValue("@TongTien", phieuNhap.TongTien);
                        cmdPhieuNhap.Parameters.AddWithValue("@NhaCungCap", phieuNhap.NhaCungCap);
                        cmdPhieuNhap.Parameters.AddWithValue("@GhiChu", phieuNhap.GhiChu);
                        int maPN = Convert.ToInt32(cmdPhieuNhap.ExecuteScalar());

                        // Insert ChiTietPhieuNhap
                        foreach (var item in chiTiet)
                        {
                            string insertChiTietQuery = "INSERT INTO ChiTietPhieuNhap (MaPN, MaNL, SoLuong, DonGia, ThanhTien) " +
                                                        "VALUES (@MaPN, @MaNL, @SoLuong, @DonGia, @ThanhTien)";
                            SqlCommand cmdChiTiet = new SqlCommand(insertChiTietQuery, connection, transaction);
                            cmdChiTiet.Parameters.AddWithValue("@MaPN", maPN);
                            cmdChiTiet.Parameters.AddWithValue("@MaNL", item.MaNL);
                            cmdChiTiet.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                            cmdChiTiet.Parameters.AddWithValue("@DonGia", item.DonGia);
                            cmdChiTiet.Parameters.AddWithValue("@ThanhTien", item.ThanhTien);
                            cmdChiTiet.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public List<PhieuNhapKho> LayLichSuNhapKho()
        {
            var danhSachPhieuNhap = new List<PhieuNhapKho>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PhieuNhapKho";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    danhSachPhieuNhap.Add(new PhieuNhapKho
                    {
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        NgayNhap = Convert.ToDateTime(reader["NgayNhap"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        NhaCungCap = reader["NhaCungCap"].ToString(),
                        GhiChu = reader["GhiChu"].ToString()
                    });
                }
            }
            return danhSachPhieuNhap;
        }

        public List<ChiTietPhieuNhap> LayChiTietPhieuNhap(int maPN)
        {
            var chiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPN", maPN);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chiTietPhieuNhap.Add(new ChiTietPhieuNhap
                    {
                        MaCTPN = Convert.ToInt32(reader["MaCTPN"]),
                        MaPN = Convert.ToInt32(reader["MaPN"]),
                        MaNL = Convert.ToInt32(reader["MaNL"]),
                        SoLuong = Convert.ToDecimal(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        ThanhTien = Convert.ToDecimal(reader["ThanhTien"])
                    });
                }
            }
            return chiTietPhieuNhap;
        }

        public bool KiemTraTonKho(int maNL, decimal soLuong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SoLuongTon FROM NguyenLieu WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", maNL);
                connection.Open();
                decimal soLuongTon = Convert.ToDecimal(command.ExecuteScalar());
                return soLuongTon >= soLuong;
            }
        }

        internal string LayDonViTinh(string? v)
        {
            //Get DVT of NguyenLieu by MaNL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DonViTinh FROM NguyenLieu WHERE MaNL = @MaNL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNL", v);
                connection.Open();
                return command.ExecuteScalar().ToString();
            }
        }
    }
} 