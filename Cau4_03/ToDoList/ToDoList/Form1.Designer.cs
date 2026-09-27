namespace ToDoList
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
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            tsmiDanhDauHoanThanh = new ToolStripMenuItem();
            tsmiXoaCongViec = new ToolStripMenuItem();
            tsmiXoaTatCa = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();

            txtCongViecMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCongViecMoi.Font = new Font("Segoe UI", 10F);
            txtCongViecMoi.Location = new Point(12, 14);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(360, 25);
            txtCongViecMoi.TabIndex = 0;

            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(378, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            lstCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Font = new Font("Segoe UI", 10F);
            lstCongViec.FormattingEnabled = true;
            lstCongViec.ItemHeight = 17;
            lstCongViec.Location = new Point(12, 49);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(460, 395);
            lstCongViec.TabIndex = 2;

            cmsCongViec.Items.AddRange(new ToolStripItem[] {
                tsmiDanhDauHoanThanh,
                tsmiXoaCongViec,
                tsmiXoaTatCa
            });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(187, 70);

            tsmiDanhDauHoanThanh.Name = "tsmiDanhDauHoanThanh";
            tsmiDanhDauHoanThanh.Size = new Size(186, 22);
            tsmiDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
            tsmiDanhDauHoanThanh.Click += tsmiDanhDauHoanThanh_Click;

            tsmiXoaCongViec.Name = "tsmiXoaCongViec";
            tsmiXoaCongViec.Size = new Size(186, 22);
            tsmiXoaTatCa.Text = "Xóa công việc này";
            tsmiXoaCongViec.Text = "Xóa công việc này";
            tsmiXoaCongViec.Click += tsmiXoaCongViec_Click;

            tsmiXoaTatCa.Name = "tsmiXoaTatCa";
            tsmiXoaTatCa.Size = new Size(186, 22);
            tsmiXoaTatCa.Text = "Xóa tất cả";
            tsmiXoaTatCa.Click += tsmiXoaTatCa_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            MinimumSize = new Size(400, 300);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách việc cần làm hằng ngày";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem tsmiDanhDauHoanThanh;
        private ToolStripMenuItem tsmiXoaCongViec;
        private ToolStripMenuItem tsmiXoaTatCa;
    }
}
