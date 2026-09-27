namespace PhongKham
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string tenBenhNhan = txtTenBenhNhan.Text.Trim();
            if (string.IsNullOrEmpty(tenBenhNhan))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return;
            }

            string ngayGio = dtpNgayGio.Value.ToString("dd/MM/yyyy HH:mm");
            string thongTin = $"{tenBenhNhan} - Lịch hẹn: {ngayGio}";
            danhSachLichHen.Add(thongTin);
            lstLichHen.Items.Add(thongTin);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
