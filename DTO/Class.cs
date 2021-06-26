using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class Class
    {
        //DoNotCallOverridableMethodsInConstructors
        public Class()
        {
            this.Students = new HashSet<Student>();
        }

        public int Class_ID { get; set; }
        public string Class_Name { get; set; }

        public int Class_Group { get; set; }
        public int NumberMember { get; set; }
        int _selectedItem { get; set; }

        //CollectionPropertiesShouldBeReadOnly
        public virtual ICollection<Student> Students { get; set; }
    }
}
