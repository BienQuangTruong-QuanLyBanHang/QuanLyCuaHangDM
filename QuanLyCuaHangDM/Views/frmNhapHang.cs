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
using DAL_BLL;

namespace QuanLyCuaHangDM
{
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_PhieuNhap bll_phieunhap = new DAL_BLL_PhieuNhap();
        DAL_BLL_ChiTietPhieuNhap bll_ctpn = new DAL_BLL_ChiTietPhieuNhap();
        DAL_BLL_NhaPhanPhoi bll_npp = new DAL_BLL_NhaPhanPhoi();
        DAL_BLL_NhanVien bll_nhanvien = new DAL_BLL_NhanVien();
        DAL_BLL_SanPham bll_sanpham = new DAL_BLL_SanPham();
        List<ChiTietPhieuNhap> lst = new List<ChiTietPhieuNhap>();
        string MaNV;
        int flagPN = 0;
        string MaSP = null;
        public static frmNhapHang nv = new frmNhapHang();
        public frmNhapHang()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        public frmNhapHang(string _MaNV)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            MaNV = _MaNV;
        }
        public void HienThiDSCTPN(string _MaHoaDon)
        {
            try
            {
                gridCtrlCTPN.DataSource = bll_ctpn.GetChiTietPhieuNhaps(_MaHoaDon);
            }
            catch { }
        }
        void disEndPN(bool e)
        {
            cboNPP.Enabled = e;
            cboMaPN.Enabled = !e;
            btnThemPN.Enabled = !e;
            btnLuuPN.Enabled = e;
            btnThemCTPN.Enabled = e;
        }
        void disEndCTPN(bool e)
        {
            cboMaSP.Enabled = e;
            txtSoLuong.Enabled = e;
            btnThemCTPN.Enabled = e;
        }
        void disEndBtnCTPN(bool e)
        {
            btnSuaCTPN.Enabled = e;
            btnXoaCTPN.Enabled = e;
        }
        public void loadControl_cboMaPN()
        {
            cboMaPN.DataSource = bll_phieunhap.GetPhieuNhaps();
            cboMaPN.DisplayMember = "MaPhieuNhap";
            cboMaPN.ValueMember = "MaPhieuNhap";
            cboMaPN.SelectedIndex = 0;
        }
        public void loadControl_cboNPP()
        {
            cboNPP.DataSource = bll_npp.GetPhanPhois();
            cboNPP.DisplayMember = "TenNhaPhanPhoi";
            cboNPP.ValueMember = "MaNhaPhanPhoi";
            cboNPP.SelectedIndex = 0;
        }
        public void loadControl_cboMaSP()
        {
            cboMaSP.DataSource = bll_sanpham.GetSanPhams();
            cboMaSP.DisplayMember = "TenSanPham";
            cboMaSP.ValueMember = "MaSanPham";
            cboMaSP.SelectedIndex = 0;
        }
        void clearDataPN()
        {
            txtTongTien.Text = "0";
            txtNgayNhap.Text = Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("dd-MM-yyyy");
            loadControl_cboNPP();
            txtMaNV.Text = bll_nhanvien.GetTenNhanVien(MaNV);
        }
        void clearDataCTPN()
        {
            txtSoLuong.Text = "0";
            gridCtrlCTPN.DataSource = null;
            loadControl_cboMaSP();
        }
        void loadListCTPN()
        {
            var source = new BindingSource();
            source.DataSource = lst;
            gridCtrlCTPN.DataSource = source;
            formatGV();
        }
        void formatGV()
        {
            gv_CTPN.Columns["SoLuong"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv_CTPN.Columns["SoLuong"].DisplayFormat.FormatString = "#,###";

            gv_CTPN.Columns["TongTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv_CTPN.Columns["TongTien"].DisplayFormat.FormatString = "#,###";

            gv_CTPN.Columns["GiaNhap"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv_CTPN.Columns["GiaNhap"].DisplayFormat.FormatString = "#,###";
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            cboMaPN.SelectedIndexChanged -= cboMaPN_SelectedIndexChanged;
            cboMaSP.SelectedIndexChanged -= cboMaSP_SelectedIndexChanged;
            disEndPN(false);
            disEndCTPN(false);
            disEndBtnCTPN(false);
            clearDataPN();
            clearDataCTPN();
            cboMaPN.Enabled = true;
            loadControl_cboMaPN();
            loadControl_cboNPP();
            loadControl_cboMaSP();
            txtNgayNhap.Text = Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("dd-MM-yyyy");
            cboMaPN.SelectedIndexChanged += cboMaPN_SelectedIndexChanged;
            cboMaSP.SelectedIndexChanged += cboMaSP_SelectedIndexChanged;
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            flagPN = 0;
            string str = bll_phieunhap.GetLastMaPhieuNhaps();
            int str2 = Convert.ToInt32(str.Remove(0, 2));
            if (str2 + 1 < 10)
            {
                cboMaPN.Text = "PN00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                cboMaPN.Text = "PN0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                cboMaPN.Text = "PN" + (str2 + 1).ToString();
            }
            clearDataPN();
            clearDataCTPN();
            disEndCTPN(false);
            disEndPN(true);
            cboMaPN.Enabled = false;
            txtMaPN.Text = cboMaPN.Text;
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            string _MaPhieuNhap = "";
            string _MaNhanVien = "";
            string _MaNhaPhanPhoi = "";
            int _TongTien = 0;
            DateTime _NgayNhap = DateTime.Now;
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
                _TongTien = Convert.ToInt32(string.Format("{0:0,0.00}", txtTongTien.Text));
            }
            catch { }
            if (flagPN == 0)
            {
                if (lst.Count > 0)
                {
                    int i = bll_phieunhap.AddPhieuNhaps(_MaPhieuNhap, _MaNhanVien, _MaNhaPhanPhoi, _TongTien, _NgayNhap);
                    for (int j = 0; j < lst.Count; j++)
                    {
                        int k = bll_ctpn.AddChiTietPhieuNhaps(lst[j].MaPhieuNhap, lst[j].MaSanPham, Convert.ToInt32(lst[j].GiaNhap), lst[j].SoLuong, Convert.ToInt32(lst[j].TongTien));
                        if (k < 1)
                        {
                            XtraMessageBox.Show("Thêm mới thất bại");
                            return;
                        }
                    }
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Thêm mới thành công");
                        lst.Clear();
                        frmNhapHang_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Thêm mới thất bại");
                }
                else
                    XtraMessageBox.Show("Phiếu nhập đang rỗng");
            }
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
            disEndBtnCTPN(true);
            string _MaPhieuNhap = "";
            string _MaSanPham = "";
            string _TenSanPham = "";
            int _GiaNhap = 0;
            int _SoLuong = 0;
            int _TongTien = 0;
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
                _TenSanPham = (cboMaSP.Text.Trim());
            }
            catch { }
            try
            {
                _GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            }
            catch { }
            try
            {
                _SoLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            try
            {
                _TongTien = Convert.ToInt32(txtGiaNhap.Text) * Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            if (txtSoLuong.Text != string.Empty && Convert.ToInt32(txtSoLuong.Text) > 0)
            {
                for (int k = 0; k < lst.Count; k++)
                {
                    if (lst[k].MaSanPham == cboMaSP.SelectedValue.ToString())
                    {
                        lst[k].SoLuong = _SoLuong;
                        lst[k].TenSanPham = _TenSanPham;
                        lst[k].GiaNhap = _GiaNhap;
                        lst[k].TongTien = _TongTien;
                        MessageBox.Show("Đã cập nhật hóa đơn");
                        loadListCTPN();
                        return;
                    }
                }
                lst.Add(new ChiTietPhieuNhap { MaPhieuNhap = _MaPhieuNhap, MaSanPham = _MaSanPham, SoLuong = _SoLuong, TongTien = _TongTien });
                loadListCTPN();
                int money = 0;
                for (int i = 0; i < lst.Count; i++)
                {
                    money += Convert.ToInt32(lst[i].TongTien);
                }
                txtTongTien.Text = money.ToString();
                disEndBtnCTPN(true);
            }
            else
            {
                XtraMessageBox.Show("Hãy nhập số lượng !");
            }
        }
        private void btnSuaCTPN_Click(object sender, EventArgs e)
        {
            if (MaSP != null)
            {
                bool ex = false;
                string _MaPhieuNhap = "";
                string _MaSanPham = "";
                string _TenSanPham = "";
                int _GiaNhap = 0;
                int _SoLuong = 0;
                int _TongTien = 0;
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
                    _TenSanPham = (cboMaSP.Text.Trim());
                }
                catch { }
                try
                {
                    _GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
                }
                catch { }
                try
                {
                    _SoLuong = Convert.ToInt32(txtSoLuong.Text);
                }
                catch { }
                try
                {
                    _TongTien = Convert.ToInt32(txtGiaNhap.Text) * Convert.ToInt32(txtSoLuong.Text);
                }
                catch { }
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].MaSanPham == MaSP)
                    {
                        lst[i].GiaNhap = _GiaNhap;
                        lst[i].TenSanPham = _TenSanPham;
                        lst[i].SoLuong = _SoLuong;
                        lst[i].TongTien = _TongTien;
                        ex = true;
                        break;
                    }
                }
                if (ex)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    loadListCTPN();
                }
                else
                    XtraMessageBox.Show("Không thể sửa sản phẩm không có trong Phiếu nhập");
            }
            else
                XtraMessageBox.Show("Hãy chọn chi tiết phiếu nhập cần sửa");
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            bool ex = false;
            string _MaPhieuNhap = "";
            string _MaSanPham = "";
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
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].MaPhieuNhap == _MaPhieuNhap && lst[i].MaSanPham == _MaSanPham)
                {
                    lst.RemoveAt(i);
                    ex = true;
                    break;
                }
            }
            if (ex)
            {
                XtraMessageBox.Show("Xóa thành công");
                loadListCTPN();
            }
            else
                XtraMessageBox.Show("Không thể xóa sản phẩm không có trong Phiếu nhập");
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _MaPhieuNhap = "";
            try
            {
                _MaPhieuNhap = (cboMaPN.Text);

                txtMaPN.Text = bll_phieunhap.GetPhieuNhaps(_MaPhieuNhap).FirstOrDefault().MaPhieuNhap;
                cboNPP.Text = bll_phieunhap.GetPhieuNhaps(_MaPhieuNhap).FirstOrDefault().MaNhaPhanPhoi;
                txtTongTien.Text = bll_phieunhap.GetPhieuNhaps(_MaPhieuNhap).FirstOrDefault().TongTien.ToString();
                txtNgayNhap.Text = Convert.ToDateTime(bll_phieunhap.GetPhieuNhaps(_MaPhieuNhap).FirstOrDefault().NgayNhap.ToString()).ToString("dd-MM-yyyy");
                txtMaNV.Text = bll_nhanvien.GetTenNhanVien(bll_phieunhap.GetPhieuNhaps(_MaPhieuNhap).FirstOrDefault().MaNhanVien);
            }
            catch { }

            HienThiDSCTPN(_MaPhieuNhap);
            formatGV();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhapHang_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint())
            {
                Properties.Settings.Default.MaPN = bll_phieunhap.GetLastMaPhieuNhaps();
                Properties.Settings.Default.Save();
                frm.InPhieuNhap();
                frm.ShowDialog();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gv_CTPN_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                MaSP = gv_CTPN.GetRowCellValue(e.RowHandle, gc_TenSP).ToString();
                cboMaSP.Text = gv_CTPN.GetRowCellValue(e.RowHandle, gc_TenSP).ToString();
                txtSoLuong.Text = gv_CTPN.GetRowCellValue(e.RowHandle, gc_SoLuong).ToString();
                txtGiaNhap.Text = gv_CTPN.GetRowCellValue(e.RowHandle, gc_GiaNhap).ToString();
            }
            catch { }
        }
    }
}