using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            them_sinh_vien t = new them_sinh_vien(dataGridView1);
            t.ShowDialog();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchText = txtTimKiem.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["dgvTen"].Value != null)
                {
                    string tenSinhVien = row.Cells["dgvTen"].Value.ToString().ToLower();
                    if (Regex.IsMatch(tenSinhVien, searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
          

        }
    }
}
