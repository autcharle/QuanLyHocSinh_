using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class Point
    {
        //DoNotCallOverridableMethodsInConstructors
        public Point()
        {
            this.Students = new HashSet<Student>();
        }

        public int Point_ID { get; set; }
        public int? Subject_ID { get; set; }
        public int? Student_ID { get; set; }
        public int? Semester { get; set; }
        public double? Point_15 { get; set; }
        public double? Point_45 { get; set; }
        public double? Point_CK { get; set; }

        public virtual Subject Subject { get; set; }
        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<Student> Students { get; set; }
    }
}
