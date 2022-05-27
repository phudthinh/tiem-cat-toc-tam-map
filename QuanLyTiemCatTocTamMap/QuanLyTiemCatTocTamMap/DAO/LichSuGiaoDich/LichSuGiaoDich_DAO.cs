using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyTiemCatTocTamMap
{
    internal class LichSuGiaoDich_DAO
    {
        private static LichSuGiaoDich_DAO instance;
        public static LichSuGiaoDich_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichSuGiaoDich_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private LichSuGiaoDich_DAO() { }
        public DataTable ViewLichSuGiaoDich()
        {
            string query = "SELECT * FROM VIEWDanhSachLichSuGiaoDich";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int GetTongDoanhThu()
        {
            string query = "SELECT * FROM GetTongDoanhThu";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
