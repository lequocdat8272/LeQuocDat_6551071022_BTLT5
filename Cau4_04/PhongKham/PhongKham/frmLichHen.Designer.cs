namespace PhongKham
{
    partial class frmLichHen
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
            lblNgayGio = new Label();
            dtpNgayGio = new DateTimePicker();
            lblTenBenhNhan = new Label();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            lblDanhSach = new Label();
            lstLichHen = new ListBox();
            SuspendLayout();

            lblNgayGio.AutoSize = true;
            lblNgayGio.Location = new Point(20, 20);
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(80, 15);
            lblNgayGio.TabIndex = 0;
            lblNgayGio.Text = "Ngày giờ hẹn:";

            dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGio.Format = DateTimePickerFormat.Custom;
            dtpNgayGio.Location = new Point(120, 17);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(200, 23);
            dtpNgayGio.TabIndex = 1;

            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Location = new Point(20, 60);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(87, 15);
            lblTenBenhNhan.TabIndex = 2;
            lblTenBenhNhan.Text = "Tên bệnh nhân:";

            txtTenBenhNhan.Location = new Point(120, 57);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(200, 23);
            txtTenBenhNhan.TabIndex = 3;

            btnDatLich.Location = new Point(120, 100);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(100, 30);
            btnDatLich.TabIndex = 4;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;

            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(350, 20);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(111, 15);
            lblDanhSach.TabIndex = 5;
            lblDanhSach.Text = "Danh sách lịch hẹn:";

            lstLichHen.FormattingEnabled = true;
            lstLichHen.ItemHeight = 15;
            lstLichHen.Location = new Point(350, 40);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(300, 184);
            lstLichHen.TabIndex = 6;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 240);
            Controls.Add(lstLichHen);
            Controls.Add(lblDanhSach);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lblTenBenhNhan);
            Controls.Add(dtpNgayGio);
            Controls.Add(lblNgayGio);
            Name = "frmLichHen";
            Text = "Đặt lịch hẹn";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNgayGio;
        private DateTimePicker dtpNgayGio;
        private Label lblTenBenhNhan;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
        private Label lblDanhSach;
        private ListBox lstLichHen;
    }
}
