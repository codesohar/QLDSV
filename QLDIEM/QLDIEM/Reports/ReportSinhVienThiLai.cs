using DevExpress.XtraReports.UI;
using QLDIEM.ConnectDatabase;

namespace QLDIEM.Reports
{
    public partial class ReportSinhVienThiLai : XtraReport
    {
        private Connect connect;
        public ReportSinhVienThiLai()
        {
            InitializeComponent();
            connect = new Connect();
            this.DataSource = connect.ReportData($"SELECT DiemSo.MaSV, HoTen, GioiTinh, NgaySinh, TenMonHoc FROM DiemSo, SinhVien, MonHoc WHERE DiemSo.MaSV = SinhVien.MaSV AND DiemSo.MaMonHoc = MonHoc.MaMonHoc AND ROUND((((Diem15p + (Diem45p1 + Diem45p2 + Diem45p3) * 2) / 7) * 0.4 + DiemThi * 0.6), 2) < 5 AND ROUND((((Diem15p + (Diem45p1 + Diem45p2 + Diem45p3) * 2) / 7) * 0.4 + DiemThi * 0.6), 2) >= 2;");
            loadData();
        }

        void loadData()
        {
            MaSV.DataBindings.Add("Text", this.DataSource, "MaSV");
            HoTen.DataBindings.Add("Text", this.DataSource, "HoTen");
            GioiTinh.DataBindings.Add("Text", this.DataSource, "GioiTinh");
            NgaySinh.DataBindings.Add("Text", this.DataSource, "NgaySinh");
            TenMonHoc.DataBindings.Add("Text", this.DataSource, "TenMonHoc");
        }
    }
}
