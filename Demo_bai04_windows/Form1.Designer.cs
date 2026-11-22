namespace Demo_bai04_windows
{
    partial class Form1
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
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 16;
            this.lstSinhVien.Location = new System.Drawing.Point(12, 12);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(360, 180);
            this.lstSinhVien.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 205);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(360, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm sinh viên (mở Form2)";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 269);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.btnThem);
            this.Name = "Form1";
            this.Text = "Form1 - Danh sách sinh viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.Button btnThem;
    }
}

