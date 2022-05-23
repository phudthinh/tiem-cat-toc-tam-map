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
    public partial class form_ChinhSuaKieuToc : Form
    {
        string maKieuToc, tenKieuToc, giaTien;
        public form_ChinhSuaKieuToc(string maKieuToc, string tenKieuToc, string giaTien)
        {
            InitializeComponent();
            this.maKieuToc = maKieuToc;
            this.tenKieuToc = tenKieuToc;
            this.giaTien = giaTien;
        }
        private void form_ChinhSuaKieuToc_Load(object sender, EventArgs e)
        {
            textBox_TenKieuToc.Text = tenKieuToc;
            textBox_GiaTien.Text = giaTien;
        }
        public void KiemTraThongTin()
        {
            if (textBox_TenKieuToc.Text == "")
            {
                label_Loi.Text = "Tên kiểu tóc không được để trống";
            }
            else if (textBox_GiaTien.Text == "")
            {
                label_Loi.Text = "Giá tiền không được để trống";
            }
            else
            {
                ChinhSuaKieuToc(maKieuToc, textBox_TenKieuToc.Text, textBox_GiaTien.Text);
                (this.Owner as form_QuanLyKieuToc).DanhSachKieuToc();
            }
        }

        private void textBox_KieuToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void ChinhSuaKieuToc(string maKieuToc, string tenKieuToc, string GiaTien)
        {
            QuanLyKieuToc_DAO.Instance.ChinhSuaKieuToc(maKieuToc, tenKieuToc, GiaTien);
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }
    }
}