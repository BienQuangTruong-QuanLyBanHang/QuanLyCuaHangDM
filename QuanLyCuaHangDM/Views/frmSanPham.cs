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
using System.Data.SqlClient;
using System.IO;
using DAL_BLL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraLayout.Converter;
using System.Globalization;
using DevExpress.Utils.MVVM;

namespace QuanLyCuaHangDM
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_SanPham bll_sp = new DAL_BLL_SanPham();
        DAL_BLL_HangSanXuat bll_hsx = new DAL_BLL_HangSanXuat();
        DAL_BLL_LoaiSanPham bll_lsp = new DAL_BLL_LoaiSanPham();
        DAL_BLL_BangMau bll_bangmau = new DAL_BLL_BangMau();
        public frmSanPham()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmSanPham nv = new frmSanPham();
        public void HienThiDSSanPham()
        {
            try
            {
                gridCtrlSanPham.DataSource = bll_sp.GetSanPhams();
                //CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                //string a = double.Parse("12345").ToString("#,###", cul.NumberFormat);

                gv_SanPham.Columns["GiaNhap"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gv_SanPham.Columns["GiaNhap"].DisplayFormat.FormatString = "#,###";

                gv_SanPham.Columns["GiaBan"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gv_SanPham.Columns["GiaBan"].DisplayFormat.FormatString = "#,###";

                gv_SanPham.Columns["TonKho"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gv_SanPham.Columns["TonKho"].DisplayFormat.FormatString = "#,###";

                rep_Image.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
                rep_Image.BestFitWidth = 100;
                gv_SanPham.Columns["Image"].ColumnEdit = rep_Image;
                
            }
            catch { }
        }
        void binding()
        {
            
        }
        void disEnd(bool e)
        {
            txtTenSP.Enabled = e;
            cboLoaiSP.Enabled = e;
            cboHSX.Enabled = e;
            txtGiaNhap.Enabled = e;
            txtGiaBan.Enabled = e;
            txtTonKho.Enabled = e;
            cboBangMau.Enabled = e;
            cboDVT.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnUpload.Enabled = e;
        }
        public void loadControl_cboHSX()
        {
            cboHSX.DataSource = bll_hsx.GetHangSanXuats();
            cboHSX.DisplayMember = "TenHangSanXuat";
            cboHSX.ValueMember = "MaHangSanXuat";
            cboHSX.SelectedIndex = 0;
        }
        public void loadControl_cboBangMau()
        {
            cboBangMau.DataSource = bll_bangmau.GetBangMaus();
            cboBangMau.DisplayMember = "TenMau";
            cboBangMau.ValueMember = "MaMau";
            cboBangMau.SelectedIndex = 0;
        }
        public void loadControl_cboLSP()
        {
            cboLoaiSP.DataSource = bll_lsp.GetLoaiSanPhams();
            cboLoaiSP.DisplayMember = "TenLoaiSanPham";
            cboLoaiSP.ValueMember = "MaLoaiSanPham";
            cboLoaiSP.SelectedIndex = 0;
        }
        public void loadControl_cboDVT()
        {
            List<string> lst = new List<string>() { "Cái", "Bộ", "Thùng", "Hộp", "Chai" };
            cboDVT.Items.Clear();
            cboDVT.DataSource = lst;
        }
        void clearData()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtTonKho.Text = "";
            txtHinhSanPham.Text = "";
            loadControl_cboHSX();
            loadControl_cboLSP();
            loadControl_cboBangMau();
        }
        void reActive()
        {
            HienThiDSSanPham();
            disEnd(false);
            gv_SanPham.RowClick += gv_SanPham_RowClick;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            disEnd(false);
            loadControl_cboHSX();
            loadControl_cboLSP();
            loadControl_cboDVT();
            loadControl_cboBangMau();
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            clearData();
            gv_SanPham.RowClick -= gv_SanPham_RowClick;
            string str = bll_sp.GetLastMaSanPhams();
            int str2 = Convert.ToInt32(str.Remove(0, 2));
            if (str2 + 1 < 10)
            {
                txtMaSP.Text = "SP00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtMaSP.Text = "SP0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtMaSP.Text = "SP" + (str2 + 1).ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            gv_SanPham.RowClick -= gv_SanPham_RowClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaSanPham = "";
            try
            {
                _MaSanPham = (txtMaSP.Text);
            }
            catch { }
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int rs = bll_sp.kiemTraKhoaNgoai(_MaSanPham);
                if (rs > 0)
                {
                    int i = bll_sp.DeleteSanPhams(_MaSanPham);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        frmSanPham_Load(sender, e);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaSanPham = "";
            string _TenSanPham = "";
            string _LoaiSanPham = "";
            string _HangSanXuat = "";
            int _GiaNhap = 0;
            int _GiaBan = 0;
            int _TonKho = 0;
            string _DVT = "";
            string _MaMau = "";
            string _HinhSanPham = "";
            try
            {
                _MaSanPham = (txtMaSP.Text);
            }
            catch { }
            try
            {
                _TenSanPham = txtTenSP.Text;
            }
            catch { }
            try
            {
                _LoaiSanPham = (cboLoaiSP.SelectedValue.ToString());
            }
            catch { }
            try
            {
                _HangSanXuat = (cboHSX.SelectedValue.ToString());
            }
            catch { }
            try
            {
                _GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            }
            catch { }
            try
            {
                _GiaBan = Convert.ToInt32(txtGiaBan.Text);
            }
            catch { }
            try
            {
                _DVT = cboDVT.Text;
            }
            catch { }
            try
            {
                _TonKho = Convert.ToInt32(txtTonKho.Text);
            }
            catch { }
            try
            {
                _MaMau = cboBangMau.SelectedValue.ToString();
            }
            catch { }
            try
            {
                _HinhSanPham = txtHinhSanPham.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_TenSanPham == "" || txtGiaNhap.Text == string.Empty || txtGiaBan.Text == string.Empty || txtTonKho.Text == string.Empty)
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_sp.AddSanPhams(_MaSanPham, _TenSanPham, _LoaiSanPham, _HangSanXuat, _GiaNhap, _GiaBan, _DVT, _TonKho, _MaMau, _HinhSanPham);
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
                if (_TenSanPham == "" || txtGiaNhap.Text == string.Empty || txtGiaBan.Text == string.Empty || txtTonKho.Text == string.Empty)
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_sp.UpdateSanPhams(_MaSanPham, _TenSanPham, _LoaiSanPham, _HangSanXuat, _GiaNhap, _GiaBan, _DVT, _TonKho, _MaMau, _HinhSanPham);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                        reActive();
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if(xtraOpenFileDialog1.CheckFileExists)
{
                        string extension = System.IO.Path.GetExtension(xtraOpenFileDialog1.FileName);

                        if (extension == ".jpg" || extension == ".png")
                        {
                            System.IO.FileInfo fInfo = new System.IO.FileInfo(xtraOpenFileDialog1.FileName);
                            string strFileName = fInfo.Name;
                            string strFilePath = fInfo.DirectoryName;
                            txtHinhSanPham.Text = strFilePath + "\\" + strFileName;
                        }
                        else
                        {
                            XtraMessageBox.Show("Chỉ cho phép file .jpg và .png!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnHangSX_Click(object sender, EventArgs e)
        {
            frmHangSX Hang = null;
            if (Hang == null || Hang.IsDisposed)
                Hang = new frmHangSX();
            Hang.ShowDialog();
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSP LoaiSP = null;
            if (LoaiSP == null || LoaiSP.IsDisposed)
                LoaiSP = new frmLoaiSP();
            LoaiSP.ShowDialog();
        }

        private void gridCtrlSanPham_Click(object sender, EventArgs e)
        {
            binding();
        }

        private void txtHinhSanPham_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtHinhSanPham.Text != string.Empty)
                    picHinhSP.Image = Image.FromFile(@"" + txtHinhSanPham.Text);
                else
                    picHinhSP.Image = Image.FromFile("/Resources/image-not-found.jpg");
            }
            catch { }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmMain.num = 6;
            using (frmPrint prt = new frmPrint())
            {
                prt.ShowDialog();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void gv_SanPham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaSP.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_MaSanPham).ToString();
                txtTenSP.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_TenSanPham).ToString();
                cboLoaiSP.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_LoaiSanPham).ToString();
                cboHSX.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_HangSanXuat).ToString();
                txtGiaNhap.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_GiaNhap).ToString();
                txtGiaBan.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_GiaBan).ToString();
                txtTonKho.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_TonKho).ToString();
                cboBangMau.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_Mau).ToString();
                txtMaSP.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_MaSanPham).ToString();
                picHinhSP.Image = Image.FromFile(gv_SanPham.GetRowCellValue(e.RowHandle, gc_Image).ToString());
                txtHinhSanPham.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_Image).ToString();
                cboDVT.Text = gv_SanPham.GetRowCellValue(e.RowHandle, gc_DVT).ToString();
            }
            catch { }
        }

        private void gv_SanPham_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            try
            {
                int dx = 5;
                Rectangle r = e.Bounds;
                r.X += e.Bounds.Height + dx + 2;
                r.Width -= (e.Bounds.Height + dx + 3);
                e.Graphics.DrawImage(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(
                    (byte[])gv_SanPham.GetDataRow(e.RowHandle)["gridCtrlSanPham"]), e.Bounds.X + dx,
                    e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
                e.Appearance.DrawString(e.Cache, gv_SanPham.GetRowPreviewDisplayText(e.RowHandle), r);
                e.Handled = true;
            }
            catch { }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            string value = txtGiaNhap.Text.Replace(",", "").Replace("đ", "");
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                //Unsub the event so we don't enter a loop
                txtGiaNhap.TextChanged -= txtGiaNhap_TextChanged;
                //Format the text as currency
                txtGiaNhap.Text = string.Format(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"), "{0:N0}", ul);
                txtGiaNhap.TextChanged += txtGiaNhap_TextChanged;
            }
        }
    }
}