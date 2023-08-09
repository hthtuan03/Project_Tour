namespace Nhom13_QuanLyTourDuLIch
{
    partial class frmTourTrongNuoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvViewTourTrongNuoc = new System.Windows.Forms.DataGridView();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNguoiDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSoLuongTourTrongNuoc = new System.Windows.Forms.Label();
            this.pnlViewDatTour = new System.Windows.Forms.Panel();
            this.btnDatTourTN = new System.Windows.Forms.Button();
            this.pnlViewTenTourTrongNuoc = new System.Windows.Forms.Panel();
            this.lblViewTenTour = new System.Windows.Forms.Label();
            this.pnlViewGiaTienTrongNuoc = new System.Windows.Forms.Panel();
            this.lblViewGiaTour = new System.Windows.Forms.Label();
            this.lblMaTourTrongNuoc = new System.Windows.Forms.Label();
            this.lblSlotTrongNuoc = new System.Windows.Forms.Label();
            this.lblNoiKHTrongNuoc = new System.Windows.Forms.Label();
            this.lblSoNgayTrongNuoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.dtNgayKTTrongNuoc = new System.Windows.Forms.DateTimePicker();
            this.btnResetTrongNuoc = new System.Windows.Forms.Button();
            this.btnLocketquaTrongNuoc = new System.Windows.Forms.Button();
            this.nudSoNguoiDiTrongNuoc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayDiTrongNuoc = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblSoNgayDi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTourTrongNuoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSoNgayTN = new System.Windows.Forms.Label();
            this.lblKhoiHanhTN = new System.Windows.Forms.Label();
            this.lblMaTourTN = new System.Windows.Forms.Label();
            this.lblSlotTN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTourTrongNuoc)).BeginInit();
            this.pnlViewDatTour.SuspendLayout();
            this.pnlViewTenTourTrongNuoc.SuspendLayout();
            this.pnlViewGiaTienTrongNuoc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoiDiTrongNuoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "THÔNG TIN TOUR TRONG NƯỚC";
            // 
            // dgvViewTourTrongNuoc
            // 
            this.dgvViewTourTrongNuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvViewTourTrongNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewTourTrongNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTour,
            this.colTenTour,
            this.colSoNguoiDi,
            this.colNgayDi,
            this.colNgayKetThuc,
            this.colGiaTour});
            this.dgvViewTourTrongNuoc.Location = new System.Drawing.Point(12, 293);
            this.dgvViewTourTrongNuoc.Name = "dgvViewTourTrongNuoc";
            this.dgvViewTourTrongNuoc.RowHeadersWidth = 51;
            this.dgvViewTourTrongNuoc.RowTemplate.Height = 24;
            this.dgvViewTourTrongNuoc.Size = new System.Drawing.Size(1144, 213);
            this.dgvViewTourTrongNuoc.TabIndex = 1;
            this.dgvViewTourTrongNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewTourTrongNuoc_CellClick);
            // 
            // colMaTour
            // 
            this.colMaTour.HeaderText = "Mã Tour";
            this.colMaTour.MinimumWidth = 6;
            this.colMaTour.Name = "colMaTour";
            this.colMaTour.Width = 125;
            // 
            // colTenTour
            // 
            this.colTenTour.HeaderText = "Tên Tour";
            this.colTenTour.MinimumWidth = 6;
            this.colTenTour.Name = "colTenTour";
            this.colTenTour.Width = 300;
            // 
            // colSoNguoiDi
            // 
            this.colSoNguoiDi.HeaderText = "Số Người Đi";
            this.colSoNguoiDi.MinimumWidth = 6;
            this.colSoNguoiDi.Name = "colSoNguoiDi";
            this.colSoNguoiDi.Width = 125;
            // 
            // colNgayDi
            // 
            this.colNgayDi.HeaderText = "Ngày Đi";
            this.colNgayDi.MinimumWidth = 6;
            this.colNgayDi.Name = "colNgayDi";
            this.colNgayDi.Width = 125;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.colNgayKetThuc.MinimumWidth = 6;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Width = 210;
            // 
            // colGiaTour
            // 
            this.colGiaTour.HeaderText = "Giá Tour";
            this.colGiaTour.MinimumWidth = 6;
            this.colGiaTour.Name = "colGiaTour";
            this.colGiaTour.Width = 210;
            // 
            // lblSoLuongTourTrongNuoc
            // 
            this.lblSoLuongTourTrongNuoc.AutoSize = true;
            this.lblSoLuongTourTrongNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSoLuongTourTrongNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoLuongTourTrongNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTourTrongNuoc.Location = new System.Drawing.Point(942, 237);
            this.lblSoLuongTourTrongNuoc.Name = "lblSoLuongTourTrongNuoc";
            this.lblSoLuongTourTrongNuoc.Size = new System.Drawing.Size(189, 27);
            this.lblSoLuongTourTrongNuoc.TabIndex = 2;
            this.lblSoLuongTourTrongNuoc.Text = "Đã Tìm Thấy 0 Tour";
            // 
            // pnlViewDatTour
            // 
            this.pnlViewDatTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewDatTour.Controls.Add(this.btnDatTourTN);
            this.pnlViewDatTour.Controls.Add(this.pnlViewTenTourTrongNuoc);
            this.pnlViewDatTour.Controls.Add(this.pnlViewGiaTienTrongNuoc);
            this.pnlViewDatTour.Location = new System.Drawing.Point(12, 512);
            this.pnlViewDatTour.Name = "pnlViewDatTour";
            this.pnlViewDatTour.Size = new System.Drawing.Size(1144, 100);
            this.pnlViewDatTour.TabIndex = 3;
            // 
            // btnDatTourTN
            // 
            this.btnDatTourTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTourTN.Location = new System.Drawing.Point(962, 2);
            this.btnDatTourTN.Name = "btnDatTourTN";
            this.btnDatTourTN.Size = new System.Drawing.Size(177, 95);
            this.btnDatTourTN.TabIndex = 68;
            this.btnDatTourTN.Text = "Đặt Tour";
            this.btnDatTourTN.UseVisualStyleBackColor = true;
            this.btnDatTourTN.Click += new System.EventHandler(this.btnDatTourTN_Click);
            // 
            // pnlViewTenTourTrongNuoc
            // 
            this.pnlViewTenTourTrongNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewTenTourTrongNuoc.Controls.Add(this.lblViewTenTour);
            this.pnlViewTenTourTrongNuoc.Location = new System.Drawing.Point(3, 3);
            this.pnlViewTenTourTrongNuoc.Name = "pnlViewTenTourTrongNuoc";
            this.pnlViewTenTourTrongNuoc.Size = new System.Drawing.Size(729, 94);
            this.pnlViewTenTourTrongNuoc.TabIndex = 2;
            // 
            // lblViewTenTour
            // 
            this.lblViewTenTour.AutoSize = true;
            this.lblViewTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTenTour.Location = new System.Drawing.Point(3, 15);
            this.lblViewTenTour.Name = "lblViewTenTour";
            this.lblViewTenTour.Size = new System.Drawing.Size(101, 25);
            this.lblViewTenTour.TabIndex = 2;
            this.lblViewTenTour.Text = "Tên Tour";
            // 
            // pnlViewGiaTienTrongNuoc
            // 
            this.pnlViewGiaTienTrongNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewGiaTienTrongNuoc.Controls.Add(this.lblViewGiaTour);
            this.pnlViewGiaTienTrongNuoc.Location = new System.Drawing.Point(738, 0);
            this.pnlViewGiaTienTrongNuoc.Name = "pnlViewGiaTienTrongNuoc";
            this.pnlViewGiaTienTrongNuoc.Size = new System.Drawing.Size(218, 97);
            this.pnlViewGiaTienTrongNuoc.TabIndex = 0;
            // 
            // lblViewGiaTour
            // 
            this.lblViewGiaTour.AutoSize = true;
            this.lblViewGiaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewGiaTour.Location = new System.Drawing.Point(27, 21);
            this.lblViewGiaTour.Name = "lblViewGiaTour";
            this.lblViewGiaTour.Size = new System.Drawing.Size(89, 22);
            this.lblViewGiaTour.TabIndex = 0;
            this.lblViewGiaTour.Text = "Giá Tour";
            // 
            // lblMaTourTrongNuoc
            // 
            this.lblMaTourTrongNuoc.AutoSize = true;
            this.lblMaTourTrongNuoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaTourTrongNuoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTourTrongNuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMaTourTrongNuoc.Location = new System.Drawing.Point(908, 646);
            this.lblMaTourTrongNuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaTourTrongNuoc.Name = "lblMaTourTrongNuoc";
            this.lblMaTourTrongNuoc.Size = new System.Drawing.Size(0, 23);
            this.lblMaTourTrongNuoc.TabIndex = 79;
            this.lblMaTourTrongNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlotTrongNuoc
            // 
            this.lblSlotTrongNuoc.AutoSize = true;
            this.lblSlotTrongNuoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblSlotTrongNuoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotTrongNuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSlotTrongNuoc.Location = new System.Drawing.Point(934, 746);
            this.lblSlotTrongNuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlotTrongNuoc.Name = "lblSlotTrongNuoc";
            this.lblSlotTrongNuoc.Size = new System.Drawing.Size(0, 23);
            this.lblSlotTrongNuoc.TabIndex = 77;
            this.lblSlotTrongNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoiKHTrongNuoc
            // 
            this.lblNoiKHTrongNuoc.AutoSize = true;
            this.lblNoiKHTrongNuoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoiKHTrongNuoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiKHTrongNuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNoiKHTrongNuoc.Location = new System.Drawing.Point(934, 679);
            this.lblNoiKHTrongNuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoiKHTrongNuoc.Name = "lblNoiKHTrongNuoc";
            this.lblNoiKHTrongNuoc.Size = new System.Drawing.Size(0, 23);
            this.lblNoiKHTrongNuoc.TabIndex = 76;
            this.lblNoiKHTrongNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoNgayTrongNuoc
            // 
            this.lblSoNgayTrongNuoc.AutoSize = true;
            this.lblSoNgayTrongNuoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoNgayTrongNuoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayTrongNuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSoNgayTrongNuoc.Location = new System.Drawing.Point(908, 714);
            this.lblSoNgayTrongNuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNgayTrongNuoc.Name = "lblSoNgayTrongNuoc";
            this.lblSoNgayTrongNuoc.Size = new System.Drawing.Size(0, 23);
            this.lblSoNgayTrongNuoc.TabIndex = 75;
            this.lblSoNgayTrongNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturnMain);
            this.groupBox1.Controls.Add(this.dtNgayKTTrongNuoc);
            this.groupBox1.Controls.Add(this.btnResetTrongNuoc);
            this.groupBox1.Controls.Add(this.btnLocketquaTrongNuoc);
            this.groupBox1.Controls.Add(this.nudSoNguoiDiTrongNuoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtNgayDiTrongNuoc);
            this.groupBox1.Controls.Add(this.lblNgayDi);
            this.groupBox1.Controls.Add(this.lblSoNgayDi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbTourTrongNuoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 199);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMain.Location = new System.Drawing.Point(810, 121);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(99, 34);
            this.btnReturnMain.TabIndex = 15;
            this.btnReturnMain.Text = "Trở Về";
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // dtNgayKTTrongNuoc
            // 
            this.dtNgayKTTrongNuoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKTTrongNuoc.Location = new System.Drawing.Point(553, 114);
            this.dtNgayKTTrongNuoc.Name = "dtNgayKTTrongNuoc";
            this.dtNgayKTTrongNuoc.Size = new System.Drawing.Size(166, 22);
            this.dtNgayKTTrongNuoc.TabIndex = 14;
            // 
            // btnResetTrongNuoc
            // 
            this.btnResetTrongNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResetTrongNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTrongNuoc.Location = new System.Drawing.Point(957, 21);
            this.btnResetTrongNuoc.Name = "btnResetTrongNuoc";
            this.btnResetTrongNuoc.Size = new System.Drawing.Size(185, 47);
            this.btnResetTrongNuoc.TabIndex = 13;
            this.btnResetTrongNuoc.Text = "Reset ";
            this.btnResetTrongNuoc.UseVisualStyleBackColor = false;
            this.btnResetTrongNuoc.Click += new System.EventHandler(this.btnResetTrongNuoc_Click);
            // 
            // btnLocketquaTrongNuoc
            // 
            this.btnLocketquaTrongNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLocketquaTrongNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocketquaTrongNuoc.Location = new System.Drawing.Point(957, 114);
            this.btnLocketquaTrongNuoc.Name = "btnLocketquaTrongNuoc";
            this.btnLocketquaTrongNuoc.Size = new System.Drawing.Size(185, 47);
            this.btnLocketquaTrongNuoc.TabIndex = 12;
            this.btnLocketquaTrongNuoc.Text = "Lọc kết quả";
            this.btnLocketquaTrongNuoc.UseVisualStyleBackColor = false;
            this.btnLocketquaTrongNuoc.Click += new System.EventHandler(this.btnLocketquaTrongNuoc_Click);
            // 
            // nudSoNguoiDiTrongNuoc
            // 
            this.nudSoNguoiDiTrongNuoc.Location = new System.Drawing.Point(553, 26);
            this.nudSoNguoiDiTrongNuoc.Name = "nudSoNguoiDiTrongNuoc";
            this.nudSoNguoiDiTrongNuoc.Size = new System.Drawing.Size(223, 22);
            this.nudSoNguoiDiTrongNuoc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số người đi:";
            // 
            // dtNgayDiTrongNuoc
            // 
            this.dtNgayDiTrongNuoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDiTrongNuoc.Location = new System.Drawing.Point(141, 114);
            this.dtNgayDiTrongNuoc.Name = "dtNgayDiTrongNuoc";
            this.dtNgayDiTrongNuoc.Size = new System.Drawing.Size(171, 22);
            this.dtNgayDiTrongNuoc.TabIndex = 7;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(25, 116);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(84, 20);
            this.lblNgayDi.TabIndex = 6;
            this.lblNgayDi.Text = "Ngày đi: ";
            // 
            // lblSoNgayDi
            // 
            this.lblSoNgayDi.AutoSize = true;
            this.lblSoNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayDi.Location = new System.Drawing.Point(421, 116);
            this.lblSoNgayDi.Name = "lblSoNgayDi";
            this.lblSoNgayDi.Size = new System.Drawing.Size(86, 20);
            this.lblSoNgayDi.TabIndex = 5;
            this.lblSoNgayDi.Text = "Ngày KT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm đi:";
            // 
            // cmbTourTrongNuoc
            // 
            this.cmbTourTrongNuoc.FormattingEnabled = true;
            this.cmbTourTrongNuoc.Items.AddRange(new object[] {
            "TP. Hồ Chí Minh",
            "Hà Nội"});
            this.cmbTourTrongNuoc.Location = new System.Drawing.Point(141, 26);
            this.cmbTourTrongNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTourTrongNuoc.Name = "cmbTourTrongNuoc";
            this.cmbTourTrongNuoc.Size = new System.Drawing.Size(254, 24);
            this.cmbTourTrongNuoc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 624);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 195);
            this.panel1.TabIndex = 81;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Nhom13_QuanLyTourDuLIch.Properties.Resources._107238192;
            this.pictureBox3.Location = new System.Drawing.Point(597, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhom13_QuanLyTourDuLIch.Properties.Resources._352_3523121_new_travel_peeps_travel_agency_logo_png_clipart3;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "HotLine: 09********";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nhom13_QuanLyTourDuLIch.Properties.Resources._126509;
            this.pictureBox2.Location = new System.Drawing.Point(236, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "TƯ VẤN MIỄN PHÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "CÔNG TY DU LỊCH UY TÍN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "CÔNG TY DU LỊCH TỔ CHỨC TOUR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(802, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 82;
            this.label8.Text = "Mã Tour:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(802, 693);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 83;
            this.label9.Text = "Tên Tour:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(802, 734);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 84;
            this.label10.Text = "Ngày Đi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(802, 775);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 85;
            this.label11.Text = "Số Lượng:";
            // 
            // lblSoNgayTN
            // 
            this.lblSoNgayTN.AutoSize = true;
            this.lblSoNgayTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayTN.Location = new System.Drawing.Point(887, 734);
            this.lblSoNgayTN.Name = "lblSoNgayTN";
            this.lblSoNgayTN.Size = new System.Drawing.Size(70, 18);
            this.lblSoNgayTN.TabIndex = 86;
            this.lblSoNgayTN.Text = "Điểm đi:";
            // 
            // lblKhoiHanhTN
            // 
            this.lblKhoiHanhTN.AutoSize = true;
            this.lblKhoiHanhTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoiHanhTN.Location = new System.Drawing.Point(890, 693);
            this.lblKhoiHanhTN.Name = "lblKhoiHanhTN";
            this.lblKhoiHanhTN.Size = new System.Drawing.Size(70, 18);
            this.lblKhoiHanhTN.TabIndex = 86;
            this.lblKhoiHanhTN.Text = "Điểm đi:";
            // 
            // lblMaTourTN
            // 
            this.lblMaTourTN.AutoSize = true;
            this.lblMaTourTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTourTN.Location = new System.Drawing.Point(890, 648);
            this.lblMaTourTN.Name = "lblMaTourTN";
            this.lblMaTourTN.Size = new System.Drawing.Size(70, 18);
            this.lblMaTourTN.TabIndex = 87;
            this.lblMaTourTN.Text = "Điểm đi:";
            // 
            // lblSlotTN
            // 
            this.lblSlotTN.AutoSize = true;
            this.lblSlotTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotTN.Location = new System.Drawing.Point(896, 775);
            this.lblSlotTN.Name = "lblSlotTN";
            this.lblSlotTN.Size = new System.Drawing.Size(70, 18);
            this.lblSlotTN.TabIndex = 88;
            this.lblSlotTN.Text = "Điểm đi:";
            // 
            // frmTourTrongNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 831);
            this.Controls.Add(this.lblSlotTN);
            this.Controls.Add(this.lblMaTourTN);
            this.Controls.Add(this.lblKhoiHanhTN);
            this.Controls.Add(this.lblSoNgayTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaTourTrongNuoc);
            this.Controls.Add(this.lblSlotTrongNuoc);
            this.Controls.Add(this.lblNoiKHTrongNuoc);
            this.Controls.Add(this.lblSoNgayTrongNuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlViewDatTour);
            this.Controls.Add(this.lblSoLuongTourTrongNuoc);
            this.Controls.Add(this.dgvViewTourTrongNuoc);
            this.Name = "frmTourTrongNuoc";
            this.Load += new System.EventHandler(this.frmTourTrongNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTourTrongNuoc)).EndInit();
            this.pnlViewDatTour.ResumeLayout(false);
            this.pnlViewTenTourTrongNuoc.ResumeLayout(false);
            this.pnlViewTenTourTrongNuoc.PerformLayout();
            this.pnlViewGiaTienTrongNuoc.ResumeLayout(false);
            this.pnlViewGiaTienTrongNuoc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoiDiTrongNuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvViewTourTrongNuoc;
        private System.Windows.Forms.Label lblSoLuongTourTrongNuoc;
        private System.Windows.Forms.Panel pnlViewDatTour;
        private System.Windows.Forms.Panel pnlViewGiaTienTrongNuoc;
        private System.Windows.Forms.Label lblViewGiaTour;
        private System.Windows.Forms.Label lblViewTenTour;
        private System.Windows.Forms.Panel pnlViewTenTourTrongNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNguoiDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTour;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblMaTourTrongNuoc;
        public System.Windows.Forms.Label lblSlotTrongNuoc;
        public System.Windows.Forms.Label lblNoiKHTrongNuoc;
        public System.Windows.Forms.Label lblSoNgayTrongNuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayKTTrongNuoc;
        private System.Windows.Forms.Button btnResetTrongNuoc;
        private System.Windows.Forms.Button btnLocketquaTrongNuoc;
        private System.Windows.Forms.NumericUpDown nudSoNguoiDiTrongNuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayDiTrongNuoc;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblSoNgayDi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTourTrongNuoc;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDatTourTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSoNgayTN;
        private System.Windows.Forms.Label lblKhoiHanhTN;
        private System.Windows.Forms.Label lblMaTourTN;
        private System.Windows.Forms.Label lblSlotTN;
    }
}