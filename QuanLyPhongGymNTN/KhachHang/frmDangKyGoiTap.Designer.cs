
namespace QuanLyPhongGymNTN.KhachHang
{
    partial class frmDangKyGoiTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyGoiTap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkChonPT = new System.Windows.Forms.CheckBox();
            this.cbbPT = new System.Windows.Forms.ComboBox();
            this.cbbLoaiGoiTap = new System.Windows.Forms.ComboBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGiaGoi = new System.Windows.Forms.Label();
            this.lblTenMonTap = new System.Windows.Forms.Label();
            this.lblTenGoiTap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chkChonPT);
            this.groupBox2.Controls.Add(this.cbbPT);
            this.groupBox2.Controls.Add(this.cbbLoaiGoiTap);
            this.groupBox2.Controls.Add(this.dtpNgayHetHan);
            this.groupBox2.Controls.Add(this.dtpNgayDangKy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblGiaGoi);
            this.groupBox2.Controls.Add(this.lblTenMonTap);
            this.groupBox2.Controls.Add(this.lblTenGoiTap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 348);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin gói tập";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(614, 269);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 59);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(163, 311);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(64, 17);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "tongTien";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng tiền:";
            // 
            // chkChonPT
            // 
            this.chkChonPT.AutoSize = true;
            this.chkChonPT.Location = new System.Drawing.Point(66, 184);
            this.chkChonPT.Name = "chkChonPT";
            this.chkChonPT.Size = new System.Drawing.Size(89, 21);
            this.chkChonPT.TabIndex = 15;
            this.chkChonPT.Text = "Chọn PT:";
            this.chkChonPT.UseVisualStyleBackColor = true;
            this.chkChonPT.CheckedChanged += new System.EventHandler(this.tinhTien);
            // 
            // cbbPT
            // 
            this.cbbPT.FormattingEnabled = true;
            this.cbbPT.Location = new System.Drawing.Point(166, 181);
            this.cbbPT.Name = "cbbPT";
            this.cbbPT.Size = new System.Drawing.Size(143, 24);
            this.cbbPT.TabIndex = 14;
            this.cbbPT.SelectedIndexChanged += new System.EventHandler(this.tinhTien);
            // 
            // cbbLoaiGoiTap
            // 
            this.cbbLoaiGoiTap.FormattingEnabled = true;
            this.cbbLoaiGoiTap.Location = new System.Drawing.Point(166, 140);
            this.cbbLoaiGoiTap.Name = "cbbLoaiGoiTap";
            this.cbbLoaiGoiTap.Size = new System.Drawing.Size(143, 24);
            this.cbbLoaiGoiTap.TabIndex = 13;
            this.cbbLoaiGoiTap.SelectedIndexChanged += new System.EventHandler(this.tinhTien);
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(166, 269);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(143, 22);
            this.dtpNgayHetHan.TabIndex = 12;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(166, 228);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(143, 22);
            this.dtpNgayDangKy.TabIndex = 11;
            this.dtpNgayDangKy.ValueChanged += new System.EventHandler(this.tinhTien);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày hết hạn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày đăng ký:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại gói:";
            // 
            // lblGiaGoi
            // 
            this.lblGiaGoi.AutoSize = true;
            this.lblGiaGoi.Location = new System.Drawing.Point(163, 102);
            this.lblGiaGoi.Name = "lblGiaGoi";
            this.lblGiaGoi.Size = new System.Drawing.Size(27, 17);
            this.lblGiaGoi.TabIndex = 6;
            this.lblGiaGoi.Text = "gia";
            // 
            // lblTenMonTap
            // 
            this.lblTenMonTap.AutoSize = true;
            this.lblTenMonTap.Location = new System.Drawing.Point(163, 68);
            this.lblTenMonTap.Name = "lblTenMonTap";
            this.lblTenMonTap.Size = new System.Drawing.Size(55, 17);
            this.lblTenMonTap.TabIndex = 5;
            this.lblTenMonTap.Text = "tenMon";
            // 
            // lblTenGoiTap
            // 
            this.lblTenGoiTap.AutoSize = true;
            this.lblTenGoiTap.Location = new System.Drawing.Point(163, 33);
            this.lblTenGoiTap.Name = "lblTenGoiTap";
            this.lblTenGoiTap.Size = new System.Drawing.Size(50, 17);
            this.lblTenGoiTap.TabIndex = 4;
            this.lblTenGoiTap.Text = "tenGoi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá gói:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên môn tập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên gói tập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐĂNG KÝ GÓI TẬP";
            // 
            // frmDangKyGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(776, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKyGoiTap";
            this.Text = "Đăng ký gói tập";
            this.Load += new System.EventHandler(this.frmDangKyGoiTap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGiaGoi;
        private System.Windows.Forms.Label lblTenMonTap;
        private System.Windows.Forms.Label lblTenGoiTap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.CheckBox chkChonPT;
        private System.Windows.Forms.ComboBox cbbPT;
        private System.Windows.Forms.ComboBox cbbLoaiGoiTap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThanhToan;
    }
}