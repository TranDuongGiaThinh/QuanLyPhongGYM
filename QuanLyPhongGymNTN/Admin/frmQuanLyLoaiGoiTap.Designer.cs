
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmQuanLyLoaiGoiTap
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudThoiGianGoi = new System.Windows.Forms.NumericUpDown();
            this.txtTenLoaiGoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachLoaiGoiTap = new System.Windows.Forms.DataGridView();
            this.maloaigoitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaigoitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGianGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiGoiTap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudThoiGianGoi);
            this.groupBox2.Controls.Add(this.txtTenLoaiGoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(408, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(420, 138);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "(ngày)";
            // 
            // nudThoiGianGoi
            // 
            this.nudThoiGianGoi.Location = new System.Drawing.Point(191, 69);
            this.nudThoiGianGoi.Margin = new System.Windows.Forms.Padding(4);
            this.nudThoiGianGoi.Name = "nudThoiGianGoi";
            this.nudThoiGianGoi.Size = new System.Drawing.Size(99, 22);
            this.nudThoiGianGoi.TabIndex = 2;
            // 
            // txtTenLoaiGoi
            // 
            this.txtTenLoaiGoi.Location = new System.Drawing.Point(191, 33);
            this.txtTenLoaiGoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiGoi.Name = "txtTenLoaiGoi";
            this.txtTenLoaiGoi.Size = new System.Drawing.Size(159, 22);
            this.txtTenLoaiGoi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời gian gói:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại gói tập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "QUẢN LÝ LOẠI GÓI TẬP";
            // 
            // dgvDanhSachLoaiGoiTap
            // 
            this.dgvDanhSachLoaiGoiTap.AllowUserToAddRows = false;
            this.dgvDanhSachLoaiGoiTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiGoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiGoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaigoitap,
            this.tenloaigoitap,
            this.thoigian});
            this.dgvDanhSachLoaiGoiTap.Location = new System.Drawing.Point(408, 282);
            this.dgvDanhSachLoaiGoiTap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachLoaiGoiTap.Name = "dgvDanhSachLoaiGoiTap";
            this.dgvDanhSachLoaiGoiTap.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiGoiTap.RowTemplate.Height = 24;
            this.dgvDanhSachLoaiGoiTap.Size = new System.Drawing.Size(523, 177);
            this.dgvDanhSachLoaiGoiTap.TabIndex = 0;
            this.dgvDanhSachLoaiGoiTap.TabStop = false;
            this.dgvDanhSachLoaiGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLoaiGoiTap_CellClick);
            // 
            // maloaigoitap
            // 
            this.maloaigoitap.DataPropertyName = "MALOAIGOITAP";
            this.maloaigoitap.HeaderText = "Mã loại gói tập";
            this.maloaigoitap.MinimumWidth = 6;
            this.maloaigoitap.Name = "maloaigoitap";
            this.maloaigoitap.Visible = false;
            // 
            // tenloaigoitap
            // 
            this.tenloaigoitap.DataPropertyName = "TENLOAIGOITAP";
            this.tenloaigoitap.HeaderText = "Tên loại gói";
            this.tenloaigoitap.MinimumWidth = 6;
            this.tenloaigoitap.Name = "tenloaigoitap";
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "THOIGIAN";
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(856, 223);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.CapNhat;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(856, 178);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(856, 133);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyLoaiGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1270, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachLoaiGoiTap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyLoaiGoiTap";
            this.Text = "Loại gói tập";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiGoiTap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGianGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiGoiTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudThoiGianGoi;
        private System.Windows.Forms.TextBox txtTenLoaiGoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiGoiTap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaigoitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaigoitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
    }
}