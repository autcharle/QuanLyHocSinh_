using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class Student
    {
        public int IDStudent { get; set; }
        public int? IDClassRoom { get; set; }
        public int? IDMark { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Mark Mark { get; set; }
    }
}
