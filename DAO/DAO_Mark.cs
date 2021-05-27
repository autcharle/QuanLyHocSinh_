using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Mark : DBConnect
    {
        public List<Mark> GetOneSubjectMarkBySemester(int? IDSubject, int? IDStudent, int? IDSemester)
        {
            var output = _connection.Query<Mark>($"select * from Mark where IDSubject = '{IDSubject}' and IDStudent = '{IDStudent}' and IDSemester = '{IDSemester}'").ToList();
            return output;
        }
    }
}
