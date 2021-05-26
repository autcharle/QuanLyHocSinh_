using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class Subject
    {
        //DoNotCallOverridableMethodsInConstructors
        public Subject()
        {
            this.Marks = new HashSet<Mark>();
        }

        public int IdSubject { get; set; }
        public int? IDSemesterClassroom { get; set; }
        public string NameSubject { get; set; }

        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual SemesterClassroom SemesterClassroom { get; set; }
    }
}
