namespace QLDIEM.Forms
{
    partial class DiemQuaTrinhForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemQuaTrinhForm));
            this.dgvListDiemSo = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.numDiem45So3 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numDiem45So2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numDiem45So1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numDiem15 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateDiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comSearchMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comSearchLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemSo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem45So3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem45So2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem45So1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem15)).BeginInit();
            this.SuspendLayout();
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
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvListDiemSo.Location = new System.Drawing.Point(14, 311);
            this.dgvListDiemSo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListDiemSo.Name = "dgvListDiemSo";
            this.dgvListDiemSo.RowHeadersVisible = false;
            this.dgvListDiemSo.RowHeadersWidth = 51;
            this.dgvListDiemSo.RowTemplate.Height = 24;
            this.dgvListDiemSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDiemSo.Size = new System.Drawing.Size(1372, 386);
            this.dgvListDiemSo.TabIndex = 112;
            this.dgvListDiemSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDiemSo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.numDiem45So3);
            this.groupBox1.Controls.Add(this.numDiem45So2);
            this.groupBox1.Controls.Add(this.numDiem45So1);
            this.groupBox1.Controls.Add(this.numDiem15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnUpdateDiem);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1372, 209);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm Quá Trình";
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(223, 46);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(231, 26);
            this.txtMaSV.TabIndex = 116;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(223, 95);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(231, 26);
            this.txtHoTen.TabIndex = 115;
            // 
            // numDiem45So3
            // 
            this.numDiem45So3.BackColor = System.Drawing.Color.Transparent;
            this.numDiem45So3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDiem45So3.DecimalPlaces = 2;
            this.numDiem45So3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDiem45So3.Location = new System.Drawing.Point(660, 137);
            this.numDiem45So3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDiem45So3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiem45So3.Name = "numDiem45So3";
            this.numDiem45So3.Size = new System.Drawing.Size(231, 35);
            this.numDiem45So3.TabIndex = 114;
            // 
            // numDiem45So2
            // 
            this.numDiem45So2.BackColor = System.Drawing.Color.Transparent;
            this.numDiem45So2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDiem45So2.DecimalPlaces = 2;
            this.numDiem45So2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDiem45So2.Location = new System.Drawing.Point(660, 83);
            this.numDiem45So2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDiem45So2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiem45So2.Name = "numDiem45So2";
            this.numDiem45So2.Size = new System.Drawing.Size(231, 35);
            this.numDiem45So2.TabIndex = 113;
            // 
            // numDiem45So1
            // 
            this.numDiem45So1.BackColor = System.Drawing.Color.Transparent;
            this.numDiem45So1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDiem45So1.DecimalPlaces = 2;
            this.numDiem45So1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDiem45So1.Location = new System.Drawing.Point(660, 37);
            this.numDiem45So1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDiem45So1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiem45So1.Name = "numDiem45So1";
            this.numDiem45So1.Size = new System.Drawing.Size(231, 35);
            this.numDiem45So1.TabIndex = 112;
            // 
            // numDiem15
            // 
            this.numDiem15.BackColor = System.Drawing.Color.Transparent;
            this.numDiem15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDiem15.DecimalPlaces = 2;
            this.numDiem15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDiem15.Location = new System.Drawing.Point(223, 137);
            this.numDiem15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDiem15.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiem15.Name = "numDiem15";
            this.numDiem15.Size = new System.Drawing.Size(231, 35);
            this.numDiem15.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Điểm 15\':";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "Tên Sinh Viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Mã Sinh Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Điểm 45\' Số 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Điểm 45\' Số 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(534, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Điểm 45\' Số 1:";
            // 
            // btnUpdateDiem
            // 
            this.btnUpdateDiem.BorderRadius = 20;
            this.btnUpdateDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDiem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDiem.FillColor = System.Drawing.Color.Lime;
            this.btnUpdateDiem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateDiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateDiem.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDiem.Image")));
            this.btnUpdateDiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateDiem.Location = new System.Drawing.Point(993, 95);
            this.btnUpdateDiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdateDiem.Name = "btnUpdateDiem";
            this.btnUpdateDiem.Size = new System.Drawing.Size(143, 64);
            this.btnUpdateDiem.TabIndex = 93;
            this.btnUpdateDiem.Text = "Cập Nhật Điểm";
            this.btnUpdateDiem.Click += new System.EventHandler(this.btnUpdateDiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Mã Lớp Học:";
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
            this.comSearchMonHoc.Location = new System.Drawing.Point(405, 270);
            this.comSearchMonHoc.Name = "comSearchMonHoc";
            this.comSearchMonHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchMonHoc.TabIndex = 114;
            this.comSearchMonHoc.SelectedIndexChanged += new System.EventHandler(this.comSearchMonHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Chọn Mã Môn Học:";
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
            this.comSearchLopHoc.Location = new System.Drawing.Point(764, 270);
            this.comSearchLopHoc.Name = "comSearchLopHoc";
            this.comSearchLopHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchLopHoc.TabIndex = 116;
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
            this.Column3.DataPropertyName = "Diem15p";
            this.Column3.HeaderText = "Điểm 15\'";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diem45p1";
            this.Column4.HeaderText = "Điểm 45\' Số 1";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Diem45p2";
            this.Column5.HeaderText = "Điểm 45\' Số 2";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Diem45p3";
            this.Column6.HeaderText = "Điểm 45\' Số 3";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // DiemQuaTrinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 704);
            this.Controls.Add(this.comSearchLopHoc);
            this.Controls.Add(this.comSearchMonHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListDiemSo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiemQuaTrinhForm";
            this.Text = "Điểm Quá Trình";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemSo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem45So3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem45So2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem45So1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dgvListDiemSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateDiem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiem45So3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiem45So2;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiem45So1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiem15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchMonHoc;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchLopHoc;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}