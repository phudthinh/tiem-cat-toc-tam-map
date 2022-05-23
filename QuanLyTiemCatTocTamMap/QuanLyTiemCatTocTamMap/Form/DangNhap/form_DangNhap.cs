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
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
            label_Loi.Text = "";
        }
        public void KiemTraDangNhap()
        {
            string textTK = textBox_TaiKhoan.Text;
            string textMK = textBox_MatKhau.Text;
            if (textBox_TaiKhoan.Text == "" || textBox_MatKhau.Text == "")
            {
                label_Loi.Text = "Thông tin không được để trống";
                textBox_MatKhau.Text = string.Empty;
            }
            else
            {
                if (DangNhap(textTK, textMK))
                {
                    this.Hide();
                    form_Chinh fC = new form_Chinh(textTK);
                    fC.ShowDialog();
                    this.Close();
                }
                else
                {
                    label_Loi.Text = "Tài khoản hoặc mật khẩu không chính xác";
                    textBox_MatKhau.Text = string.Empty;
                }
            }
        }
        public bool DangNhap(string TK, string MK)
        {
            return DangNhap_DAO.Instance.DangNhap(TK, MK);
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }

        private void textBox_TaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                KiemTraDangNhap();
            }
        }

        private void textBox_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                KiemTraDangNhap();
            }
        }
    }
}
