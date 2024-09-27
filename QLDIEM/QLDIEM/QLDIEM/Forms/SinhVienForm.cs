using DevExpress.XtraEditors;
using QLDIEM.ConnectDatabase;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class SinhVienForm : XtraForm
    {
        private Connect connect;
        private String MaSV;
        private int id;

        public SinhVienForm()
        {
            InitializeComponent();
            connect = new Connect();
            btnEditSinhVien.Enabled = false;
            btnRemoveSinhVien.Enabled = false;
            connect.QueryData("SELECT * FROM SinhVien;", dgvListSinhVien);
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            if (Controller.Invalidate.IsNullOrEmpty(txtMaLop.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtHoTenSinhVien.Text) ||
                Controller.Invalidate.IsNullOrEmpty(comGioiTinh.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtEmail.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtSoDienThoai.Text) ||
                Controller.Invalidate.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Các trường nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM LopHoc WHERE MaLop = '{txtMaLop.Text}';") <= 0)
            {
                MessageBox.Show("Mã lớp không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            id = connect.ExecuteScalar($"SELECT * FROM CountSinhVien;");
            connect.ExecuteNonQuery($"INSERT INTO SinhVien VALUES ('MSV{txtMaLop.Text}202400{id}', N'{txtHoTenSinhVien.Text}', N'{comGioiTinh.Text}', '{dateNgaySinh.Value.ToString("yyyy-MM-dd")}', '{txtEmail.Text}', '{txtSoDienThoai.Text}', N'{txtDiaChi.Text}', '{txtMaLop.Text}');");
            connect.ExecuteNonQuery($"UPDATE CountSinhVien SET [count] = {id + 1};");
            MessageBox.Show("Thêm thành công vào Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefeshSinhVien_Click(sender, e);
        }

        private void btnRefeshSinhVien_Click(object sender, EventArgs e)
        {
            btnAddSinhVien.Enabled = true;
            btnEditSinhVien.Enabled = false;
            btnRemoveSinhVien.Enabled = false;
            txtMaLop.Clear();
            txtHoTenSinhVien.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtSearchSinhVien.Clear();
            connect.QueryData("SELECT * FROM SinhVien;", dgvListSinhVien);
        }

        private void btnEditSinhVien_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"UPDATE SinhVien SET MaSV = 'MSV{txtMaLop.Text}202400{id}', HoTen = N'{txtHoTenSinhVien.Text}', GioiTinh = N'{comGioiTinh.Text}', NgaySinh = '{dateNgaySinh.Value.ToString("yyyy-MM-dd")}', Email = '{txtEmail.Text}', SoDienThoai = '{txtSoDienThoai.Text}', DiaChi = N'{txtDiaChi.Text}', MaLop = '{txtMaLop.Text}' WHERE MaSV = '{MaSV}';");
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefeshSinhVien_Click(sender, e);
        }

        private void btnRemoveSinhVien_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connect.ExecuteNonQuery($"DELETE FROM SinhVien WHERE MaSV = '{MaSV}';");
                MessageBox.Show("Xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefeshSinhVien_Click(sender, e);
            }
            else
            {
                btnRefeshSinhVien_Click(sender, e);
            }
        }

        private void txtSearchSinhVien_TextChanged(object sender, EventArgs e)
        {
            connect.QueryData($"SELECT * FROM SinhVien WHERE MaSV LIKE '%{txtSearchSinhVien.Text}%' OR HoTen LIKE N'%{txtSearchSinhVien.Text}%' OR GioiTinh LIKE N'%{txtSearchSinhVien.Text}%' OR Email LIKE '%{txtSearchSinhVien.Text}%' OR SoDienThoai LIKE '%{txtSearchSinhVien.Text}%' OR DiaChi LIKE '%{txtSearchSinhVien.Text}%' OR MaLop LIKE '%{txtSearchSinhVien.Text}%';", dgvListSinhVien);
        }

        private void dgvListSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaSV = dgvListSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenSinhVien.Text = dgvListSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                comGioiTinh.Text = dgvListSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNgaySinh.Value = DateTime.Parse(dgvListSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtEmail.Text = dgvListSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoDienThoai.Text = dgvListSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvListSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMaLop.Text = dgvListSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                btnAddSinhVien.Enabled = false;
                btnEditSinhVien.Enabled = true;
                if (connect.ExecuteScalar($"SELECT COUNT(*) FROM DiemSo WHERE MaSV = '{MaSV}';") <= 0)
                {
                    btnRemoveSinhVien.Enabled = true;
                }
                else
                {
                    btnRemoveSinhVien.Enabled = false;
                }
            }
        }
    }
}