namespace BangVe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlCanvas = new Panel();
            lblViTri = new Label();
            SuspendLayout();

            pnlCanvas.BackColor = Color.White;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Dock = DockStyle.Fill;
            pnlCanvas.Location = new Point(0, 0);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(800, 415);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;

            lblViTri.BorderStyle = BorderStyle.Fixed3D;
            lblViTri.Dock = DockStyle.Bottom;
            lblViTri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblViTri.Location = new Point(0, 415);
            lblViTri.Name = "lblViTri";
            lblViTri.Padding = new Padding(5, 0, 0, 0);
            lblViTri.Size = new Size(800, 35);
            lblViTri.TabIndex = 1;
            lblViTri.Text = "Tọa độ: X=0, Y=0 - Sẵn sàng";
            lblViTri.TextAlign = ContentAlignment.MiddleLeft;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCanvas);
            Controls.Add(lblViTri);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng vẽ mini";
            ResumeLayout(false);
        }

        private Panel pnlCanvas;
        private Label lblViTri;
    }
}
