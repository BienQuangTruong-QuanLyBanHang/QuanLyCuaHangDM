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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_KhachHang bll_kh = new DAL_BLL_KhachHang();
        DAL_BLL_LoaiKhachHang bll_lkh = new DAL_BLL_LoaiKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmNhanVien nv = new frmNhanVien();
        public void HienThiDSKhachHang()
        {
            gridCtrlKhachHang.DataSource = bll_kh.GetKhachHangs();
        }
        void binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", gridCtrlKhachHang.DataSource, "MaKhachHang");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", gridCtrlKhachHang.DataSource, "TenKhachHang");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", gridCtrlKhachHang.DataSource, "NgaySinh");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", gridCtrlKhachHang.DataSource, "GioiTinh");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", gridCtrlKhachHang.DataSource, "DiaChi");
            cboLoaiKH.DataBindings.Clear();
            cboLoaiKH.DataBindings.Add("SelectedValue", gridCtrlKhachHang.DataSource, "LoaiKhachHang");
        }
        void disEnd(bool e)
        {
            txtTenKH.Enabled = e;
            txtDC.Enabled = e;
            cboLoaiKH.Enabled = e;
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
        void loadControl_cboLoaiKH()
        {
            cboLoaiKH.DataSource = bll_lkh.GetLoaiKhachHangs();
            cboLoaiKH.ValueMember = "MaLoaiKhachHang";
            cboLoaiKH.SelectedIndex = 0;
        }
        void clearData()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDC.Text = "";
            loadControl_cboGT();
            loadControl_cboLoaiKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            loadControl_cboGT();
            loadControl_cboLoaiKH();
            clearData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaKhachHang = "";
            string _TenKhachHang = "";
            DateTime _NgaySinh = dtpNgaySinh.Value;
            string _GioiTinh = "";
            string _DiaChi = "";
            string _LoaiKhachHang = "";
            try
            {
                _MaKhachHang = (txtMaKH.Text);
            }
            catch { }
            try
            {
                _TenKhachHang = txtTenKH.Text;
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
                _DiaChi = txtDC.Text;
            }
            catch { }
            try
            {
                _LoaiKhachHang = (cboLoaiKH.SelectedValue.ToString());
            }
            catch { }
            if (flag == 0)
            {
                if (_TenKhachHang == "" || _DiaChi == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_kh.addKhachHang(_MaKhachHang, _TenKhachHang, _NgaySinh, _GioiTinh, _DiaChi, _LoaiKhachHang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công");
                        HienThiDSKhachHang();
                    }
                    else
                        XtraMessageBox.Show("Thêm mới thất bại");
                }
            }
            else
            {
                int i = bll_kh.updateKhachHang(_MaKhachHang, _TenKhachHang, _NgaySinh, _GioiTinh, _DiaChi, _LoaiKhachHang);
                if (i > 0)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    HienThiDSKhachHang();
                }
                else
                    XtraMessageBox.Show("Sửa thất bại");
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            loadControl_cboGT();
            loadControl_cboLoaiKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaKhachHang = "";
            try
            {
                _MaKhachHang = (txtMaKH.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rs = bll_kh.kiemTraKhoaNgoai(_MaKhachHang);
                if (rs > 0)
                {
                    int i = 0;
                    i = bll_kh.deleteKhachHang(_MaKhachHang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSKhachHang();
                        frmKhachHang_Load(sender, e);
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

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
            disEnd(false);
            binding();
        }

        private void btnLoaiKH_Click(object sender, EventArgs e)
        {
            frmLoaiKhachHang LoaiKH = null;
            if (LoaiKH == null || LoaiKH.IsDisposed)
                LoaiKH = new frmLoaiKhachHang();
            LoaiKH.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
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
            frmMain.num = 2;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }
    }
}