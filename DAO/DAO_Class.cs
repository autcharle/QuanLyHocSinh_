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
        public void InsertAClass(Class _class)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var affectedRows = _dbConnection.Execute($"insert into CLASS (CLASS_NAME,CLASS_GROUP)  values (@ClassName,@ClassGroup)", new
                {

                    ClassName = _class.Class_Name,
                    ClassGroup = _class.Class_Group,
                }) ;
               ;
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
        public List<Class> GetAllClassGroup()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Class>($"select CLASS_GROUP from CLASS GROUP BY CLASS_GROUP").ToList();
                return output;
            }
        }
        public List<Class> ReadClassByClassGroup(int class_group)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Class>($"select * from CLASS where CLASS_GROUP = '{class_group}'").ToList();
                return output;
            }
        }
        public List<Class> ReadClassByID( int  class_id)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Class>($"select * from CLASS where CLASS_ID = '{class_id}'").ToList();
                return output;
            }
        }
        public List<Class> ReadClassByByNameAndClassGroup(string NameClass,int? Class_Group)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Class>($"select * from CLASS where CLASS_NAME like N'%{NameClass}%' AND CLASS_GROUP='{ Class_Group}'").ToList();
                return output;
            }
        }
        public List<Class> ReadClassByName(string NameClass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Class>($"select * from CLASS where CLASS_NAME like N'%{NameClass}%'").ToList();
                return output;
            }
        }
    }
}
