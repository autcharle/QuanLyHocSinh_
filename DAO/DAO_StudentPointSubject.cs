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
    public class DAO_StudenPointSubject : DBConnect
    {
/*        public void InsertAStudent(Student _student)
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
        }*/

        public List<StudentPointSubject> getStudentPointSubject(int semester, int idClass, int idSubject)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.CLASS_ID = '{idClass}' and st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID and sb.SUBJECT_ID = '{idSubject}' and p.SEMESTER = '{semester}'").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getAllStudentPointSubject()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getBySemester(int semester)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID and p.SEMESTER = '{semester}'").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getByIdClass(int idClass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.CLASS_ID = '{idClass}' and st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getByIdSubject(int idSubject)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID and sb.SUBJECT_ID = '{idSubject}'").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getBySemesterAndIdClass(int semester, int idClass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.CLASS_ID = '{idClass}' and st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID and p.SEMESTER = '{semester}'").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getByIdClassAndIdSubject(int idClass, int idSubject)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.CLASS_ID = '{idClass}' and st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID and sb.SUBJECT_ID = '{idSubject}'").ToList();
                return output;
            }
        }

        public List<StudentPointSubject> getBySemesterAndIdSubject(int semester, int idSubject)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            {
                var output = _dbConnection.Query<StudentPointSubject>($"select st.FULLNAME, p.POINT_15, p. POINT_45, p.POINT_CK, sb.SUBJECT_NAME from STUDENT as st, POINT as p, SUBJECT as sb where st.STUDENT_ID = p.STUDENT_ID and sb.SUBJECT_ID = p.SUBJECT_ID and sb.SUBJECT_ID = '{idSubject}' and p.SEMESTER = '{semester}'").ToList();
                return output;
            }
        }
    }
}
