using QLDIEM.ConnectDatabase;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class MonHocForm : DevExpress.XtraEditors.XtraForm
    {
        private Connect connect;

        public MonHocForm()
        {
            InitializeComponent();
            connect = new Connect();
            btnEditMonHoc.Enabled = false;
            btnRemoveMonHoc.Enabled = false;
            connect.QueryData("SELECT * FROM MonHoc;", dgvListMonHoc);
        }

        private void btnAddMonHoc_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaMonHoc.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenMonHoc.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(numSoTinChi.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaMonHoc.Text))
            {
                MessageBox.Show("Mã môn học không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = '{txtMaMonHoc.Text}';") > 0)
            {
                MessageBox.Show("Mã môn học đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM ChuyenNganh WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}';") <= 0)
            {
                MessageBox.Show("Mã chuyên ngành không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connect.ExecuteNonQuery($"INSERT INTO MonHoc VALUES ('{txtMaMonHoc.Text}', N'{txtTenMonHoc.Text}', {numSoTinChi.Text}, '{txtMaChuyenNganh.Text}');");
            MessageBox.Show("Thêm thành công vào Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefeshMonHoc_Click(sender, e);
        }

        private void btnRefeshMonHoc_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = true;
            btnAddMonHoc.Enabled = true;
            btnEditMonHoc.Enabled = false;
            btnRemoveMonHoc.Enabled = false;
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            txtMaChuyenNganh.Clear();
            numSoTinChi.Value = 1;
            connect.QueryData("SELECT * FROM MonHoc;", dgvListMonHoc);
        }

        private void btnEditMonHoc_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaMonHoc.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenMonHoc.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(numSoTinChi.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"UPDATE MonHoc SET TenMonHoc = N'{txtTenMonHoc.Text}', MaChuyenNganh = '{txtMaChuyenNganh.Text}', SoTinChi = N'{numSoTinChi.Text}' WHERE MaMonHoc = '{txtMaMonHoc.Text}';");
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefeshMonHoc_Click(sender, e);
        }

        private void btnRemoveMonHoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"DELETE FROM MonHoc WHERE MaMonHoc = '{txtMaMonHoc.Text}';");
                MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefeshMonHoc_Click(sender, e);
            }
        }

        private void txtSearchMonHoc_TextChanged(object sender, EventArgs e)
        {
            connect.QueryData($"SELECT * FROM MonHoc WHERE MaMonHoc LIKE '%{txtSearchMonHoc.Text}%' OR TenMonHoc LIKE N'%{txtSearchMonHoc.Text}%' OR MaChuyenNganh LIKE '%{txtSearchMonHoc.Text}%';", dgvListMonHoc);
        }

        private void dgvListMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaMonHoc.Text = dgvListMonHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMonHoc.Text = dgvListMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaChuyenNganh.Text = dgvListMonHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                numSoTinChi.Text = dgvListMonHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnAddMonHoc.Enabled = false;
                txtMaMonHoc.Enabled = false;
                btnEditMonHoc.Enabled = true;
                btnRemoveMonHoc.Enabled = true;
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemSo WHERE MaMonHoc = '{txtMaMonHoc.Text}'") <= 0)
                {
                    btnRemoveMonHoc.Enabled = true;
                }
                else
                {
                    btnRemoveMonHoc.Enabled = false;
                }
            }
        }
    }
}