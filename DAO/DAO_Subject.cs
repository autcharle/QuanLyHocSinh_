using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Subject : DBConnect
    {
        public List<Subject> GetAll()
        {
            var output = _connection.Query<Subject>($"select * from Subject").ToList();
            return output;
        }

        public int Count()
        {
            var output = this.GetAll();
            return output.Count();
        }
    }
}
