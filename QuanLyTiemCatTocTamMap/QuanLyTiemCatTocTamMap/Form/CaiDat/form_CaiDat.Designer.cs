namespace QuanLyTiemCatTocTamMap
{
    partial class form_CaiDat
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
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.textBox_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_XNMatKhauMoi = new System.Windows.Forms.TextBox();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.label_Loi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TaiKhoan.Location = new System.Drawing.Point(12, 9);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(100, 15);
            this.label_TaiKhoan.TabIndex = 22;
            this.label_TaiKhoan.Text = "Mật khẩu cũ";
            this.label_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_MatKhauCu
            // 
            this.textBox_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_MatKhauCu.Location = new System.Drawing.Point(12, 27);
            this.textBox_MatKhauCu.Name = "textBox_MatKhauCu";
            this.textBox_MatKhauCu.Size = new System.Drawing.Size(360, 20);
            this.textBox_MatKhauCu.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mật khẩu mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(12, 68);
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(360, 20);
            this.textBox_MatKhauMoi.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Xác nhận mật khẩu mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_XNMatKhauMoi
            // 
            this.textBox_XNMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_XNMatKhauMoi.Location = new System.Drawing.Point(12, 109);
            this.textBox_XNMatKhauMoi.Name = "textBox_XNMatKhauMoi";
            this.textBox_XNMatKhauMoi.Size = new System.Drawing.Size(360, 20);
            this.textBox_XNMatKhauMoi.TabIndex = 25;
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CapNhat.Location = new System.Drawing.Point(708, 408);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(80, 30);
            this.button_CapNhat.TabIndex = 27;
            this.button_CapNhat.Text = "Cập nhật";
            this.button_CapNhat.UseVisualStyleBackColor = true;
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.ForeColor = System.Drawing.Color.Red;
            this.label_Loi.Location = new System.Drawing.Point(9, 412);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(360, 23);
            this.label_Loi.TabIndex = 28;
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_XNMatKhauMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.label_TaiKhoan);
            this.Controls.Add(this.textBox_MatKhauCu);
            this.Name = "form_CaiDat";
            this.Text = "Cài đặt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhauCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_XNMatKhauMoi;
        private System.Windows.Forms.Button button_CapNhat;
        private System.Windows.Forms.Label label_Loi;
    }
}