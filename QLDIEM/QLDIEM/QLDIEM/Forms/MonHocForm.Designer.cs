namespace QLDIEM.Forms
{
    partial class MonHocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocForm));
            this.txtMaChuyenNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.dgvListMonHoc = new Krypton.Toolkit.KryptonDataGridView();
            this.btnRemoveMonHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefeshMonHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditMonHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddMonHoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numSoTinChi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchMonHoc = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaChuyenNganh
            // 
            this.txtMaChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyenNganh.Location = new System.Drawing.Point(630, 52);
            this.txtMaChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenNganh.Name = "txtMaChuyenNganh";
            this.txtMaChuyenNganh.Size = new System.Drawing.Size(231, 26);
            this.txtMaChuyenNganh.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Môn Học:";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(195, 101);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(231, 26);
            this.txtTenMonHoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Môn Học:";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(195, 52);
            this.txtMaMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(231, 26);
            this.txtMaMonHoc.TabIndex = 5;
            // 
            // dgvListMonHoc
            // 
            this.dgvListMonHoc.AllowUserToAddRows = false;
            this.dgvListMonHoc.AllowUserToDeleteRows = false;
            this.dgvListMonHoc.AllowUserToResizeColumns = false;
            this.dgvListMonHoc.AllowUserToResizeRows = false;
            this.dgvListMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListMonHoc.Location = new System.Drawing.Point(2, 311);
            this.dgvListMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListMonHoc.Name = "dgvListMonHoc";
            this.dgvListMonHoc.RowHeadersVisible = false;
            this.dgvListMonHoc.RowHeadersWidth = 51;
            this.dgvListMonHoc.RowTemplate.Height = 24;
            this.dgvListMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMonHoc.Size = new System.Drawing.Size(924, 386);
            this.dgvListMonHoc.TabIndex = 104;
            this.dgvListMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMonHoc_CellClick);
            // 
            // btnRemoveMonHoc
            // 
            this.btnRemoveMonHoc.BorderRadius = 20;
            this.btnRemoveMonHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveMonHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveMonHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveMonHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveMonHoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveMonHoc.Image")));
            this.btnRemoveMonHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemoveMonHoc.Location = new System.Drawing.Point(700, 160);
            this.btnRemoveMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemoveMonHoc.Name = "btnRemoveMonHoc";
            this.btnRemoveMonHoc.Size = new System.Drawing.Size(128, 49);
            this.btnRemoveMonHoc.TabIndex = 96;
            this.btnRemoveMonHoc.Text = "Xoá";
            this.btnRemoveMonHoc.Click += new System.EventHandler(this.btnRemoveMonHoc_Click);
            // 
            // btnRefeshMonHoc
            // 
            this.btnRefeshMonHoc.BorderRadius = 20;
            this.btnRefeshMonHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshMonHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefeshMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshMonHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefeshMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefeshMonHoc.FillColor = System.Drawing.Color.Cyan;
            this.btnRefeshMonHoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeshMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefeshMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnRefeshMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnRefeshMonHoc.Image")));
            this.btnRefeshMonHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefeshMonHoc.Location = new System.Drawing.Point(280, 160);
            this.btnRefeshMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefeshMonHoc.Name = "btnRefeshMonHoc";
            this.btnRefeshMonHoc.Size = new System.Drawing.Size(128, 49);
            this.btnRefeshMonHoc.TabIndex = 95;
            this.btnRefeshMonHoc.Text = "Làm Mới";
            this.btnRefeshMonHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefeshMonHoc.Click += new System.EventHandler(this.btnRefeshMonHoc_Click);
            // 
            // btnEditMonHoc
            // 
            this.btnEditMonHoc.BorderRadius = 20;
            this.btnEditMonHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditMonHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditMonHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditMonHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditMonHoc.FillColor2 = System.Drawing.Color.Yellow;
            this.btnEditMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnEditMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMonHoc.Image")));
            this.btnEditMonHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditMonHoc.Location = new System.Drawing.Point(491, 160);
            this.btnEditMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditMonHoc.Name = "btnEditMonHoc";
            this.btnEditMonHoc.Size = new System.Drawing.Size(128, 49);
            this.btnEditMonHoc.TabIndex = 94;
            this.btnEditMonHoc.Text = "Sửa";
            this.btnEditMonHoc.Click += new System.EventHandler(this.btnEditMonHoc_Click);
            // 
            // btnAddMonHoc
            // 
            this.btnAddMonHoc.BorderRadius = 20;
            this.btnAddMonHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMonHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMonHoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMonHoc.FillColor = System.Drawing.Color.Lime;
            this.btnAddMonHoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnAddMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMonHoc.Image")));
            this.btnAddMonHoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddMonHoc.Location = new System.Drawing.Point(76, 160);
            this.btnAddMonHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddMonHoc.Name = "btnAddMonHoc";
            this.btnAddMonHoc.Size = new System.Drawing.Size(128, 49);
            this.btnAddMonHoc.TabIndex = 93;
            this.btnAddMonHoc.Text = "Thêm";
            this.btnAddMonHoc.Click += new System.EventHandler(this.btnAddMonHoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Tín Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Chuyên Ngành:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSoTinChi);
            this.groupBox1.Controls.Add(this.btnRemoveMonHoc);
            this.groupBox1.Controls.Add(this.btnRefeshMonHoc);
            this.groupBox1.Controls.Add(this.btnEditMonHoc);
            this.groupBox1.Controls.Add(this.btnAddMonHoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaChuyenNganh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaMonHoc);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(924, 231);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Môn Học";
            // 
            // numSoTinChi
            // 
            this.numSoTinChi.BackColor = System.Drawing.Color.Transparent;
            this.numSoTinChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoTinChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoTinChi.Location = new System.Drawing.Point(630, 97);
            this.numSoTinChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoTinChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTinChi.Name = "numSoTinChi";
            this.numSoTinChi.Size = new System.Drawing.Size(232, 28);
            this.numSoTinChi.TabIndex = 98;
            this.numSoTinChi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txtSearchMonHoc
            // 
            this.txtSearchMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMonHoc.Location = new System.Drawing.Point(349, 277);
            this.txtSearchMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchMonHoc.Name = "txtSearchMonHoc";
            this.txtSearchMonHoc.Size = new System.Drawing.Size(231, 26);
            this.txtSearchMonHoc.TabIndex = 100;
            this.txtSearchMonHoc.TextChanged += new System.EventHandler(this.txtSearchMonHoc_TextChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMonHoc";
            this.Column1.HeaderText = "Mã Môn Học";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMonHoc";
            this.Column2.HeaderText = "Tên Môn Học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoTinChi";
            this.Column3.HeaderText = "Số Tín Chỉ";
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
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListMonHoc);
            this.Controls.Add(this.txtSearchMonHoc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonHocForm";
            this.Text = "Môn Học";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaChuyenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private Krypton.Toolkit.KryptonDataGridView dgvListMonHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveMonHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefeshMonHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditMonHoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoTinChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}