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
    public partial class form_LichSuGiaoDich : Form
    {
        public form_LichSuGiaoDich()
        {
            InitializeComponent();
        }

        private void form_LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            DanhSachLSGD();
        }
        public void DanhSachLSGD()
        {
            dataGridView.DataSource = LichSuGiaoDich_DAO.Instance.ViewLichSuGiaoDich();
        }
    }
}
