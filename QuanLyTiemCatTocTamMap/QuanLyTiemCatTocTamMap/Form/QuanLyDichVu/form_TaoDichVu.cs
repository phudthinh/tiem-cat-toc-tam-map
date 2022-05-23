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
    public partial class form_TaoDichVu : Form
    {
        public form_TaoDichVu()
        {
            InitializeComponent();
        }
        public void KiemTraThongTin()
        {
            if (textBox_TenDichVu.Text == "")
            {
                label_Loi.Text = "Tên dịch vụ không được để trống";
            }
            else if (textBox_GiaTien.Text == "")
            {
                label_Loi.Text = "Giá tiền không được để trống";
            }
            else
            {
                TaoDichVu(textBox_TenDichVu.Text, textBox_GiaTien.Text);
                (this.Owner as form_QuanLyDichVu).DanhSachDichVu();
            }
        }
        public void TaoDichVu(string TenDichVu, string GiaTien)
        {
            QuanLyDichVu_DAO.Instance.TaoDichVu(TenDichVu, GiaTien);
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
