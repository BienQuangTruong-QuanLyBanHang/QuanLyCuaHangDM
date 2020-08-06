using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyCuaHangDM.Views.rpt
{
    public partial class rptCTPN : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCTPN()
        {
            InitializeComponent();
        }

        private void rptCTPN_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            Parameters["MaPhieuNhap"].Value = Properties.Settings.Default.MaPN;
        }
    }
}
