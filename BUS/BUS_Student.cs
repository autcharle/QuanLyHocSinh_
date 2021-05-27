using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Student
    {
        DAO_Student _daoStudent = new DAO_Student();
        DAO_Class _daoClassroom = new DAO_Class();
        BUS_Point _busMark = new BUS_Point();

        public List<Student> GetAllStudent() => _daoStudent.GetAll();
        /// <summary>
        /// Tra cứu học sinh
        /// </summary>
        /// <returns>Danh sách học sinh theo BM3</returns>
        public List<Student> ReadAllStudent()
        {
            var output = GetAllStudent();
            //Lấy tên lớp của học sinh
            foreach (var _student in output)
            {
                _student.NameClass = _daoClassroom.GetNameClassByID(_student.Class_ID);
                _student.Score1stSem = Math.Round((double)_busMark.CalAverageAllSubjectMarkBySemester(_student.Student_ID, 1),2);
                _student.Score2ndSem = Math.Round((double)_busMark.CalAverageAllSubjectMarkBySemester(_student.Student_ID, 2),2);

            }
            //Lấy điểm các môn

            //Tính điểm trung bình mỗi môn

            //Tính điểm trung bình học kỳ

            //Gán vào thuộc tính của Student


            return output;
        }
    }
}
