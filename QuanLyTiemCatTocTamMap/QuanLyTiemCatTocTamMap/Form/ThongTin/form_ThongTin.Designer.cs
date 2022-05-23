namespace QuanLyTiemCatTocTamMap
{
    partial class form_ThongTin
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
            this.label_Ten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Ten
            // 
            this.label_Ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Ten.Location = new System.Drawing.Point(0, 144);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(800, 163);
            this.label_Ten.TabIndex = 7;
            this.label_Ten.Text = "...";
            this.label_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Ten);
            this.Name = "form_ThongTin";
            this.Text = "Thông tin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Ten;
    }
}