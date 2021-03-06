﻿using System;
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
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.ReportGeneration;

namespace QuanLyCuaHangDM
{
    public partial class frmLoaiKhachHang : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_LoaiKhachHang bll_lkh = new DAL_BLL_LoaiKhachHang();
        public frmLoaiKhachHang()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static frmLoaiSP loaisp = new frmLoaiSP();
        public void HienThiDSLoaiKhachHang()
        {
            gridCtrlLoaiKH.DataSource = bll_lkh.GetLoaiKhachHangs();
        }
        void binding()
        {

        }
        void disEnd(bool e)
        {
            txtTenLoai.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void clearData()
        {
            txtTenLoai.Text = "";
            txtMaLoai.Text = "";
        }
        void reActive()
        {
            HienThiDSLoaiKhachHang();
            disEnd(false);
            gv_LoaiKH.RowClick += gv_LoaiKH_RowClick;
        }
        bool kiemTraTextLength(string _Str)
        {
            if (_Str.Length < 5 || _Str.Length > 50)
                return false;
            return true;
        }
        private void frmLoaiKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiKhachHang();
            disEnd(false);
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearData();
            flag = 0;
            disEnd(true);
            gv_LoaiKH.RowClick -= gv_LoaiKH_RowClick;
            string str = bll_lkh.GetLastMaLoaiKhachHangs();
            int str2 = Convert.ToInt32(str.Remove(0, 3));
            if (str2 + 1 < 10)
            {
                txtMaLoai.Text = "LKH00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtMaLoai.Text = "LKH0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtMaLoai.Text = "LKH" + (str2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaLoaiKhachHang = "";
            string _TenLoaiKhachHang = "";
            try
            {
                _MaLoaiKhachHang = (txtMaLoai.Text);
            }
            catch { }
            try
            {
                _TenLoaiKhachHang = txtTenLoai.Text;
            }
            catch { }
            if (_TenLoaiKhachHang == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            if (!kiemTraTextLength(_TenLoaiKhachHang))
            {
                XtraMessageBox.Show("Tên loại giới hạn 5 ~ 50 kí tự");
                return;
            }
            if (flag == 0)
            {
                int i = bll_lkh.AddLoaiKhachHangs(_MaLoaiKhachHang, _TenLoaiKhachHang);
                if (i > 0)
                {
                    XtraMessageBox.Show("Thêm mới thành công");
                    reActive();
                }
                else
                    XtraMessageBox.Show("Thêm mới thất bại");
            }
            else
            {
                int i = bll_lkh.UpdateLoaiKhachHangs(_MaLoaiKhachHang, _TenLoaiKhachHang);
                if (i > 0)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    reActive();
                }
                else
                    XtraMessageBox.Show("Sửa thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            gv_LoaiKH.RowClick -= gv_LoaiKH_RowClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaLoaiKhachHang = "";
            try
            {
                _MaLoaiKhachHang = (txtMaLoai.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rs = bll_lkh.kiemTraKhoaNgoai(_MaLoaiKhachHang);
                if (rs > 0)
                {
                    int i = bll_lkh.DeleteLoaiKhachHangs(_MaLoaiKhachHang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        frmLoaiKhachHang_Load(sender, e);
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
            frmLoaiKhachHang_Load(sender, e);
            reActive();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }

        private void PrintGrid(GridControl grid)
        {
            // Check whether the GridControl can be printed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Print.
            grid.Print();
        }

        private void gv_LoaiKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaLoai.Text = gv_LoaiKH.GetRowCellValue(e.RowHandle, gc_MaLoai).ToString();
                txtTenLoai.Text = gv_LoaiKH.GetRowCellValue(e.RowHandle, gc_TenLoai).ToString();
            }
            catch { }
        }

        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTenLoai_Leave(object sender, EventArgs e)
        {

        }

        private void txtTenLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }

        private void txtTenLoai_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }
    }
}