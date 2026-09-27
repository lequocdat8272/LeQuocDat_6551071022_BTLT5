namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text.Trim());
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void tsmiDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string? itemText = lstCongViec.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(itemText) && !itemText.StartsWith("[Hoàn thành] "))
                {
                    int index = lstCongViec.SelectedIndex;
                    lstCongViec.Items[index] = "[Hoàn thành] " + itemText;
                }
            }
        }

        private void tsmiXoaCongViec_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmiXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả công việc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
