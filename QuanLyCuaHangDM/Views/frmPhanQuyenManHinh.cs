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
                //lst = bll_pqmh.GetPhanQuyenManHinhs(gv_ChucVu.GetRowCellValue(e.RowHandle, gc_MaCV).ToString());
                //var source = new BindingSource();
                //source.DataSource = lst;
                //gridCtrlPhanQuyen.DataSource = source;
                gridCtrlPhanQuyen.DataSource = bll_pqmh.GetPhanQuyenManHinhs(gv_ChucVu.GetRowCellValue(e.RowHandle, gc_MaCV).ToString());
            }
            catch { }
        }

        private void frmPhanQuyenManHinh_Load(object sender, EventArgs e)
        {
            HienThiDSCV();
            gridCtrlPhanQuyen.DataSource = GetData();
        }
        public class Custom
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
        private BindingList<Custom> GetData()
        {
            BindingList<Custom> list = new BindingList<Custom>();
            for (int i = 0; i < 10; i++)
                list.Add(new Custom() { ID = "false", Name = "Name" + i });
            return list;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            lst = gridCtrlPhanQuyen.DataSource as List<PhanQuyenManHinh>;
            for(int i = 0; i < lst.Count; i++)
            {
                //bll_pqmh.AddPhanQuyenManHinhs(_MaCV, lst[i].MaMH, Convert.ToBoolean(lst[i].CoQuyen));
                //MessageBox.Show(_MaCV + " " + lst[i].MaMH + " " + Convert.ToBoolean(lst[i].CoQuyen).ToString());
            }
        }
    }
}