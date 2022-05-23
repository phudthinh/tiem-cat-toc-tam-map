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
    public partial class form_ChinhSuaDichVu : Form
    {
        string maDichVu, tenDichVu, giaTien;
        public form_ChinhSuaDichVu(string maDichVu, string tenDichVu, string giaTien)
        {
            InitializeComponent();
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.giaTien = giaTien;
        }
        private void form_ChinhSuaDichVu_Load(object sender, EventArgs e)
        {
            textBox_TenDichVu.Text = tenDichVu;
            textBox_GiaTien.Text = giaTien;
        }
        public void KiemTraThongTin()
        {
            if (textBox_TenDichVu.Text == "")
            {
                label_Loi.Text = "Tên kiểu tóc không được để trống";
            }
            else if (textBox_GiaTien.Text == "")
            {
                label_Loi.Text = "Giá tiền không được để trống";
            }
            else
            {
                ChinhSuaDichVu(maDichVu, textBox_TenDichVu.Text, textBox_GiaTien.Text);
                (this.Owner as form_QuanLyDichVu).DanhSachDichVu();
            }
        }

        private void textBox_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void ChinhSuaDichVu(string maDichVu, string tenDichVu, string GiaTien)
        {
            QuanLyDichVu_DAO.Instance.ChinhSuaDichVu(maDichVu, tenDichVu, GiaTien);
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }
    }
}