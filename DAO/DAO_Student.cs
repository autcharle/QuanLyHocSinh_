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
            DBConnect _dbContext = new DBConnect();
            IDbConnection dbConnection = _dbContext.CreateConnection();
            var output = dbConnection.Query<Student>($"select * from Student").ToList();
            return output;
        }
    }
}
