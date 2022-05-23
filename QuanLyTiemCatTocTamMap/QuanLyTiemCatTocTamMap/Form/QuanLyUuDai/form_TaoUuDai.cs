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
    public partial class form_TaoUuDai : Form
    {
        public form_TaoUuDai()
        {
            InitializeComponent();
        }
        public void KiemTraThongTin()
        {
            if (textBox_TenUuDai.Text == "")
            {
                label_Loi.Text = "Tên ưu đãi không được để trống";
            }
            else if (textBox_PhanTramGiamGia.Text == "")
            {
                label_Loi.Text = "Phần trăm giảm giá không được để trống";
            }
            else
            {
                TaoUuDai(textBox_TenUuDai.Text, textBox_PhanTramGiamGia.Text);
                (this.Owner as form_QuanLyUuDai).DanhSachUuDai();
            }
        }
        public void TaoUuDai(string TenUuDai, string PhanTramGiamGia)
        {
            QuanLyUuDai_DAO.Instance.TaoUuDai(TenUuDai, PhanTramGiamGia);
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }

        private void textBox_PhanTramGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
