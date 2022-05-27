namespace QuanLyTiemCatTocTamMap
{
    partial class form_Chinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_QuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_QuanLyUuDai = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_QuanLyKieuToc = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_TinhTien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LichSuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_ThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_CaiDat = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuItem_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_QuanLy,
            this.menuItem_TinhTien,
            this.menuItem_DoanhThu,
            this.menuItem_LichSuGiaoDich,
            this.menuItem_TroGiup,
            this.miniMenuItem_ThongTin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip_Top";
            // 
            // menuItem_QuanLy
            // 
            this.menuItem_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniMenuItem_QuanLyTaiKhoan,
            this.miniMenuItem_QuanLyUuDai,
            this.miniMenuItem_QuanLyKieuToc,
            this.miniMenuItem_DichVu});
            this.menuItem_QuanLy.Name = "menuItem_QuanLy";
            this.menuItem_QuanLy.Size = new System.Drawing.Size(60, 20);
            this.menuItem_QuanLy.Text = "Quản lý";
            // 
            // miniMenuItem_QuanLyTaiKhoan
            // 
            this.miniMenuItem_QuanLyTaiKhoan.Name = "miniMenuItem_QuanLyTaiKhoan";
            this.miniMenuItem_QuanLyTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.miniMenuItem_QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.miniMenuItem_QuanLyTaiKhoan.Click += new System.EventHandler(this.miniMenuItem_QuanLyTaiKhoan_Click);
            // 
            // miniMenuItem_QuanLyUuDai
            // 
            this.miniMenuItem_QuanLyUuDai.Name = "miniMenuItem_QuanLyUuDai";
            this.miniMenuItem_QuanLyUuDai.Size = new System.Drawing.Size(167, 22);
            this.miniMenuItem_QuanLyUuDai.Text = "Quản lý ưu đãi";
            this.miniMenuItem_QuanLyUuDai.Click += new System.EventHandler(this.miniMenuItem_QuanLyUuDai_Click);
            // 
            // miniMenuItem_QuanLyKieuToc
            // 
            this.miniMenuItem_QuanLyKieuToc.Name = "miniMenuItem_QuanLyKieuToc";
            this.miniMenuItem_QuanLyKieuToc.Size = new System.Drawing.Size(167, 22);
            this.miniMenuItem_QuanLyKieuToc.Text = "Quản lý kiểu tóc";
            this.miniMenuItem_QuanLyKieuToc.Click += new System.EventHandler(this.miniMenuItem_QuanLyKieuToc_Click);
            // 
            // miniMenuItem_DichVu
            // 
            this.miniMenuItem_DichVu.Name = "miniMenuItem_DichVu";
            this.miniMenuItem_DichVu.Size = new System.Drawing.Size(167, 22);
            this.miniMenuItem_DichVu.Text = "Quản lý dịch vụ";
            this.miniMenuItem_DichVu.Click += new System.EventHandler(this.miniMenuItem_DichVu_Click);
            // 
            // menuItem_TinhTien
            // 
            this.menuItem_TinhTien.Name = "menuItem_TinhTien";
            this.menuItem_TinhTien.Size = new System.Drawing.Size(65, 20);
            this.menuItem_TinhTien.Text = "Tính tiền";
            this.menuItem_TinhTien.Click += new System.EventHandler(this.menuItem_TinhTien_Click);
            // 
            // menuItem_DoanhThu
            // 
            this.menuItem_DoanhThu.Name = "menuItem_DoanhThu";
            this.menuItem_DoanhThu.Size = new System.Drawing.Size(75, 20);
            this.menuItem_DoanhThu.Text = "Doanh thu";
            this.menuItem_DoanhThu.Click += new System.EventHandler(this.menuItem_DoanhThu_Click);
            // 
            // menuItem_LichSuGiaoDich
            // 
            this.menuItem_LichSuGiaoDich.Name = "menuItem_LichSuGiaoDich";
            this.menuItem_LichSuGiaoDich.Size = new System.Drawing.Size(108, 20);
            this.menuItem_LichSuGiaoDich.Text = "Lịch sử giao dịch";
            this.menuItem_LichSuGiaoDich.Click += new System.EventHandler(this.menuItem_LichSuGiaoDich_Click);
            // 
            // menuItem_TroGiup
            // 
            this.menuItem_TroGiup.Name = "menuItem_TroGiup";
            this.menuItem_TroGiup.Size = new System.Drawing.Size(62, 20);
            this.menuItem_TroGiup.Text = "Trợ giúp";
            this.menuItem_TroGiup.Click += new System.EventHandler(this.menuItem_TroGiup_Click);
            // 
            // miniMenuItem_ThongTin
            // 
            this.miniMenuItem_ThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.miniMenuItem_CaiDat,
            this.miniMenuItem_DangXuat});
            this.miniMenuItem_ThongTin.Name = "miniMenuItem_ThongTin";
            this.miniMenuItem_ThongTin.Size = new System.Drawing.Size(69, 20);
            this.miniMenuItem_ThongTin.Text = "Tài khoản";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // miniMenuItem_CaiDat
            // 
            this.miniMenuItem_CaiDat.Name = "miniMenuItem_CaiDat";
            this.miniMenuItem_CaiDat.Size = new System.Drawing.Size(128, 22);
            this.miniMenuItem_CaiDat.Text = "Cài đặt";
            this.miniMenuItem_CaiDat.Click += new System.EventHandler(this.miniMenuItem_CaiDat_Click);
            // 
            // miniMenuItem_DangXuat
            // 
            this.miniMenuItem_DangXuat.Name = "miniMenuItem_DangXuat";
            this.miniMenuItem_DangXuat.Size = new System.Drawing.Size(128, 22);
            this.miniMenuItem_DangXuat.Text = "Đăng xuất";
            this.miniMenuItem_DangXuat.Click += new System.EventHandler(this.miniMenuItem_DangXuat_Click);
            // 
            // panel_Form
            // 
            this.panel_Form.Controls.Add(this.label_Logo);
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form.Location = new System.Drawing.Point(0, 24);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(844, 457);
            this.panel_Form.TabIndex = 1;
            // 
            // label_Logo
            // 
            this.label_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Logo.Location = new System.Drawing.Point(0, 155);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(844, 163);
            this.label_Logo.TabIndex = 5;
            this.label_Logo.Text = "Tiệm cắt tóc Tâm Mập";
            this.label_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.panel_Form);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "form_Chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiệm cắt tóc Tâm Mập";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Form.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TinhTien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LichSuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_ThongTin;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_CaiDat;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_QuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_QuanLyUuDai;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_QuanLyKieuToc;
        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.ToolStripMenuItem miniMenuItem_DichVu;
        private System.Windows.Forms.Label label_Logo;
    }
}