namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatThoiGianVaTrangThai();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGianVaTrangThai();
        }

        private void CapNhatThoiGianVaTrangThai()
        {
            DateTime now = DateTime.Now;

            lblTrangThai.Text = now.ToString("HH:mm:ss");

            int currentHour = now.Hour;
            if (currentHour >= 6 && currentHour < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void menuDoiMauNen_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
