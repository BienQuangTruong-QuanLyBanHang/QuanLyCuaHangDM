using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DAL_BLL
{
    public class QL_CSDL
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.QuanLySanPhamConnectionString == null)
                return 1;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.QuanLySanPhamConnectionString);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
    }
}
