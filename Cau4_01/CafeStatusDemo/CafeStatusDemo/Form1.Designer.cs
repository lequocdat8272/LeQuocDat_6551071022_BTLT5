namespace CafeStatusDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            đổiMàuNềnToolStripMenuItem = new ToolStripMenuItem();
            đổiMàuNềnToolStripMenuItem1 = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblGioHienTai = new ToolStripStatusLabel();
            lblTenQuan = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { đổiMàuNềnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Hệ thống";
            // 
            // đổiMàuNềnToolStripMenuItem
            // 
            đổiMàuNềnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMàuNềnToolStripMenuItem1, thoátToolStripMenuItem });
            đổiMàuNềnToolStripMenuItem.Name = "đổiMàuNềnToolStripMenuItem";
            đổiMàuNềnToolStripMenuItem.Size = new Size(85, 24);
            đổiMàuNềnToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMàuNềnToolStripMenuItem1
            // 
            đổiMàuNềnToolStripMenuItem1.Name = "đổiMàuNềnToolStripMenuItem1";
            đổiMàuNềnToolStripMenuItem1.Size = new Size(177, 26);
            đổiMàuNềnToolStripMenuItem1.Text = "Đổi màu nền";
            đổiMàuNềnToolStripMenuItem1.Click += menuDoiMauNen_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(177, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += menuThoat_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
            statusStrip1.Location = new Point(0, 180);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(453, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblGioHienTai
            // 
            lblGioHienTai.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblGioHienTai.Name = "lblGioHienTai";
            lblGioHienTai.Overflow = ToolStripItemOverflow.Never;
            lblGioHienTai.Size = new Size(63, 20);
            lblGioHienTai.Text = "00:00:00";
            lblGioHienTai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTenQuan
            // 
            lblTenQuan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Overflow = ToolStripItemOverflow.Never;
            lblTenQuan.Size = new Size(300, 20);
            lblTenQuan.Spring = true;
            lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // lblTrangThai
            // 
            lblTrangThai.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Overflow = ToolStripItemOverflow.Never;
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 2;
            label1.Text = "Lê Quốc Đạt - 6551071022";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 206);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem đổiMàuNềnToolStripMenuItem;
        private ToolStripMenuItem đổiMàuNềnToolStripMenuItem1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTenQuan;
        private System.Windows.Forms.Timer timerClock;
        private ColorDialog colorDialog1;
        private ToolStripStatusLabel lblGioHienTai;
        private Label label1;
        private ToolStripStatusLabel lblTrangThai;
    }
}
