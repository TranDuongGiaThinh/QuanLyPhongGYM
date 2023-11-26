
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmQuanLyLoaiTaiKhoan
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
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachLoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.maloaitaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaitaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMoTa);
            this.groupBox2.Controls.Add(this.txtTenLoaiTaiKhoan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(392, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(420, 92);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại tài khoản";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(189, 61);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(179, 22);
            this.txtMoTa.TabIndex = 1;
            // 
            // txtTenLoaiTaiKhoan
            // 
            this.txtTenLoaiTaiKhoan.Location = new System.Drawing.Point(189, 26);
            this.txtTenLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiTaiKhoan.Name = "txtTenLoaiTaiKhoan";
            this.txtTenLoaiTaiKhoan.Size = new System.Drawing.Size(179, 22);
            this.txtTenLoaiTaiKhoan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "QUẢN LÝ LOẠI TÀI KHOẢN";
            // 
            // dgvDanhSachLoaiTaiKhoan
            // 
            this.dgvDanhSachLoaiTaiKhoan.AllowUserToAddRows = false;
            this.dgvDanhSachLoaiTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaitaikhoan,
            this.tenloaitaikhoan,
            this.mota});
            this.dgvDanhSachLoaiTaiKhoan.Location = new System.Drawing.Point(392, 240);
            this.dgvDanhSachLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachLoaiTaiKhoan.Name = "dgvDanhSachLoaiTaiKhoan";
            this.dgvDanhSachLoaiTaiKhoan.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiTaiKhoan.RowTemplate.Height = 24;
            this.dgvDanhSachLoaiTaiKhoan.Size = new System.Drawing.Size(512, 252);
            this.dgvDanhSachLoaiTaiKhoan.TabIndex = 0;
            this.dgvDanhSachLoaiTaiKhoan.TabStop = false;
            this.dgvDanhSachLoaiTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLoaiTaiKhoan_CellClick);
            // 
            // maloaitaikhoan
            // 
            this.maloaitaikhoan.DataPropertyName = "MALOAITAIKHOAN";
            this.maloaitaikhoan.HeaderText = "Mã loại tài khoản";
            this.maloaitaikhoan.MinimumWidth = 6;
            this.maloaitaikhoan.Name = "maloaitaikhoan";
            this.maloaitaikhoan.Visible = false;
            // 
            // tenloaitaikhoan
            // 
            this.tenloaitaikhoan.DataPropertyName = "TENLOAITAIKHOAN";
            this.tenloaitaikhoan.HeaderText = "Tên loại tài khoản";
            this.tenloaitaikhoan.MinimumWidth = 6;
            this.tenloaitaikhoan.Name = "tenloaitaikhoan";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "MOTA";
            this.mota.HeaderText = "Mô tả";
            this.mota.MinimumWidth = 6;
            this.mota.Name = "mota";
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.CapNhat;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(829, 170);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 55);
            this.btnSua.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQuanLyLoaiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1272, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachLoaiTaiKhoan);
            this.Controls.Add(this.btnSua);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyLoaiTaiKhoan";
            this.Text = "Quản lý loại tài khoản";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiTaiKhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenLoaiTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiTaiKhoan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaitaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaitaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
    }
}