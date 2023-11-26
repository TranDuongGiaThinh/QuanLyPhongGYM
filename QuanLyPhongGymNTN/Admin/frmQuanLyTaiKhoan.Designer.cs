
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmQuanLyTaiKhoan
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
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.radTrangThai = new System.Windows.Forms.RadioButton();
            this.cbbLoaiTaiKhoanTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiemHoTen = new System.Windows.Forms.TextBox();
            this.radLoaiTaiKhoan = new System.Windows.Forms.RadioButton();
            this.radHoten = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbThongTinDangNhap = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbbLoaiTaiKhoanThongTin = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnMoKhoa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.pathAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaitaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbThongTinDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Bị khóa"});
            this.cbbTrangThai.Location = new System.Drawing.Point(667, 21);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(159, 24);
            this.cbbTrangThai.TabIndex = 0;
            this.cbbTrangThai.TabStop = false;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTrangThai
            // 
            this.radTrangThai.AutoSize = true;
            this.radTrangThai.Location = new System.Drawing.Point(524, 22);
            this.radTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTrangThai.Name = "radTrangThai";
            this.radTrangThai.Size = new System.Drawing.Size(102, 21);
            this.radTrangThai.TabIndex = 0;
            this.radTrangThai.Text = "Trạng thái: ";
            this.radTrangThai.UseVisualStyleBackColor = true;
            this.radTrangThai.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // cbbLoaiTaiKhoanTimKiem
            // 
            this.cbbLoaiTaiKhoanTimKiem.FormattingEnabled = true;
            this.cbbLoaiTaiKhoanTimKiem.Location = new System.Drawing.Point(204, 63);
            this.cbbLoaiTaiKhoanTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiTaiKhoanTimKiem.Name = "cbbLoaiTaiKhoanTimKiem";
            this.cbbLoaiTaiKhoanTimKiem.Size = new System.Drawing.Size(159, 24);
            this.cbbLoaiTaiKhoanTimKiem.TabIndex = 0;
            this.cbbLoaiTaiKhoanTimKiem.TabStop = false;
            this.cbbLoaiTaiKhoanTimKiem.SelectedIndexChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // txtTimKiemHoTen
            // 
            this.txtTimKiemHoTen.AutoCompleteCustomSource.AddRange(new string[] {
            "abc",
            "123"});
            this.txtTimKiemHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiemHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiemHoTen.Location = new System.Drawing.Point(667, 63);
            this.txtTimKiemHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemHoTen.Name = "txtTimKiemHoTen";
            this.txtTimKiemHoTen.Size = new System.Drawing.Size(159, 22);
            this.txtTimKiemHoTen.TabIndex = 0;
            this.txtTimKiemHoTen.TabStop = false;
            this.txtTimKiemHoTen.TextChanged += new System.EventHandler(this.txtTimKiemHoTen_TextChanged);
            // 
            // radLoaiTaiKhoan
            // 
            this.radLoaiTaiKhoan.AutoSize = true;
            this.radLoaiTaiKhoan.Location = new System.Drawing.Point(61, 64);
            this.radLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLoaiTaiKhoan.Name = "radLoaiTaiKhoan";
            this.radLoaiTaiKhoan.Size = new System.Drawing.Size(122, 21);
            this.radLoaiTaiKhoan.TabIndex = 0;
            this.radLoaiTaiKhoan.Text = "Loại tài khoản:";
            this.radLoaiTaiKhoan.UseVisualStyleBackColor = true;
            this.radLoaiTaiKhoan.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radHoten
            // 
            this.radHoten.AutoSize = true;
            this.radHoten.Location = new System.Drawing.Point(524, 64);
            this.radHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radHoten.Name = "radHoten";
            this.radHoten.Size = new System.Drawing.Size(133, 21);
            this.radHoten.TabIndex = 0;
            this.radHoten.Text = "Tìm kiếm họ tên:";
            this.radHoten.UseVisualStyleBackColor = true;
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(61, 22);
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
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.cbbTrangThai);
            this.groupBox2.Controls.Add(this.radTrangThai);
            this.groupBox2.Controls.Add(this.cbbLoaiTaiKhoanTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiemHoTen);
            this.groupBox2.Controls.Add(this.radLoaiTaiKhoan);
            this.groupBox2.Controls.Add(this.radHoten);
            this.groupBox2.Controls.Add(this.radTatCa);
            this.groupBox2.Location = new System.Drawing.Point(15, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1133, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp, tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbThongTinDangNhap);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.cbbLoaiTaiKhoanThongTin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ptbAnh);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1134, 142);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // gbThongTinDangNhap
            // 
            this.gbThongTinDangNhap.BackColor = System.Drawing.SystemColors.Info;
            this.gbThongTinDangNhap.Controls.Add(this.label8);
            this.gbThongTinDangNhap.Controls.Add(this.label9);
            this.gbThongTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.gbThongTinDangNhap.Controls.Add(this.txtMatKhau);
            this.gbThongTinDangNhap.Location = new System.Drawing.Point(854, 0);
            this.gbThongTinDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTinDangNhap.Name = "gbThongTinDangNhap";
            this.gbThongTinDangNhap.Padding = new System.Windows.Forms.Padding(2);
            this.gbThongTinDangNhap.Size = new System.Drawing.Size(280, 142);
            this.gbThongTinDangNhap.TabIndex = 110;
            this.gbThongTinDangNhap.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên đăng nhập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(137, 37);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(137, 22);
            this.txtTenDangNhap.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(137, 74);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(137, 22);
            this.txtMatKhau.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(709, 36);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(139, 22);
            this.txtGhiChu.TabIndex = 7;
            // 
            // cbbLoaiTaiKhoanThongTin
            // 
            this.cbbLoaiTaiKhoanThongTin.FormattingEnabled = true;
            this.cbbLoaiTaiKhoanThongTin.Location = new System.Drawing.Point(709, 74);
            this.cbbLoaiTaiKhoanThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiTaiKhoanThongTin.Name = "cbbLoaiTaiKhoanThongTin";
            this.cbbLoaiTaiKhoanThongTin.Size = new System.Drawing.Size(140, 24);
            this.cbbLoaiTaiKhoanThongTin.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ghi chú:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(589, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Loại tài khoản:";
            // 
            // ptbAnh
            // 
            this.ptbAnh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ptbAnh.Location = new System.Drawing.Point(20, 21);
            this.ptbAnh.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(107, 114);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 9;
            this.ptbAnh.TabStop = false;
            this.ptbAnh.Click += new System.EventHandler(this.ptbAnh_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(504, 113);
            this.radNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 6;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(431, 113);
            this.radNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 5;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(429, 71);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(137, 22);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(431, 37);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(137, 22);
            this.txtDienThoai.TabIndex = 3;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(195, 113);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(136, 22);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(195, 37);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(137, 22);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày sinh:";
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnKhoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.KhoaTaiKhoan;
            this.btnKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhoa.Location = new System.Drawing.Point(1156, 215);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(108, 81);
            this.btnKhoa.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnKhoa, "Khóa tài khoản");
            this.btnKhoa.UseVisualStyleBackColor = false;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.LamMoi;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLamMoi.Location = new System.Drawing.Point(1157, 472);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(108, 81);
            this.btnLamMoi.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSua.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.CapNhatTaiKhoan;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(1156, 127);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 81);
            this.btnSua.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhập tài khoản");
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.ThemTaiKhoan;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(1156, 39);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 81);
            this.btnThem.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm tài khoản");
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnMoKhoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.MoKhoaTaiKhoan;
            this.btnMoKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoKhoa.Location = new System.Drawing.Point(1156, 301);
            this.btnMoKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(108, 81);
            this.btnMoKhoa.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnMoKhoa, "Mở khóa tài khoản");
            this.btnMoKhoa.UseVisualStyleBackColor = false;
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(1157, 386);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 81);
            this.btnXoa.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDanhSachTaiKhoan
            // 
            this.dgvDanhSachTaiKhoan.AllowUserToAddRows = false;
            this.dgvDanhSachTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTaiKhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathAnh,
            this.mataikhoan,
            this.hinhanh,
            this.hoten,
            this.email,
            this.dienthoai,
            this.diachi,
            this.ngaysinh,
            this.gioitinh,
            this.loaitaikhoan,
            this.tendangnhan,
            this.trangthai,
            this.ghichu});
            this.dgvDanhSachTaiKhoan.Location = new System.Drawing.Point(15, 313);
            this.dgvDanhSachTaiKhoan.Name = "dgvDanhSachTaiKhoan";
            this.dgvDanhSachTaiKhoan.RowHeadersWidth = 51;
            this.dgvDanhSachTaiKhoan.RowTemplate.Height = 24;
            this.dgvDanhSachTaiKhoan.Size = new System.Drawing.Size(1133, 240);
            this.dgvDanhSachTaiKhoan.TabIndex = 109;
            this.dgvDanhSachTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTaiKhoan_CellClick);
            // 
            // pathAnh
            // 
            this.pathAnh.DataPropertyName = "pathhinhanh";
            this.pathAnh.HeaderText = "Path hình ảnh";
            this.pathAnh.MinimumWidth = 6;
            this.pathAnh.Name = "pathAnh";
            this.pathAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pathAnh.Visible = false;
            // 
            // mataikhoan
            // 
            this.mataikhoan.DataPropertyName = "mataikhoan";
            this.mataikhoan.HeaderText = "Mã tài khoản";
            this.mataikhoan.MinimumWidth = 6;
            this.mataikhoan.Name = "mataikhoan";
            this.mataikhoan.Visible = false;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "hinhanh";
            this.hinhanh.HeaderText = "Ảnh";
            this.hinhanh.MinimumWidth = 6;
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hinhanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "strgioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            // 
            // loaitaikhoan
            // 
            this.loaitaikhoan.DataPropertyName = "tenloaitaikhoan";
            this.loaitaikhoan.HeaderText = "Loại tài khoản";
            this.loaitaikhoan.MinimumWidth = 6;
            this.loaitaikhoan.Name = "loaitaikhoan";
            // 
            // tendangnhan
            // 
            this.tendangnhan.DataPropertyName = "tendangnhap";
            this.tendangnhan.HeaderText = "Tên đăng nhập";
            this.tendangnhan.MinimumWidth = 6;
            this.tendangnhan.Name = "tendangnhan";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "strtrangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1277, 555);
            this.Controls.Add(this.dgvDanhSachTaiKhoan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoKhoa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbThongTinDangNhap.ResumeLayout(false);
            this.gbThongTinDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.RadioButton radTrangThai;
        private System.Windows.Forms.ComboBox cbbLoaiTaiKhoanTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemHoTen;
        private System.Windows.Forms.RadioButton radLoaiTaiKhoan;
        private System.Windows.Forms.RadioButton radHoten;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoKhoa;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbbLoaiTaiKhoanThongTin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbThongTinDangNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.DataGridView dgvDanhSachTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoan;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaitaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}