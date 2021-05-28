using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Class
    {
        DAO_Class _daoClass = new DAO_Class();
        public List<Class> GetAllClass() => _daoClass.GetAll();
    }
}
