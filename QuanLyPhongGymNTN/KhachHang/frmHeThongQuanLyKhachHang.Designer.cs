
namespace QuanLyPhongGymNTN.KhachHang
{
    partial class frmHeThongQuanLyKhachHang
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
            this.theTap = new System.Windows.Forms.ToolStripMenuItem();
            this.goiTap = new System.Windows.Forms.ToolStripMenuItem();
            this.lichTap = new System.Windows.Forms.ToolStripMenuItem();
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
            this.theTap,
            this.goiTap,
            this.lichTap,
            this.dangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thongTinCaNhan
            // 
            this.thongTinCaNhan.Name = "thongTinCaNhan";
            this.thongTinCaNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.thongTinCaNhan.Size = new System.Drawing.Size(141, 24);
            this.thongTinCaNhan.Text = "Thông tin cá nhân";
            this.thongTinCaNhan.Click += new System.EventHandler(this.thongTinCaNhan_Click);
            // 
            // theTap
            // 
            this.theTap.Name = "theTap";
            this.theTap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.theTap.Size = new System.Drawing.Size(73, 24);
            this.theTap.Text = "Thẻ tập";
            this.theTap.Click += new System.EventHandler(this.theTap_Click);
            // 
            // goiTap
            // 
            this.goiTap.Name = "goiTap";
            this.goiTap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.goiTap.Size = new System.Drawing.Size(72, 24);
            this.goiTap.Text = "Gói tập";
            this.goiTap.Click += new System.EventHandler(this.goiTap_Click);
            // 
            // lichTap
            // 
            this.lichTap.Name = "lichTap";
            this.lichTap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.lichTap.Size = new System.Drawing.Size(75, 24);
            this.lichTap.Text = "Lịch tập";
            this.lichTap.Click += new System.EventHandler(this.lichTap_Click);
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.dangXuat.Size = new System.Drawing.Size(91, 24);
            this.dangXuat.Text = "Đăng xuất";
            this.dangXuat.Click += new System.EventHandler(this.dangXuat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(811, 26);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabel1.Text = "Họ và tên:";
            // 
            // slHoTen
            // 
            this.slHoTen.Name = "slHoTen";
            this.slHoTen.Size = new System.Drawing.Size(47, 20);
            this.slHoTen.Text = "hoten";
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BackColor = System.Drawing.SystemColors.Info;
            this.pnlNoiDung.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.AnhNenDangNhap;
            this.pnlNoiDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNoiDung.Location = new System.Drawing.Point(0, 30);
            this.pnlNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(811, 386);
            this.pnlNoiDung.TabIndex = 4;
            // 
            // frmHeThongQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 446);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHeThongQuanLyKhachHang";
            this.Text = "Hệ thống quản lý khách hàng";
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
        private System.Windows.Forms.ToolStripMenuItem theTap;
        private System.Windows.Forms.ToolStripMenuItem goiTap;
        private System.Windows.Forms.ToolStripMenuItem lichTap;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slHoTen;
        private System.Windows.Forms.Panel pnlNoiDung;
    }
}