using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Mark
    {
        DAO_Mark _daoMark = new DAO_Mark();
        BUS_Subject _busSubject = new BUS_Subject();

        public double? CalAverageOneSubjectMarkBySemester(int? IDSubject, int? IDStudent, int? IDSemester)
        {
            var outputObj = _daoMark.GetOneSubjectMarkBySemester(IDSubject, IDStudent, IDSemester);
            if (outputObj.Count() <= 0)
            {
                return 0;
            }
            var ObjScore15min = outputObj[outputObj.Count() - 1].Score15min;
            var ObjScore60min = outputObj[outputObj.Count() - 1].Score60min;
            var ObjScoreFinal = outputObj[outputObj.Count() - 1].ScoreFinal;
            var output = (ObjScore15min + ObjScore60min * 2 + ObjScoreFinal * 3) / 6;
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
