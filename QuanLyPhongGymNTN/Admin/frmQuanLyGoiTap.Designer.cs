
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmQuanLyGoiTap
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMonTap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaGoi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachGoiTap = new System.Windows.Forms.DataGridView();
            this.magoitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengoitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giagoitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGoiTap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(887, 228);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 43);
            this.btnXoa.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.CapNhat;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(887, 181);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 43);
            this.btnSua.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSua, "Cập nhật");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(887, 134);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 43);
            this.btnThem.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMonTap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGiaGoi);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenGoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(304, 127);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(565, 144);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin gói tập";
            // 
            // cbbMonTap
            // 
            this.cbbMonTap.FormattingEnabled = true;
            this.cbbMonTap.Location = new System.Drawing.Point(124, 75);
            this.cbbMonTap.Name = "cbbMonTap";
            this.cbbMonTap.Size = new System.Drawing.Size(179, 24);
            this.cbbMonTap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá:";
            // 
            // txtGiaGoi
            // 
            this.txtGiaGoi.Location = new System.Drawing.Point(124, 113);
            this.txtGiaGoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaGoi.Name = "txtGiaGoi";
            this.txtGiaGoi.Size = new System.Drawing.Size(179, 22);
            this.txtGiaGoi.TabIndex = 3;
            this.txtGiaGoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaGoi_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(361, 57);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(179, 80);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Môn tập:";
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenGoi.Location = new System.Drawing.Point(124, 37);
            this.txtTenGoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(179, 22);
            this.txtTenGoi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên gói:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "QUẢN LÝ GÓI TẬP";
            // 
            // dgvDanhSachGoiTap
            // 
            this.dgvDanhSachGoiTap.AllowUserToAddRows = false;
            this.dgvDanhSachGoiTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachGoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magoitap,
            this.tengoitap,
            this.montap,
            this.giagoitap,
            this.ghichu});
            this.dgvDanhSachGoiTap.Location = new System.Drawing.Point(304, 292);
            this.dgvDanhSachGoiTap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachGoiTap.Name = "dgvDanhSachGoiTap";
            this.dgvDanhSachGoiTap.RowHeadersWidth = 51;
            this.dgvDanhSachGoiTap.RowTemplate.Height = 24;
            this.dgvDanhSachGoiTap.Size = new System.Drawing.Size(648, 210);
            this.dgvDanhSachGoiTap.TabIndex = 0;
            this.dgvDanhSachGoiTap.TabStop = false;
            this.dgvDanhSachGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachGoiTap_CellClick);
            // 
            // magoitap
            // 
            this.magoitap.DataPropertyName = "MAGOITAP";
            this.magoitap.HeaderText = "Mã gói";
            this.magoitap.MinimumWidth = 6;
            this.magoitap.Name = "magoitap";
            this.magoitap.Visible = false;
            // 
            // tengoitap
            // 
            this.tengoitap.DataPropertyName = "TENGOITAP";
            this.tengoitap.HeaderText = "Tên gói";
            this.tengoitap.MinimumWidth = 6;
            this.tengoitap.Name = "tengoitap";
            // 
            // montap
            // 
            this.montap.DataPropertyName = "TENMONTAP";
            this.montap.HeaderText = "Môn tập";
            this.montap.MinimumWidth = 6;
            this.montap.Name = "montap";
            // 
            // giagoitap
            // 
            this.giagoitap.DataPropertyName = "GIAGOITAP";
            this.giagoitap.HeaderText = "Giá gói";
            this.giagoitap.MinimumWidth = 6;
            this.giagoitap.Name = "giagoitap";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "GHICHU";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            // 
            // frmQuanLyGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1262, 601);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachGoiTap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyGoiTap";
            this.Text = "Quản lý gói tập";
            this.Load += new System.EventHandler(this.frmQuanLyGoiTap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGoiTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachGoiTap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaGoi;
        private System.Windows.Forms.ComboBox cbbMonTap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magoitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengoitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn montap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giagoitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}