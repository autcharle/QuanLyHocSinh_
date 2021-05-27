using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class Mark
    {
        //DoNotCallOverridableMethodsInConstructors
        public Mark()
        {
            this.Students = new HashSet<Student>();
        }

        public int IDMark { get; set; }
        public int? IDSubject { get; set; }
        public int? IDStudent { get; set; }
        public int? IDSemester { get; set; }
        public double? Score15min { get; set; }
        public double? Score60min { get; set; }
        public double? ScoreFinal { get; set; }

        public virtual Subject Subject { get; set; }
        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<Student> Students { get; set; }
    }
}
