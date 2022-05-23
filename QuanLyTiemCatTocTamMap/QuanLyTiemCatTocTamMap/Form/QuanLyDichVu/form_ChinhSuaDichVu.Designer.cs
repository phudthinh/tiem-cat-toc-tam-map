namespace QuanLyTiemCatTocTamMap
{
    partial class form_ChinhSuaDichVu
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
            this.label_Loi = new System.Windows.Forms.Label();
            this.button_ChinhSua = new System.Windows.Forms.Button();
            this.label_GiaTien = new System.Windows.Forms.Label();
            this.textBox_GiaTien = new System.Windows.Forms.TextBox();
            this.label_TenDichVu = new System.Windows.Forms.Label();
            this.textBox_TenDichVu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Loi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Loi.ForeColor = System.Drawing.Color.Red;
            this.label_Loi.Location = new System.Drawing.Point(12, 108);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(274, 15);
            this.label_Loi.TabIndex = 32;
            this.label_Loi.Text = "...";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_ChinhSua
            // 
            this.button_ChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChinhSua.Location = new System.Drawing.Point(292, 100);
            this.button_ChinhSua.Name = "button_ChinhSua";
            this.button_ChinhSua.Size = new System.Drawing.Size(80, 30);
            this.button_ChinhSua.TabIndex = 31;
            this.button_ChinhSua.Text = "Chỉnh sửa";
            this.button_ChinhSua.UseVisualStyleBackColor = true;
            this.button_ChinhSua.Click += new System.EventHandler(this.button_ChinhSua_Click);
            // 
            // label_GiaTien
            // 
            this.label_GiaTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GiaTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_GiaTien.Location = new System.Drawing.Point(12, 51);
            this.label_GiaTien.Name = "label_GiaTien";
            this.label_GiaTien.Size = new System.Drawing.Size(100, 15);
            this.label_GiaTien.TabIndex = 30;
            this.label_GiaTien.Text = "Giá tiền";
            this.label_GiaTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_GiaTien
            // 
            this.textBox_GiaTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_GiaTien.Location = new System.Drawing.Point(12, 69);
            this.textBox_GiaTien.Name = "textBox_GiaTien";
            this.textBox_GiaTien.Size = new System.Drawing.Size(360, 20);
            this.textBox_GiaTien.TabIndex = 29;
            this.textBox_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_GiaTien_KeyPress);
            // 
            // label_TenDichVu
            // 
            this.label_TenDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_TenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenDichVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TenDichVu.Location = new System.Drawing.Point(12, 10);
            this.label_TenDichVu.Name = "label_TenDichVu";
            this.label_TenDichVu.Size = new System.Drawing.Size(100, 15);
            this.label_TenDichVu.TabIndex = 28;
            this.label_TenDichVu.Text = "Tên dịch vụ";
            this.label_TenDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_TenDichVu
            // 
            this.textBox_TenDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_TenDichVu.Location = new System.Drawing.Point(12, 28);
            this.textBox_TenDichVu.Name = "textBox_TenDichVu";
            this.textBox_TenDichVu.Size = new System.Drawing.Size(360, 20);
            this.textBox_TenDichVu.TabIndex = 27;
            // 
            // form_ChinhSuaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.button_ChinhSua);
            this.Controls.Add(this.label_GiaTien);
            this.Controls.Add(this.textBox_GiaTien);
            this.Controls.Add(this.label_TenDichVu);
            this.Controls.Add(this.textBox_TenDichVu);
            this.Name = "form_ChinhSuaDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa dịch vụ";
            this.Load += new System.EventHandler(this.form_ChinhSuaDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Loi;
        private System.Windows.Forms.Button button_ChinhSua;
        private System.Windows.Forms.Label label_GiaTien;
        private System.Windows.Forms.TextBox textBox_GiaTien;
        private System.Windows.Forms.Label label_TenDichVu;
        private System.Windows.Forms.TextBox textBox_TenDichVu;
    }
}