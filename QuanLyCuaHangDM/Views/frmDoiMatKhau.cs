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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            txtMatKhauCu.Properties.PasswordChar = '*';
            txtMatKhauMoi.Properties.PasswordChar = '*';
            txtMatKhauNhapLai.Properties.PasswordChar = '*';
        }

        private void linkDangKy_Click(object sender, EventArgs e)
        {

        }
    }
}