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
    public partial class form_TaoTaiKhoanNguoiDung : Form
    {
        public form_TaoTaiKhoanNguoiDung()
        {
            InitializeComponent();
        }
        public void KiemTraThongTin()
        {
            if(textBox_TaiKhoan.Text == "")
            {
                label_Loi.Text = "Tài khoản không được để trống";
            }
            else if (textBox_TenNguoiDung.Text == "")
            {
                label_Loi.Text = "Tên người dùng không được để trống";
            }
            else if (KiemTraTaiKhoanTrung(textBox_TaiKhoan.Text))
            {
                label_Loi.Text = "Tài khoản đã tồn tại";
            }
            else
            {
                TaoTaiKhoanNguoiDung(textBox_TaiKhoan.Text, textBox_TenNguoiDung.Text, comboBox_KieuTocYeuThich.Text, textBox_GhiChu.Text);
                (this.Owner as form_QuanLyTaiKhoan).DanhSachNguoiDung();
            }
        }
        public bool KiemTraTaiKhoanTrung(string TK)
        {
            return QuanLyTaiKhoan_DAO.Instance.KiemTraTaiKhoanTrung(TK);
        }
        public void TaoTaiKhoanNguoiDung(string TK, string Ten, string KieuTocYeuThich, string GhiChu)
        {
            QuanLyTaiKhoan_DAO.Instance.TaoTaiKhoanNguoiDung(TK, Ten, KieuTocYeuThich, GhiChu);
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }

        private void form_TaoTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            LoadKieuToc();
        }
        public void LoadKieuToc()
        {
            DataTable data = QuanLyTaiKhoan_DAO.Instance.VIEWDanhSachKieuTocTinhTien();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox_KieuTocYeuThich.Items.Add(data.Rows[i][0].ToString());
            }
        }
        public void VIEWDanhSachKieuTocTinhTien()
        {
            QuanLyTaiKhoan_DAO.Instance.VIEWDanhSachKieuTocTinhTien();
        }
    }
}
