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
    public partial class frmHangSX : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_HangSanXuat bll_hsx = new DAL_BLL_HangSanXuat();
        public frmHangSX()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static frmHangSX hangsx = new frmHangSX();
        public void HienThiDSHangSX()
        {
            gridCtrlHangSX.DataSource = bll_hsx.GetHangSanXuats();
        }
        void binding()
        {
            
        }
        void disEnd(bool e)
        {
            txtTenHang.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void clearData()
        {
            txtTenHang.Text = "";
            txtMaHang.Text = "";
        }
        void reActive()
        {
            HienThiDSHangSX();
            disEnd(false);
            gv_HangSanXuat.RowClick += gv_HangSanXuat_RowClick;
        }
        private void frmHangSX_Load(object sender, EventArgs e)
        {
            HienThiDSHangSX();
            disEnd(false);
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            clearData();
            gv_HangSanXuat.RowClick -= gv_HangSanXuat_RowClick;
            string str = bll_hsx.GetLastMaHangSanXuats();
            int str2 = Convert.ToInt32(str.Remove(0, 3));
            if (str2 + 1 < 10)
            {
                txtMaHang.Text = "HSX00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtMaHang.Text = "HSX0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtMaHang.Text = "HSX" + (str2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaHangSanXuat = "";
            string _TenHangSanXuat = "";
            try
            {
                _MaHangSanXuat = (txtMaHang.Text);
            }
            catch { }
            try
            {
                _TenHangSanXuat = txtTenHang.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_TenHangSanXuat == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_hsx.addHangSanXuat(_MaHangSanXuat, _TenHangSanXuat);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công");
                        reActive();
                    }
                    else
                        XtraMessageBox.Show("Thêm mới thất bại");
                }
            }
            else
            {
                if (_TenHangSanXuat == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_hsx.updateHangSanXuat(_MaHangSanXuat, _TenHangSanXuat);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                        reActive();
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            gv_HangSanXuat.RowClick -= gv_HangSanXuat_RowClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaHangSanXuat = "";
            try
            {
                _MaHangSanXuat = (txtMaHang.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rs = bll_hsx.kiemTraKhoaNgoai(_MaHangSanXuat);
                if (rs > 0)
                {
                    int i = bll_hsx.deleteHangSanXuat(_MaHangSanXuat);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        frmHangSX_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa thất bại !");
                }
                else
                    XtraMessageBox.Show("Dữ liệu này đang được sử dụng !");
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmHangSX_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmMain.num = 1;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }

        private void gv_HangSanXuat_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaHang.Text = gv_HangSanXuat.GetRowCellValue(e.RowHandle, gc_MaHSX).ToString();
                txtTenHang.Text = gv_HangSanXuat.GetRowCellValue(e.RowHandle, gc_TenHSX).ToString();
            }
            catch { }
        }

        private void txtTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}