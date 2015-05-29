using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Models
{
    class ImmediateFamily
    {
        public ImmediateFamily()
        {
            
        }

        public int ImmediateFamilyID { get; set; }
        public int DadRefID { get; set; }
        public int MomRefID { get; set; }

        [ForeignKey("DadRefID")]
        public virtual Person Dad { get; set; }
        [ForeignKey("MomRefID")]
        public virtual Person Mom { get; set; }

        public virtual ICollection<Person> Members { get; set; }
    }
}
