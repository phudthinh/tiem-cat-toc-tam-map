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
    public partial class form_QuanLyUuDai : Form
    {
        public DataGridViewRow row;
        public int vt = -1;
        public form_QuanLyUuDai()
        {
            InitializeComponent();
        }

        private void form_QuanLyUuDai_Load(object sender, EventArgs e)
        {
            DanhSachUuDai();
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
        public void DanhSachUuDai()
        {
            dataGridView.DataSource = QuanLyUuDai_DAO.Instance.ViewDanhSachUuDai();
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            form_TaoUuDai ftud = new form_TaoUuDai();
            ftud.Owner = this;
            ftud.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string MaGiamGia = dataGridView.CurrentRow.Cells[0].Value.ToString();
                string TenUuDai = dataGridView.CurrentRow.Cells[1].Value.ToString();
                string PhanTramGiam = dataGridView.CurrentRow.Cells[2].Value.ToString();
                form_ChinhSuaUuDai fcsud = new form_ChinhSuaUuDai(MaGiamGia, TenUuDai, PhanTramGiam);
                fcsud.Owner = this;
                fcsud.ShowDialog();
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                string MaUuDai = dataGridView.CurrentRow.Cells[0].Value.ToString();
                DialogResult msb = MessageBox.Show("Bạn có chắc muốn ưu đãi này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msb == DialogResult.OK)
                {
                    QuanLyUuDai_DAO.Instance.XoaUuDai(MaUuDai);
                    DanhSachUuDai();
                }
            }
        }
    }
}
