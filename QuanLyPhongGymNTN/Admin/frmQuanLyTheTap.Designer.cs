
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmQuanLyTheTap
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
            this.components = new System.ComponentModel.Container();
            this.btnXemLichSuGoiTap = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMoKhoa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radTheHetHan = new System.Windows.Forms.RadioButton();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.radTrangThai = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachTheTap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTheTap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemLichSuGoiTap
            // 
            this.btnXemLichSuGoiTap.BackColor = System.Drawing.SystemColors.Window;
            this.btnXemLichSuGoiTap.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.XemLichSuGoiTap;
            this.btnXemLichSuGoiTap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemLichSuGoiTap.Location = new System.Drawing.Point(926, 310);
            this.btnXemLichSuGoiTap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemLichSuGoiTap.Name = "btnXemLichSuGoiTap";
            this.btnXemLichSuGoiTap.Size = new System.Drawing.Size(74, 53);
            this.btnXemLichSuGoiTap.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnXemLichSuGoiTap, "Xem lịch sử gói tập");
            this.btnXemLichSuGoiTap.UseVisualStyleBackColor = false;
            this.btnXemLichSuGoiTap.Click += new System.EventHandler(this.btnXemLichSuGoiTap_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.KhoaThe;
            this.btnKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhoa.Location = new System.Drawing.Point(926, 139);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(74, 53);
            this.btnKhoa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnKhoa, "Khóa");
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.MoKhoaThe;
            this.btnMoKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoKhoa.Location = new System.Drawing.Point(926, 196);
            this.btnMoKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(74, 53);
            this.btnMoKhoa.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnMoKhoa, "Mở khóa");
            this.btnMoKhoa.UseVisualStyleBackColor = true;
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(926, 253);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 53);
            this.btnXoa.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "QUẢN LÝ THẺ TẬP";
            // 
            // radTheHetHan
            // 
            this.radTheHetHan.AutoSize = true;
            this.radTheHetHan.Location = new System.Drawing.Point(102, 80);
            this.radTheHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTheHetHan.Name = "radTheHetHan";
            this.radTheHetHan.Size = new System.Drawing.Size(106, 21);
            this.radTheHetHan.TabIndex = 1;
            this.radTheHetHan.TabStop = true;
            this.radTheHetHan.Text = "Thẻ hết hạn";
            this.radTheHetHan.UseVisualStyleBackColor = true;
            this.radTheHetHan.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Bị khóa"});
            this.cbbTrangThai.Location = new System.Drawing.Point(232, 129);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(144, 24);
            this.cbbTrangThai.TabIndex = 3;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTrangThai
            // 
            this.radTrangThai.AutoSize = true;
            this.radTrangThai.Location = new System.Drawing.Point(102, 130);
            this.radTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTrangThai.Name = "radTrangThai";
            this.radTrangThai.Size = new System.Drawing.Size(122, 21);
            this.radTrangThai.TabIndex = 2;
            this.radTrangThai.TabStop = true;
            this.radTrangThai.Text = "Trạng thái thẻ:";
            this.radTrangThai.UseVisualStyleBackColor = true;
            this.radTrangThai.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(102, 32);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(69, 21);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTheHetHan);
            this.groupBox2.Controls.Add(this.cbbTrangThai);
            this.groupBox2.Controls.Add(this.radTrangThai);
            this.groupBox2.Controls.Add(this.radTatCa);
            this.groupBox2.Location = new System.Drawing.Point(277, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(642, 224);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp, tìm kiếm";
            // 
            // dgvDanhSachTheTap
            // 
            this.dgvDanhSachTheTap.AllowUserToAddRows = false;
            this.dgvDanhSachTheTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTheTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTheTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4});
            this.dgvDanhSachTheTap.Location = new System.Drawing.Point(277, 369);
            this.dgvDanhSachTheTap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachTheTap.Name = "dgvDanhSachTheTap";
            this.dgvDanhSachTheTap.RowHeadersWidth = 51;
            this.dgvDanhSachTheTap.RowTemplate.Height = 24;
            this.dgvDanhSachTheTap.Size = new System.Drawing.Size(723, 196);
            this.dgvDanhSachTheTap.TabIndex = 50;
            this.dgvDanhSachTheTap.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATHETAP";
            this.Column1.HeaderText = "Mã thẻ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKHACHHANG";
            this.Column2.HeaderText = "Khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENGOITAP";
            this.Column3.HeaderText = "Gói tập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYDANGKY";
            this.Column5.HeaderText = "Ngày đăng ký";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYHETHAN";
            this.Column6.HeaderText = "Ngày hết hạn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "KHOA";
            this.Column4.HeaderText = "Hết hạn (khóa)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmQuanLyTheTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1276, 591);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemLichSuGoiTap);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoKhoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDanhSachTheTap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyTheTap";
            this.Text = "Quản lý thẻ tập";
            this.Load += new System.EventHandler(this.frmQuanLyTheTap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTheTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXemLichSuGoiTap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnMoKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTheHetHan;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.RadioButton radTrangThai;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachTheTap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}