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
    public partial class form_ChinhSuaTaiKhoanNguoiDung : Form
    {
        string tk, ten, kieuTocYeuThich, ghiChu;

        public form_ChinhSuaTaiKhoanNguoiDung(string tk, string ten, string kieuTocYeuThich, string ghiChu)
        {
            InitializeComponent();
            this.tk = tk;
            this.ten = ten;
            this.kieuTocYeuThich = kieuTocYeuThich;
            this.ghiChu = ghiChu;
        }
        private void form_ChinhSuaTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            textBox_TaiKhoan.Text = tk;
            textBox_TenNguoiDung.Text = ten;
            comboBox_KieuTocYeuThich.Text = kieuTocYeuThich;
            textBox_GhiChu.Text = ghiChu;
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
        public void KiemTraThongTin()
        {
            if (textBox_TenNguoiDung.Text == "")
            {
                label_Loi.Text = "Tên người dùng không được để trống";
            }
            else
            {
                ChinhSuaTaiKhoanNguoiDung(textBox_TaiKhoan.Text, textBox_TenNguoiDung.Text, comboBox_KieuTocYeuThich.Text, textBox_GhiChu.Text);
                (this.Owner as form_QuanLyTaiKhoan).DanhSachNguoiDung();
            }
        }
        public void ChinhSuaTaiKhoanNguoiDung(string TK, string Ten, string KieuTocYeuThich, string GhiChu)
        {
            QuanLyTaiKhoan_DAO.Instance.ChinhSuaTaiKhoanNguoiDung(TK, Ten, KieuTocYeuThich, GhiChu);
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            this.Close();
        }
    }
}
