using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class LopForm : XtraForm
    {
        private Connect connect;

        public LopForm()
        {
            InitializeComponent();
            connect = new Connect();
            btnEditLopHoc.Enabled = false;
            btnRemoveLopHoc.Enabled = false;
            connect.QueryData("SELECT LopHoc.*, GiaoVien.HoTen FROM LopHoc, GiaoVien WHERE LopHoc.MaGV = GiaoVien.MaGV;", dgvListLopHoc);
        }

        private void btnAddLopHoc_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaLop.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenLop.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaGiaoVien.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp học không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM LopHoc WHERE MaLop = '{txtMaLop.Text}';") > 0)
            {
                MessageBox.Show("Mã lớp học đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") <= 0)
            {
                MessageBox.Show("Mã khoa chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM ChuyenNganh WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}';") <= 0)
            {
                MessageBox.Show("Mã chuyên ngành chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM GiaoVien WHERE MaGV = '{txtMaGiaoVien.Text}';") <= 0)
            {
                MessageBox.Show("Mã giáo viên chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connect.ExecuteNonQuery($"INSERT INTO LopHoc VALUES ('{txtMaLop.Text}', N'{txtTenLop.Text}', '{txtMaKhoa.Text}', '{txtMaChuyenNganh.Text}', '{txtMaGiaoVien.Text}');");
            MessageBox.Show("Thêm thành công vào Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefeshLopHoc_Click(sender, e);
        }

        private void btnRefeshLopHoc_Click(object sender, EventArgs e)
        {
            txtMaLop.Enabled = true;
            btnAddLopHoc.Enabled = true;
            btnEditLopHoc.Enabled = false;
            btnRemoveLopHoc.Enabled = false;
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Clear();
            txtMaChuyenNganh.Clear();
            txtMaGiaoVien.Clear();
            connect.QueryData("SELECT LopHoc.*, GiaoVien.HoTen FROM LopHoc, GiaoVien WHERE LopHoc.MaGV = GiaoVien.MaGV;", dgvListLopHoc);
        }

        private void btnEditLopHoc_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaLop.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenLop.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaGiaoVien.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") <= 0)
            {
                MessageBox.Show("Mã khoa chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM ChuyenNganh WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}';") <= 0)
            {
                MessageBox.Show("Mã chuyên ngành chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM GiaoVien WHERE MaGV = '{txtMaGiaoVien.Text}';") <= 0)
            {
                MessageBox.Show("Mã giáo viên chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"UPDATE LopHoc SET TenLop = N'{txtTenLop.Text}', MaKhoa = '{txtMaKhoa.Text}', MaChuyenNganh = '{txtMaChuyenNganh.Text}', MaGV = '{txtMaGiaoVien.Text}' WHERE MaLop = '{txtMaLop.Text}';");
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefeshLopHoc_Click(sender, e);
        }

        private void btnRemoveLopHoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"DELETE FROM LopHoc WHERE MaLop = '{txtMaLop.Text}';");
                MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefeshLopHoc_Click(sender, e);
            }
            else
            {
                btnRefeshLopHoc_Click(sender, e);
            }
        }

        private void txtSearchLopHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLop.Text = dgvListLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLop.Text = dgvListLopHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaKhoa.Text = dgvListLopHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaChuyenNganh.Text = dgvListLopHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaGiaoVien.Text = dgvListLopHoc.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnAddLopHoc.Enabled = false;
                txtMaLop.Enabled = false;
                btnEditLopHoc.Enabled = true;
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM SinhVien WHERE MaLop = '{txtMaLop.Text}'") <= 0)
                {
                    btnRemoveLopHoc.Enabled = true;
                }
                else
                {
                    btnRemoveLopHoc.Enabled = false;
                }
            }
        }
    }
}