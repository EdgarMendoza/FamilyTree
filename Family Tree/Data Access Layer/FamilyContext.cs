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
        public FamilyContext() : base("FamilyDB")
        {
            //Take this away after finished developing
            Database.SetInitializer<FamilyContext>(new DropCreateDatabaseAlways<FamilyContext>());
        }

        //public DbSet<Tree> Tree { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<ImmediateFamily> Families { get; set; }
        public DbSet<Generation> Generations { get; set; }


    }
}
