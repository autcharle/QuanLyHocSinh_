using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Classroom : DBConnect
    {
        public string GetNameClassByID(int? ID)
        {
            var outputObj = _connection.Query<Classroom>($"select * from Classroom where IDClassroom ='{ID}'").ToList();
            var output = outputObj[0].NameClass;
            return output;
        }
    }
}
