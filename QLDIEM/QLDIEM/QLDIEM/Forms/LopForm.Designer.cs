namespace QLDIEM.Forms
{
    partial class LopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LopForm));
            this.dgvListLopHoc = new Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveLopHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefeshLopHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditLopHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddLopHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchLopHoc = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaChuyenNganh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLopHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListLopHoc
            // 
            this.dgvListLopHoc.AllowUserToAddRows = false;
            this.dgvListLopHoc.AllowUserToDeleteRows = false;
            this.dgvListLopHoc.AllowUserToResizeColumns = false;
            this.dgvListLopHoc.AllowUserToResizeRows = false;
            this.dgvListLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvListLopHoc.Location = new System.Drawing.Point(14, 311);
            this.dgvListLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListLopHoc.Name = "dgvListLopHoc";
            this.dgvListLopHoc.RowHeadersVisible = false;
            this.dgvListLopHoc.RowHeadersWidth = 51;
            this.dgvListLopHoc.RowTemplate.Height = 24;
            this.dgvListLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListLopHoc.Size = new System.Drawing.Size(1372, 386);
            this.dgvListLopHoc.TabIndex = 108;
            this.dgvListLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListLopHoc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLop";
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaKhoa";
            this.Column3.HeaderText = "Mã Khoa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaChuyenNganh";
            this.Column4.HeaderText = "Mã Chuyên Ngành";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaGV";
            this.Column5.HeaderText = "Mã GV";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HoTen";
            this.Column6.HeaderText = "Tên GV Chủ Nhiệm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnRemoveLopHoc
            // 
            this.btnRemoveLopHoc.BorderRadius = 20;
            this.btnRemoveLopHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveLopHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveLopHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveLopHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveLopHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveLopHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveLopHoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveLopHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveLopHoc.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveLopHoc.Image")));
            this.btnRemoveLopHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemoveLopHoc.Location = new System.Drawing.Point(934, 160);
            this.btnRemoveLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemoveLopHoc.Name = "btnRemoveLopHoc";
            this.btnRemoveLopHoc.Size = new System.Drawing.Size(128, 49);
            this.btnRemoveLopHoc.TabIndex = 96;
            this.btnRemoveLopHoc.Text = "Xoá";
            this.btnRemoveLopHoc.Click += new System.EventHandler(this.btnRemoveLopHoc_Click);
            // 
            // btnRefeshLopHoc
            // 
            this.btnRefeshLopHoc.BorderRadius = 20;
            this.btnRefeshLopHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshLopHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshLopHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshLopHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshLopHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefeshLopHoc.FillColor = System.Drawing.Color.Cyan;
            this.btnRefeshLopHoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeshLopHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefeshLopHoc.ForeColor = System.Drawing.Color.Black;
            this.btnRefeshLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeshLopHoc.Image")));
            this.btnRefeshLopHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefeshLopHoc.Location = new System.Drawing.Point(514, 160);
            this.btnRefeshLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefeshLopHoc.Name = "btnRefeshLopHoc";
            this.btnRefeshLopHoc.Size = new System.Drawing.Size(128, 49);
            this.btnRefeshLopHoc.TabIndex = 95;
            this.btnRefeshLopHoc.Text = "Làm Mới";
            this.btnRefeshLopHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefeshLopHoc.Click += new System.EventHandler(this.btnRefeshLopHoc_Click);
            // 
            // btnEditLopHoc
            // 
            this.btnEditLopHoc.BorderRadius = 20;
            this.btnEditLopHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditLopHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditLopHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditLopHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditLopHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditLopHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditLopHoc.FillColor2 = System.Drawing.Color.Yellow;
            this.btnEditLopHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditLopHoc.ForeColor = System.Drawing.Color.Black;
            this.btnEditLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditLopHoc.Image")));
            this.btnEditLopHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditLopHoc.Location = new System.Drawing.Point(726, 160);
            this.btnEditLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditLopHoc.Name = "btnEditLopHoc";
            this.btnEditLopHoc.Size = new System.Drawing.Size(128, 49);
            this.btnEditLopHoc.TabIndex = 94;
            this.btnEditLopHoc.Text = "Sửa";
            this.btnEditLopHoc.Click += new System.EventHandler(this.btnEditLopHoc_Click);
            // 
            // btnAddLopHoc
            // 
            this.btnAddLopHoc.BorderRadius = 20;
            this.btnAddLopHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLopHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLopHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddLopHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddLopHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddLopHoc.FillColor = System.Drawing.Color.Lime;
            this.btnAddLopHoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddLopHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddLopHoc.ForeColor = System.Drawing.Color.Black;
            this.btnAddLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLopHoc.Image")));
            this.btnAddLopHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddLopHoc.Location = new System.Drawing.Point(310, 160);
            this.btnAddLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddLopHoc.Name = "btnAddLopHoc";
            this.btnAddLopHoc.Size = new System.Drawing.Size(128, 49);
            this.btnAddLopHoc.TabIndex = 93;
            this.btnAddLopHoc.Text = "Thêm";
            this.btnAddLopHoc.Click += new System.EventHandler(this.btnAddLopHoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Chuyên Ngành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txtSearchLopHoc
            // 
            this.txtSearchLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLopHoc.Location = new System.Drawing.Point(584, 277);
            this.txtSearchLopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchLopHoc.Name = "txtSearchLopHoc";
            this.txtSearchLopHoc.Size = new System.Drawing.Size(231, 26);
            this.txtSearchLopHoc.TabIndex = 106;
            this.txtSearchLopHoc.TextChanged += new System.EventHandler(this.txtSearchLopHoc_TextChanged);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(630, 52);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(231, 26);
            this.txtMaKhoa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Lớp Học:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(195, 101);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(231, 26);
            this.txtTenLop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(195, 52);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(231, 26);
            this.txtMaLop.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaGiaoVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaChuyenNganh);
            this.groupBox1.Controls.Add(this.btnRemoveLopHoc);
            this.groupBox1.Controls.Add(this.btnRefeshLopHoc);
            this.groupBox1.Controls.Add(this.btnEditLopHoc);
            this.groupBox1.Controls.Add(this.btnAddLopHoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1372, 231);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học";
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiaoVien.Location = new System.Drawing.Point(1076, 52);
            this.txtMaGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(231, 26);
            this.txtMaGiaoVien.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(908, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "MãGV Chủ Nhiệm:";
            // 
            // txtMaChuyenNganh
            // 
            this.txtMaChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyenNganh.Location = new System.Drawing.Point(630, 97);
            this.txtMaChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenNganh.Name = "txtMaChuyenNganh";
            this.txtMaChuyenNganh.Size = new System.Drawing.Size(231, 26);
            this.txtMaChuyenNganh.TabIndex = 97;
            // 
            // LopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 704);
            this.Controls.Add(this.dgvListLopHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchLopHoc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LopForm";
            this.Text = "Lớp ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLopHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvListLopHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveLopHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefeshLopHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditLopHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddLopHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchLopHoc;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}