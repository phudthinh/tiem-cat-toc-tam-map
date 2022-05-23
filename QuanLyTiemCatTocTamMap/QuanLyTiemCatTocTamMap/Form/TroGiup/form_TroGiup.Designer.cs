namespace QuanLyTiemCatTocTamMap
{
    partial class form_TroGiup
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
            this.label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Title.Location = new System.Drawing.Point(0, 144);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(800, 163);
            this.label_Title.TabIndex = 6;
            this.label_Title.Text = "Đây là trợ giúp nè";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_TroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Title);
            this.Name = "form_TroGiup";
            this.Text = "Trợ giúp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
    }
}