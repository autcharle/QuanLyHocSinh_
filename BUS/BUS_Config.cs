using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Config
    {
        DAO_Config _daoConfig = new DAO_Config();
        public List<Config> GetAllConfig() => _daoConfig.GetAll();
        public int GetMinAge()
        {
            return (int)_daoConfig.GetAll()[0].Min_Age;
        }
        public int GetMaxAge()
        {
            return (int)_daoConfig.GetAll()[0].Max_Age;
        }
       
    }
}
