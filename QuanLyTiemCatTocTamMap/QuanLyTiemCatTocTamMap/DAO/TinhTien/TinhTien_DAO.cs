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
        public DataTable VIEWDanhSachUuDaiTinhTien()
        {
            string query = "SELECT * FROM VIEWDanhSachUuDaiTinhTien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int PhanTramGiamUuDai(string TenUuDai)
        {
            string query = "PhanTramGiamUuDai @TenUuDai";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { TenUuDai });
        }
        public void TaoLichSuGiaoDich(string Ten, string TongTien)
        {
            string query = "TaoLichSuGiaoDich @Ten , @TongTien";
            DataProvider.Instance.ExecuteScalar(query, new object[] { Ten , TongTien });
        }
    }
}
