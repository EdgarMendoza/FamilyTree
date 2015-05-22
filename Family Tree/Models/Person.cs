using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class Person
    {
        public int ID { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Death { get; set; }
        public string Gender { get; set; }
        public string Birthplace { get; set; }
        public bool Deceased { get; set; }

        public virtual ICollection<ImmediateFamily> Family { get; set; }
    }

    enum Gender
    {
        Male, Female
    }
}
