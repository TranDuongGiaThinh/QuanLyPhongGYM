
namespace QuanLyPhongGymNTN.KhachHang
{
    partial class frmGoiTap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGoiTap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgvDanhSachGoiTap = new System.Windows.Forms.DataGridView();
            this.ColMaTheTap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenGoiTap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiaGoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttChucNang = new System.Windows.Forms.ToolTip(this.components);
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbbMonTap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGoiTap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "THÔNG TIN GÓI TẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Tên gói :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Môn tập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ghi chú:";
            // 
            // txtTenGoiTap
            // 
            this.txtTenGoiTap.Enabled = false;
            this.txtTenGoiTap.Location = new System.Drawing.Point(276, 74);
            this.txtTenGoiTap.Name = "txtTenGoiTap";
            this.txtTenGoiTap.Size = new System.Drawing.Size(237, 22);
            this.txtTenGoiTap.TabIndex = 65;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Location = new System.Drawing.Point(276, 210);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(237, 43);
            this.txtGhiChu.TabIndex = 67;
            // 
            // dgvDanhSachGoiTap
            // 
            this.dgvDanhSachGoiTap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachGoiTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachGoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaTheTap,
            this.ColTenGoiTap,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDanhSachGoiTap.Location = new System.Drawing.Point(130, 259);
            this.dgvDanhSachGoiTap.Name = "dgvDanhSachGoiTap";
            this.dgvDanhSachGoiTap.RowHeadersWidth = 51;
            this.dgvDanhSachGoiTap.RowTemplate.Height = 24;
            this.dgvDanhSachGoiTap.Size = new System.Drawing.Size(535, 157);
            this.dgvDanhSachGoiTap.TabIndex = 68;
            this.dgvDanhSachGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTGoiTap_CellClick);
            // 
            // ColMaTheTap
            // 
            this.ColMaTheTap.DataPropertyName = "MAGOITAP";
            this.ColMaTheTap.HeaderText = "Mã gói tập";
            this.ColMaTheTap.MinimumWidth = 6;
            this.ColMaTheTap.Name = "ColMaTheTap";
            this.ColMaTheTap.Visible = false;
            // 
            // ColTenGoiTap
            // 
            this.ColTenGoiTap.DataPropertyName = "TenGoiTap";
            this.ColTenGoiTap.HeaderText = "Tên gói";
            this.ColTenGoiTap.MinimumWidth = 6;
            this.ColTenGoiTap.Name = "ColTenGoiTap";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENMONTAP";
            this.Column1.HeaderText = "Môn tập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GIAGOITAP";
            this.Column2.HeaderText = "Giá gói";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GHICHU";
            this.Column3.HeaderText = "Ghi chú";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // txtGiaGoi
            // 
            this.txtGiaGoi.Enabled = false;
            this.txtGiaGoi.Location = new System.Drawing.Point(276, 166);
            this.txtGiaGoi.Name = "txtGiaGoi";
            this.txtGiaGoi.Size = new System.Drawing.Size(237, 22);
            this.txtGiaGoi.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Giá gói:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.Them;
            this.btnDangKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangKy.Location = new System.Drawing.Point(593, 167);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(72, 63);
            this.btnDangKy.TabIndex = 71;
            this.btnDangKy.TabStop = false;
            this.ttChucNang.SetToolTip(this.btnDangKy, "Đăng ký gói tập");
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbbMonTap
            // 
            this.cbbMonTap.Enabled = false;
            this.cbbMonTap.FormattingEnabled = true;
            this.cbbMonTap.Location = new System.Drawing.Point(276, 116);
            this.cbbMonTap.Name = "cbbMonTap";
            this.cbbMonTap.Size = new System.Drawing.Size(237, 24);
            this.cbbMonTap.TabIndex = 72;
            // 
            // frmGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(786, 442);
            this.Controls.Add(this.cbbMonTap);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtGiaGoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDanhSachGoiTap);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenGoiTap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGoiTap";
            this.Text = "Gói tập";
            this.Load += new System.EventHandler(this.frmGoiTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGoiTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGoiTap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvDanhSachGoiTap;
        private System.Windows.Forms.TextBox txtGiaGoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaTheTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenGoiTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cbbMonTap;
    }
}