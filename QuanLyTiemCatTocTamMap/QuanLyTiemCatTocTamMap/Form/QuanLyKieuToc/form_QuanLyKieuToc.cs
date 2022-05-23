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
    public partial class form_QuanLyKieuToc : Form
    {
        public DataGridViewRow row;
        public int vt = -1;
        public form_QuanLyKieuToc()
        {
            InitializeComponent();
        }
        private void form_QuanLyKieuToc_Load(object sender, EventArgs e)
        {
            DanhSachKieuToc();
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
        public void DanhSachKieuToc()
        {
            dataGridView.DataSource = QuanLyKieuToc_DAO.Instance.ViewDanhSachKieuToc();
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            form_TaoKieuToc ftud = new form_TaoKieuToc();
            ftud.Owner = this;
            ftud.ShowDialog();
        }
        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string MaKieuToc = dataGridView.CurrentRow.Cells[0].Value.ToString();
                string TenKieuToc = dataGridView.CurrentRow.Cells[1].Value.ToString();
                string GiaTien = dataGridView.CurrentRow.Cells[2].Value.ToString();
                form_ChinhSuaKieuToc fcskt = new form_ChinhSuaKieuToc(MaKieuToc, TenKieuToc, GiaTien);
                fcskt.Owner = this;
                fcskt.ShowDialog();
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string MaKieuToc = dataGridView.CurrentRow.Cells[0].Value.ToString();
                DialogResult msb = MessageBox.Show("Bạn có chắc muốn kiểu tóc này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msb == DialogResult.OK)
                {
                    QuanLyKieuToc_DAO.Instance.XoaKieuToc(MaKieuToc);
                    DanhSachKieuToc();
                    vt = -1;
                }
            }
        }
    }
}