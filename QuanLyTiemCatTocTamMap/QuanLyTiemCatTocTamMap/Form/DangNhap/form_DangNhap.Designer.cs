namespace QuanLyTiemCatTocTamMap
{
    partial class form_DangNhap
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
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.label_Loi = new System.Windows.Forms.Label();
            this.label_Logo = new System.Windows.Forms.Label();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(12, 175);
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(360, 32);
            this.textBox_TaiKhoan.TabIndex = 0;
            this.textBox_TaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TaiKhoan_KeyPress);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.Location = new System.Drawing.Point(12, 228);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(360, 32);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            this.textBox_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MatKhau_KeyPress);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.Location = new System.Drawing.Point(12, 289);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(360, 60);
            this.button_DangNhap.TabIndex = 2;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.UseVisualStyleBackColor = true;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Loi.ForeColor = System.Drawing.Color.Red;
            this.label_Loi.Location = new System.Drawing.Point(12, 263);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(360, 23);
            this.label_Loi.TabIndex = 3;
            this.label_Loi.Text = "Tài khoản hoặc mật khẩu không chính xác";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Logo
            // 
            this.label_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Logo.Location = new System.Drawing.Point(12, 9);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(360, 163);
            this.label_Logo.TabIndex = 4;
            this.label_Logo.Text = "Tâm Mập";
            this.label_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TaiKhoan.Location = new System.Drawing.Point(12, 157);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(100, 15);
            this.label_TaiKhoan.TabIndex = 5;
            this.label_TaiKhoan.Text = "Tài khoản";
            this.label_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_MatKhau.Location = new System.Drawing.Point(12, 210);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(100, 15);
            this.label_MatKhau.TabIndex = 6;
            this.label_MatKhau.Text = "Mật khẩu";
            this.label_MatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label_MatKhau);
            this.Controls.Add(this.label_TaiKhoan);
            this.Controls.Add(this.label_Logo);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TaiKhoan);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.Label label_Loi;
        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.Label label_MatKhau;
    }
}

