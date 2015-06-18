using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class Tree
    {
        public Tree(string treeName)
        {
            TreeName = treeName;
        }

        public int WholeFamilyID { get; set; }
        public string TreeName { get; set; }
        public virtual ICollection<Person> Members { get; set; }
        
    }
}
