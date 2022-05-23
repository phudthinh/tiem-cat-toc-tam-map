using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace QuanLyTiemCatTocTamMap.DAO
{
    internal class CaiDat_DAO
    {
        private static CaiDat_DAO instance;
        public static CaiDat_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CaiDat_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private CaiDat_DAO() { }
        public void ChinhSuaMatKhauTaiKhoanNguoiDung(string TK, string MK)
        {
            string query = "ChinhSuaMatKhauTaiKhoanNguoiDung @TK , @MK ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { TK, MK });
        }
        public bool KiemTraMatKhauTrung(string TK, string MK)
        {
            string query = "KiemTraMatKhauTrung @TK , @MK";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TK, MK });
            return result.Rows.Count > 0;
        }
    }
}
