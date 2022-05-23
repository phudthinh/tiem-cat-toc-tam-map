using QuanLyTiemCatTocTamMap.DAO;
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
    public partial class form_CaiDat : Form
    {
        string tk;
        public form_CaiDat(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if(textBox_MatKhauCu.Text == "" || textBox_MatKhauMoi.Text == "" || textBox_XNMatKhauMoi.Text == "")
            {
                label_Loi.Text = "Thông tin không được để trống";
            }
            else if(textBox_MatKhauMoi.Text != textBox_XNMatKhauMoi.Text)
            {
                label_Loi.Text = "Mật khẩu mới không trùng khớp";
            }
            else if(!KiemTraMatKhauTrung(tk, textBox_MatKhauCu.Text))
            {
                label_Loi.Text = "Mật khẩu cũ không chính xác";
            }
            else
            {
                ChinhSuaMatKhauTaiKhoanNguoiDung(tk, textBox_MatKhauMoi.Text);
                label_Loi.Text = "Đã đổi mật khẩu thành công";
            }
        }
        public bool KiemTraMatKhauTrung(string TK, string MK)
        {
            return CaiDat_DAO.Instance.KiemTraMatKhauTrung(TK, MK);
        }
        public void ChinhSuaMatKhauTaiKhoanNguoiDung(string TK, string MK)
        {
            CaiDat_DAO.Instance.ChinhSuaMatKhauTaiKhoanNguoiDung(TK, MK);
        }
    }
}
