namespace SieuThi
{
    partial class FormBanHang
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMaSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;

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
            lblMaSP = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            SuspendLayout();

            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(30, 30);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(102, 20);
            lblMaSP.Text = "Mã sản phẩm:";

            txtMaSP.Location = new Point(140, 27);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(200, 27);

            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(30, 75);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.Text = "Số lượng:";

            txtSoLuong.Location = new Point(140, 72);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 27);
            txtSoLuong.KeyPress += TxtChiNhapSo_KeyPress;

            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(30, 120);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(65, 20);
            lblDonGia.Text = "Đơn giá:";

            txtDonGia.Location = new Point(140, 117);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 27);
            txtDonGia.KeyPress += TxtChiNhapSo_KeyPress;

            btnThem.Location = new Point(370, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 35);
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += BtnThem_Click;

            btnXoaTrang.Location = new Point(370, 72);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(120, 35);
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += BtnXoaTrang_Click;

            lstKetQua.FormattingEnabled = true;
            lstKetQua.ItemHeight = 20;
            lstKetQua.Location = new Point(30, 175);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(460, 184);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 390);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(lblMaSP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán hàng";
            KeyDown += FormBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
