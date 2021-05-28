using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Class : DBConnect
    {
        public string GetNameClassByID(int? ID)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var outputObj = _dbConnection.Query<Class>($"select CLASS_NAME from CLASS where CLASS_ID ='{ID}'").ToList();
                if (outputObj.Count == 0) return "";
                var output = outputObj[0].Class_Name;
                return output;
            }
        }

        public List<Class> GetAll()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Class>($"select * from CLASS").ToList();
                return output;
            }
        }
    }
}
