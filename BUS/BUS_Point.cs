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
    }
}
