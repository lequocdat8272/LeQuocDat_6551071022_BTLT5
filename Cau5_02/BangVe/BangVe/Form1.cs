namespace BangVe
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;
        private string status = "Sẵn sàng";

        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
                status = "Đang vẽ...";
                lblViTri.Text = $"Tọa độ: X={e.X}, Y={e.Y} - {status}";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = $"Tọa độ: X={e.X}, Y={e.Y} - {status}";

            if (isDrawing && e.Button == MouseButtons.Left)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(pen, lastPoint, e.Location);
                    }
                }
                lastPoint = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                status = "Sẵn sàng";
                lblViTri.Text = $"Tọa độ: X={e.X}, Y={e.Y} - {status}";
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();
            }
        }
    }
}
