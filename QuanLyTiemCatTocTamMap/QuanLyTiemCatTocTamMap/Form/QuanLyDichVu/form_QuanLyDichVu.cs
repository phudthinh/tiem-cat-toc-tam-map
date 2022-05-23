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
    public partial class form_QuanLyDichVu : Form
    {
        public DataGridViewRow row;
        public int vt = -1;
        public form_QuanLyDichVu()
        {
            InitializeComponent();
        }
        private void form_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            DanhSachDichVu();
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
        public void DanhSachDichVu()
        {
            dataGridView.DataSource = QuanLyDichVu_DAO.Instance.ViewDanhSachDichVu();
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            form_TaoDichVu ftud = new form_TaoDichVu();
            ftud.Owner = this;
            ftud.ShowDialog();
        }
        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string MaDichVu = dataGridView.CurrentRow.Cells[0].Value.ToString();
                string TenDichVu = dataGridView.CurrentRow.Cells[1].Value.ToString();
                string GiaTien = dataGridView.CurrentRow.Cells[2].Value.ToString();
                form_ChinhSuaDichVu fcsdv = new form_ChinhSuaDichVu(MaDichVu, TenDichVu, GiaTien);
                fcsdv.Owner = this;
                fcsdv.ShowDialog();
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string MaDichVu = dataGridView.CurrentRow.Cells[0].Value.ToString();
                DialogResult msb = MessageBox.Show("Bạn có chắc muốn dịch vụ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msb == DialogResult.OK)
                {
                    QuanLyDichVu_DAO.Instance.XoaDichVu(MaDichVu);
                    DanhSachDichVu();
                    vt = -1;
                }
            }
        }
    }
}