using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void dinhDangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tsbFont.Items.Add(font.Name);
            }
            List<int> listS = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listS)
            {
                tsbSize.Items.Add(s);
            }

            tsbFont.Text = "Tahoma";
            tsbSize.Text = "14";
            richText.Font = new Font(tsbFont.Text, float.Parse(tsbSize.Text));
        }

        private void tsbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsbSize.Text != "")
                richText.Font = new Font(tsbFont.Text, float.Parse(tsbSize.Text));

        }

        private void luuNoiDungVanBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            //lọc hiện thị các loại file
            dlg.Filter = "RTF file|*.rtf |txt File | *.txt";
            //hien thi openDialog
            if (dlg.ShowDialog() == DialogResult.OK)
                richText.SaveFile(dlg.FileName);
        }

        private void taoVanBanMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Clear();
            tsbFont.Text = "Tahoma";
            tsbSize.Text = "14";
            richText.Font = new Font(tsbFont.Text, float.Parse(tsbSize.Text));
        }

        private void moTapTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //lọc hiện thị các loại file
            dlg.Filter = "RTF file|*.rtf | txt File | *.txt";
            //hien thi openDialog
            if (dlg.ShowDialog() == DialogResult.OK)
                richText.LoadFile(dlg.FileName); //Lấy tên file cần mở
        }

        private void InDam_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Style == FontStyle.Bold)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Bold);
            }
        }

        private void InNghieng_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Style == FontStyle.Italic)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Italic);
            }
        }

        private void GachChan_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Style == FontStyle.Underline)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Underline);
            }
        }
    }
}
