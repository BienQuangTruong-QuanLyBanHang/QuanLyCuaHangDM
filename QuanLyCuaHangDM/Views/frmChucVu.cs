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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_ChucVu bll_chucvu = new DAL_BLL_ChucVu();
        public frmChucVu()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static frmChucVu cv = new frmChucVu();
        public void HienThiDSCV()
        {
            gridCtrlChucVu.DataSource = bll_chucvu.GetChucVus();
        }
        void binding()
        {
            txtMaCV.DataBindings.Clear();
            txtMaCV.DataBindings.Add("Text", gridCtrlChucVu.DataSource, "MaChucVu");
            txtTenCV.DataBindings.Clear();
            txtTenCV.DataBindings.Add("Text", gridCtrlChucVu.DataSource, "TenChucVu");

            //txtMaCV.Text = 
        }
        void disEnd(bool e)
        {
            txtTenCV.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void clearData()
        {
            txtTenCV.Text = "";
            txtMaCV.Text = "";
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            HienThiDSCV();
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
            string _MaChucVu = "";
            string _TenChucVu = "";
            try
            {
                _MaChucVu = (txtMaCV.Text);
            }
            catch { }
            try
            {
                _TenChucVu = txtTenCV.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_TenChucVu == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_chucvu.addChucVu(_MaChucVu, _TenChucVu);
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
                if (_TenChucVu == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_chucvu.updateChucVu(_MaChucVu, _TenChucVu);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
            }
            frmChucVu_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaChucVu = "";
            try
            {
                _MaChucVu = (txtMaCV.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int chk = Models.Connection.CheckForeignKey("NhanVien", "ChucVu", _MaChucVu);
                if (chk == 0)
                {
                    int i = 0;
                    i = Controllers.ChucVuCtrl.DeleteChucVu(_MaChucVu);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSCV();
                        frmChucVu_Load(sender, e);
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
            frmChucVu_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}