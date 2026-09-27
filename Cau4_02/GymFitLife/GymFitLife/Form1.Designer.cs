namespace GymFitLife
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            lblTieuDe = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGoiTap = new Label();
            cboGoiTap = new ComboBox();
            lblSoBuoiTuan = new Label();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.MidnightBlue;
            lblTieuDe.Location = new Point(70, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(355, 31);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG KÝ HỘI VIÊN GYM FITLIFE";

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(40, 75);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(76, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ và tên:";

            txtHoTen.Location = new Point(165, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(270, 27);
            txtHoTen.TabIndex = 2;
            toolTip1.SetToolTip(txtHoTen, "Nhập họ và tên đầy đủ");

            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(40, 120);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 20);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại:";

            txtSDT.Location = new Point(165, 117);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(270, 27);
            txtSDT.TabIndex = 4;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 165);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";

            txtEmail.Location = new Point(165, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 6;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");

            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(40, 210);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày sinh:";

            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(165, 207);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(270, 27);
            dtpNgaySinh.TabIndex = 8;
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày tháng năm sinh của hội viên");

            lblGoiTap.AutoSize = true;
            lblGoiTap.Location = new Point(40, 255);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(61, 20);
            lblGoiTap.TabIndex = 9;
            lblGoiTap.Text = "Gói tập:";

            cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(165, 252);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(270, 28);
            cboGoiTap.TabIndex = 10;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");

            lblSoBuoiTuan.AutoSize = true;
            lblSoBuoiTuan.Location = new Point(40, 300);
            lblSoBuoiTuan.Name = "lblSoBuoiTuan";
            lblSoBuoiTuan.Size = new Size(100, 20);
            lblSoBuoiTuan.TabIndex = 11;
            lblSoBuoiTuan.Text = "Số buổi/tuần:";

            numSoBuoiTuan.Location = new Point(165, 298);
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(270, 27);
            numSoBuoiTuan.TabIndex = 12;
            toolTip1.SetToolTip(numSoBuoiTuan, "Chọn số buổi tập trong tuần từ 1 đến 7");

            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.Location = new Point(165, 355);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(160, 42);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            toolTip1.SetToolTip(btnDangKy, "Nhấn để xác nhận đăng ký hội viên");

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 430);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(lblSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(lblGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Đăng Ký Hội Viên - Gym FitLife";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolTip toolTip1;
        private Label lblTieuDe;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGoiTap;
        private ComboBox cboGoiTap;
        private Label lblSoBuoiTuan;
        private NumericUpDown numSoBuoiTuan;
        private Button btnDangKy;
    }
}
