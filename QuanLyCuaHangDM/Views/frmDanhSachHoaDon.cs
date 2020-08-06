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
    public partial class frmDanhSachHoaDon : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_HoaDon bll_hd = new DAL_BLL_HoaDon();
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            gridCtrlDSHD.DataSource = bll_hd.GetHoaDons();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!gridCtrlDSHD.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            gridCtrlDSHD.ShowPrintPreview();
        }
    }
}