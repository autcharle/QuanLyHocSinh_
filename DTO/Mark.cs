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
        public Nullable<int> IDSubject { get; set; }
        public Nullable<double> Score15min { get; set; }
        public Nullable<double> Score60min { get; set; }
        public Nullable<double> ScoreFinal { get; set; }

        public virtual Subject Subject { get; set; }
        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<Student> Students { get; set; }
    }
}
