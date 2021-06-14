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
    public class DAO_Config : DBConnect
    {
        public List<Config> GetAll()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Config>($"select * from CONFIG").ToList();
                return output;
            }
        }
        public Config GetConfig()
        {
            DBConnect _dbContext = new DBConnect();
            var output = new Config();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                try
                {
                    output = _dbConnection.Query<Config>($"select * from CONFIG").FirstOrDefault();
                    return output;
                }
                catch (Exception ex)
                {
                    var mess = ex.Message;
                    return null;
                }
            }
        }
    }
}
