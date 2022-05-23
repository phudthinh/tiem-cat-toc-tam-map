namespace QuanLyTiemCatTocTamMap
{
    partial class form_TaoKieuToc
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
            this.button_Tao = new System.Windows.Forms.Button();
            this.label_GiaTien = new System.Windows.Forms.Label();
            this.textBox_GiaTien = new System.Windows.Forms.TextBox();
            this.label_TenKieuToc = new System.Windows.Forms.Label();
            this.textBox_TenKieuToc = new System.Windows.Forms.TextBox();
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
            this.label_Loi.TabIndex = 26;
            this.label_Loi.Text = "...";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Tao
            // 
            this.button_Tao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Tao.Location = new System.Drawing.Point(292, 100);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(80, 30);
            this.button_Tao.TabIndex = 25;
            this.button_Tao.Text = "Tạo";
            this.button_Tao.UseVisualStyleBackColor = true;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // label_GiaTien
            // 
            this.label_GiaTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GiaTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_GiaTien.Location = new System.Drawing.Point(12, 51);
            this.label_GiaTien.Name = "label_GiaTien";
            this.label_GiaTien.Size = new System.Drawing.Size(100, 15);
            this.label_GiaTien.TabIndex = 23;
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
            this.textBox_GiaTien.TabIndex = 22;
            this.textBox_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_GiaTien_KeyPress);
            // 
            // label_TenKieuToc
            // 
            this.label_TenKieuToc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_TenKieuToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKieuToc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TenKieuToc.Location = new System.Drawing.Point(12, 10);
            this.label_TenKieuToc.Name = "label_TenKieuToc";
            this.label_TenKieuToc.Size = new System.Drawing.Size(100, 15);
            this.label_TenKieuToc.TabIndex = 21;
            this.label_TenKieuToc.Text = "Tên kiểu tóc";
            this.label_TenKieuToc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_TenKieuToc
            // 
            this.textBox_TenKieuToc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TenKieuToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox_TenKieuToc.Location = new System.Drawing.Point(12, 28);
            this.textBox_TenKieuToc.Name = "textBox_TenKieuToc";
            this.textBox_TenKieuToc.Size = new System.Drawing.Size(360, 20);
            this.textBox_TenKieuToc.TabIndex = 20;
            // 
            // form_TaoKieuToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.button_Tao);
            this.Controls.Add(this.label_GiaTien);
            this.Controls.Add(this.textBox_GiaTien);
            this.Controls.Add(this.label_TenKieuToc);
            this.Controls.Add(this.textBox_TenKieuToc);
            this.Name = "form_TaoKieuToc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo kiểu tóc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Loi;
        private System.Windows.Forms.Button button_Tao;
        private System.Windows.Forms.Label label_GiaTien;
        private System.Windows.Forms.TextBox textBox_GiaTien;
        private System.Windows.Forms.Label label_TenKieuToc;
        private System.Windows.Forms.TextBox textBox_TenKieuToc;
    }
}