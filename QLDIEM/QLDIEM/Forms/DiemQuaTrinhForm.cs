using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Data;

namespace QLDIEM.Forms
{
    public partial class DiemQuaTrinhForm : XtraForm
    {
        private Connect connect;

        public DiemQuaTrinhForm()
        {
            InitializeComponent();
            connect = new Connect();
            comSearchMonHoc.DataSource = connect.DataTable($"SELECT MaMonHoc, TenMonHoc FROM MonHoc;");
            comSearchMonHoc.DisplayMember = "TenMonHoc";
            comSearchMonHoc.ValueMember = "MaMonHoc";
            comSearchMonHoc.SelectedIndex = -1;
            comSearchLopHoc.DataSource = connect.DataTable($"SELECT MaLop, TenLop FROM LopHoc;");
            comSearchLopHoc.DisplayMember = "TenLop";
            comSearchLopHoc.ValueMember = "MaLop";
            comSearchLopHoc.SelectedIndex = -1;
            btnUpdateDiem.Enabled = false;
        }

        private void comSearchMonHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           if (comSearchMonHoc.SelectedIndex != -1 && comSearchLopHoc.SelectedIndex != -1)
            {
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';") <= 0)
                {
                    if (connect.ExecuteScalar($"SELECT COUNT(*) FROM SinhVien WHERE SinhVien.MaLop = '{comSearchLopHoc.SelectedValue}';") > 0)
                    {
                        DataTable dataTable = connect.DataTable($"SELECT MaSV FROM SinhVien, LopHoc WHERE SinhVien.MaLop = LopHoc.MaLop AND LopHoc.MaLop = '{comSearchLopHoc.SelectedValue}';");
                        foreach (DataRow row in dataTable.Rows)
                        {
                            connect.ExecuteNonQuery($"INSERT INTO DiemSo(MaMonHoc, MaLop, MaSV) VALUES ('{comSearchMonHoc.SelectedValue}', '{comSearchLopHoc.SelectedValue}', '{row["MaSV"]}');");
                        }
                    }
                }
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, Diem15p, Diem45p1, Diem45p2, Diem45p3 FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
            }
        }

        private void comSearchLopHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comSearchMonHoc.SelectedIndex != -1 && comSearchLopHoc.SelectedIndex != -1)
            {
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';") <= 0)
                {
                    if (connect.ExecuteScalar($"SELECT COUNT(*) FROM SinhVien WHERE SinhVien.MaLop = '{comSearchLopHoc.SelectedValue}';") > 0)
                    {
                        DataTable dataTable = connect.DataTable($"SELECT MaSV FROM SinhVien, LopHoc WHERE SinhVien.MaLop = LopHoc.MaLop AND LopHoc.MaLop = '{comSearchLopHoc.SelectedValue}';");
                        foreach (DataRow row in dataTable.Rows)
                        {
                            connect.ExecuteNonQuery($"INSERT INTO DiemSo(MaMonHoc, MaLop, MaSV) VALUES ('{comSearchMonHoc.SelectedValue}', '{comSearchLopHoc.SelectedValue}', '{row["MaSV"]}');");
                        }
                    }
                }
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, Diem15p, Diem45p1, Diem45p2, Diem45p3 FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
            }
        }

        private void dgvListDiemSo_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            if (e.RowIndex >= 0)
            {
                txtMaSV.Text = dgvListDiemSo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvListDiemSo.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (dgvListDiemSo.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    numDiem15.Value = Convert.ToDecimal(dgvListDiemSo.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                if (dgvListDiemSo.Rows[e.RowIndex].Cells[3].Value.ToString() != "")
                {
                    numDiem45So1.Value = Convert.ToDecimal(dgvListDiemSo.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                if (dgvListDiemSo.Rows[e.RowIndex].Cells[4].Value.ToString() != "")
                {
                    numDiem45So2.Value = Convert.ToDecimal(dgvListDiemSo.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
                if (dgvListDiemSo.Rows[e.RowIndex].Cells[5].Value.ToString() != "")
                {
                    numDiem45So3.Value = Convert.ToDecimal(dgvListDiemSo.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
                btnUpdateDiem.Enabled = true;
            }
        }
        

        private void btnUpdateDiem_Click(object sender, System.EventArgs e)
        {
            connect.ExecuteNonQuery($"UPDATE DiemSo SET Diem15p = {numDiem15.Value}, Diem45p1 = {numDiem45So1.Value}, Diem45p2 = {numDiem45So2.Value}, Diem45p3 = {numDiem45So3.Value} WHERE MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND MaLop = '{comSearchLopHoc.SelectedValue}' AND MaSV = '{txtMaSV.Text}';");
            connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, Diem15p, Diem45p1, Diem45p2, Diem45p3 FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
        }
    }
}