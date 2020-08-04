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
    public partial class frmPhanQuyenManHinh : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_PhanQuyenManHinh bll_pqmh = new DAL_BLL_PhanQuyenManHinh();
        DAL_BLL_ChucVu bll_cv = new DAL_BLL_ChucVu();
        public frmPhanQuyenManHinh()
        {
            InitializeComponent();
        }
        public void HienThiDSCV()
        {
            try
            {
                gridCtrlChucVu.DataSource = bll_cv.GetChucVus();
            }
            catch { }
        }

        private void gv_ChucVu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                gridCtrlPhanQuyen.DataSource = bll_pqmh.GetPhanQuyenManHinhs();
            }
            catch { }
        }

        private void frmPhanQuyenManHinh_Load(object sender, EventArgs e)
        {
            HienThiDSCV();
        }
    }
}