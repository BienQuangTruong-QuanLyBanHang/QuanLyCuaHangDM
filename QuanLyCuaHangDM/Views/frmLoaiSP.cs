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

namespace QuanLyCuaHangDM
{
    public partial class frmLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_LoaiSanPham bll_lsp = new DAL_BLL_LoaiSanPham();
        public frmLoaiSP()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static frmLoaiSP loaisp = new frmLoaiSP();
        public void HienThiDSLoaiSanPham()
        {
            gridCtrlLoaiSP.DataSource = bll_lsp.GetLoaiSanPhams();
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
            gv_LoaiKhachHang.RowClick += gv_LoaiKhachHang_RowClick;
            disEnd(false);
            HienThiDSLoaiSanPham();
        }
        bool kiemTraTextLength(string _Str)
        {
            if (_Str.Length < 5 || _Str.Length > 50)
                return false;
            return true;
        }
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiSanPham();
            disEnd(false);
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            clearData();
            gv_LoaiKhachHang.RowClick -= gv_LoaiKhachHang_RowClick;
            string str = bll_lsp.GetLastMaLoaiSanPhams();
            int str2 = Convert.ToInt32(str.Remove(0, 3));
            if (str2 + 1 < 10)
            {
                txtMaLoai.Text = "LSP00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtMaLoai.Text = "LSP0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtMaLoai.Text = "LSP" + (str2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaLoaiSanPham = "";
            string _TenLoaiSanPham = "";
            try
            {
                _MaLoaiSanPham = (txtMaLoai.Text);
            }
            catch { }
            try
            {
                _TenLoaiSanPham = txtTenLoai.Text;
            }
            catch { }
            if (_TenLoaiSanPham == string.Empty)
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            if(!kiemTraTextLength(_TenLoaiSanPham))
            {
                XtraMessageBox.Show("Tên loại giới hạn 5 ~ 50 kí tự");
                return;
            }    
            if (flag == 0)
            {
                int i = bll_lsp.AddLoaiSanPhams(_MaLoaiSanPham, _TenLoaiSanPham);
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
                int i = bll_lsp.UpdateLoaiSanPhams(_MaLoaiSanPham, _TenLoaiSanPham);
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
            gv_LoaiKhachHang.RowClick -= gv_LoaiKhachHang_RowClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaLoaiSanPham = "";
            try
            {
                _MaLoaiSanPham = (txtMaLoai.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int rs = bll_lsp.kiemTraKhoaNgoai(_MaLoaiSanPham);
            if (rs > 0)
            {
                if (dr == DialogResult.Yes)
                {
                    int i = bll_lsp.DeleteLoaiSanPhams(_MaLoaiSanPham);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        frmLoaiSP_Load(sender, e);
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
            frmLoaiSP_Load(sender, e);
            reActive();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void gv_LoaiKhachHang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaLoai.Text = gv_LoaiKhachHang.GetRowCellValue(e.RowHandle, gridColumn2).ToString();
            txtTenLoai.Text = gv_LoaiKhachHang.GetRowCellValue(e.RowHandle, gridColumn3).ToString();
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