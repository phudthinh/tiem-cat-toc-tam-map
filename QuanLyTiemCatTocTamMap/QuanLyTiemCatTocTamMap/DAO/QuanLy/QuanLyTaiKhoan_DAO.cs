using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class QuanLyTaiKhoan_DAO
    {
        private static QuanLyTaiKhoan_DAO instance;
        public static QuanLyTaiKhoan_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLyTaiKhoan_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuanLyTaiKhoan_DAO() { }
        public DataTable ViewDanhSachNguoiDung()
        {
            string query = "SELECT * FROM ViewDanhSachNguoiDung";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void TaoTaiKhoanNguoiDung(string TK, string Ten, string KieuTocYeuThich, string GhiChu)
        {
            string query = "TaoTaiKhoanNguoiDung @TK , @Ten , @KieuTocYeuThich , @GhiChu ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TK, Ten, KieuTocYeuThich, GhiChu });
        }
        public void ChinhSuaTaiKhoanNguoiDung(string TK, string Ten, string KieuTocYeuThich, string GhiChu)
        {
            string query = "ChinhSuaTaiKhoanNguoiDung @TK , @Ten , @KieuTocYeuThich , @GhiChu ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TK, Ten, KieuTocYeuThich, GhiChu });
        }
        public void XoaTaiKhoanNguoiDung(string TK)
        {
            string query = "XoaTaiKhoanNguoiDung @TK ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TK });
        }
        public DataTable VIEWDanhSachKieuTocTinhTien()
        {
            string query = "SELECT * FROM VIEWDanhSachKieuTocTinhTien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool KiemTraTaiKhoanTrung(string TK)
        {
            string query = "KiemTraTaiKhoanTrung @TK";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TK });
            return result.Rows.Count > 0;
        }
    }
}
