namespace PhongKham
{
    partial class frmParent
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
            menuStrip1 = new MenuStrip();
            menuNghiepVu = new ToolStripMenuItem();
            menuBenhNhan = new ToolStripMenuItem();
            menuLichHen = new ToolStripMenuItem();
            menuCuaSo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            menuStrip1.Items.AddRange(new ToolStripItem[] { menuNghiepVu, menuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = menuCuaSo;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            menuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { menuBenhNhan, menuLichHen });
            menuNghiepVu.Name = "menuNghiepVu";
            menuNghiepVu.Size = new Size(74, 20);
            menuNghiepVu.Text = "Nghiệp vụ";

            menuBenhNhan.Name = "menuBenhNhan";
            menuBenhNhan.Size = new Size(185, 22);
            menuBenhNhan.Text = "Thông tin bệnh nhân";
            menuBenhNhan.Click += menuBenhNhan_Click;

            menuLichHen.Name = "menuLichHen";
            menuLichHen.Size = new Size(185, 22);
            menuLichHen.Text = "Đặt lịch hẹn";
            menuLichHen.Click += menuLichHen_Click;

            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new Size(57, 20);
            menuCuaSo.Text = "Cửa sổ";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý phòng khám mini";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuNghiepVu;
        private ToolStripMenuItem menuBenhNhan;
        private ToolStripMenuItem menuLichHen;
        private ToolStripMenuItem menuCuaSo;
    }
}
