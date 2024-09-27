namespace QLDIEM.Forms
{
    partial class SinhVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVienForm));
            this.txtSearchSinhVien = new System.Windows.Forms.TextBox();
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
            this.btnRemoveSinhVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefeshSinhVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditSinhVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddSinhVien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListSinhVien = new Krypton.Toolkit.KryptonDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenSinhVien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchSinhVien
            // 
            this.txtSearchSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSinhVien.Location = new System.Drawing.Point(584, 277);
            this.txtSearchSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSinhVien.Name = "txtSearchSinhVien";
            this.txtSearchSinhVien.Size = new System.Drawing.Size(231, 26);
            this.txtSearchSinhVien.TabIndex = 110;
            this.txtSearchSinhVien.TextChanged += new System.EventHandler(this.txtSearchSinhVien_TextChanged);
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
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Mã Lớp:";
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
            this.label8.TabIndex = 109;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // btnRemoveSinhVien
            // 
            this.btnRemoveSinhVien.BorderRadius = 20;
            this.btnRemoveSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveSinhVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveSinhVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveSinhVien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSinhVien.Image")));
            this.btnRemoveSinhVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemoveSinhVien.Location = new System.Drawing.Point(1182, 146);
            this.btnRemoveSinhVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemoveSinhVien.Name = "btnRemoveSinhVien";
            this.btnRemoveSinhVien.Size = new System.Drawing.Size(128, 49);
            this.btnRemoveSinhVien.TabIndex = 96;
            this.btnRemoveSinhVien.Text = "Xoá";
            this.btnRemoveSinhVien.Click += new System.EventHandler(this.btnRemoveSinhVien_Click);
            // 
            // btnRefeshSinhVien
            // 
            this.btnRefeshSinhVien.BorderRadius = 20;
            this.btnRefeshSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshSinhVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefeshSinhVien.FillColor = System.Drawing.Color.Cyan;
            this.btnRefeshSinhVien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeshSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefeshSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnRefeshSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeshSinhVien.Image")));
            this.btnRefeshSinhVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefeshSinhVien.Location = new System.Drawing.Point(990, 146);
            this.btnRefeshSinhVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefeshSinhVien.Name = "btnRefeshSinhVien";
            this.btnRefeshSinhVien.Size = new System.Drawing.Size(128, 49);
            this.btnRefeshSinhVien.TabIndex = 95;
            this.btnRefeshSinhVien.Text = "Làm Mới";
            this.btnRefeshSinhVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefeshSinhVien.Click += new System.EventHandler(this.btnRefeshSinhVien_Click);
            // 
            // btnEditSinhVien
            // 
            this.btnEditSinhVien.BorderRadius = 20;
            this.btnEditSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditSinhVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditSinhVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditSinhVien.FillColor2 = System.Drawing.Color.Yellow;
            this.btnEditSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnEditSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSinhVien.Image")));
            this.btnEditSinhVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditSinhVien.Location = new System.Drawing.Point(1182, 73);
            this.btnEditSinhVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditSinhVien.Name = "btnEditSinhVien";
            this.btnEditSinhVien.Size = new System.Drawing.Size(128, 49);
            this.btnEditSinhVien.TabIndex = 94;
            this.btnEditSinhVien.Text = "Sửa";
            this.btnEditSinhVien.Click += new System.EventHandler(this.btnEditSinhVien_Click);
            // 
            // btnAddSinhVien
            // 
            this.btnAddSinhVien.BorderRadius = 20;
            this.btnAddSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSinhVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSinhVien.FillColor = System.Drawing.Color.Lime;
            this.btnAddSinhVien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnAddSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSinhVien.Image")));
            this.btnAddSinhVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddSinhVien.Location = new System.Drawing.Point(990, 73);
            this.btnAddSinhVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddSinhVien.Name = "btnAddSinhVien";
            this.btnAddSinhVien.Size = new System.Drawing.Size(128, 49);
            this.btnAddSinhVien.TabIndex = 93;
            this.btnAddSinhVien.Text = "Thêm";
            this.btnAddSinhVien.Click += new System.EventHandler(this.btnAddSinhVien_Click);
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
            // dgvListSinhVien
            // 
            this.dgvListSinhVien.AllowUserToAddRows = false;
            this.dgvListSinhVien.AllowUserToDeleteRows = false;
            this.dgvListSinhVien.AllowUserToResizeColumns = false;
            this.dgvListSinhVien.AllowUserToResizeRows = false;
            this.dgvListSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvListSinhVien.Location = new System.Drawing.Point(14, 311);
            this.dgvListSinhVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListSinhVien.Name = "dgvListSinhVien";
            this.dgvListSinhVien.RowHeadersVisible = false;
            this.dgvListSinhVien.RowHeadersWidth = 51;
            this.dgvListSinhVien.RowTemplate.Height = 24;
            this.dgvListSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSinhVien.Size = new System.Drawing.Size(1372, 386);
            this.dgvListSinhVien.TabIndex = 108;
            this.dgvListSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSinhVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Tên Sinh Viên:";
            // 
            // txtHoTenSinhVien
            // 
            this.txtHoTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenSinhVien.Location = new System.Drawing.Point(230, 94);
            this.txtHoTenSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenSinhVien.Name = "txtHoTenSinhVien";
            this.txtHoTenSinhVien.Size = new System.Drawing.Size(231, 26);
            this.txtHoTenSinhVien.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.comGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnRemoveSinhVien);
            this.groupBox1.Controls.Add(this.btnRefeshSinhVien);
            this.groupBox1.Controls.Add(this.btnEditSinhVien);
            this.groupBox1.Controls.Add(this.btnAddSinhVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTenSinhVien);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1372, 244);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSV";
            this.Column1.HeaderText = "Mã Sinh Viên";
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
            this.Column8.DataPropertyName = "MaLop";
            this.Column8.HeaderText = "Mã Lớp";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(230, 45);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(231, 26);
            this.txtMaLop.TabIndex = 106;
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 704);
            this.Controls.Add(this.txtSearchSinhVien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListSinhVien);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinhVienForm";
            this.Text = "Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchSinhVien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgaySinh;
        private Guna.UI2.WinForms.Guna2ComboBox comGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveSinhVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefeshSinhVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditSinhVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonDataGridView dgvListSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtMaLop;
    }
}