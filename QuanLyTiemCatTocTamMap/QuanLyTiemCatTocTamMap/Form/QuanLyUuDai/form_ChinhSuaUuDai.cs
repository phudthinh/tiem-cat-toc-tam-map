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
    public partial class form_ChinhSuaUuDai : Form
    {
        string maUuDai, tenUuDai, phanTramGiamGia;

        public form_ChinhSuaUuDai(string maUuDai, string tenUuDai, string phanTramGiamGia)
        {
            InitializeComponent();
            this.maUuDai = maUuDai;
            this.tenUuDai = tenUuDai;
            this.phanTramGiamGia = phanTramGiamGia;
        }
        private void form_ChinhSuaUuDai_Load(object sender, EventArgs e)
        {
            textBox_TenUuDai.Text = tenUuDai;
            textBox_PhanTramGiamGia.Text = phanTramGiamGia;
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
                ChinhSuaUuDai(maUuDai, textBox_TenUuDai.Text, textBox_PhanTramGiamGia.Text);
                (this.Owner as form_QuanLyUuDai).DanhSachUuDai();
            }
        }

        private void textBox_PhanTramGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void ChinhSuaUuDai(string MaUuDai, string TenUuDai, string PhanTramGiam)
        {
            QuanLyUuDai_DAO.Instance.ChinhSuaUuDai(MaUuDai, TenUuDai, PhanTramGiam);
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }
    }
}
