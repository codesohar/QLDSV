using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLDIEM.Reports;
using System;
using System.Windows.Forms;

namespace QLDIEM.Forms
{
    public partial class HomeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Type typeForm)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == typeForm)
                {
                    form.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(KhoaForm));
        }

        private void btnChuyenNganh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(ChuyenNganhForm));
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(MonHocForm));
        }

        private void btnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(GiaoVienForm));
        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(LopForm));
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(SinhVienForm));
        }

        private void btnDiemDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(DiemDanhForm));
        }

        private void btnDiemQuaTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(DiemQuaTrinhForm));
        }

        private void btnDiemThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(DiemThiForm));
        }

        private void btnKetQuaHocTap_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(KetQuaHocTapForm));
        }

        private void btnSinhVienThiLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReportSinhVienThiLai().ShowPreview();
        }

        private void btnSinhVienHocLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReportSinhVienHocLai().ShowPreview();
        }

        private void btnSinhVienHocBong_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReportSinhVienHocBong().ShowPreview();
        }

        private void btnInPhieuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(InBangDiemForm));

        }
    }
}