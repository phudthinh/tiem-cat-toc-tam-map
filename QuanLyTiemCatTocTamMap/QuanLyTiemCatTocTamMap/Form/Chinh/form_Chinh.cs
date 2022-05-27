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
    public partial class form_Chinh : Form
    {
        string tk;
        private Form currentChildForm;
        public form_Chinh(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Form.Controls.Add(childForm);
            panel_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void miniMenuItem_QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_QuanLyTaiKhoan());
        }

        private void miniMenuItem_QuanLyUuDai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_QuanLyUuDai());
        }
        private void miniMenuItem_QuanLyKieuToc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_QuanLyKieuToc());
        }
        private void miniMenuItem_DichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_QuanLyDichVu());
        }
        private void menuItem_TroGiup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_TroGiup());
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_ThongTin(tk));
        }
        private void miniMenuItem_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_DangNhap dn = new form_DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void menuItem_TinhTien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_TinhTien());
        }

        private void miniMenuItem_CaiDat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_CaiDat(tk));
        }

        private void menuItem_LichSuGiaoDich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_LichSuGiaoDich());
        }

        private void menuItem_DoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_DoanhThu());
        }
    }
}
