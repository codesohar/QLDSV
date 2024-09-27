namespace QLDIEM.Forms
{
    partial class KetQuaHocTapForm
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
            this.comSearchLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comSearchMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListDiemSo = new Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemSo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comSearchLopHoc);
            this.groupBox1.Controls.Add(this.comSearchMonHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvListDiemSo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1372, 684);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả Học Tập";
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
            this.comSearchLopHoc.Location = new System.Drawing.Point(750, 83);
            this.comSearchLopHoc.Name = "comSearchLopHoc";
            this.comSearchLopHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchLopHoc.TabIndex = 127;
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
            this.comSearchMonHoc.Location = new System.Drawing.Point(391, 83);
            this.comSearchMonHoc.Name = "comSearchMonHoc";
            this.comSearchMonHoc.Size = new System.Drawing.Size(231, 36);
            this.comSearchMonHoc.TabIndex = 126;
            this.comSearchMonHoc.SelectedIndexChanged += new System.EventHandler(this.comSearchMonHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 125;
            this.label5.Text = "Chọn Mã Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 123;
            this.label2.Text = "Chọn Mã Lớp Học:";
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
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvListDiemSo.Location = new System.Drawing.Point(0, 124);
            this.dgvListDiemSo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListDiemSo.Name = "dgvListDiemSo";
            this.dgvListDiemSo.RowHeadersVisible = false;
            this.dgvListDiemSo.RowHeadersWidth = 51;
            this.dgvListDiemSo.RowTemplate.Height = 24;
            this.dgvListDiemSo.RowTemplate.ReadOnly = true;
            this.dgvListDiemSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDiemSo.Size = new System.Drawing.Size(1372, 554);
            this.dgvListDiemSo.TabIndex = 124;
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
            // Column7
            // 
            this.Column7.DataPropertyName = "DiemThi";
            this.Column7.HeaderText = "Điểm Thi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DiemTrungBinh";
            this.Column8.HeaderText = "Điểm Trung Bình";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // KetQuaHocTapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 704);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KetQuaHocTapForm";
            this.Text = "Kết Quả Học Tập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDiemSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchLopHoc;
        private Guna.UI2.WinForms.Guna2ComboBox comSearchMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonDataGridView dgvListDiemSo;
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