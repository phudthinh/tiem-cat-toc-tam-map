using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class TinhTien_DAO
    {
        private static TinhTien_DAO instance;
        public static TinhTien_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinhTien_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TinhTien_DAO() { }
        public bool KiemTraTaiKhoanTonTai(string TK)
        {
            string query = "KiemTraTaiKhoanTrung @TK";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TK });
            return result.Rows.Count > 0;
        }
        public DataTable VIEWDanhSachKieuTocTinhTien()
        {
            string query = "SELECT * FROM VIEWDanhSachKieuTocTinhTien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable VIEWDanhSachDichVuTinhTien()
        {
            string query = "SELECT * FROM VIEWDanhSachDichVuTinhTien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int GiaTienDichVu(string TenDichVu)
        {
            string query = "GiaTienDichVu @TenDichVu";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { TenDichVu });
        }
        public int AllTongGiaTienDichVu()
        {
            string query = "AllTongGiaTienDichVu";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        public int GiaTienKieuToc(string TenKieuToc)
        {
            string query = "GiaTienKieuToc @TenKieuToc";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { TenKieuToc });
        }
    }
}
