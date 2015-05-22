using Family_Tree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Data_Access_Layer
{
    class FamilyContext : DbContext
    {
        public FamilyContext() : base("FamilyContext") { }

        public DbSet<Person> People { get; set; }
        public DbSet<ImmediateFamily> Family { get; set; }


    }
}
