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
            txtMaHang.DataBindings.Clear();
            txtMaHang.DataBindings.Add("Text", gridCtrlHangSX.DataSource, "MaHangSanXuat");
            txtTenHang.DataBindings.Clear();
            txtTenHang.DataBindings.Add("Text", gridCtrlHangSX.DataSource, "TenHangSanXuat");
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
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
            }
            frmHangSX_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
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
                    int i = 0;
                    //i = Controllers.HangSanXuatCtrl.DeleteHSX(_MaHangSanXuat);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSHangSX();
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
    }
}