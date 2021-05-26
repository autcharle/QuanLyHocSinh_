using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Student : DBConnect
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", _connection);
            DataTable dtStudent = new DataTable();
            da.Fill(dtStudent);
            return dtStudent;
        }
    }
}
