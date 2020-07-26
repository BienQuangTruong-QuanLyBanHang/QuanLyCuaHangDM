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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_User bll_user = new DAL_BLL_User();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = '*';
            chkBoxRemember.Checked = true;
            txtUser.Text = Properties.Settings.Default.userName;
            txtPass.Text = Properties.Settings.Default.pass;
        }

        private void linkDangKy_Click(object sender, EventArgs e)
        {
            
        }

        private void chkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}