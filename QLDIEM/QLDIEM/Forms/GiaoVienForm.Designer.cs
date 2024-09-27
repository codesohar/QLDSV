namespace QLDIEM.Forms
{
    partial class GiaoVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoVienForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenGiaoVien = new System.Windows.Forms.TextBox();
            this.dgvListGiaoVien = new Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveGiaoVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefeshGiaoVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditGiaoVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddGiaoVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchGiaoVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Tên Giáo Viên:";
            // 
            // txtHoTenGiaoVien
            // 
            this.txtHoTenGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenGiaoVien.Location = new System.Drawing.Point(230, 94);
            this.txtHoTenGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenGiaoVien.Name = "txtHoTenGiaoVien";
            this.txtHoTenGiaoVien.Size = new System.Drawing.Size(231, 26);
            this.txtHoTenGiaoVien.TabIndex = 7;
            // 
            // dgvListGiaoVien
            // 
            this.dgvListGiaoVien.AllowUserToAddRows = false;
            this.dgvListGiaoVien.AllowUserToDeleteRows = false;
            this.dgvListGiaoVien.AllowUserToResizeColumns = false;
            this.dgvListGiaoVien.AllowUserToResizeRows = false;
            this.dgvListGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvListGiaoVien.Location = new System.Drawing.Point(14, 311);
            this.dgvListGiaoVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListGiaoVien.Name = "dgvListGiaoVien";
            this.dgvListGiaoVien.RowHeadersVisible = false;
            this.dgvListGiaoVien.RowHeadersWidth = 51;
            this.dgvListGiaoVien.RowTemplate.Height = 24;
            this.dgvListGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGiaoVien.Size = new System.Drawing.Size(1372, 386);
            this.dgvListGiaoVien.TabIndex = 104;
            this.dgvListGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListGiaoVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaGV";
            this.Column1.HeaderText = "Mã Giáo Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoDienThoai";
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa Chỉ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaKhoa";
            this.Column8.HeaderText = "Mã Khoa";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnRemoveGiaoVien
            // 
            this.btnRemoveGiaoVien.BorderRadius = 20;
            this.btnRemoveGiaoVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveGiaoVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveGiaoVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveGiaoVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveGiaoVien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveGiaoVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveGiaoVien.Image")));
            this.btnRemoveGiaoVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemoveGiaoVien.Location = new System.Drawing.Point(1182, 146);
            this.btnRemoveGiaoVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemoveGiaoVien.Name = "btnRemoveGiaoVien";
            this.btnRemoveGiaoVien.Size = new System.Drawing.Size(128, 49);
            this.btnRemoveGiaoVien.TabIndex = 96;
            this.btnRemoveGiaoVien.Text = "Xoá";
            this.btnRemoveGiaoVien.Click += new System.EventHandler(this.btnRemoveGiaoVien_Click);
            // 
            // btnRefeshGiaoVien
            // 
            this.btnRefeshGiaoVien.BorderRadius = 20;
            this.btnRefeshGiaoVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshGiaoVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshGiaoVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefeshGiaoVien.FillColor = System.Drawing.Color.Cyan;
            this.btnRefeshGiaoVien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeshGiaoVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefeshGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.btnRefeshGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeshGiaoVien.Image")));
            this.btnRefeshGiaoVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefeshGiaoVien.Location = new System.Drawing.Point(990, 146);
            this.btnRefeshGiaoVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefeshGiaoVien.Name = "btnRefeshGiaoVien";
            this.btnRefeshGiaoVien.Size = new System.Drawing.Size(128, 49);
            this.btnRefeshGiaoVien.TabIndex = 95;
            this.btnRefeshGiaoVien.Text = "Làm Mới";
            this.btnRefeshGiaoVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefeshGiaoVien.Click += new System.EventHandler(this.btnRefeshGiaoVien_Click);
            // 
            // btnEditGiaoVien
            // 
            this.btnEditGiaoVien.BorderRadius = 20;
            this.btnEditGiaoVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGiaoVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditGiaoVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditGiaoVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditGiaoVien.FillColor2 = System.Drawing.Color.Yellow;
            this.btnEditGiaoVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.btnEditGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnEditGiaoVien.Image")));
            this.btnEditGiaoVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditGiaoVien.Location = new System.Drawing.Point(1182, 73);
            this.btnEditGiaoVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditGiaoVien.Name = "btnEditGiaoVien";
            this.btnEditGiaoVien.Size = new System.Drawing.Size(128, 49);
            this.btnEditGiaoVien.TabIndex = 94;
            this.btnEditGiaoVien.Text = "Sửa";
            this.btnEditGiaoVien.Click += new System.EventHandler(this.btnEditGiaoVien_Click);
            // 
            // btnAddGiaoVien
            // 
            this.btnAddGiaoVien.BorderRadius = 20;
            this.btnAddGiaoVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGiaoVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGiaoVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddGiaoVien.FillColor = System.Drawing.Color.Lime;
            this.btnAddGiaoVien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddGiaoVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.btnAddGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGiaoVien.Image")));
            this.btnAddGiaoVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddGiaoVien.Location = new System.Drawing.Point(990, 73);
            this.btnAddGiaoVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddGiaoVien.Name = "btnAddGiaoVien";
            this.btnAddGiaoVien.Size = new System.Drawing.Size(128, 49);
            this.btnAddGiaoVien.TabIndex = 93;
            this.btnAddGiaoVien.Text = "Thêm";
            this.btnAddGiaoVien.Click += new System.EventHandler(this.btnAddGiaoVien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới Tính:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(230, 44);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(231, 26);
            this.txtMaKhoa.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.comGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnRemoveGiaoVien);
            this.groupBox1.Controls.Add(this.btnRefeshGiaoVien);
            this.groupBox1.Controls.Add(this.btnEditGiaoVien);
            this.groupBox1.Controls.Add(this.btnAddGiaoVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTenGiaoVien);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1372, 244);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giáo Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Checked = true;
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(230, 204);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(232, 28);
            this.dateNgaySinh.TabIndex = 105;
            this.dateNgaySinh.Value = new System.DateTime(2023, 4, 24, 11, 23, 21, 983);
            // 
            // comGioiTinh
            // 
            this.comGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.comGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comGioiTinh.ItemHeight = 30;
            this.comGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comGioiTinh.Location = new System.Drawing.Point(230, 142);
            this.comGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.comGioiTinh.Name = "comGioiTinh";
            this.comGioiTinh.Size = new System.Drawing.Size(231, 36);
            this.comGioiTinh.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Mã Khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(672, 144);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 26);
            this.txtDiaChi.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(672, 95);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(231, 26);
            this.txtSoDienThoai.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(534, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(672, 44);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 26);
            this.txtEmail.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 105;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // txtSearchGiaoVien
            // 
            this.txtSearchGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGiaoVien.Location = new System.Drawing.Point(584, 277);
            this.txtSearchGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchGiaoVien.Name = "txtSearchGiaoVien";
            this.txtSearchGiaoVien.Size = new System.Drawing.Size(231, 26);
            this.txtSearchGiaoVien.TabIndex = 106;
            this.txtSearchGiaoVien.TextChanged += new System.EventHandler(this.txtSearchGiaoVien_TextChanged);
            // 
            // GiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 704);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchGiaoVien);
            this.Controls.Add(this.dgvListGiaoVien);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiaoVienForm";
            this.Text = "Giáo Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenGiaoVien;
        private Krypton.Toolkit.KryptonDataGridView dgvListGiaoVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveGiaoVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefeshGiaoVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditGiaoVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}