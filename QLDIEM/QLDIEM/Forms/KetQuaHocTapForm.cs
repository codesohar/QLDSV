using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Data;

namespace QLDIEM.Forms
{
    public partial class KetQuaHocTapForm : XtraForm
    {
        private Connect connect;

        public KetQuaHocTapForm()
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
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, Diem15p, Diem45p1, Diem45p2, Diem45p3, DiemThi, ROUND((((Diem15p + (Diem45p1 + Diem45p2 + Diem45p3) * 2) / 7) * 0.4 + DiemThi * 0.6), 2) AS DiemTrungBinh FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
            }
        }

        private void comSearchLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSearchMonHoc.SelectedIndex != -1 && comSearchLopHoc.SelectedIndex != -1)
            {
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue} ';") <= 0)
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
                connect.QueryData($"SELECT SinhVien.MaSV, SinhVien.HoTen, Diem15p, Diem45p1, Diem45p2, Diem45p3, DiemThi, ROUND((((Diem15p + (Diem45p1 + Diem45p2 + Diem45p3) * 2) / 7) * 0.4 + DiemThi * 0.6), 2) AS DiemTrungBinh FROM DiemSo, MonHoc, LopHoc, SinhVien WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND DiemSo.MaLop = LopHoc.MaLop AND DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = '{comSearchMonHoc.SelectedValue}' AND DiemSo.MaLop = '{comSearchLopHoc.SelectedValue}';", dgvListDiemSo);
            }
        }
    }
}