using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class WholeFamily
    {
        public WholeFamily()
        {

        }

        public int WholeFamilyID { get; set; }
        public virtual ICollection<Person> Members { get; set; }
        
    }
}
