namespace QLDIEM.Forms
{
    partial class DiemThiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemThiForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListDiemSo = new Krypton.Toolkit.KryptonDataGridView();
            this.btnAddDiemThi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDiemThi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.comSearchLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comSearchMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemSo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Sinh Viên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(226, 94);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(231, 26);
            this.txtHoTen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Sinh Viên:";
            // 
            // dgvListDiemSo
            // 
            this.dgvListDiemSo.AllowUserToAddRows = false;
            this.dgvListDiemSo.AllowUserToDeleteRows = false;
            this.dgvListDiemSo.AllowUserToResizeColumns = false;
            this.dgvListDiemSo.AllowUserToResizeRows = false;
            this.dgvListDiemSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDiemSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDiemSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListDiemSo.Location = new System.Drawing.Point(2, 311);
            this.dgvListDiemSo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListDiemSo.Name = "dgvListDiemSo";
            this.dgvListDiemSo.RowHeadersVisible = false;
            this.dgvListDiemSo.RowHeadersWidth = 51;
            this.dgvListDiemSo.RowTemplate.Height = 24;
            this.dgvListDiemSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDiemSo.Size = new System.Drawing.Size(924, 386);
            this.dgvListDiemSo.TabIndex = 104;
            this.dgvListDiemSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDiemSo_CellClick);
            // 
            // btnAddDiemThi
            // 
            this.btnAddDiemThi.BorderRadius = 20;
            this.btnAddDiemThi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiemThi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiemThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDiemThi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDiemThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDiemThi.FillColor = System.Drawing.Color.Lime;
            this.btnAddDiemThi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddDiemThi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddDiemThi.ForeColor = System.Drawing.Color.Black;
            this.btnAddDiemThi.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDiemThi.Image")));
            this.btnAddDiemThi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddDiemThi.Location = new System.Drawing.Point(622, 66);
            this.btnAddDiemThi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddDiemThi.Name = "btnAddDiemThi";
            this.btnAddDiemThi.Size = new System.Drawing.Size(141, 72);
            this.btnAddDiemThi.TabIndex = 93;
            this.btnAddDiemThi.Text = "Cập Nhật Điểm Thi";
            this.btnAddDiemThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddDiemThi.Click += new System.EventHandler(this.btnAddDiemThi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm Thi:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(226, 48);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(231, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDiemThi);
            this.groupBox1.Controls.Add(this.btnAddDiemThi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(924, 193);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm Thi";
            // 
            // numDiemThi
            // 
            this.numDiemThi.BackColor = System.Drawing.Color.Transparent;
            this.numDiemThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDiemThi.DecimalPlaces = 2;
            this.numDiemThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDiemThi.Location = new System.Drawing.Point(226, 140);
            this.numDiemThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDiemThi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiemThi.Name = "numDiemThi";
            this.numDiemThi.Size = new System.Drawing.Size(231, 35);
            this.numDiemThi.TabIndex = 112;
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
            this.comSearchLopHoc.Location = new System.Drawing.Point(528, 253);
            this.comSearchLopHoc.Name = "comSearchLopHoc";
            this.comSearchLopHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchLopHoc.TabIndex = 120;
            this.comSearchLopHoc.SelectedIndexChanged += new System.EventHandler(this.comSearchLopHoc_SelectedIndexChanged);
            // 
            // comSearchMonHoc
            // 
            this.comSearchMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.comSearchMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comSearchMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSearchMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comSearchMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comSearchMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comSearchMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comSearchMonHoc.ItemHeight = 30;
            this.comSearchMonHoc.Location = new System.Drawing.Point(169, 253);
            this.comSearchMonHoc.Name = "comSearchMonHoc";
            this.comSearchMonHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchMonHoc.TabIndex = 119;
            this.comSearchMonHoc.SelectedIndexChanged += new System.EventHandler(this.comSearchMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Chọn Mã Môn Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Chọn Mã Lớp Học:";
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
            this.Column3.DataPropertyName = "DiemThi";
            this.Column3.HeaderText = "Điểm Thi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // DiemThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 704);
            this.Controls.Add(this.comSearchLopHoc);
            this.Controls.Add(this.comSearchMonHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvListDiemSo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiemThiForm";
            this.Text = "Điểm Thi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemSo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonDataGridView dgvListDiemSo;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddDiemThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiemThi;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchLopHoc;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}