using Family_Tree.Data_Access_Layer;
using Family_Tree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree.Data_Logic_Layer
{
    public partial class MainScreen
    {
        bool AddPerson (Person newPerson)
        {
            bool success = false;

            using(var db = new FamilyContext())
            {
                db.People.Add(newPerson);
                db.SaveChanges();

                if (CheckPersonExist(newPerson.FirstName, newPerson.LastName, newPerson.Birthdate))
                    success = true;
            }

            return success;
        }

        bool CheckPersonExist(string firstName, string lastName, DateTime birthDate)
        {
            using(var db = new FamilyContext())
            {
                var query = from b in db.People
                            where b.FirstName == firstName && b.LastName == lastName && b.Birthdate == birthDate
                            select b;

                if (query.Count() == 1)
                    return true;
            }
            return false;
        }
    }
}
