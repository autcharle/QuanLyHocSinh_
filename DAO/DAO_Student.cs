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
        public void InsertAStudent(Student _student)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var affectedRows = _dbConnection.Execute($"insert into STUDENT (FULLNAME,GENDER,BIRTHDAY,ADDRESS,EMAIL) values (@FullName,@Gender,@Birthday,@Address,@Email)", new
                {
                    FullName = _student.FullName,
                    Gender = _student.Gender,
                    Birthday = _student.Birthday,
                    Address = _student.Address,
                    Email = _student.Email
                }) ;
            }
        }
        public List<Student> GetAll()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            { 
                var output = _dbConnection.Query<Student>($"select * from STUDENT").ToList();
                return output;
            }
        }

        public List<Student> GetStudentByClassID(int? IDClass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Student>($"select * from STUDENT where CLASS_ID = '{IDClass}'").ToList();
                return output;
            }
        }

        public List<Student> GetStudentByName(string NameStudent)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Student>($"select * from STUDENT where FULLNAME like N'%{NameStudent}%'").ToList();
                return output;
            }
        }

        public List<Student> GetStudentByNameAndClassID(string NameStudent, int? IDClass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Student>($"select * from STUDENT where FULLNAME like N'%{NameStudent}%' and CLASS_ID = '{IDClass}'").ToList();
                return output;
            }
        }
    }
}
