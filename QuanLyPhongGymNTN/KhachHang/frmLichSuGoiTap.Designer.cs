
namespace QuanLyPhongGymNTN.KhachHang
{
    partial class frmLichSuGoiTap
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
        public void InitializeComponent()
        {
            this.dgvDanhSachLichSuGoiTap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radTimTheoNgayHetHan = new System.Windows.Forms.RadioButton();
            this.radTimTheoNgayDangKy = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblGiaGoi = new System.Windows.Forms.Label();
            this.lblTenMonTap = new System.Windows.Forms.Label();
            this.lblTenGoiTap = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLichSuGoiTap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachLichSuGoiTap
            // 
            this.dgvDanhSachLichSuGoiTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLichSuGoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLichSuGoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDanhSachLichSuGoiTap.Location = new System.Drawing.Point(29, 299);
            this.dgvDanhSachLichSuGoiTap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachLichSuGoiTap.Name = "dgvDanhSachLichSuGoiTap";
            this.dgvDanhSachLichSuGoiTap.RowHeadersWidth = 51;
            this.dgvDanhSachLichSuGoiTap.RowTemplate.Height = 24;
            this.dgvDanhSachLichSuGoiTap.Size = new System.Drawing.Size(756, 158);
            this.dgvDanhSachLichSuGoiTap.TabIndex = 5;
            this.dgvDanhSachLichSuGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLichSuGoiTap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATHETAP";
            this.Column1.HeaderText = "Mã thẻ tập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MAGOITAP";
            this.Column7.HeaderText = "Mã gói tập";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENGOITAP";
            this.Column2.HeaderText = "Gói tập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TENLOAIGOITAP";
            this.Column6.HeaderText = "Loại gói tập";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENPT";
            this.Column3.HeaderText = "PT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYDANGKY";
            this.Column4.HeaderText = "Ngày đăng ký";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYHETHAN";
            this.Column5.HeaderText = "Ngày hết hạn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH SỬ GÓI TẬP";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblTenKhachHang);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvDanhSachLichSuGoiTap);
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(819, 457);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch sử gói tập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radTimTheoNgayHetHan);
            this.groupBox3.Controls.Add(this.radTimTheoNgayDangKy);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox3.Controls.Add(this.dtpNgayBatDau);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(29, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(756, 114);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm lịch sử gói tập";
            // 
            // radTimTheoNgayHetHan
            // 
            this.radTimTheoNgayHetHan.AutoSize = true;
            this.radTimTheoNgayHetHan.Location = new System.Drawing.Point(59, 49);
            this.radTimTheoNgayHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimTheoNgayHetHan.Name = "radTimTheoNgayHetHan";
            this.radTimTheoNgayHetHan.Size = new System.Drawing.Size(171, 21);
            this.radTimTheoNgayHetHan.TabIndex = 2;
            this.radTimTheoNgayHetHan.TabStop = true;
            this.radTimTheoNgayHetHan.Text = "Tìm theo ngày hết hạn";
            this.radTimTheoNgayHetHan.UseVisualStyleBackColor = true;
            // 
            // radTimTheoNgayDangKy
            // 
            this.radTimTheoNgayDangKy.AutoSize = true;
            this.radTimTheoNgayDangKy.Location = new System.Drawing.Point(59, 21);
            this.radTimTheoNgayDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimTheoNgayDangKy.Name = "radTimTheoNgayDangKy";
            this.radTimTheoNgayDangKy.Size = new System.Drawing.Size(173, 21);
            this.radTimTheoNgayDangKy.TabIndex = 1;
            this.radTimTheoNgayDangKy.TabStop = true;
            this.radTimTheoNgayDangKy.Text = "Tìm theo ngày đăng ký";
            this.radTimTheoNgayDangKy.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.TimKiem;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.Location = new System.Drawing.Point(604, 82);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(52, 27);
            this.btnTim.TabIndex = 5;
            this.btnTim.TabStop = false;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(461, 82);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(136, 22);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(179, 82);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(136, 22);
            this.dtpNgayBatDau.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "đến tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ tháng:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(157, 33);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(0, 17);
            this.lblTenKhachHang.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGhiChu);
            this.groupBox2.Controls.Add(this.lblGiaGoi);
            this.groupBox2.Controls.Add(this.lblTenMonTap);
            this.groupBox2.Controls.Add(this.lblTenGoiTap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(29, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(756, 101);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin gói tập";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(491, 69);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(0, 17);
            this.lblGhiChu.TabIndex = 7;
            // 
            // lblGiaGoi
            // 
            this.lblGiaGoi.AutoSize = true;
            this.lblGiaGoi.Location = new System.Drawing.Point(487, 31);
            this.lblGiaGoi.Name = "lblGiaGoi";
            this.lblGiaGoi.Size = new System.Drawing.Size(0, 17);
            this.lblGiaGoi.TabIndex = 6;
            // 
            // lblTenMonTap
            // 
            this.lblTenMonTap.AutoSize = true;
            this.lblTenMonTap.Location = new System.Drawing.Point(125, 70);
            this.lblTenMonTap.Name = "lblTenMonTap";
            this.lblTenMonTap.Size = new System.Drawing.Size(0, 17);
            this.lblTenMonTap.TabIndex = 5;
            // 
            // lblTenGoiTap
            // 
            this.lblTenGoiTap.AutoSize = true;
            this.lblTenGoiTap.Location = new System.Drawing.Point(123, 31);
            this.lblTenGoiTap.Name = "lblTenGoiTap";
            this.lblTenGoiTap.Size = new System.Drawing.Size(0, 17);
            this.lblTenGoiTap.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá gói:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên môn tập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên gói tập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // frmLichSuGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLichSuGoiTap";
            this.Text = "Lịch sử gói tập";
            this.Load += new System.EventHandler(this.frmLichSuGoiTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLichSuGoiTap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLichSuGoiTap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblGiaGoi;
        private System.Windows.Forms.Label lblTenMonTap;
        private System.Windows.Forms.Label lblTenGoiTap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RadioButton radTimTheoNgayHetHan;
        private System.Windows.Forms.RadioButton radTimTheoNgayDangKy;
    }
}