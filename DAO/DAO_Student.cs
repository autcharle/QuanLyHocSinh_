using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Student : DBConnect
    {
        public List<Student> GetAll()
        {
            var output = _connection.Query<Student>($"select * from Student").ToList();
            return output;
        }
    }
}
