using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class ChuyenNganhForm : XtraForm
    {
        private Connect connect;

        public ChuyenNganhForm()
        {
            InitializeComponent();
            connect = new Connect();
            btnEditChuyenNganh.Enabled = false;
            btnRemoveChuyenNganh.Enabled = false;
            connect.QueryData("SELECT * FROM ChuyenNganh;", dgvListChuyenNganh);
            
        }

        private void btnAddChuyenNganh_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaChuyenNganh.Text))
            {
                MessageBox.Show("Mã chuyên ngành không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM ChuyenNganh WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}';") > 0)
            {
                MessageBox.Show("Mã chuyên ngành đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") <= 0)
            {
                MessageBox.Show("Mã khoa chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connect.ExecuteNonQuery($"INSERT INTO ChuyenNganh VALUES ('{txtMaChuyenNganh.Text}', N'{txtTenChuyenNganh.Text}', '{txtMaKhoa.Text}', N'{txtMoTa.Text}');");
            MessageBox.Show("Thêm thành công vào Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefeshChuyenNganh_Click(sender, e);
        }

        private void btnRefeshChuyenNganh_Click(object sender, EventArgs e)
        {
            txtMaChuyenNganh.Enabled = true;
            btnAddChuyenNganh.Enabled = true;
            btnEditChuyenNganh.Enabled = false;
            btnRemoveChuyenNganh.Enabled = false;
            txtMaChuyenNganh.Clear();
            txtTenChuyenNganh.Clear();
            txtMoTa.Clear();
            connect.QueryData("SELECT * FROM ChuyenNganh;", dgvListChuyenNganh);
        }

        private void btnEditChuyenNganh_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenChuyenNganh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") <= 0)
            {
                MessageBox.Show("Mã khoa chưa tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"UPDATE ChuyenNganh SET TenChuyenNganh = N'{txtTenChuyenNganh.Text}', MaKhoa = '{txtMaKhoa.Text}', MoTa = N'{txtMoTa.Text}' WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}';");
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefeshChuyenNganh_Click(sender, e);
        }

        private void btnRemoveChuyenNganh_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"DELETE FROM ChuyenNganh WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}';");
                MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefeshChuyenNganh_Click(sender, e);
            }
            else
            {
                btnRefeshChuyenNganh_Click(sender, e);
            }
        }

        private void dgvListChuyenNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaChuyenNganh.Text = dgvListChuyenNganh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenChuyenNganh.Text = dgvListChuyenNganh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaKhoa.Text = dgvListChuyenNganh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMoTa.Text = dgvListChuyenNganh.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnAddChuyenNganh.Enabled = false;
                txtMaChuyenNganh.Enabled = false;
                btnEditChuyenNganh.Enabled = true;
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM MonHoc WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}'") <= 0 ||
                    connect.ExecuteScalar($"SELECT COUNT(*) FROM LopHoc WHERE MaChuyenNganh = '{txtMaChuyenNganh.Text}'") <= 0)
                {
                    btnRemoveChuyenNganh.Enabled = true;
                }
                else
                {
                    btnRemoveChuyenNganh.Enabled = false;
                }
            }
        }

        private void txtMaKhoa_Click(object sender, EventArgs e)
        {

            txtMaKhoa.DataSource = connect.DataTable($"SELECT MaKhoa FROM Khoa;");
            txtMaKhoa.DisplayMember = "MaKhoa";
            txtMaKhoa.ValueMember = "MaKhoa";
            txtMaKhoa.SelectedIndex = -1;

        }
    }
}