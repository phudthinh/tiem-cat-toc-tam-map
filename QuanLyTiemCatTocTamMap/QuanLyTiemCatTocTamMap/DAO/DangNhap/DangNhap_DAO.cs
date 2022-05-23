using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class DangNhap_DAO
    {
        private static DangNhap_DAO instance;
        public static DangNhap_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DangNhap_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DangNhap_DAO() { }
        public bool DangNhap(string TK, string MK)
        {
            string query = "DangNhap @TK , @MK";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TK, MK });
            return result.Rows.Count > 0;
        }
    }
}
