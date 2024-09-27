using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class DiemThiForm : XtraForm
    {
        private Connect connect;

        public DiemThiForm()
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
            btnAddDiemThi.Enabled = false;
        }

        private void comSearchMonHoc_SelectedIndexChanged(object sender, EventArgs e)
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
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, DiemThi FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
            }
        }

        private void comSearchLopHoc_SelectedIndexChanged(object sender, EventArgs e)
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
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, DiemThi FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
            }
        }

        private void dgvListDiemSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSV.Text = dgvListDiemSo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvListDiemSo.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (dgvListDiemSo.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    numDiemThi.Value = Convert.ToDecimal(dgvListDiemSo.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                btnAddDiemThi.Enabled = true;
            }
        }

        private void btnAddDiemThi_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            float diemThiMoi = (float)numDiemThi.Value;
            if (diemThiMoi > 10 || diemThiMoi < 0)
            {
                MessageBox.Show("Điểm thi không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                connect.ExecuteNonQuery($"UPDATE DiemSo SET DiemThi = {diemThiMoi} WHERE MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND MaLop = '{comSearchLopHoc.SelectedValue}' AND MaSV = '{txtMaSV.Text}';");
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, DiemThi FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);

            }
        }
    }
}