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

namespace QuanLyCuaHangDM
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_SanPham bll_sp = new DAL_BLL_SanPham();
        DAL_BLL_HangSanXuat bll_hsx = new DAL_BLL_HangSanXuat();
        DAL_BLL_LoaiSanPham bll_lsp = new DAL_BLL_LoaiSanPham();
        public frmSanPham()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmSanPham nv = new frmSanPham();
        public void HienThiDSSanPham()
        {
            gridCtrlSanPham.DataSource = bll_sp.GetSanPhams();
        }
        void binding()
        {
            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "MaSanPham");
            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "TenSanPham");
            cboLoaiSP.DataBindings.Clear();
            cboLoaiSP.DataBindings.Add("SelectedValue", gridCtrlSanPham.DataSource, "LoaiSanPham");
            cboHSX.DataBindings.Clear();
            cboHSX.DataBindings.Add("SelectedValue", gridCtrlSanPham.DataSource, "HangSanXuat");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "GiaNhap");
            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "GiaBan");
            txtTonKho.DataBindings.Clear();
            txtTonKho.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "TonKho");
            txtHinhSanPham.DataBindings.Clear();
            txtHinhSanPham.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "Image");
            picHinhSP.DataBindings.Clear();
            cboBangMau.DataBindings.Clear();
            cboBangMau.DataBindings.Add("Text", gridCtrlSanPham.DataSource, "BangMau");
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
        public void loadControl_cboLSP()
        {
            cboLoaiSP.DataSource = bll_lsp.GetLoaiSanPhams();
            cboLoaiSP.DisplayMember = "TenLoaiSanPham";
            cboLoaiSP.ValueMember = "MaLoaiSanPham";
            cboLoaiSP.SelectedIndex = 0;
        }
        public void loadControl_cboTT()
        {
            cboBangMau.Items.Clear();
            cboBangMau.Items.Add("Còn");
            cboBangMau.Items.Add("Hết");
            cboBangMau.SelectedIndex = 0;
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
            loadControl_cboTT();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            disEnd(false);
            loadControl_cboHSX();
            loadControl_cboLSP();
            loadControl_cboTT();
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            clearData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
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
                    int i = 0;
                    //i = Controllers.SanPhamCtrl.DeleteSanPham(_MaSanPham);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSSanPham();
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
                _TonKho = Convert.ToInt32(txtTonKho.Text);
            }
            catch { }
            try
            {
                _MaMau = cboBangMau.Text;
            }
            catch { }
            try
            {
                _HinhSanPham = txtHinhSanPham.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_TenSanPham == "" || _GiaNhap <= 0 || _GiaBan <= 0 || _TonKho < 0)
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_sp.AddSanPhams(_MaSanPham, _TenSanPham, _LoaiSanPham, _HangSanXuat, _GiaNhap, _GiaBan, _TonKho, _MaMau, _HinhSanPham);
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
                if (_TenSanPham == "" || _GiaNhap <= 0 || _GiaBan <= 0 || _TonKho < 0)
                    XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = bll_sp.UpdateSanPhams(_MaSanPham, _TenSanPham, _LoaiSanPham, _HangSanXuat, _GiaNhap, _GiaBan, _TonKho, _MaMau, _HinhSanPham);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
            }
            frmSanPham_Load(sender, e);
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
                if (txtHinhSanPham.Text != "")
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
    }
}