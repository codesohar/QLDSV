namespace QLDIEM.Forms
{
    partial class DiemDanhForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemDanhForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListDiemDanh = new Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayDiemDanh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCapNhatDiemDanh = new Guna.UI2.WinForms.Guna2Button();
            this.comSearchLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCoPhep = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkKhongPhep = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comSearchLopHoc);
            this.groupBox1.Controls.Add(this.btnCapNhatDiemDanh);
            this.groupBox1.Controls.Add(this.dateNgayDiemDanh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvListDiemDanh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(924, 691);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Điểm Danh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm Kiếm Lớp Học:";
            // 
            // dgvListDiemDanh
            // 
            this.dgvListDiemDanh.AllowUserToAddRows = false;
            this.dgvListDiemDanh.AllowUserToDeleteRows = false;
            this.dgvListDiemDanh.AllowUserToResizeColumns = false;
            this.dgvListDiemDanh.AllowUserToResizeRows = false;
            this.dgvListDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.checkCoPhep,
            this.checkKhongPhep});
            this.dgvListDiemDanh.Location = new System.Drawing.Point(0, 250);
            this.dgvListDiemDanh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListDiemDanh.Name = "dgvListDiemDanh";
            this.dgvListDiemDanh.RowHeadersVisible = false;
            this.dgvListDiemDanh.RowHeadersWidth = 51;
            this.dgvListDiemDanh.RowTemplate.Height = 24;
            this.dgvListDiemDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDiemDanh.Size = new System.Drawing.Size(924, 435);
            this.dgvListDiemDanh.TabIndex = 103;
            this.dgvListDiemDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDiemDanh_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Ngày Điểm Danh:";
            // 
            // dateNgayDiemDanh
            // 
            this.dateNgayDiemDanh.Checked = true;
            this.dateNgayDiemDanh.CustomFormat = "dd/MM/yyyy";
            this.dateNgayDiemDanh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateNgayDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDiemDanh.Location = new System.Drawing.Point(421, 65);
            this.dateNgayDiemDanh.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayDiemDanh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayDiemDanh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayDiemDanh.Name = "dateNgayDiemDanh";
            this.dateNgayDiemDanh.Size = new System.Drawing.Size(231, 28);
            this.dateNgayDiemDanh.TabIndex = 106;
            this.dateNgayDiemDanh.Value = new System.DateTime(2023, 4, 24, 11, 23, 21, 983);
            this.dateNgayDiemDanh.ValueChanged += new System.EventHandler(this.dateNgayDiemDanh_ValueChanged);
            // 
            // btnCapNhatDiemDanh
            // 
            this.btnCapNhatDiemDanh.BorderRadius = 20;
            this.btnCapNhatDiemDanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatDiemDanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatDiemDanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatDiemDanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatDiemDanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCapNhatDiemDanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhatDiemDanh.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatDiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatDiemDanh.Image")));
            this.btnCapNhatDiemDanh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapNhatDiemDanh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCapNhatDiemDanh.Location = new System.Drawing.Point(361, 175);
            this.btnCapNhatDiemDanh.Name = "btnCapNhatDiemDanh";
            this.btnCapNhatDiemDanh.Size = new System.Drawing.Size(202, 45);
            this.btnCapNhatDiemDanh.TabIndex = 107;
            this.btnCapNhatDiemDanh.Text = "Cập Nhật Điểm Danh";
            this.btnCapNhatDiemDanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCapNhatDiemDanh.Click += new System.EventHandler(this.btnCapNhatDiemDanh_Click);
            // 
            // comSearchLopHoc
            // 
            this.comSearchLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.comSearchLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comSearchLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSearchLopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comSearchLopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comSearchLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comSearchLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comSearchLopHoc.ItemHeight = 30;
            this.comSearchLopHoc.Location = new System.Drawing.Point(421, 106);
            this.comSearchLopHoc.Name = "comSearchLopHoc";
            this.comSearchLopHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchLopHoc.TabIndex = 108;
            this.comSearchLopHoc.SelectedIndexChanged += new System.EventHandler(this.comSearchLopHoc_SelectedIndexChanged);
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
            this.Column2.HeaderText = "Tên Sinh Viên";
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
            // checkCoPhep
            // 
            this.checkCoPhep.DataPropertyName = "CoPhep";
            this.checkCoPhep.FalseValue = "0";
            this.checkCoPhep.HeaderText = "Có Phép";
            this.checkCoPhep.MinimumWidth = 6;
            this.checkCoPhep.Name = "checkCoPhep";
            this.checkCoPhep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkCoPhep.TrueValue = "1";
            // 
            // checkKhongPhep
            // 
            this.checkKhongPhep.DataPropertyName = "KhongPhep";
            this.checkKhongPhep.FalseValue = "0";
            this.checkKhongPhep.HeaderText = "Không Phép";
            this.checkKhongPhep.MinimumWidth = 6;
            this.checkKhongPhep.Name = "checkKhongPhep";
            this.checkKhongPhep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkKhongPhep.TrueValue = "1";
            // 
            // DiemDanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 704);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiemDanhForm";
            this.Text = "Thông Tin Điểm Danh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonDataGridView dgvListDiemDanh;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayDiemDanh;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatDiemDanh;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCoPhep;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkKhongPhep;
    }
}