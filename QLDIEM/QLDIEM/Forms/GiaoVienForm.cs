using QLDIEM.ConnectDatabase;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class GiaoVienForm : DevExpress.XtraEditors.XtraForm
    {
        private Connect connect;
        private String MaGV;
        int id;

        public GiaoVienForm()
        {
            InitializeComponent();
            connect = new Connect();
            btnEditGiaoVien.Enabled = false;
            btnRemoveGiaoVien.Enabled = false;
            connect.QueryData("SELECT * FROM GiaoVien;", dgvListGiaoVien);
        }

        private void btnAddGiaoVien_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtHoTenGiaoVien.Text) ||
                Controller.Invalidate.IsNullOrEmpty(comGioiTinh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtEmail.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtSoDienThoai.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaKhoa.Text))
            {
                MessageBox.Show("Mã khoa không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") <= 0)
            {
                MessageBox.Show("Mã khoa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Controller.Invalidate.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Không đúng định dạng Email!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Controller.Invalidate.IsPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = connect.ExecuteScalar($"SELECT * FROM CountGiaoVien;");
            connect.ExecuteNonQuery($"INSERT INTO GiaoVien VALUES ('{txtMaKhoa.Text}202400{id}', N'{txtHoTenGiaoVien.Text}', N'{comGioiTinh.Text}', '{dateNgaySinh.Value.ToString("yyyy-MM-dd")}', '{txtEmail.Text}', '{txtSoDienThoai.Text}', N'{txtDiaChi.Text}', '{txtMaKhoa.Text}');");
            connect.ExecuteNonQuery($"UPDATE CountGiaoVien SET [count] = {id + 1};");
            MessageBox.Show("Thêm thành công vào Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefeshGiaoVien_Click(sender, e);
        }

        private void btnEditGiaoVien_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaKhoa.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtHoTenGiaoVien.Text) ||
                Controller.Invalidate.IsNullOrEmpty(comGioiTinh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtEmail.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtSoDienThoai.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaKhoa.Text))
            {
                MessageBox.Show("Mã khoa không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{txtMaKhoa.Text}';") <= 0)
            {
                MessageBox.Show("Mã khoa không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Controller.Invalidate.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Không đúng định dạng Email!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                connect.ExecuteNonQuery($"UPDATE GiaoVien SET MaGV = '{txtMaKhoa.Text}202400{id}', HoTen = N'{txtHoTenGiaoVien.Text}', GioiTinh = N'{comGioiTinh.Text}', NgaySinh = '{dateNgaySinh.Value.ToString("yyyy-MM-dd")}', Email = '{txtEmail.Text}', SoDienThoai = '{txtSoDienThoai.Text}', DiaChi = N'{txtDiaChi.Text}', MaKhoa = '{txtMaKhoa.Text}' WHERE MaGV = '{MaGV}';");
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefeshGiaoVien_Click(sender, e);
        }

        private void btnRefeshGiaoVien_Click(object sender, EventArgs e)
        {
            btnAddGiaoVien.Enabled = true;
            btnEditGiaoVien.Enabled = false;
            btnRemoveGiaoVien.Enabled = false;
            txtMaKhoa.Clear();
            txtHoTenGiaoVien.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtSearchGiaoVien.Clear();
            connect.QueryData("SELECT * FROM GiaoVien;", dgvListGiaoVien);
        }

        private void btnRemoveGiaoVien_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"DELETE FROM GiaoVien WHERE MaGV = '{MaGV}';");
                MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefeshGiaoVien_Click(sender, e);
            }
            else
            {
                btnRefeshGiaoVien_Click(sender, e);
            }
        }

        private void txtSearchGiaoVien_TextChanged(object sender, EventArgs e)
        {
            connect.QueryData($"SELECT * FROM GiaoVien WHERE MaGV LIKE '%{txtSearchGiaoVien.Text}%' OR HoTen LIKE N'%{txtSearchGiaoVien.Text}%' OR GioiTinh LIKE N'%{txtSearchGiaoVien.Text}%' OR Email LIKE '%{txtSearchGiaoVien.Text}%' OR SoDienThoai LIKE '%{txtSearchGiaoVien.Text}%' OR DiaChi LIKE '%{txtSearchGiaoVien.Text}%' OR MaKhoa LIKE '%{txtSearchGiaoVien.Text}%';", dgvListGiaoVien);
        }

        private void dgvListGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaGV = dgvListGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenGiaoVien.Text = dgvListGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                comGioiTinh.Text = dgvListGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNgaySinh.Value = DateTime.Parse(dgvListGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtEmail.Text = dgvListGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoDienThoai.Text = dgvListGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvListGiaoVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMaKhoa.Text = dgvListGiaoVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                btnAddGiaoVien.Enabled = false;
                btnEditGiaoVien.Enabled = true;
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM LopHoc WHERE MaGV = '{MaGV}'") <= 0)
                {
                    btnRemoveGiaoVien.Enabled = true;
                }
                else
                {
                    btnRemoveGiaoVien.Enabled = false;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}