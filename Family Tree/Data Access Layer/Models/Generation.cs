using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class Generation
    {
        public Generation()
        {

        }

        public int GenerationID { get; set; }

        public virtual ICollection<Person> Members { get; set; }
    }
}
