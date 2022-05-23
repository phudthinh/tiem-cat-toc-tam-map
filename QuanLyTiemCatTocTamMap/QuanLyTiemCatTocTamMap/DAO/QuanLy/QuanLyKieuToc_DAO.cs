using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class QuanLyKieuToc_DAO
    {
        private static QuanLyKieuToc_DAO instance;
        public static QuanLyKieuToc_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLyKieuToc_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuanLyKieuToc_DAO() { }
        public DataTable ViewDanhSachKieuToc()
        {
            string query = "SELECT * FROM VIEWDanhSachKieuToc";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void TaoKieuToc(string TenKieuToc, string GiaTien)
        {
            string query = "TaoKieuToc @TenKieuToc , @GiaTien ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TenKieuToc, GiaTien });
        }
        public void ChinhSuaKieuToc(string MaKieuToc, string TenKieuToc, string GiaTien)
        {
            string query = "ChinhSuaKieuToc @MaKieuToc , @TenKieuToc , @GiaTien ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { MaKieuToc, TenKieuToc, GiaTien });
        }
        public void XoaKieuToc(string MaKieuToc)
        {
            string query = "XoaKieuToc @MaKieuToc ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { MaKieuToc });
        }
    }
}
