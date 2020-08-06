using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;

namespace QuanLyCuaHangDM
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_HoaDon bll_hd = new DAL_BLL_HoaDon();
        public frmPrint()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        public void InHoaDon()
        {
            Views.rpt.rptCTHD rpt = new Views.rpt.rptCTHD();
            documentViewer1.DocumentSource = rpt;
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
            {
                p.Visible = false;
            }
            documentViewer1.Refresh();
            rpt.CreateDocument();
        }
        public void InPhieuNhap()
        {
            Views.rpt.rptCTPN rpt = new Views.rpt.rptCTPN();
            documentViewer1.DocumentSource = rpt;
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
            {
                p.Visible = false;
            }
            documentViewer1.Refresh();
            rpt.CreateDocument();
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            //switch(frmMain.num)
            //{
            //    case 0:
            //        {
            //            Views.rpt.rptCTHD rpt = new Views.rpt.rptCTHD();
            //            //foreach (DevExpress.XtraReports.Parameters.Parameter p in rpt.Parameters)
            //            //{
            //            //    p.Visible = false;
            //            //}
            //            //rpt.Parameters["MaHoaDon"].Value = frmBanHang.MaHD;
            //            documentViewer1.DocumentSource = rpt;
            //            rpt.RequestParameters = false;
            //            //rpt.ParametersRequestSubmit += new EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(BindData);
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 1:
            //        {
            //            Views.rpt.rptHangSX rpt = new Views.rpt.rptHangSX();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 2:
            //        {
            //            Views.rptKhachHang rpt = new Views.rptKhachHang();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 3:
            //        {
            //            Views.rpt.rptNhanVien rpt = new Views.rpt.rptNhanVien();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 4:
            //        {
            //            Views.rpt.rptCTPN rpt = new Views.rpt.rptCTPN();
            //            rpt.Parameters["MaPhieuNhap"].Value = frmNhapHang.MaPN;
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 5:
            //        {
            //            Views.rpt.rptNhaPhanPhoi rpt = new Views.rpt.rptNhaPhanPhoi();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 6:
            //        {
            //            Views.rpt.rptSanPham rpt = new Views.rpt.rptSanPham();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 7:
            //        {
            //            Views.rpt.rptUser rpt = new Views.rpt.rptUser();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 8:
            //        {
            //            Views.rpt.rptPhieuNhap rpt = new Views.rpt.rptPhieuNhap();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    case 9:
            //        {
            //            Views.rpt.rptHoaDon rpt = new Views.rpt.rptHoaDon();
            //            documentViewer1.DocumentSource = rpt;
            //            documentViewer1.Refresh();
            //            rpt.CreateDocument();
            //            break;
            //        }
            //    default:
            //        XtraMessageBox.Show("Error at switch case!");
            //        break;
            //}
        }
    }
}