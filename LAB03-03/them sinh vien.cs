using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_03
{
    public partial class them_sinh_vien : Form
    {
        private readonly DataGridView dataGridViewOnForm1;
        public them_sinh_vien(DataGridView dataGridViewOnForm1)
        {
            InitializeComponent();
            this.dataGridViewOnForm1 = dataGridViewOnForm1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void them_sinh_vien_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = 0;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtmssv.Text;

            // Kiểm tra xem mã sinh viên đã tồn tại trong DataGridView hay chưa
            foreach (DataGridViewRow existingRow in dataGridViewOnForm1.Rows)
            {
                if (existingRow.Cells["dgvMSSV"].Value != null &&
                    existingRow.Cells["dgvMSSV"].Value.ToString() == maSinhVien)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.");
                    return; // Không thêm dữ liệu nếu mã sinh viên trùng.
                }
            }
            if (string.IsNullOrWhiteSpace(txtten.Text) ||
                string.IsNullOrWhiteSpace(txtmssv.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text) ||
                cmbKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double dgvDTB) || dgvDTB < 0 || dgvDTB > 10)
            {
                MessageBox.Show("Điểm trung bình phải nằm trong khoảng từ 0 đến 10.");
                return;
            }

            string tenSinhVien = txtten.Text;
            string khoa = cmbKhoa.SelectedItem.ToString();

            // Thay vì sử dụng nextSoThuTu, bạn có thể lấy số thứ tự từ số dòng cuối cùng và tăng nó lên 1.
            int soThuTu = dataGridViewOnForm1.Rows.Count + 1;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = soThuTu });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = maSinhVien });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = tenSinhVien });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = khoa });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = dgvDTB });

            // Thêm row vào DataGridView trên Form1
            dataGridViewOnForm1.Rows.Add(row);

            MessageBox.Show("Thêm sinh viên thành công!");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
