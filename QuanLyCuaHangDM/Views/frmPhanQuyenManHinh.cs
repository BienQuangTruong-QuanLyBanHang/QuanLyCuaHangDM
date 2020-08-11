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
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.DataProcessing;
using DevExpress.Utils.Extensions;

namespace QuanLyCuaHangDM
{
    public partial class frmPhanQuyenManHinh : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_PhanQuyenManHinh bll_pqmh = new DAL_BLL_PhanQuyenManHinh();
        DAL_BLL_ChucVu bll_cv = new DAL_BLL_ChucVu();
        List<PhanQuyenManHinh> lst = new List<PhanQuyenManHinh>();
        string maCV = string.Empty;

        public string MaCV { get => maCV; set => maCV = value; }

        public frmPhanQuyenManHinh()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
                MaCV = gv_ChucVu.GetRowCellValue(e.RowHandle, gc_MaCV).ToString();
                gridCtrlPhanQuyen.DataSource = bll_pqmh.GetPhanQuyenManHinhs(gv_ChucVu.GetRowCellValue(e.RowHandle, gc_MaCV).ToString());
            }
            catch { }
        }

        private void frmPhanQuyenManHinh_Load(object sender, EventArgs e)
        {
            HienThiDSCV();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MaCV != string.Empty)
            {
                bll_pqmh.clearData(MaCV);
                lst = gridCtrlPhanQuyen.DataSource as List<PhanQuyenManHinh>;
                for (int i = 0; i < lst.Count; i++)
                {
                    int rs = bll_pqmh.AddPhanQuyenManHinhs(MaCV, lst[i].MaMH, Convert.ToBoolean(lst[i].CoQuyen));
                    if (rs < 1)
                    {
                        XtraMessageBox.Show("Lưu thất bại");
                        return;
                    }
                }
                XtraMessageBox.Show("Lưu thành công");
            }
            else
                XtraMessageBox.Show("Hãy chọn chức vụ cần phân quyền");
        }
    }
}