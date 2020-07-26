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
    public partial class Register : DevExpress.XtraEditors.XtraForm
    {
        public Register()
        {
            InitializeComponent();
            txtPass.Properties.PasswordChar = '*';
            txtRePass.Properties.PasswordChar = '*';
        }
    }
}