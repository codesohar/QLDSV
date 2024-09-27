using QLDIEM.ConnectDatabase;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class KhoaForm : DevExpress.XtraEditors.XtraForm
    {
        private Connect connect;

        public KhoaForm()
        {
            InitializeComponent();
            connect = new Connect();
            btnEditKhoa.Enabled = false;
            btnRemoveKhoa.Enabled = false;
            connect.QueryData("SELECT * FROM Khoa;", dgvListKhoa);
        }

        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtDiaChi.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaKhoa.Text))
            {
                MessageBox.Show("Mã khoa không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") > 0)
            {
                MessageBox.Show("Mã khoa đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Controller.Invalidate.IsPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connect.ExecuteNonQuery($"INSERT INTO Khoa VALUES ('{txtMaKhoa.Text}', N'{txtTenKhoa.Text}', N'{txtDiaChi.Text}', '{txtSoDienThoai.Text}');");
            MessageBox.Show("Thêm thành công vào Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefeshKhoa_Click(sender, e);
        }

        private void btnRefeshKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = true;
            btnAddKhoa.Enabled = true;
            btnEditKhoa.Enabled = false;
            btnRemoveKhoa.Enabled = false;
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            connect.QueryData("SELECT * FROM Khoa;", dgvListKhoa);
        }

        private void btnEditKhoa_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtTenKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtDiaChi.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Controller.Invalidate.IsPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"UPDATE Khoa SET TenKhoa = N'{txtTenKhoa.Text}', DiaChi = N'{txtDiaChi.Text}', SoDienThoai = N'{txtSoDienThoai.Text}' WHERE MaKhoa = '{txtMaKhoa.Text}';");
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefeshKhoa_Click(sender, e);
        }

        private void btnRemoveKhoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"DELETE FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';");
                MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefeshKhoa_Click(sender, e);
            }
        }

        private void dgvListKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKhoa.Text = dgvListKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvListKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvListKhoa.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoDienThoai.Text = dgvListKhoa.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnAddKhoa.Enabled = false;
                txtMaKhoa.Enabled = false;
                btnEditKhoa.Enabled = true;
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM ChuyenNganh WHERE MaKhoa = '{txtMaKhoa.Text}'") <= 0 &&
                    connect.ExecuteScalar($"SELECT COUNT(*) FROM LopHoc WHERE MaKhoa = '{txtMaKhoa.Text}'") <= 0)
                {
                    btnRemoveKhoa.Enabled = true;
                    return;
                }
                btnRemoveKhoa.Enabled = false;
            }
        }
    }
}