using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemCatTocTamMap
{
    public partial class form_DoanhThu : Form
    {
        public form_DoanhThu()
        {
            InitializeComponent();
        }

        private void form_DoanhThu_Load(object sender, EventArgs e)
        {
            DanhSachLSGD();
        }
        public void DanhSachLSGD()
        {
            dataGridView.DataSource = LichSuGiaoDich_DAO.Instance.ViewLichSuGiaoDich();
            label_ValueTongTien.Text = LichSuGiaoDich_DAO.Instance.GetTongDoanhThu().ToString();
        }
    }
}
