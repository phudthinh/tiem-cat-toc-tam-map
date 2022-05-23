using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemCatTocTamMap.DAO.ThongTin
{
    internal class ThongTin_DAO
    {
        private static ThongTin_DAO instance;
        public static ThongTin_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTin_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThongTin_DAO() { }
        public string GetTenNguoiDung(string TK)
        {
            string query = "GetTenNguoiDung @TK ";
            return (string)DataProvider.Instance.ExecuteScalar(query, new object[] { TK });
        }
    }
}
