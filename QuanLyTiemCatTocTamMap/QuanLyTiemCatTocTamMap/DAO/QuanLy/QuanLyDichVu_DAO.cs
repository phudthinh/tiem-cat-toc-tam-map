using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class QuanLyDichVu_DAO
    {
        private static QuanLyDichVu_DAO instance;
        public static QuanLyDichVu_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLyDichVu_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuanLyDichVu_DAO() { }
        public DataTable ViewDanhSachDichVu()
        {
            string query = "SELECT * FROM VIEWDanhSachDichVu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void TaoDichVu(string TenDichVu, string GiaTien)
        {
            string query = "TaoDichVu @TenDichVu , @GiaTien ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TenDichVu, GiaTien });
        }
        public void ChinhSuaDichVu(string MaDichVu, string TenDichVu, string GiaTien)
        {
            string query = "ChinhSuaDichVu @MaDichVu , @TenDichVu , @GiaTien ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { MaDichVu, TenDichVu, GiaTien });
        }
        public void XoaDichVu(string MaDichVu)
        {
            string query = "XoaDichVu @MaDichVu ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { MaDichVu });
        }
    }
}
