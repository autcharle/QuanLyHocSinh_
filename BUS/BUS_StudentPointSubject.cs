using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_StudentPointSubject
    {
        DAO_Point _daoMark = new DAO_Point();
        BUS_Subject _busSubject = new BUS_Subject();
        DAO_StudenPointSubject _daoStudenPointSubject = new DAO_StudenPointSubject();
        DAO_Class _daoClass = new DAO_Class();

        public List<StudentPointSubject> getStudentPointSubject(int semester, int idClass, int idSubject) => _daoStudenPointSubject.getStudentPointSubject(semester, idClass, idSubject);

        public List<StudentPointSubject> getAllStudentPointSubject() => _daoStudenPointSubject.getAllStudentPointSubject();

        public List<StudentPointSubject> getBySemester(int semester) => _daoStudenPointSubject.getBySemester(semester);

        public List<StudentPointSubject> getByIdSubject(int idSubject) => _daoStudenPointSubject.getByIdSubject(idSubject);

        public List<StudentPointSubject> getByIdClass(int idClass) => _daoStudenPointSubject.getByIdClass(idClass);

        public List<StudentPointSubject> getBySemesterAndIdClass(int semester,int idclass) => _daoStudenPointSubject.getBySemesterAndIdClass(semester, idclass);

        public List<StudentPointSubject> getByIdClassAndIdSubject(int idClass,int idSubject) => _daoStudenPointSubject.getByIdClassAndIdSubject(idClass, idSubject);

        public List<StudentPointSubject> getBySemesterAndIdSubject(int semester,int idClass) => _daoStudenPointSubject.getBySemesterAndIdSubject(semester, idClass);

    }
}
