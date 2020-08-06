using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DAL_BLL;
using System.Windows.Forms;

namespace QuanLyCuaHangDM.Views.rpt
{
    public partial class rptCTHD : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCTHD()
        {
            InitializeComponent();
        }

        private void rptCTHD_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            Parameters["MaHoaDon"].Value = Properties.Settings.Default.MaHD;
        }
    }
}
