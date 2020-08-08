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
using System.Text.RegularExpressions;

namespace QuanLyCuaHangDM
{
    public partial class frmNhaPhanPhoi : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_NhaPhanPhoi bll_npp = new DAL_BLL_NhaPhanPhoi();
        public frmNhaPhanPhoi()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmNhaPhanPhoi npp = new frmNhaPhanPhoi();
        public void HienThiDSNPP()
        {
            gridCtrlNPP.DataSource = bll_npp.GetPhanPhois();
        }
        void binding()
        {
            
        }
        void disEnd(bool e)
        {
            txtTenNPP.Enabled = e;
            txtDT.Enabled = e;
            txtEmail.Enabled = e;
            txtDiaChi.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void clearData()
        {
            txtMaNPP.Text = "";
            txtTenNPP.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
        }
        void reActive()
        {
            HienThiDSNPP();
            disEnd(false);
            gv_NhaPhanPhoi.RowClick += gv_NhaPhanPhoi_RowClick;
        }

        private void frmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            HienThiDSNPP();
            disEnd(false);
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            clearData();
            gv_NhaPhanPhoi.RowClick -= gv_NhaPhanPhoi_RowClick;
            string str = bll_npp.GetLastMaNhaPhanPhois();
            int str2 = Convert.ToInt32(str.Remove(0, 3));
            if (str2 + 1 < 10)
            {
                txtMaNPP.Text = "NPP00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtMaNPP.Text = "NPP0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtMaNPP.Text = "NPP" + (str2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaNhaPhanPhoi = "";
            string _TenNhaPhanPhoi = "";
            string _DiaChi = "";
            string _SDT = "";
            string _Email = "";
            try
            {
                _MaNhaPhanPhoi = txtMaNPP.Text;
            }
            catch { }
            try
            {
                _TenNhaPhanPhoi = txtTenNPP.Text;
            }
            catch { }
            try
            {
                _DiaChi = txtDiaChi.Text;
            }
            catch { }
            try
            {
                _Email = txtEmail.Text;
            }
            catch { }
            try
            {
                _SDT = txtDT.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_TenNhaPhanPhoi == "" || _DiaChi == "" || _SDT == "" || _Email == "")
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_npp.AddNhaPhanPhois(_MaNhaPhanPhoi, _TenNhaPhanPhoi, _DiaChi, _SDT, _Email);
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
                int i = bll_npp.UpdateNhaPhanPhois(_MaNhaPhanPhoi, _TenNhaPhanPhoi, _DiaChi, _SDT, _Email);
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
            gv_NhaPhanPhoi.RowClick -= gv_NhaPhanPhoi_RowClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaNhaPhanPhoi = "";
            try
            {
                _MaNhaPhanPhoi = txtMaNPP.Text;
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rs = bll_npp.KiemTraKhoaNgoai(_MaNhaPhanPhoi);
                if (rs > 0)
                {
                    int i = bll_npp.DeleteNhaPhanPhois(_MaNhaPhanPhoi);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        frmNhaPhanPhoi_Load(sender, e);
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
            frmNhaPhanPhoi_Load(sender, e);
            HienThiDSNPP();
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
            frmMain.num = 5;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }

        private void gv_NhaPhanPhoi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaNPP.Text = gv_NhaPhanPhoi.GetRowCellValue(e.RowHandle, gc_MaNPP).ToString();
                txtTenNPP.Text = gv_NhaPhanPhoi.GetRowCellValue(e.RowHandle, gc_TenNPP).ToString();
                txtDT.Text = gv_NhaPhanPhoi.GetRowCellValue(e.RowHandle, gc_DienThoai).ToString();
                txtDiaChi.Text = gv_NhaPhanPhoi.GetRowCellValue(e.RowHandle, gc_DiaChi).ToString();
                txtEmail.Text = gv_NhaPhanPhoi.GetRowCellValue(e.RowHandle, gc_Email).ToString();
            }
            catch { }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if(txtEmail.Text == string.Empty)
            {
                return;
            }    
            if (!Regex.IsMatch(txtEmail.Text, match))
            {
                MessageBox.Show("Nhập sai Email !!!");
                txtEmail.Focus();
            }
        }
    }
}