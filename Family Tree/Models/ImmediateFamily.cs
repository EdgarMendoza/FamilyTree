using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class ImmediateFamily
    {
        public int ImmediateFamilyID { get; set; }
        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}
