using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class QuanLyUuDai_DAO
    {
        private static QuanLyUuDai_DAO instance;
        public static QuanLyUuDai_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLyUuDai_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuanLyUuDai_DAO() { }
        public DataTable ViewDanhSachUuDai()
        {
            string query = "SELECT * FROM VIEWDanhSachUuDai";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void TaoUuDai(string TenUuDai, string PhanTramGiam)
        {
            string query = "TaoUuDai @TenUuDai , @PhanTramGiam ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TenUuDai, PhanTramGiam });
        }
        public void ChinhSuaUuDai(string MaUuDai, string TenUuDai, string PhanTramGiam)
        {
            string query = "ChinhSuaUuDai @MaUuDai , @TenUuDai , @PhanTramGiam ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { MaUuDai, TenUuDai, PhanTramGiam });
        }
        public void XoaUuDai(string MaUuDai)
        {
            string query = "XoaUuDai @MaUuDai ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { MaUuDai });
        }
    }
}
