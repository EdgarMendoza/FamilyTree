using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class Person
    {
        public Person()
        {
            
        }

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime DeathDate { get; set; }
        public string BirthPlace { get; set; }
        public string DeathPlace { get; set; }
        public Gender Gender { get; set; }
        public bool Deceased { get; set; }

        public virtual ICollection<ImmediateFamily> Family { get; set; }
        public virtual Generation Generation { get; set; }
        //public virtual Tree WholeFamily { get; set; }
    }

    enum Gender { Male, Female};
}
