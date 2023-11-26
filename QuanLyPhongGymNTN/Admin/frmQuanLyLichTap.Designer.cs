
namespace QuanLyPhongGymNTN.Admin
{
    partial class frmQuanLyLichTap
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
            this.dgvDanhSachLichTap = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.cbbPT = new System.Windows.Forms.ComboBox();
            this.radHoTenKhachHang = new System.Windows.Forms.RadioButton();
            this.radPT = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLichTap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachLichTap
            // 
            this.dgvDanhSachLichTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLichTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLichTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDanhSachLichTap.Location = new System.Drawing.Point(251, 303);
            this.dgvDanhSachLichTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachLichTap.Name = "dgvDanhSachLichTap";
            this.dgvDanhSachLichTap.RowHeadersWidth = 51;
            this.dgvDanhSachLichTap.Size = new System.Drawing.Size(771, 246);
            this.dgvDanhSachLichTap.TabIndex = 7;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MATHETAP";
            this.Column10.HeaderText = "Mã thẻ tập";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENKHACHHANG";
            this.Column1.HeaderText = "Khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENPT";
            this.Column2.HeaderText = "PT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "THUHAI";
            this.Column3.HeaderText = "Thứ hai";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "THUBA";
            this.Column4.HeaderText = "Thứ ba";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "THUTU";
            this.Column5.HeaderText = "Thứ tư";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "THUNAM";
            this.Column6.HeaderText = "Thứ năm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "THUSAU";
            this.Column7.HeaderText = "Thứ sáu";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "THUBAY";
            this.Column8.HeaderText = "Thứ bảy";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CHUNHAT";
            this.Column9.HeaderText = "Chủ nhật";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.cbbPT);
            this.groupBox1.Controls.Add(this.radHoTenKhachHang);
            this.groupBox1.Controls.Add(this.radPT);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Location = new System.Drawing.Point(251, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(771, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::QuanLyPhongGymNTN.Properties.Resources.TimKiem;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.Location = new System.Drawing.Point(339, 71);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(77, 28);
            this.btnTim.TabIndex = 3;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(168, 74);
            this.txtHoTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(161, 22);
            this.txtHoTenKhachHang.TabIndex = 2;
            // 
            // cbbPT
            // 
            this.cbbPT.FormattingEnabled = true;
            this.cbbPT.Location = new System.Drawing.Point(549, 26);
            this.cbbPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbPT.Name = "cbbPT";
            this.cbbPT.Size = new System.Drawing.Size(160, 24);
            this.cbbPT.TabIndex = 5;
            this.cbbPT.SelectedIndexChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radHoTenKhachHang
            // 
            this.radHoTenKhachHang.AutoSize = true;
            this.radHoTenKhachHang.Location = new System.Drawing.Point(36, 74);
            this.radHoTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radHoTenKhachHang.Name = "radHoTenKhachHang";
            this.radHoTenKhachHang.Size = new System.Drawing.Size(117, 21);
            this.radHoTenKhachHang.TabIndex = 1;
            this.radHoTenKhachHang.TabStop = true;
            this.radHoTenKhachHang.Text = "Họ tên khách:";
            this.radHoTenKhachHang.UseVisualStyleBackColor = true;
            // 
            // radPT
            // 
            this.radPT.AutoSize = true;
            this.radPT.Location = new System.Drawing.Point(491, 27);
            this.radPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPT.Name = "radPT";
            this.radPT.Size = new System.Drawing.Size(47, 21);
            this.radPT.TabIndex = 4;
            this.radPT.TabStop = true;
            this.radPT.Text = "PT";
            this.radPT.UseVisualStyleBackColor = true;
            this.radPT.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(36, 27);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(69, 21);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ LỊCH TẬP";
            // 
            // frmQuanLyLichTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1285, 619);
            this.Controls.Add(this.dgvDanhSachLichTap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyLichTap";
            this.Text = "Quản lý lịch tập";
            this.Load += new System.EventHandler(this.frmQuanLyLichTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLichTap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSachLichTap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtHoTenKhachHang;
        private System.Windows.Forms.ComboBox cbbPT;
        private System.Windows.Forms.RadioButton radHoTenKhachHang;
        private System.Windows.Forms.RadioButton radPT;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}