using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class DiemDanhForm : XtraForm
    {
        private Connect connect;
        public DiemDanhForm()
        {
            InitializeComponent();
            connect = new Connect();
            dateNgayDiemDanh.Value = DateTime.Now;
            comSearchLopHoc.DataSource = connect.DataTable($"SELECT MaLop, TenLop FROM LopHoc;");
            comSearchLopHoc.DisplayMember = "TenLop";
            comSearchLopHoc.ValueMember = "MaLop";
            comSearchLopHoc.SelectedIndex = -1;
        }

        private void btnCapNhatDiemDanh_Click(object sender, EventArgs e)
        {
            if (comSearchLopHoc.Text == "")
            {
                MessageBox.Show("Mời bạn chọn lớp học!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dataTable = connect.DataTable($"SELECT MaSV FROM SinhVien, LopHoc WHERE SinhVien.MaLop = LopHoc.MaLop AND LopHoc.MaLop = '{comSearchLopHoc.SelectedValue}';");
            foreach (DataRow row in dataTable.Rows)
            {
                connect.ExecuteNonQuery($"INSERT INTO DiemDanh(DiemDanh.MaLop, DiemDanh.MaSV, NgayDiemDanh) VALUES ('{comSearchLopHoc.SelectedValue}', '{row["MaSV"]}', '{dateNgayDiemDanh.Value.ToString("yyyy-MM-dd")}');");
            }
            connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.GioiTinh, SinhVien.NgaySinh, DiemDanh.CoPhep, DiemDanh.KhongPhep FROM DiemDanh, SinhVien WHERE DiemDanh.MaSV = SinhVien.MaSV AND DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND NgayDiemDanh = '{dateNgayDiemDanh.Value.ToString("yyyy-MM-dd")}';", dgvListDiemDanh);
            btnCapNhatDiemDanh.Enabled = false;
        }

        private void dateNgayDiemDanh_ValueChanged(object sender, EventArgs e)
        {
            connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.GioiTinh, SinhVien.NgaySinh, DiemDanh.CoPhep, DiemDanh.KhongPhep FROM DiemDanh, SinhVien WHERE DiemDanh.MaSV = SinhVien.MaSV AND DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND NgayDiemDanh = '{dateNgayDiemDanh.Value.ToString("yyyy-MM-dd")}';", dgvListDiemDanh);
            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemDanh, SinhVien WHERE DiemDanh.MaSV = SinhVien.MaSV AND DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND NgayDiemDanh = '{dateNgayDiemDanh.Value.ToString("yyyy-MM-dd")}';") <= 0)
            {
                btnCapNhatDiemDanh.Enabled = true;
            }
            else
            {
                btnCapNhatDiemDanh.Enabled = false;
            }
        }

        private void comSearchLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.GioiTinh, SinhVien.NgaySinh, DiemDanh.CoPhep, DiemDanh.KhongPhep FROM DiemDanh, SinhVien WHERE DiemDanh.MaSV = SinhVien.MaSV AND DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND NgayDiemDanh = '{dateNgayDiemDanh.Value.ToString("yyyy-MM-dd")}';", dgvListDiemDanh);
            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemDanh, SinhVien WHERE DiemDanh.MaSV = SinhVien.MaSV AND DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND NgayDiemDanh = '{dateNgayDiemDanh.Value.ToString("yyyy-MM-dd")}';") <= 0)
            {
                btnCapNhatDiemDanh.Enabled = true;
            }
            else
            {
                btnCapNhatDiemDanh.Enabled = false;
            }
        }

        private void dgvListDiemDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvListDiemDanh.Columns["checkCoPhep"].Index)
            {
                if ((int)dgvListDiemDanh.Rows[e.RowIndex].Cells[4].Value == 0)
                {
                    connect.ExecuteNonQuery($"UPDATE DiemDanh SET CoPhep = 1 WHERE DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND DiemDanh.MaSV = '{dgvListDiemDanh.Rows[e.RowIndex].Cells[0].Value}';");
                }
                else if (true)
                {
                    connect.ExecuteNonQuery($"UPDATE DiemDanh SET CoPhep = 0 WHERE DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND DiemDanh.MaSV = '{dgvListDiemDanh.Rows[e.RowIndex].Cells[0].Value}';");
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvListDiemDanh.Columns["checkKhongPhep"].Index)
            {
                if ((int)dgvListDiemDanh.Rows[e.RowIndex].Cells[5].Value == 0) connect.ExecuteNonQuery($"UPDATE DiemDanh SET KhongPhep = 1 WHERE DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND DiemDanh.MaSV = '{dgvListDiemDanh.Rows[e.RowIndex].Cells[0].Value}';");
                else connect.ExecuteNonQuery($"UPDATE DiemDanh SET KhongPhep = 0 WHERE DiemDanh.MaLop = '{comSearchLopHoc.SelectedValue}' AND DiemDanh.MaSV = '{dgvListDiemDanh.Rows[e.RowIndex].Cells[0].Value}';");
            }
        }
    }
}