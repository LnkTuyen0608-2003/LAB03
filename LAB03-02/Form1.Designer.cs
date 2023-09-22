namespace LAB03_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoVanBanMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moTapTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luuNoiDungVanBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tsbSize = new System.Windows.Forms.ToolStripComboBox();
            this.InDam = new System.Windows.Forms.ToolStripButton();
            this.InNghieng = new System.Windows.Forms.ToolStripButton();
            this.GachChan = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(12, 43);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(614, 216);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.dinhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoVanBanMoiToolStripMenuItem,
            this.moTapTinToolStripMenuItem,
            this.luuNoiDungVanBanToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.heThongToolStripMenuItem.Text = "He thong";
            // 
            // taoVanBanMoiToolStripMenuItem
            // 
            this.taoVanBanMoiToolStripMenuItem.Image = global::LAB03_02.Properties.Resources._607924;
            this.taoVanBanMoiToolStripMenuItem.Name = "taoVanBanMoiToolStripMenuItem";
            this.taoVanBanMoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.taoVanBanMoiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.taoVanBanMoiToolStripMenuItem.Text = "Tao van ban moi";
            this.taoVanBanMoiToolStripMenuItem.Click += new System.EventHandler(this.taoVanBanMoiToolStripMenuItem_Click);
            // 
            // moTapTinToolStripMenuItem
            // 
            this.moTapTinToolStripMenuItem.Image = global::LAB03_02.Properties.Resources.open;
            this.moTapTinToolStripMenuItem.Name = "moTapTinToolStripMenuItem";
            this.moTapTinToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.moTapTinToolStripMenuItem.Text = "Mo tap tin";
            this.moTapTinToolStripMenuItem.Click += new System.EventHandler(this.moTapTinToolStripMenuItem_Click);
            // 
            // luuNoiDungVanBanToolStripMenuItem
            // 
            this.luuNoiDungVanBanToolStripMenuItem.Image = global::LAB03_02.Properties.Resources.save_icon_125167;
            this.luuNoiDungVanBanToolStripMenuItem.Name = "luuNoiDungVanBanToolStripMenuItem";
            this.luuNoiDungVanBanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.luuNoiDungVanBanToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.luuNoiDungVanBanToolStripMenuItem.Text = "Luu noi dung van ban";
            this.luuNoiDungVanBanToolStripMenuItem.Click += new System.EventHandler(this.luuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.thoatToolStripMenuItem.Text = "Thoat";
            // 
            // dinhDangToolStripMenuItem
            // 
            this.dinhDangToolStripMenuItem.Name = "dinhDangToolStripMenuItem";
            this.dinhDangToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dinhDangToolStripMenuItem.Text = "Dinh dang";
            this.dinhDangToolStripMenuItem.Click += new System.EventHandler(this.dinhDangToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsbFont,
            this.tsbSize,
            this.InDam,
            this.InNghieng,
            this.GachChan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // tsbFont
            // 
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(121, 25);
            this.tsbFont.SelectedIndexChanged += new System.EventHandler(this.tsbFont_SelectedIndexChanged);
            this.tsbFont.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // tsbSize
            // 
            this.tsbSize.Name = "tsbSize";
            this.tsbSize.Size = new System.Drawing.Size(121, 25);
            // 
            // InDam
            // 
            this.InDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InDam.Image = ((System.Drawing.Image)(resources.GetObject("InDam.Image")));
            this.InDam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InDam.Name = "InDam";
            this.InDam.Size = new System.Drawing.Size(23, 22);
            this.InDam.Text = "toolStripButton3";
            this.InDam.Click += new System.EventHandler(this.InDam_Click);
            // 
            // InNghieng
            // 
            this.InNghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InNghieng.Image = ((System.Drawing.Image)(resources.GetObject("InNghieng.Image")));
            this.InNghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InNghieng.Name = "InNghieng";
            this.InNghieng.Size = new System.Drawing.Size(23, 22);
            this.InNghieng.Text = "toolStripButton4";
            this.InNghieng.Click += new System.EventHandler(this.InNghieng_Click);
            // 
            // GachChan
            // 
            this.GachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GachChan.Image = ((System.Drawing.Image)(resources.GetObject("GachChan.Image")));
            this.GachChan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GachChan.Name = "GachChan";
            this.GachChan.Size = new System.Drawing.Size(23, 22);
            this.GachChan.Text = "toolStripButton5";
            this.GachChan.Click += new System.EventHandler(this.GachChan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoVanBanMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moTapTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luuNoiDungVanBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox tsbFont;
        private System.Windows.Forms.ToolStripComboBox tsbSize;
        private System.Windows.Forms.ToolStripButton InDam;
        private System.Windows.Forms.ToolStripButton InNghieng;
        private System.Windows.Forms.ToolStripButton GachChan;
    }
}

