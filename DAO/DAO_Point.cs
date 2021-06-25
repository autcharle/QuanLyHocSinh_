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
    public class DAO_Point : DBConnect
    {
        public List<Point> GetOneSubjectMarkBySemester(int? IDSubject, int? IDStudent, int? IDSemester)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<Point>($"select POINT_15,POINT_45,POINT_CK from POINT where SUBJECT_ID = '{IDSubject}' and STUDENT_ID = '{IDStudent}' and SEMESTER = '{IDSemester}'").ToList();
                return output;
            }
        }

        public bool DeletePointByStudentID(int ID)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var affectedRows = _dbConnection.Execute($"delete from POINT where STUDENT_ID = '{ID}'");
                if (affectedRows == 0) return false;
                else return true;
            }
        }
    }
}
