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
    public partial class form_TaoKieuToc : Form
    {
        public form_TaoKieuToc()
        {
            InitializeComponent();
        }
        public void KiemTraThongTin()
        {
            if (textBox_TenKieuToc.Text == "")
            {
                label_Loi.Text = "Tên kiểu tóc không được để trống";
            }
            else if (textBox_TenKieuToc.Text == "")
            {
                label_Loi.Text = "Giá tiền không được để trống";
            }
            else
            {
                TaoKieuToc(textBox_TenKieuToc.Text, textBox_GiaTien.Text);
                (this.Owner as form_QuanLyKieuToc).DanhSachKieuToc();
            }
        }
        public void TaoKieuToc(string TenKieuToc, string GiaTien)
        {
            QuanLyKieuToc_DAO.Instance.TaoKieuToc(TenKieuToc, GiaTien);
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }

        private void textBox_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
