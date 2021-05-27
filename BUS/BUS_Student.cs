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

        public List<Student> GetAllStudent() => _daoStudent.GetAll();
    }
}
