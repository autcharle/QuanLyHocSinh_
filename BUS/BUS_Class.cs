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
        DAO_Student _daoStudent = new DAO_Student();
        BUS_Config _busConfig = new BUS_Config();
        public List<Class> GetAllClass() => _daoClass.GetAll();

        public bool InsertAClass(Class _class){
            if (_class.Class_Name == "" || _class.Class_Name==" ") return false;
                _daoClass.InsertAClass(_class);
                return true;
}
        public List<Class> ReadClassByClassGroup(int class_group)
        {
            var output= _daoClass.ReadClassByClassGroup(class_group);
            getNumberMember(output);
            return output;
        }
        public List<Class> ReadClassByID(int class_id)
        {
            var output= _daoClass.ReadClassByID(class_id);
            getNumberMember(output);
            return output;
        }
        public List<Class> ReadClassByNameAndClassGroup(string NameClass, int? Class_Group)
        {
           var output= _daoClass.ReadClassByByNameAndClassGroup(NameClass, Class_Group);
            getNumberMember(output);
            return output;
        }
        public List<Class> ReadClassByName(string NameClass)
        {
            var output=_daoClass.ReadClassByName(NameClass);
            getNumberMember(output);
            return output;
        }
        public List<Class> GetAllClassGroup() => _daoClass.GetAllClassGroup();
        public List<Class> ReadAllClass()
        {
            var output = GetAllClass();
            foreach (var _class in output)
            {
                int count = 0;
                List<Student> listStudent = new List<Student>();
                listStudent = _daoStudent.GetStudentByClassID(_class.Class_ID);
                foreach(var student in listStudent)
                {
                    count++;
                }
                _class.NumberMember = count;
            }
            return output;
        }
        public void getNumberMember(List<Class> output)
        {
            foreach (var _class in output)
            {
                int count = 0;
                List<Student> listStudent = new List<Student>();
                listStudent = _daoStudent.GetStudentByClassID(_class.Class_ID);
                foreach (var student in listStudent)
                {
                    count++;
                }
                _class.NumberMember = count;
            }
           
        }
        
    }

}
