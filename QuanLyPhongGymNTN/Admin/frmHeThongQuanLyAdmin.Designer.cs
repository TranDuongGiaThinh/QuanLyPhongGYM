
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmHeThongQuanLyAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThongQuanLyAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.goiTap = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiGoiTap = new System.Windows.Forms.ToolStripMenuItem();
            this.theTap = new System.Windows.Forms.ToolStripMenuItem();
            this.lichTap = new System.Windows.Forms.ToolStripMenuItem();
            this.monTap = new System.Windows.Forms.ToolStripMenuItem();
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
            this.taiKhoan,
            this.loaiTaiKhoan,
            this.goiTap,
            this.loaiGoiTap,
            this.theTap,
            this.lichTap,
            this.monTap,
            this.dangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoan
            // 
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.ShortcutKeyDisplayString = "";
            this.taiKhoan.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.taiKhoan.Size = new System.Drawing.Size(85, 24);
            this.taiKhoan.Text = "Tài khoản";
            this.taiKhoan.Click += new System.EventHandler(this.taiKhoan_Click);
            // 
            // loaiTaiKhoan
            // 
            this.loaiTaiKhoan.AccessibleDescription = "";
            this.loaiTaiKhoan.Name = "loaiTaiKhoan";
            this.loaiTaiKhoan.ShortcutKeyDisplayString = "";
            this.loaiTaiKhoan.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.loaiTaiKhoan.Size = new System.Drawing.Size(116, 24);
            this.loaiTaiKhoan.Text = "Loại tài khoản";
            this.loaiTaiKhoan.Click += new System.EventHandler(this.loaiTaiKhoan_Click);
            // 
            // goiTap
            // 
            this.goiTap.Name = "goiTap";
            this.goiTap.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.goiTap.Size = new System.Drawing.Size(72, 24);
            this.goiTap.Text = "Gói tập";
            this.goiTap.Click += new System.EventHandler(this.goiTap_Click);
            // 
            // loaiGoiTap
            // 
            this.loaiGoiTap.Name = "loaiGoiTap";
            this.loaiGoiTap.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.loaiGoiTap.Size = new System.Drawing.Size(103, 24);
            this.loaiGoiTap.Text = "Loại gói tập";
            this.loaiGoiTap.Click += new System.EventHandler(this.loaiGoiTap_Click);
            // 
            // theTap
            // 
            this.theTap.Name = "theTap";
            this.theTap.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.theTap.Size = new System.Drawing.Size(73, 24);
            this.theTap.Text = "Thẻ tập";
            this.theTap.Click += new System.EventHandler(this.theTap_Click);
            // 
            // lichTap
            // 
            this.lichTap.Name = "lichTap";
            this.lichTap.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.lichTap.Size = new System.Drawing.Size(75, 24);
            this.lichTap.Text = "Lịch tập";
            this.lichTap.Click += new System.EventHandler(this.lichTap_Click);
            // 
            // monTap
            // 
            this.monTap.Name = "monTap";
            this.monTap.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.monTap.Size = new System.Drawing.Size(79, 24);
            this.monTap.Text = "Môn tập";
            this.monTap.Click += new System.EventHandler(this.mônTậpToolStripMenuItem_Click);
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.ShortcutKeys = System.Windows.Forms.Keys.F8;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1276, 26);
            this.statusStrip1.TabIndex = 1;
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
            this.pnlNoiDung.Location = new System.Drawing.Point(0, 31);
            this.pnlNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(1276, 559);
            this.pnlNoiDung.TabIndex = 2;
            // 
            // frmHeThongQuanLyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1276, 618);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHeThongQuanLyAdmin";
            this.Text = "Hệ thống quản lý Admin";
            this.Load += new System.EventHandler(this.frmHeThongQuanLyAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goiTap;
        private System.Windows.Forms.ToolStripMenuItem theTap;
        private System.Windows.Forms.ToolStripMenuItem taiKhoan;
        private System.Windows.Forms.ToolStripMenuItem lichTap;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.ToolStripMenuItem loaiTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem loaiGoiTap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slHoTen;
        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.ToolStripMenuItem monTap;
    }
}