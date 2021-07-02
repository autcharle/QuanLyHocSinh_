using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Point
    {
        DAO_Point _daoMark = new DAO_Point();
        DAO_Student _daoStudent = new DAO_Student();
        BUS_Subject _busSubject = new BUS_Subject();

        public double? CalAverageOneSubjectMarkBySemester(int? IDSubject, int? IDStudent, int? IDSemester)
        {
            var outputObj = _daoMark.GetOneSubjectMarkBySemester(IDSubject, IDStudent, IDSemester);
            if (outputObj.Count() <= 0)
            {
                return 0;
            }
            var ObjScore15min = outputObj[outputObj.Count() - 1].Point_15;
            var ObjScore45min = outputObj[outputObj.Count() - 1].Point_45;
            var ObjScoreFinal = outputObj[outputObj.Count() - 1].Point_CK;
            var output = (ObjScore15min + ObjScore45min * 2 + ObjScoreFinal * 3) / 6;
            return output;
        }

        public double? CalAverageAllSubjectMarkBySemester(int? IDStudent, int? IDSemester)
        {
            List<double> _ListMark = new List<double>();
            for (int IDSubject = 1; IDSubject <= _busSubject.CountSubject(); IDSubject++)
            {
                _ListMark.Add((double)CalAverageOneSubjectMarkBySemester(IDSubject, IDStudent, IDSemester));
            }
            double? output = 0;
            foreach (double _mark in _ListMark)
            {
                output += _mark;
            }
            return output / _ListMark.Count();
        }

        public bool InsertPointForStudent(Point _point)
        {
            if (_point.Point_15 > 10 || _point.Point_15 <0) return false;
            if (_point.Point_45 > 10 || _point.Point_45 < 0) return false;
            if (_point.Point_CK > 10 || _point.Point_CK < 0) return false;
            _daoMark.InsertPointForStudent(_point);
            var _avg = Math.Round((double)CalAverageAllSubjectMarkBySemester(_point.Student_ID, _point.Semester), 2);
            if (_point.Semester == 1)
            {
                _daoStudent.UpdateAVGS1ForStudent(_point.Student_ID, _avg);
            }
            else
            {
                _daoStudent.UpdateAVGS2ForStudent(_point.Student_ID, _avg);
            }
            return true;
        }

        public List<Point> getAll()
        {
            return _daoMark.getAll();
        }

        public bool updatePointForStudent(Point _point)
        {
            if (_point.Point_15 > 10 || _point.Point_15 < 0) return false;
            if (_point.Point_45 > 10 || _point.Point_45 < 0) return false;
            if (_point.Point_CK > 10 || _point.Point_CK < 0) return false;
            _daoMark.updatePointForStudent(_point);
            var _avg = Math.Round((double)CalAverageAllSubjectMarkBySemester(_point.Student_ID, _point.Semester), 2);
            if (_point.Semester == 1)
            {
                _daoStudent.UpdateAVGS1ForStudent(_point.Student_ID, _avg);
            }
            else
            {
                _daoStudent.UpdateAVGS2ForStudent(_point.Student_ID, _avg);
            }
            return true;
        }
    }
}
