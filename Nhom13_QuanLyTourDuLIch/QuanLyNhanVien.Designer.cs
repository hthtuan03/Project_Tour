namespace Nhom13_QuanLyTourDuLIch
{
    partial class QuanLyNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChucVuNV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtQLDiaChiNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQLSoDTNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtQLNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQLTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQLMSNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvQLNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.cmbTimNV = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChucVuNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.btnSuaNV);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.txtQLDiaChiNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQLSoDTNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtQLNgaySinhNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQLTenNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQLMSNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 725);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // cmbChucVuNV
            // 
            this.cmbChucVuNV.FormattingEnabled = true;
            this.cmbChucVuNV.Items.AddRange(new object[] {
            "Quản Lý",
            "HDV ",
            "Nhân Viên"});
            this.cmbChucVuNV.Location = new System.Drawing.Point(10, 584);
            this.cmbChucVuNV.Name = "cmbChucVuNV";
            this.cmbChucVuNV.Size = new System.Drawing.Size(390, 28);
            this.cmbChucVuNV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Chức Vụ";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(149, 642);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(104, 45);
            this.btnXoaNV.TabIndex = 22;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(296, 642);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(104, 45);
            this.btnSuaNV.TabIndex = 20;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(10, 642);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(104, 45);
            this.btnThemNV.TabIndex = 19;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtQLDiaChiNV
            // 
            this.txtQLDiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQLDiaChiNV.Location = new System.Drawing.Point(10, 489);
            this.txtQLDiaChiNV.Name = "txtQLDiaChiNV";
            this.txtQLDiaChiNV.Size = new System.Drawing.Size(390, 27);
            this.txtQLDiaChiNV.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtQLSoDTNV
            // 
            this.txtQLSoDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQLSoDTNV.Location = new System.Drawing.Point(10, 381);
            this.txtQLSoDTNV.Name = "txtQLSoDTNV";
            this.txtQLSoDTNV.Size = new System.Drawing.Size(390, 27);
            this.txtQLSoDTNV.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số ĐT";
            // 
            // dtQLNgaySinhNV
            // 
            this.dtQLNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtQLNgaySinhNV.Location = new System.Drawing.Point(10, 282);
            this.dtQLNgaySinhNV.Name = "dtQLNgaySinhNV";
            this.dtQLNgaySinhNV.Size = new System.Drawing.Size(390, 27);
            this.dtQLNgaySinhNV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Sinh";
            // 
            // txtQLTenNV
            // 
            this.txtQLTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQLTenNV.Location = new System.Drawing.Point(10, 176);
            this.txtQLTenNV.Name = "txtQLTenNV";
            this.txtQLTenNV.Size = new System.Drawing.Size(390, 27);
            this.txtQLTenNV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã NV";
            // 
            // txtQLMSNV
            // 
            this.txtQLMSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQLMSNV.Location = new System.Drawing.Point(10, 71);
            this.txtQLMSNV.Name = "txtQLMSNV";
            this.txtQLMSNV.Size = new System.Drawing.Size(390, 27);
            this.txtQLMSNV.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTimNV);
            this.groupBox2.Controls.Add(this.btnTimNV);
            this.groupBox2.Controls.Add(this.dgvQLNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(446, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(993, 725);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvQLNhanVien
            // 
            this.dgvQLNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvQLNhanVien.Location = new System.Drawing.Point(0, 71);
            this.dgvQLNhanVien.Name = "dgvQLNhanVien";
            this.dgvQLNhanVien.RowHeadersWidth = 51;
            this.dgvQLNhanVien.RowTemplate.Height = 24;
            this.dgvQLNhanVien.Size = new System.Drawing.Size(993, 654);
            this.dgvQLNhanVien.TabIndex = 0;
            this.dgvQLNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số ĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chức Vụ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(235, 20);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(96, 37);
            this.btnTimNV.TabIndex = 2;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = true;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // cmbTimNV
            // 
            this.cmbTimNV.FormattingEnabled = true;
            this.cmbTimNV.Items.AddRange(new object[] {
            "Quản Lý",
            "HDV",
            "Nhân Viên"});
            this.cmbTimNV.Location = new System.Drawing.Point(27, 27);
            this.cmbTimNV.Name = "cmbTimNV";
            this.cmbTimNV.Size = new System.Drawing.Size(177, 24);
            this.cmbTimNV.TabIndex = 3;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 759);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQLTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQLMSNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtQLNgaySinhNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQLDiaChiNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQLSoDTNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridView dgvQLNhanVien;
        private System.Windows.Forms.ComboBox cmbChucVuNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.ComboBox cmbTimNV;
    }
}