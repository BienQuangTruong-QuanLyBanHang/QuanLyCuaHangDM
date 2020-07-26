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
using DevExpress.XtraReports.UI;

namespace QuanLyCuaHangDM
{
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapHang()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flagPN = 0;
        int flagCTPN = 0;
        public static string mapn;
        public static frmNhapHang nv = new frmNhapHang();
        public void HienThiDSCTPN()
        {
            gridCtrlCTPN.DataSource = Controllers.ChiTietPhieuNhapCtrl.FillDataSet_getCTPNByMaPN((cboMaPN.Text)).Tables[0];
        }
        void binding()
        {
            txtMaCTPN.DataBindings.Clear();
            txtMaCTPN.DataBindings.Add("Text", gridCtrlCTPN.DataSource, "MaCTPN");
            txtMaPN.DataBindings.Clear();
            txtMaPN.DataBindings.Add("Text", gridCtrlCTPN.DataSource, "MaPhieuNhap");
            cboMaSP.DataBindings.Clear();
            cboMaSP.DataBindings.Add("SelectedValue", gridCtrlCTPN.DataSource, "MaSanPham");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", gridCtrlCTPN.DataSource, "SoLuong");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", gridCtrlCTPN.DataSource, "ChuThich");
        }
        void disEndPN(bool e)
        {
            cboNPP.Enabled = e;
            btnThemPN.Enabled = !e;
            btnSuaPN.Enabled = !e;
            btnXoaPN.Enabled = !e;
            btnLuuPN.Enabled = e;
        }
        void disEndCTPN(bool e)
        {
            cboMaSP.Enabled = e;
            txtSoLuong.Enabled = e;
            txtGhiChu.Enabled = e;
            btnThemCTPN.Enabled = !e;
            btnSuaCTPN.Enabled = !e;
            btnXoaCTPN.Enabled = !e;
            btnLuuCTPN.Enabled = e;
        }
        public void loadControl_cboMaPN()
        {
            cboMaPN.DataSource = Models.PhieuNhapModel.FillDataSetPhieuNhap().Tables[0];
            cboMaPN.DisplayMember = "MaPhieuNhap";
            cboMaPN.ValueMember = "MaPhieuNhap";
            cboMaPN.SelectedIndex = 0;
        }
        public void loadControl_cboNPP()
        {
            cboNPP.DataSource = Models.NhaPhanPhoiModel.FillDataSetNhaPhanPhoi().Tables[0];
            cboNPP.DisplayMember = "TenNhaPhanPhoi";
            cboNPP.ValueMember = "MaNhaPhanPhoi";
            cboNPP.SelectedIndex = 0;
        }
        public void loadControl_cboMaSP()
        {
            cboMaSP.DataSource = Models.SanPhamModel.FillDataSetSanPham().Tables[0];
            cboMaSP.DisplayMember = "TenSanPham";
            cboMaSP.ValueMember = "MaSanPham";
            cboMaSP.SelectedIndex = 0;
        }
        void clearDataPN()
        {
            txtTongTien.Text = "";
            cboMaPN.Text = "";
            txtNgayNhap.Text = DateTime.Now.ToShortDateString();
            txtTinhTrang.Text = "Chưa thanh toán";
            txtMaNV.Text = frmMain.IdUser;
            loadControl_cboNPP();
        }
        void clearDataCTPN()
        {
            txtMaCTPN.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            loadControl_cboMaSP();
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            cboMaPN.SelectedIndexChanged -= cboMaPN_SelectedIndexChanged;
            cboMaSP.SelectedIndexChanged -= cboMaSP_SelectedIndexChanged;
            disEndPN(false);
            disEndCTPN(false);
            cboMaPN.Enabled = true;
            loadControl_cboMaPN();
            loadControl_cboNPP();
            loadControl_cboMaSP();
            txtNgayNhap.Text = DateTime.Now.ToShortDateString();
            cboMaPN.SelectedIndexChanged += cboMaPN_SelectedIndexChanged;
            cboMaSP.SelectedIndexChanged += cboMaSP_SelectedIndexChanged;
            mapn = cboMaPN.Text;
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            flagPN = 0;
            clearDataPN();
            disEndPN(true);
            cboMaPN.Enabled = false;
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            string _MaPhieuNhap = "";
            string _MaNhanVien = "";
            string _MaNhaPhanPhoi = "";
            int _TongTien = 0;
            DateTime _NgayNhap = DateTime.Now;
            string _TinhTrang = "";
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);
            }
            catch { }
            try
            {
                _MaNhanVien = (txtMaNV.Text);
            }
            catch { }
            try
            {
                _MaNhaPhanPhoi = (cboNPP.SelectedValue.ToString());
            }
            catch { }
            try
            {
                _TongTien = Convert.ToInt32(txtTongTien.Text);
            }
            catch { }
            try
            {
                _TinhTrang = txtTinhTrang.Text;
            }
            catch { }
            if (flagPN == 0)
            {
                int i = 0;
                i = Controllers.PhieuNhapCtrl.InsertPhieuNhap(_MaPhieuNhap, _MaNhanVien, _MaNhaPhanPhoi, _TongTien, _NgayNhap, _TinhTrang);
                if (i > 0)
                {
                    XtraMessageBox.Show("Thêm mới thành công");
                }
                else
                    XtraMessageBox.Show("Thêm mới thất bại");
            }
            else
            {
                string result = Controllers.PhieuNhapCtrl.CheckTinhTrangPhieuNhap(_MaPhieuNhap);
                if (result == "0")
                {
                    int i = 0;
                    i = Controllers.PhieuNhapCtrl.UpdatePhieuNhap(_MaPhieuNhap, _MaNhanVien, _MaNhaPhanPhoi, _TongTien, _NgayNhap, _TinhTrang);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
                else
                    XtraMessageBox.Show("Không thể sửa đơn hàng đã thanh toán !");
            }
            frmNhapHang_Load(sender, e);
            cboMaPN.Text = Models.Connection.GetLastID("PhieuNhap", "MaPhieuNhap");
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            flagPN = 1;
            cboMaPN.Enabled = false;
            disEndPN(true);
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            string _MaPhieuNhap = "";
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);
            }
            catch { }
            string result = Controllers.PhieuNhapCtrl.CheckTinhTrangPhieuNhap(_MaPhieuNhap);
            if (result == "0")
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = Controllers.PhieuNhapCtrl.DeletePhieuNhap(_MaPhieuNhap);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        loadControl_cboMaPN();
                        frmNhapHang_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa thất bại !");
                }
                else
                    return;
            }
            else
                XtraMessageBox.Show("Không thể xóa đơn hàng đã thanh toán !");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            flagCTPN = 0;
            disEndCTPN(true);
            clearDataCTPN();
        }

        private void btnLuuCTPN_Click(object sender, EventArgs e)
        {
            string _MaCTPN = "";
            string _MaPhieuNhap = "";
            string _MaSanPham = "";
            int _SoLuong = 0;
            int _TongTien = 0;
            string _GhiChu = "";
            try
            {
                _MaCTPN = (txtMaCTPN.Text);
            }
            catch { }
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);
            }
            catch { }
            try
            {
                _MaSanPham = (cboMaSP.SelectedValue.ToString());
            }
            catch { }
            try
            {
                _SoLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            try
            {
                _TongTien = Convert.ToInt32(txtTongTien.Text);
            }
            catch { }
            try
            {
                _GhiChu = txtGhiChu.Text;
            }
            catch { }
            if (flagCTPN == 0)
            {
                string result = Controllers.PhieuNhapCtrl.CheckTinhTrangPhieuNhap(_MaPhieuNhap);
                if (result == "0")
                {
                    if (txtSoLuong.Text != "")
                    {
                        int i = 0;
                        i = Controllers.ChiTietPhieuNhapCtrl.InsertCTPN(_MaCTPN, _MaPhieuNhap, _MaSanPham, _SoLuong, _TongTien, _GhiChu);
                        if (i > 0)
                        {
                            XtraMessageBox.Show("Thêm mới thành công");
                        }
                        else
                            XtraMessageBox.Show("Thêm mới thất bại");
                    }
                    else
                        XtraMessageBox.Show("Hãy nhập só lượng !");
                }
                else
                    XtraMessageBox.Show("Đơn hàng này đã được thanh toán !");
            }
            else
            {
                string result = Controllers.PhieuNhapCtrl.CheckTinhTrangPhieuNhap(_MaPhieuNhap);
                if (result == "0")
                {
                    int i = 0;
                    i = Controllers.ChiTietPhieuNhapCtrl.UpdateCTPN(_MaCTPN, _MaPhieuNhap, _MaSanPham, _SoLuong, _TongTien, _GhiChu);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
                else
                    XtraMessageBox.Show("Không thể sửa đơn hàng đã thanh toán !");
            }
            HienThiDSCTPN();
            disEndCTPN(false);
            binding();
        }

        private void btnSuaCTPN_Click(object sender, EventArgs e)
        {
            flagCTPN = 1;
            disEndCTPN(true);
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            string _MaCTPN = "";
            string _MaPhieuNhap = "";
            string _MaSanPham = "";
            int _SoLuong = 0;
            int _TongTien = 0;
            string _GhiChu = "";
            try
            {
                _MaCTPN = (txtMaCTPN.Text);
            }
            catch { }
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);
            }
            catch { }
            string result = Controllers.PhieuNhapCtrl.CheckTinhTrangPhieuNhap(_MaPhieuNhap);
            if (result == "0")
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = Controllers.ChiTietPhieuNhapCtrl.DeleteCTPN(_MaCTPN, _MaPhieuNhap, _MaSanPham, _SoLuong, _TongTien, _GhiChu);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSCTPN();
                        //frmNhapHang_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa thất bại !");
                }
                else
                    return;
            }
            else
                XtraMessageBox.Show("Không thể xóa đơn hàng đã thanh toán !");
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaNhap.Text = Controllers.SanPhamCtrl.GetGiaNhapByMaSanPham((cboMaSP.SelectedValue.ToString()));
        }

        private void cboMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapn = cboMaPN.Text;
            string _MaPhieuNhap = "";
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);
            }
            catch { }

            HienThiDSCTPN();

            txtMaNV.Text = Controllers.PhieuNhapCtrl.GetMaNVByMaPhieuNhap(_MaPhieuNhap);

            cboNPP.Text = Controllers.PhieuNhapCtrl.GetMaNPPByMaPhieuNhap(_MaPhieuNhap);

            txtTongTien.Text = Controllers.PhieuNhapCtrl.GetTongTienByMaPhieuNhap(_MaPhieuNhap);

            txtNgayNhap.Text = Controllers.PhieuNhapCtrl.GetNgayNhapByMaPhieuNhap(_MaPhieuNhap);

            txtTinhTrang.Text = Controllers.PhieuNhapCtrl.GetTinhTrangByMaPhieuNhap(_MaPhieuNhap);

            txtMaPN.Text = cboMaPN.Text;

            binding();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string _MaPhieuNhap = "";
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn muốn xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.PhieuNhapCtrl.UpdateTinhTrangPhieuNhap(_MaPhieuNhap);
                if (i > 0)
                {
                    XtraMessageBox.Show("Thanh toán thành công !");
                    cboMaPN_SelectedIndexChanged(sender, e);
                    //frmNhapHang_Load(sender, e);
                }
                else
                    XtraMessageBox.Show("Thanh toán thất bại !");
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhapHang_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmMain.num = 4;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}