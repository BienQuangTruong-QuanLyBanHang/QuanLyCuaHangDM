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

namespace QuanLyCuaHangDM
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public frmUser()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmUser us = new frmUser();
        public void HienThiDSUser()
        {
            //gridCtrlUser.DataSource = Models.UserModel.FillDataSetUser().Tables[0];
        }
        void binding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", gridCtrlUser.DataSource, "ID");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", gridCtrlUser.DataSource, "MatKhau");
            txtTenDN.DataBindings.Clear();
            txtTenDN.DataBindings.Add("Text", gridCtrlUser.DataSource, "TenDangNhap");
            txtChuThich.DataBindings.Clear();
            txtChuThich.DataBindings.Add("Text", gridCtrlUser.DataSource, "ChuThich");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("Text", gridCtrlUser.DataSource, "MaNhanVien");
        }
        void disEnd(bool e)
        {
            txtMatKhau.Enabled = e;
            txtTenDN.Enabled = e;
            txtChuThich.Enabled = e;
            cboMaNV.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void loadControl_cboMaNV()
        {
            //cboMaNV.DataSource = Models.NhanVienModel.FillDataSetNhanVien().Tables[0];
            cboMaNV.DisplayMember = "MaNhanVien";
            cboMaNV.ValueMember = "MaNhanVien";
            cboMaNV.SelectedIndex = 0;
        }
        void clearData()
        {
            txtID.Text = "";
            txtMatKhau.Text = "";
            txtTenDN.Text = "";
            txtChuThich.Text = "";
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            HienThiDSUser();
            disEnd(false);
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            loadControl_cboMaNV();
            clearData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _ID = "";
            string _MaNhanVien = "";
            string _TenDangNhap = "";
            string _MatKhau = "";
            string _ChuThich = "";
            try
            {
                _ID = (txtID.Text);
            }
            catch { }
            try
            {
                //_MatKhau = Models.UserControl.SHA256(txtMatKhau.Text);
            }
            catch { }
            try
            {
                _MaNhanVien = cboMaNV.Text;
            }
            catch { }
            try
            {
                _TenDangNhap = txtTenDN.Text;
            }
            catch { }
            try
            {
                _ChuThich = txtChuThich.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_MatKhau == "" || _TenDangNhap == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    //i = Controllers.UserCtrl.InsertUser(_ID, _MaNhanVien, _TenDangNhap, _MatKhau, _ChuThich);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công");
                        HienThiDSUser();
                    }
                    else
                        XtraMessageBox.Show("Thêm mới thất bại");
                }
            }
            else
            {
                int i = 0;
                //i = Controllers.UserCtrl.UpdateUser(_ID, _MaNhanVien, _TenDangNhap, _MatKhau, _ChuThich);
                if (i > 0)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    HienThiDSUser();
                }
                else
                    XtraMessageBox.Show("Sửa thất bại");
            }
            frmUser_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            loadControl_cboMaNV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _ID = "";
            try
            {
                _ID = (txtID.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                //i = Controllers.UserCtrl.DeleteNhanVien(_ID);
                if (i > 0)
                {
                    XtraMessageBox.Show("Xóa thành công !");
                    HienThiDSUser();
                    frmUser_Load(sender, e);
                }
                else
                    XtraMessageBox.Show("Xóa thất bại !");
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
            frmUser_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmMain.num = 7;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }
    }
}