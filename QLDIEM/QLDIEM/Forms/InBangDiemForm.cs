using DevExpress.XtraReports.UI;
using QLDIEM.ConnectDatabase;
using QLDIEM.Reports;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class InBangDiemForm : DevExpress.XtraEditors.XtraForm
    {
        private Connect connect;
        public InBangDiemForm()
        {
            InitializeComponent();
            connect = new Connect();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Controller.Invalidate.isStringUTF8(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được có dấu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (connect.ExecuteScalar($"SELECT COUNT(*) FROM SinhVien WHERE MaSV = '{txtMaSV.Text}';") <= 0)
            {
                MessageBox.Show("Mã sinh viên không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new ReportBangDiem(txtMaSV.Text).ShowPreviewDialog();
        }
    }
}