namespace QLDIEM.Forms
{
    partial class KhoaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoaForm));
            this.btnRemoveKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefeshKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.dgvListKhoa = new Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveKhoa
            // 
            this.btnRemoveKhoa.BorderRadius = 20;
            this.btnRemoveKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveKhoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveKhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveKhoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveKhoa.Image")));
            this.btnRemoveKhoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemoveKhoa.Location = new System.Drawing.Point(603, 140);
            this.btnRemoveKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveKhoa.Name = "btnRemoveKhoa";
            this.btnRemoveKhoa.Size = new System.Drawing.Size(110, 40);
            this.btnRemoveKhoa.TabIndex = 96;
            this.btnRemoveKhoa.Text = "Xoá";
            this.btnRemoveKhoa.Click += new System.EventHandler(this.btnRemoveKhoa_Click);
            // 
            // btnRefeshKhoa
            // 
            this.btnRefeshKhoa.BorderRadius = 20;
            this.btnRefeshKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshKhoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefeshKhoa.FillColor = System.Drawing.Color.Cyan;
            this.btnRefeshKhoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeshKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefeshKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnRefeshKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeshKhoa.Image")));
            this.btnRefeshKhoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefeshKhoa.Location = new System.Drawing.Point(439, 140);
            this.btnRefeshKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefeshKhoa.Name = "btnRefeshKhoa";
            this.btnRefeshKhoa.Size = new System.Drawing.Size(110, 40);
            this.btnRefeshKhoa.TabIndex = 95;
            this.btnRefeshKhoa.Text = "Làm Mới";
            this.btnRefeshKhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefeshKhoa.Click += new System.EventHandler(this.btnRefeshKhoa_Click);
            // 
            // btnEditKhoa
            // 
            this.btnEditKhoa.BorderRadius = 20;
            this.btnEditKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditKhoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditKhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditKhoa.FillColor2 = System.Drawing.Color.Yellow;
            this.btnEditKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnEditKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnEditKhoa.Image")));
            this.btnEditKhoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditKhoa.Location = new System.Drawing.Point(603, 80);
            this.btnEditKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditKhoa.Name = "btnEditKhoa";
            this.btnEditKhoa.Size = new System.Drawing.Size(110, 40);
            this.btnEditKhoa.TabIndex = 94;
            this.btnEditKhoa.Text = "Sửa";
            this.btnEditKhoa.Click += new System.EventHandler(this.btnEditKhoa_Click);
            // 
            // btnAddKhoa
            // 
            this.btnAddKhoa.BorderRadius = 20;
            this.btnAddKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddKhoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddKhoa.FillColor = System.Drawing.Color.Lime;
            this.btnAddKhoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnAddKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnAddKhoa.Image")));
            this.btnAddKhoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddKhoa.Location = new System.Drawing.Point(439, 80);
            this.btnAddKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddKhoa.Name = "btnAddKhoa";
            this.btnAddKhoa.Size = new System.Drawing.Size(110, 40);
            this.btnAddKhoa.TabIndex = 93;
            this.btnAddKhoa.Text = "Thêm";
            this.btnAddKhoa.Click += new System.EventHandler(this.btnAddKhoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "SĐT:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(141, 176);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(199, 23);
            this.txtSoDienThoai.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(141, 136);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(199, 23);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Khoa:";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Location = new System.Drawing.Point(141, 97);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(199, 23);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(141, 57);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(199, 23);
            this.txtMaKhoa.TabIndex = 5;
            // 
            // dgvListKhoa
            // 
            this.dgvListKhoa.AllowUserToAddRows = false;
            this.dgvListKhoa.AllowUserToDeleteRows = false;
            this.dgvListKhoa.AllowUserToResizeColumns = false;
            this.dgvListKhoa.AllowUserToResizeRows = false;
            this.dgvListKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListKhoa.Location = new System.Drawing.Point(2, 254);
            this.dgvListKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListKhoa.Name = "dgvListKhoa";
            this.dgvListKhoa.RowHeadersVisible = false;
            this.dgvListKhoa.RowHeadersWidth = 51;
            this.dgvListKhoa.RowTemplate.Height = 24;
            this.dgvListKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListKhoa.Size = new System.Drawing.Size(792, 314);
            this.dgvListKhoa.TabIndex = 100;
            this.dgvListKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListKhoa_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKhoa";
            this.Column1.HeaderText = "Mã Khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhoa";
            this.Column2.HeaderText = "Tên Khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoDienThoai";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveKhoa);
            this.groupBox1.Controls.Add(this.btnRefeshKhoa);
            this.groupBox1.Controls.Add(this.btnEditKhoa);
            this.groupBox1.Controls.Add(this.btnAddKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 241);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // KhoaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 572);
            this.Controls.Add(this.dgvListKhoa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhoaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveKhoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefeshKhoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditKhoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private Krypton.Toolkit.KryptonDataGridView dgvListKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}