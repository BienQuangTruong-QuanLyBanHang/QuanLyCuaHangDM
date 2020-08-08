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
using DevExpress.Utils.Extensions;
using DevExpress.DataProcessing;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyCuaHangDM
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_HoaDon bll_hd = new DAL_BLL_HoaDon();
        DAL_BLL_ChiTietHoaDon bll_cthd = new DAL_BLL_ChiTietHoaDon();
        DAL_BLL_SanPham bll_sp = new DAL_BLL_SanPham();
        DAL_BLL_KhachHang bll_kh = new DAL_BLL_KhachHang();
        DAL_BLL_NhanVien bll_nv = new DAL_BLL_NhanVien();
        List<ChiTietHoaDon> lst = new List<ChiTietHoaDon>();
        string MaNV;
        string MaSP = null;
        int flagHD = 0;
        public frmBanHang()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        public frmBanHang(string _MaNV)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            MaNV = _MaNV;
        }
        public static frmNhapHang nv = new frmNhapHang();

        public void HienThiDSCTHD(string _MaHoaDon)
        {
            try
            {
                gridCtrlCTHD.DataSource = bll_cthd.GetChiTietHoaDons(_MaHoaDon);
            }
            catch { }
        }
        void disEndPN(bool e)
        {
            cboMaKH.Enabled = e;
            cboMaHD.Enabled = !e;
            btnThemHD.Enabled = !e;
            btnLuuHD.Enabled = e;
            btnThemCTHD.Enabled = e;
        }
        void disEndCTPN(bool e)
        {
            cboMaSP.Enabled = e;
            txtSoLuong.Enabled = e;
            btnThemCTHD.Enabled = e;
        }
        void disEndBtnCTHD(bool e)
        {
            btnSuaCTHD.Enabled = e;
            btnXoaCTHD.Enabled = e;
        }
        public void loadControl_cboMaHD()
        {
            cboMaHD.DataSource = bll_hd.GetHoaDons();
            cboMaHD.DisplayMember = "MaHoaDon";
            cboMaHD.ValueMember = "MaHoaDon";
            cboMaHD.SelectedIndex = 0;
        }
        public void loadControl_cboMaKH()
        {
            cboMaKH.DataSource = bll_kh.GetKhachHangs();
            cboMaKH.DisplayMember = "MaKhachHang";
            cboMaKH.ValueMember = "MaKhachHang";
            cboMaKH.SelectedIndex = 0;
        }
        public void loadControl_cboMaSP()
        {
            cboMaSP.DataSource = bll_sp.GetSanPhams();
            cboMaSP.DisplayMember = "TenSanPham";
            cboMaSP.ValueMember = "MaSanPham";
            cboMaSP.SelectedIndex = 0;
        }
        void clearDataHD()
        {
            txtTongTien.Text = "";
            txtNgayLapHoaDon.Text = Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("dd-MM-yyyy");
            loadControl_cboMaKH();
            txtMaNV.Text = bll_nv.GetTenNhanVien(MaNV);
        }
        void clearDataCTHD()
        {
            txtSoLuong.Text = "0";
            gridCtrlCTHD.DataSource = null;
            loadControl_cboMaSP();
        }
        void loadListCTHD()
        {
            var source = new BindingSource();
            source.DataSource = lst;
            gridCtrlCTHD.DataSource = source;
            formatGV();
        }
        void formatGV()
        {
            gv_CTHD.Columns["SoLuong"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv_CTHD.Columns["SoLuong"].DisplayFormat.FormatString = "#,###";

            gv_CTHD.Columns["TongTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv_CTHD.Columns["TongTien"].DisplayFormat.FormatString = "#,###";

            gv_CTHD.Columns["GiaBan"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv_CTHD.Columns["GiaBan"].DisplayFormat.FormatString = "#,###";
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cboMaHD.SelectedIndexChanged -= cboMaHD_SelectedIndexChanged_1;
            cboMaSP.SelectedIndexChanged -= cboMaSP_SelectedIndexChanged_1;
            disEndPN(false);
            disEndCTPN(false);
            disEndBtnCTHD(false);
            cboMaHD.Enabled = true;
            loadControl_cboMaHD();
            loadControl_cboMaKH();
            loadControl_cboMaSP();
            clearDataHD();
            cboMaHD.SelectedIndexChanged += cboMaHD_SelectedIndexChanged_1;
            cboMaSP.SelectedIndexChanged += cboMaSP_SelectedIndexChanged_1;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            flagHD = 0;
            string str = bll_hd.GetLastHoaDons();
            int str2 = Convert.ToInt32(str.Remove(0, 2));
            if(str2 + 1 < 10)
            {
                cboMaHD.Text = "HD00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                cboMaHD.Text = "HD0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                cboMaHD.Text = "HD" + (str2 + 1).ToString();
            }
            cboMaHD.Enabled = false;
            disEndPN(true);
            disEndCTPN(true);
            clearDataHD();
            clearDataCTHD();
            txtMaHD.Text = cboMaHD.Text;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string _MaHoaDon = "";
            string _MaNhanVien = "";
            string _MaKhachHang = "";
            int _TongTien = 0;
            DateTime _NgayNhap = DateTime.Now;
            try
            {
                _MaHoaDon = (cboMaHD.Text);
            }
            catch { }
            try
            {
                _MaNhanVien = MaNV;
            }
            catch { }
            try
            {
                _MaKhachHang = (cboMaKH.SelectedValue.ToString());
            }
            catch { }
            try
            {
                _TongTien = Convert.ToInt32(string.Format("{0:0,0.00}", txtTongTien.Text));
            }
            catch { }
            if (flagHD == 0)
            {
                if (lst.Count > 0)
                {
                    int i = bll_hd.addHoaDon(_MaHoaDon, _MaKhachHang, _MaNhanVien, _NgayNhap, _TongTien);
                    for (int j = 0; j < lst.Count; j++)
                    {
                        int k = bll_cthd.AddChiTietHoaDons(lst[j].MaHoaDon, lst[j].MaSanPham, lst[j].SoLuong, Convert.ToInt32(lst[j].TongTien));
                        if(k < 1)
                        {
                            XtraMessageBox.Show("Thêm mới thất bại");
                            return;
                        }
                    }
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Lưu thành công");
                        lst.Clear();
                        frmBanHang_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Lưu thất bại");
                }
                else
                    XtraMessageBox.Show("Đơn hàng đang rỗng");
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

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            disEndBtnCTHD(true);
            string _MaHoaDon = "";
            string _MaSanPham = "";
            string _TenSanPham = "";
            int _GiaBan = 0;
            int _SoLuong = 0;
            int _TongTien = 0;
            try
            {
                _MaHoaDon = (cboMaHD.Text);
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
                _GiaBan = Convert.ToInt32(txtGiaBan.Text);
            }
            catch { }
            try
            {
                _SoLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            try
            {
                _TongTien = Convert.ToInt32(txtGiaBan.Text) * Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            if (txtSoLuong.Text != string.Empty && Convert.ToInt32(txtSoLuong.Text) > 0)
            {
                int tonkho = bll_sp.GetSoLuongTonKho(_MaSanPham);
                if (Convert.ToInt32(txtSoLuong.Text) <= tonkho)
                {
                    for(int k = 0; k < lst.Count; k++)
                    {
                        if(lst[k].MaSanPham == cboMaSP.SelectedValue.ToString())
                        {
                            lst[k].TenSanPham = _TenSanPham;
                            lst[k].DonGia = _GiaBan;
                            lst[k].SoLuong = _SoLuong;
                            lst[k].TongTien = _TongTien;
                            MessageBox.Show("Đã cập nhật hóa đơn");
                            loadListCTHD();
                            return;
                        }
                    }
                    lst.Add(new ChiTietHoaDon { MaHoaDon = _MaHoaDon, MaSanPham = _MaSanPham, TenSanPham = _TenSanPham, SoLuong = _SoLuong, TongTien = _TongTien });
                    loadListCTHD();
                    int money = 0;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        money += Convert.ToInt32(lst[i].TongTien);
                    }
                    txtTongTien.Text = money.ToString();
                    disEndBtnCTHD(true);
                }
                else
                    XtraMessageBox.Show(cboMaSP.Text + " tồn kho còn: " + tonkho + " .Không đủ số lượng để bán !");
            }
            else
            {
                XtraMessageBox.Show("Hãy nhập số lượng !");
            }
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmBanHang_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint())
            {
                Properties.Settings.Default.MaHD = bll_hd.GetLastHoaDons();
                Properties.Settings.Default.Save();
                frm.InHoaDon();
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

        private void cboMaSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string _MaSanPham = "";
            try
            {
                _MaSanPham = cboMaSP.SelectedValue.ToString();
                txtGiaBan.Text = bll_sp.GetGiaban(_MaSanPham).ToString();
            }
            catch { }
        }

        private void cboMaHD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string _MaHoaDon = "";
            try
            {
                _MaHoaDon = (cboMaHD.Text);

                txtMaHD.Text = bll_hd.GetHoaDons(_MaHoaDon).FirstOrDefault().MaHoaDon;
                cboMaKH.Text = bll_hd.GetHoaDons(_MaHoaDon).FirstOrDefault().MaKhachHang;
                txtTongTien.Text = bll_hd.GetHoaDons(_MaHoaDon).FirstOrDefault().TongTien.ToString();
                txtNgayLapHoaDon.Text = Convert.ToDateTime(bll_hd.GetHoaDons(_MaHoaDon).FirstOrDefault().NgayLapHoaDon.ToString()).ToString("dd-MM-yyyy");
                txtMaNV.Text = bll_nv.GetTenNhanVien(bll_hd.GetHoaDons(_MaHoaDon).FirstOrDefault().MaNhanVien);
            }
            catch { }

            HienThiDSCTHD(_MaHoaDon);
            formatGV();
        }

        private void gv_CTHD_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                MaSP = gv_CTHD.GetRowCellValue(e.RowHandle, gc_MaSP).ToString();
                cboMaSP.Text = gv_CTHD.GetRowCellValue(e.RowHandle, gc_TenSanPham).ToString();
                txtSoLuong.Text = gv_CTHD.GetRowCellValue(e.RowHandle, gc_SoLuong).ToString();
            }
            catch { }
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            if (MaSP != null)
            {
                bool ex = false;
                string _MaSanPham = "";
                string _TenSanPham = "";
                int _GiaBan = 0;
                int _SoLuong = 0;
                int _TongTien = 0;
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
                    _GiaBan = Convert.ToInt32(txtGiaBan.Text);
                }
                catch { }
                try
                {
                    _SoLuong = Convert.ToInt32(txtSoLuong.Text);
                }
                catch { }
                try
                {
                    _TongTien = Convert.ToInt32(txtGiaBan.Text) * Convert.ToInt32(txtSoLuong.Text);
                }
                catch { }
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].MaSanPham == MaSP)
                    {
                        lst[i].MaSanPham = _MaSanPham;
                        lst[i].TenSanPham = _TenSanPham;
                        lst[i].DonGia = _GiaBan;
                        lst[i].SoLuong = _SoLuong;
                        lst[i].TongTien = _TongTien;
                        ex = true;
                        break;
                    }
                }
                if (ex)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    MaSP = null;
                    loadListCTHD();
                }
                else
                    XtraMessageBox.Show("Không thể sửa sản phẩm không có trong hóa đơn");
            }
            else
                XtraMessageBox.Show("Hãy chọn chi tiết hóa đơn cần sửa");
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            bool ex = false;
            string _MaHoaDon = "";
            string _MaSanPham = "";
            try
            {
                _MaHoaDon = (cboMaHD.Text);
            }
            catch { }
            try
            {
                _MaSanPham = (cboMaSP.SelectedValue.ToString());
            }
            catch { }
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].MaHoaDon == _MaHoaDon && lst[i].MaSanPham == _MaSanPham)
                {
                    lst.RemoveAt(i);
                    int money = 0;
                    for (int j = 0; j < lst.Count; j++)
                    {
                        money += Convert.ToInt32(lst[j].TongTien);
                    }
                    txtTongTien.Text = (money + (money * 1) / 10).ToString();
                    ex = true;
                    break;
                }
            }
            if (ex)
            {
                XtraMessageBox.Show("Xóa thành công");
                loadListCTHD();
            }
            else
                XtraMessageBox.Show("Không thể xóa sản phẩm không có trong hóa đơn");
        }

        private void txtSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }

        private void txtSoLuong_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }
    }
}