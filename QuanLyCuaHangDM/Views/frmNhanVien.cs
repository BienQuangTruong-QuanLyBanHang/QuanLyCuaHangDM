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
using System.Data.SqlClient;
using DAL_BLL;

namespace QuanLyCuaHangDM
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_NhanVien bll_nv = new DAL_BLL_NhanVien();
        DAL_BLL_ChucVu bll_cv = new DAL_BLL_ChucVu();
        public frmNhanVien()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmNhanVien nv = new frmNhanVien();
        public void HienThiDSNhanVien()
        {
            gridCtrlNhanVien.DataSource = bll_nv.GetNhanViens();
        }
        void binding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", gridCtrlNhanVien.DataSource, "MaNhanVien");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", gridCtrlNhanVien.DataSource, "TenNhanVien");
            txtDT.DataBindings.Clear();
            txtDT.DataBindings.Add("Text", gridCtrlNhanVien.DataSource, "SDT");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", gridCtrlNhanVien.DataSource, "NgaySinh");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", gridCtrlNhanVien.DataSource, "GioiTinh");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", gridCtrlNhanVien.DataSource, "DiaChi");
            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("SelectedValue", gridCtrlNhanVien.DataSource, "ChucVu");
        }
        void disEnd(bool e)
        {
            txtTenNV.Enabled = e;
            txtDT.Enabled = e;
            txtDC.Enabled = e;
            cboChucVu.Enabled = e;
            cboGioiTinh.Enabled = e;
            dtpNgaySinh.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void loadControl_cboGT()
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
        }
        void loadControl_cboCV()
        {
            cboChucVu.DataSource = bll_cv.GetChucVus();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
            cboChucVu.SelectedIndex = 0;
        }
        void clearData()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            loadControl_cboGT();
            loadControl_cboCV();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            disEnd(false);
            binding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            loadControl_cboGT();
            loadControl_cboCV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            loadControl_cboGT();
            loadControl_cboCV();
            clearData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaNhanVien = "";
            string _TenNhanVien = "";
            DateTime _NgaySinh = DateTime.Now;
            DateTime _NgayVaoLam = DateTime.Now;
            string _GioiTinh = "";
            string _SoDT = "";
            string _DiaChi = "";
            string _ChucVu = "";
            try
            {
                _MaNhanVien = (txtMaNV.Text);
            }
            catch { }
            try
            {
                _TenNhanVien = txtTenNV.Text;
            }
            catch { }
            try
            {
                _NgaySinh = dtpNgaySinh.Value;
            }
            catch { }
            try
            {
                _GioiTinh = cboGioiTinh.Text;
            }
            catch { }
            try
            {
                _SoDT = txtDT.Text;
            }
            catch { }
            try
            {
                _DiaChi = txtDC.Text;
            }
            catch { }
            try
            {
                _ChucVu = cboChucVu.SelectedValue.ToString();
            }
            catch { }
            if (flag == 0)
            {
                if (_TenNhanVien == "" || _DiaChi == "" || _SoDT == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_nv.AddNhanViens(_MaNhanVien, _TenNhanVien, _NgaySinh, _GioiTinh, _NgayVaoLam, _ChucVu, _DiaChi, _SoDT);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công");
                        HienThiDSNhanVien();
                    }
                    else
                        XtraMessageBox.Show("Thêm mới thất bại");
                }
            }
            else
            {
                int i = bll_nv.UpdateNhanViens(_MaNhanVien, _TenNhanVien, _NgaySinh, _GioiTinh, _ChucVu, _DiaChi, _SoDT);
                if (i > 0)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    HienThiDSNhanVien();
                }
                else
                    XtraMessageBox.Show("Sửa thất bại");
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaNhanVien = "";
            try
            {
                _MaNhanVien = (txtMaNV.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rs = bll_nv.kiemTraKhoaNgoai(_MaNhanVien);
                if (rs > 0)
                {
                    int i = bll_nv.DeleteNhanViens(_MaNhanVien);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSNhanVien();
                        frmNhanVien_Load(sender, e);
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

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu cv = null;
            if (cv == null || cv.IsDisposed)
                cv = new frmChucVu();
            cv.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmMain.num = 3;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }
    }
}