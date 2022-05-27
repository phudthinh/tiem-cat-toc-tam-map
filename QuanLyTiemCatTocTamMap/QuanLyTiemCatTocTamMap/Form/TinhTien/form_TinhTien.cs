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
    public partial class form_TinhTien : Form
    {
        public int TongTien = 0;
        public int GiamGia = 0;
        public int NewTongTien = 0;
        public form_TinhTien()
        {
            InitializeComponent();
        }

        private void form_TinhTien_Load(object sender, EventArgs e)
        {
            LoadKieuToc();
            LoadDichVu();
            LoadUuDai();
        }
        public void LoadKieuToc()
        {
            DataTable data = TinhTien_DAO.Instance.VIEWDanhSachKieuTocTinhTien();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox_KieuTocYeuThich.Items.Add(data.Rows[i][0].ToString());
            }
        }
        public bool KiemTraTaiKhoanTonTai(string TK)
        {
            return TinhTien_DAO.Instance.KiemTraTaiKhoanTonTai(TK);
        }
        public void VIEWDanhSachKieuTocTinhTien()
        {
            TinhTien_DAO.Instance.VIEWDanhSachKieuTocTinhTien();
        }
        public void LoadDichVu()
        {
            DataTable data = TinhTien_DAO.Instance.VIEWDanhSachDichVuTinhTien();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                listBox_DanhSachDichVu.Items.Add(data.Rows[i][0].ToString());
            }
        }
        public void VIEWDanhSachDichVuTinhTien()
        {
            TinhTien_DAO.Instance.VIEWDanhSachDichVuTinhTien();
        }

        public bool KiemTraTrung1(string data)
        {
            bool kiemtra = false;
            int numdata = listBox_DanhSachDaChon.Items.Count;
            for (int i = 0; i < numdata; i++)
            {
                if (data == listBox_DanhSachDaChon.Items[i].ToString())
                {
                    kiemtra = true;
                }
            }
            return kiemtra;
        }
        public bool KiemTraTrung2(string data)
        {
            bool kiemtra = false;
            int numdata = listBox_DanhSachDaChon.Items.Count;
            for (int j = 0; j < numdata; j++)
            {
                if (data == listBox_DanhSachDaChon.Items[j].ToString())
                {
                    kiemtra = true;
                }
            }
            return kiemtra;
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (listBox_DanhSachDichVu.SelectedItem == null)
            {
                MessageBox.Show("Phải chọn dịch vụ", "Thông báo");
            }
            else if (KiemTraTrung1(listBox_DanhSachDichVu.SelectedItem.ToString()))
            {
                MessageBox.Show("Không được trùng", "Thông báo");
            }
            else
            {
                listBox_DanhSachDaChon.Items.Add(listBox_DanhSachDichVu.SelectedItem.ToString());
                TongTien = TongTien + Convert.ToInt32(textBox_Gia.Text);
                label_ValueTongTien.Text = TongTien.ToString();
                UpdateNewTongTien();
            }
        }
        private void button_NextAll_Click(object sender, EventArgs e)
        {
            int numdata = listBox_DanhSachDichVu.Items.Count;
            for (int i = 0; i < numdata; i++)
            {
                if (!KiemTraTrung2(listBox_DanhSachDichVu.Items[i].ToString()))
                {
                    listBox_DanhSachDaChon.Items.Add(listBox_DanhSachDichVu.Items[i]);
                    TongTien = Convert.ToInt32(AllTongGiaTienDichVu()) + Convert.ToInt32(GiaTienKieuToc(comboBox_KieuTocYeuThich.Text));
                    label_ValueTongTien.Text = AllTongGiaTienDichVu();
                    UpdateNewTongTien();
                }
            }
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            if (listBox_DanhSachDaChon.SelectedItem != null)
            {
                listBox_DanhSachDaChon.Items.Remove(listBox_DanhSachDaChon.SelectedItem);
                TongTien = TongTien - Convert.ToInt32(textBox_Gia.Text);
                label_ValueTongTien.Text = TongTien.ToString();
                UpdateNewTongTien();
            }
            else
            {
                MessageBox.Show("Phải chọn dịch vụ", "Thông báo");
            }
        }
        private void button_BackAll_Click(object sender, EventArgs e)
        {
            listBox_DanhSachDaChon.Items.Clear();
            TongTien = 0 + Convert.ToInt32(GiaTienKieuToc(comboBox_KieuTocYeuThich.Text));
            label_ValueTongTien.Text = TongTien.ToString();
            UpdateNewTongTien();
        }
        private void button_TinhTien_Click(object sender, EventArgs e)
        {
            if (textBox_TaiKhoan.Text == "")
            {
                label_Loi.Text = "Tài khoản không được để trống";
            }
            else if (!KiemTraTaiKhoanTonTai(textBox_TaiKhoan.Text))
            {
                label_Loi.Text = "Tài khoản không tồn tại";
            }
            else
            {
                TaoLichSuGiaoDich(textBox_TaiKhoan.Text, label_ValueTongTien.Text);
                label_Loi.Text = "Tính tiền thành công";
            }
        }

        private void listBox_DanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_DanhSachDichVu.SelectedItem != null)
            {
                textBox_TenDichVuDuocChon.Text = listBox_DanhSachDichVu.SelectedItem.ToString();
                textBox_Gia.Text = TinhTien_DAO.Instance.GiaTienDichVu(textBox_TenDichVuDuocChon.Text).ToString();
            }
        }

        private void listBox_DanhSachDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_DanhSachDaChon.SelectedItem != null)
            {
                textBox_TenDichVuDuocChon.Text = listBox_DanhSachDaChon.SelectedItem.ToString();
                textBox_Gia.Text = TinhTien_DAO.Instance.GiaTienDichVu(listBox_DanhSachDaChon.Text).ToString();
            }
        }
        public string GiaTienDichVu(string TenDichVu)
        {
            return TinhTien_DAO.Instance.GiaTienDichVu(TenDichVu).ToString();
        }
        public string AllTongGiaTienDichVu()
        {
            return TinhTien_DAO.Instance.AllTongGiaTienDichVu().ToString();
        }
        public string GiaTienKieuToc(string TenKieuToc)
        {
            if (comboBox_KieuTocYeuThich.Text != "")
            {
                return TinhTien_DAO.Instance.GiaTienKieuToc(TenKieuToc).ToString();
            }
            return "0";
        }

        private void comboBox_KieuTocYeuThich_SelectedIndexChanged(object sender, EventArgs e)
        {
            TongTien = TongTien + Convert.ToInt32(GiaTienKieuToc(comboBox_KieuTocYeuThich.Text));
            label_ValueTongTien.Text = TongTien.ToString();
            UpdateNewTongTien();
        }

        public void LoadUuDai()
        {
            DataTable data = TinhTien_DAO.Instance.VIEWDanhSachUuDaiTinhTien();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox_UuDai.Items.Add(data.Rows[i][0].ToString());
            }
        }
        public void VIEWDanhSachUuDaiTinhTien()
        {
            TinhTien_DAO.Instance.VIEWDanhSachUuDaiTinhTien();
        }
        public string PhanTramGiamUuDai(string TenUuDai)
        {
            if (comboBox_UuDai.Text != "")
            {
                return TinhTien_DAO.Instance.PhanTramGiamUuDai(TenUuDai).ToString();
            }
            return "0";
        }

        private void comboBox_UuDai_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNewTongTien();
        }
        public void UpdateNewTongTien()
        {
            if (comboBox_UuDai.Text != "")
            {
                NewTongTien = 0;
            }
            else
            {
                NewTongTien = Convert.ToInt32(label_ValueTongTien.Text);
            }
            GiamGia = Convert.ToInt32(PhanTramGiamUuDai(comboBox_UuDai.Text));
            NewTongTien = TongTien - (TongTien / 100 * GiamGia);
            label_ValueTongTien.Text = NewTongTien.ToString();
        }

        public void TaoLichSuGiaoDich(string Ten, string TongTien)
        {
            TinhTien_DAO.Instance.TaoLichSuGiaoDich(Ten, TongTien);
        }
    }
}
