using DevExpress.XtraReports.UI;
using QLDIEM.ConnectDatabase;
using System;

namespace QLDIEM.Reports
{
    public partial class ReportBangDiem : XtraReport
    {
        private Connect connect;
        public ReportBangDiem()
        {
            InitializeComponent();
        }

        public ReportBangDiem(String MaSV)
        {
            InitializeComponent();
            connect = new Connect();
            this.DataSource = connect.ReportData($"SELECT DiemSo.MaMonHoc, TenMonHoc, Diem15p, Diem45p1, Diem45p2, Diem45p3, DiemThi, ROUND((((Diem15p + (Diem45p1 + Diem45p2 + Diem45p3) * 2) / 7) * 0.4 + DiemThi * 0.6), 2) AS DiemTrungBinh FROM DiemSo, MonHoc WHERE DiemSo.MaMonHoc = MonHoc.MaMonHoc AND MaSV = '{MaSV}';");
            loadData();
        }

        void loadData()
        {
            MaMonHoc.DataBindings.Add("Text", this.DataSource, "MaMonHoc");
            TenMonHoc.DataBindings.Add("Text", this.DataSource, "TenMonHoc");
            Diem15p.DataBindings.Add("Text", this.DataSource, "Diem15p");
            Diem45p1.DataBindings.Add("Text", this.DataSource, "Diem45p1");
            Diem45p2.DataBindings.Add("Text", this.DataSource, "Diem45p2");
            Diem45p3.DataBindings.Add("Text", this.DataSource, "Diem45p3");
            DiemThi.DataBindings.Add("Text", this.DataSource, "DiemThi");
            DiemTrungBinh.DataBindings.Add("Text", this.DataSource, "DiemTrungBinh");
        }
    }
}
