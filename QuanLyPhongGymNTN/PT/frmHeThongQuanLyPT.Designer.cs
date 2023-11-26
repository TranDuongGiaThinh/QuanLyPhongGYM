
namespace QuanLyPhongGymNTN.PT
{
    partial class frmHeThongQuanLyPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.lichtap = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhan,
            this.lichtap,
            this.dangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thongTinCaNhan
            // 
            this.thongTinCaNhan.BackColor = System.Drawing.SystemColors.Control;
            this.thongTinCaNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thongTinCaNhan.Name = "thongTinCaNhan";
            this.thongTinCaNhan.Size = new System.Drawing.Size(116, 20);
            this.thongTinCaNhan.Text = "Thông tin cá nhân";
            this.thongTinCaNhan.Click += new System.EventHandler(this.thongTinCaNhan_Click);
            // 
            // lichtap
            // 
            this.lichtap.Name = "lichtap";
            this.lichtap.Size = new System.Drawing.Size(61, 20);
            this.lichtap.Text = "Lịch tập";
            this.lichtap.Click += new System.EventHandler(this.lichtap_Click);
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.Size = new System.Drawing.Size(72, 20);
            this.dangXuat.Text = "Đăng xuất";
            this.dangXuat.Click += new System.EventHandler(this.dangXuat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "Họ và tên:";
            // 
            // slHoTen
            // 
            this.slHoTen.Name = "slHoTen";
            this.slHoTen.Size = new System.Drawing.Size(38, 17);
            this.slHoTen.Text = "hoten";
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BackColor = System.Drawing.SystemColors.Info;
            this.pnlNoiDung.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.AnhNenDangNhap;
            this.pnlNoiDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNoiDung.Location = new System.Drawing.Point(0, 26);
            this.pnlNoiDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(654, 274);
            this.pnlNoiDung.TabIndex = 4;
            // 
            // frmHeThongQuanLyPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 323);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHeThongQuanLyPT";
            this.Text = "Hệ thống quản lý PT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem lichtap;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slHoTen;
        private System.Windows.Forms.Panel pnlNoiDung;
    }
}