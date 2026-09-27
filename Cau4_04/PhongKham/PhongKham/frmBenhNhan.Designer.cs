namespace PhongKham
{
    partial class frmBenhNhan
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblTuoi = new Label();
            nudTuoi = new NumericUpDown();
            lblTrieuChung = new Label();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lblDanhSach = new Label();
            lstBenhNhan = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudTuoi).BeginInit();
            SuspendLayout();

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(20, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(46, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";

            txtHoTen.Location = new Point(100, 17);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 23);
            txtHoTen.TabIndex = 1;

            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(20, 55);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(33, 15);
            lblTuoi.TabIndex = 2;
            lblTuoi.Text = "Tuổi:";

            nudTuoi.Location = new Point(100, 53);
            nudTuoi.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            nudTuoi.Name = "nudTuoi";
            nudTuoi.Size = new Size(100, 23);
            nudTuoi.TabIndex = 3;

            lblTrieuChung.AutoSize = true;
            lblTrieuChung.Location = new Point(20, 90);
            lblTrieuChung.Name = "lblTrieuChung";
            lblTrieuChung.Size = new Size(74, 15);
            lblTrieuChung.TabIndex = 4;
            lblTrieuChung.Text = "Triệu chứng:";

            txtTrieuChung.Location = new Point(100, 87);
            txtTrieuChung.Multiline = true;
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(250, 60);
            txtTrieuChung.TabIndex = 5;

            btnLuuTam.Location = new Point(100, 160);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(100, 30);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;

            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(380, 20);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(123, 15);
            lblDanhSach.TabIndex = 7;
            lblDanhSach.Text = "Danh sách bệnh nhân:";

            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.ItemHeight = 15;
            lstBenhNhan.Location = new Point(380, 40);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(300, 214);
            lstBenhNhan.TabIndex = 8;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 275);
            Controls.Add(lstBenhNhan);
            Controls.Add(lblDanhSach);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(lblTrieuChung);
            Controls.Add(nudTuoi);
            Controls.Add(lblTuoi);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "frmBenhNhan";
            Text = "Thông tin bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)nudTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblTuoi;
        private NumericUpDown nudTuoi;
        private Label lblTrieuChung;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private Label lblDanhSach;
        private ListBox lstBenhNhan;
    }
}
