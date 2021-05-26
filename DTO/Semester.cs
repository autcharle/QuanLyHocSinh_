using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class Semester
    {
       //DoNotCallOverridableMethodsInConstructors
        public Semester()
        {
            this.SemesterClassrooms = new HashSet<SemesterClassroom>();
        }

        public int IDSemester { get; set; }
        public string NameSemester { get; set; }

        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<SemesterClassroom> SemesterClassrooms { get; set; }
    }
}
