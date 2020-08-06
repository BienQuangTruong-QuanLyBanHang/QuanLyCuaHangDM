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
    public partial class frmDanhSachPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_PhieuNhap bll_pn = new DAL_BLL_PhieuNhap();
        public frmDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            gridCtrlDSPN.DataSource = bll_pn.GetPhieuNhaps();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!gridCtrlDSPN.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            gridCtrlDSPN.ShowPrintPreview();
        }
    }
}