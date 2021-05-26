using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBConnect
    {
        protected SqlConnection _connection = new SqlConnection(@"Data Source=SHEEPIN\MYSQL;Initial Catalog=QuanLyHocSinh;Integrated Security=True");
    }
}
