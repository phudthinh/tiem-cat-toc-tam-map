using QuanLyTiemCatTocTamMap.DAO.ThongTin;
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
    public partial class form_ThongTin : Form
    {
        string tk;
        public form_ThongTin(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            label_Ten.Text = ThongTin_DAO.Instance.GetTenNguoiDung(tk);
        }
    }
}
