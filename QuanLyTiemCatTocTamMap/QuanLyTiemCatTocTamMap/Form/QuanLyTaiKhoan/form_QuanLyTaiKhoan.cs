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
    public partial class form_QuanLyTaiKhoan : Form
    {
        public DataGridViewRow row;
        public int vt = -1;
        public form_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            row = dataGridView.Rows[vt];
        }
        private void form_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            DanhSachNguoiDung();
        }
        public void DanhSachNguoiDung()
        {
            dataGridView.DataSource = QuanLyTaiKhoan_DAO.Instance.ViewDanhSachNguoiDung();
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            form_TaoTaiKhoanNguoiDung fttknd = new form_TaoTaiKhoanNguoiDung();
            fttknd.Owner = this;
            fttknd.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string TaiKhoan = dataGridView.CurrentRow.Cells[0].Value.ToString();
                string TenNguoiDung = dataGridView.CurrentRow.Cells[1].Value.ToString();
                string KieuTocYeuThich = dataGridView.CurrentRow.Cells[2].Value.ToString();
                string GhiChu = dataGridView.CurrentRow.Cells[3].Value.ToString();
                form_ChinhSuaTaiKhoanNguoiDung fcstknd = new form_ChinhSuaTaiKhoanNguoiDung(TaiKhoan, TenNguoiDung, KieuTocYeuThich, GhiChu);
                fcstknd.Owner = this;
                fcstknd.ShowDialog();
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string TaiKhoan = dataGridView.CurrentRow.Cells[0].Value.ToString();
                DialogResult msb = MessageBox.Show("Bạn có chắc muốn tài khoản này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msb == DialogResult.OK)
                {
                    QuanLyTaiKhoan_DAO.Instance.XoaTaiKhoanNguoiDung(TaiKhoan);
                    DanhSachNguoiDung();
                    vt = -1;
                }
            }
        }
    }
}
