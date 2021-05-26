using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class SemesterClassroom
    {
        //DoNotCallOverridableMethodsInConstructors
        public SemesterClassroom()
        {
            this.Subjects = new HashSet<Subject>();
        }

        public int IDSemesterClassroom { get; set; }
        public int? IDClassRoom { get; set; }
        public int? IDSemester { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Semester Semester { get; set; }
        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
