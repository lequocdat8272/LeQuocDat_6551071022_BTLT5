namespace PhongKham
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            int tuoi = (int)nudTuoi.Value;
            string trieuChung = txtTrieuChung.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string thongTin = $"{hoTen} - {tuoi} tuổi - Triệu chứng: {trieuChung}";
            danhSachBenhNhan.Add(thongTin);
            lstBenhNhan.Items.Add(thongTin);

            txtHoTen.Clear();
            nudTuoi.Value = 0;
            txtTrieuChung.Clear();
            txtHoTen.Focus();
        }
    }
}
