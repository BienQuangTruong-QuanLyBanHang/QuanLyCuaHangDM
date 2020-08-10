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
using DAL_BLL;
using DevExpress.XtraReports.UI;
using System.Text.RegularExpressions;

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
            txtNgayVaoLam.Text = Convert.ToDateTime(DateTime.Now).ToString("dd-MM-yyyy");
            loadControl_cboGT();
            loadControl_cboCV();
        }
        void reActive()
        {
            HienThiDSNhanVien();
            disEnd(false);
            gv_NhanVien.RowClick += gv_NhanVien_RowClick;
        }
        bool kiemTraSDT(string _SDT)
        {
            List<string> lst = new List<string>() { "032", "033", "034", "035", "036", "037", "038", "039"
            , "070", "079", "077", "076", "078"
            , "083", "084", "085", "081", "082", "088", "091", "094", "099", "059", "092", "093", "095", "096", "097", "098"
            , "056", "058", "085", "081", "082"};
            for (int i = 0; i < lst.Count; i++)
            {
                if (_SDT.StartsWith(lst[i]))
                {
                    if (_SDT.Length == 10)
                    {
                        return true;
                    }
                    continue;
                }
            }
            return false;
        }
        bool kiemTraTextLength(string _Str)
        {
            if (_Str.Length < 5 || _Str.Length > 50)
                return false;
            return true;
        }
        bool kiemTraNgaySinh(DateTime _dt)
        {
            if ((DateTime.Now.Year - _dt.Year) > 16)
            {
                return true;
            }
            else if ((DateTime.Now.Year - _dt.Year) == 16)
            {
                if (DateTime.Now.Month < _dt.Month)
                {
                    if (DateTime.Now.Day < _dt.Day)
                        return true;
                }
            }
            return false;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            clearData();
            disEnd(false);
            binding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            loadControl_cboGT();
            loadControl_cboCV();
            gv_NhanVien.RowClick -= gv_NhanVien_RowClick;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            loadControl_cboGT();
            loadControl_cboCV();
            clearData();
            gv_NhanVien.RowClick -= gv_NhanVien_RowClick;
            string str = bll_nv.GetLastMaNhanViens();
            int str2 = Convert.ToInt32(str.Remove(0, 2));
            if (str2 + 1 < 10)
            {
                txtMaNV.Text = "NV00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtMaNV.Text = "NV0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtMaNV.Text = "NV" + (str2 + 1).ToString();
            }
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
            if (_TenNhanVien == "" || _DiaChi == "" || _SoDT == "")
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            if(!kiemTraSDT(_SoDT))
            {
                XtraMessageBox.Show("Số điện thoại sai định dạng");
                return;
            }
            if(!kiemTraTextLength(_TenNhanVien))
            {
                XtraMessageBox.Show("Tên nhân viên giới hạn 5 ~ 50 kí tự");
                return;
            }
            if (!kiemTraTextLength(_DiaChi))
            {
                XtraMessageBox.Show("Địa chỉ giới hạn 5 ~ 50 kí tự");
                return;
            }
            if(!kiemTraNgaySinh(_NgaySinh))
            {
                XtraMessageBox.Show("Ngày sinh không hợp lệ, tuổi nhân viên phải lớn hơn 16");
                return;
            }    
            if (flag == 0)
            {
                int i = bll_nv.AddNhanViens(_MaNhanVien, _TenNhanVien, _NgaySinh, _GioiTinh, _NgayVaoLam, _ChucVu, _DiaChi, _SoDT);
                if (i > 0)
                {
                    XtraMessageBox.Show("Thêm mới thành công");
                    reActive();
                }
                else
                    XtraMessageBox.Show("Thêm mới thất bại");
            }
            else
            {
                int i = bll_nv.UpdateNhanViens(_MaNhanVien, _TenNhanVien, _NgaySinh, _GioiTinh, _ChucVu, _DiaChi, _SoDT);
                if (i > 0)
                {
                    XtraMessageBox.Show("Sửa thành công");
                    reActive();
                }
                else
                    XtraMessageBox.Show("Sửa thất bại");
            }
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
            reActive();
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

        private void gv_NhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtMaNV.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_MaNhanVien).ToString();
                txtTenNV.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_TenNV).ToString();
                txtDT.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_DienThoai).ToString();
                txtDC.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_DiaChi).ToString();
                dtpNgaySinh.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_NgaySinh).ToString();
                cboChucVu.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_ChucVu).ToString();
                cboGioiTinh.Text = gv_NhanVien.GetRowCellValue(e.RowHandle, gc_GioiTinh).ToString();
            }
            catch { }
        }

        private void txtDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^[0-9a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ./, ]+$");
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }

        private void txtDT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }
    }
}