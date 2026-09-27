namespace PhongKham
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void menuBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan f = new frmBenhNhan();
            f.MdiParent = this;
            f.Show();
        }

        private void menuLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen f = new frmLichHen();
            f.MdiParent = this;
            f.Show();
        }
    }
}
