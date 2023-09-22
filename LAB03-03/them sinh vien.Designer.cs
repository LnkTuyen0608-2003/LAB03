namespace LAB03_03
{
    partial class them_sinh_vien
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
            this.MSSV = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.TenSV = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.Khoa = new System.Windows.Forms.Label();
            this.DTB = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MSSV
            // 
            this.MSSV.AutoSize = true;
            this.MSSV.Location = new System.Drawing.Point(90, 50);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(81, 13);
            this.MSSV.TabIndex = 0;
            this.MSSV.Text = "Ma so sinh vien";
            this.MSSV.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(365, 271);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 1;
            this.btnThemmoi.Text = "Them Moi";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "Cong nghe thong tin",
            "Ngon ngu anh",
            "Quan tri kinh doanh"});
            this.cmbKhoa.Location = new System.Drawing.Point(225, 146);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 2;
            // 
            // TenSV
            // 
            this.TenSV.AutoSize = true;
            this.TenSV.Location = new System.Drawing.Point(90, 93);
            this.TenSV.Name = "TenSV";
            this.TenSV.Size = new System.Drawing.Size(74, 13);
            this.TenSV.TabIndex = 0;
            this.TenSV.Text = "Ten Sinh Vien";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(225, 50);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(100, 20);
            this.txtmssv.TabIndex = 3;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(225, 192);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 3;
            this.txtDiem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(90, 146);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(32, 13);
            this.Khoa.TabIndex = 0;
            this.Khoa.Text = "Khoa";
            // 
            // DTB
            // 
            this.DTB.AutoSize = true;
            this.DTB.Location = new System.Drawing.Point(90, 199);
            this.DTB.Name = "DTB";
            this.DTB.Size = new System.Drawing.Size(48, 13);
            this.DTB.TabIndex = 0;
            this.DTB.Text = "Diem TB";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(468, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(225, 93);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 3;
            // 
            // them_sinh_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.DTB);
            this.Controls.Add(this.Khoa);
            this.Controls.Add(this.TenSV);
            this.Controls.Add(this.MSSV);
            this.Name = "them_sinh_vien";
            this.Text = "them_sinh_vien";
            this.Load += new System.EventHandler(this.them_sinh_vien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MSSV;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label TenSV;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.Label DTB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtten;
    }
}