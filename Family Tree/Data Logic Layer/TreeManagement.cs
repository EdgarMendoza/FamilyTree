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
        bool CreateNewTree (Tree newTree)
        {
            bool success = false;

            using(var db = new FamilyContext())
            {
                db.Tree.Add(newTree);
                db.SaveChanges();

                if (CheckTreeExist(newTree.TreeName))
                    success = true;
            }

            return success;
        }

        //UNFINISHED
        //Need to do GetTreeID method to work on DeleteTree method
        /*bool DeleteTree(string treeName)
        {
            bool success = false;

            using(var db = new FamilyContext())
            {

            }

            return success;
        }*/

        bool CheckTreeExist(string treeName)
        {
            using(var db = new FamilyContext())
            {
                var query = from b in db.Tree
                            where b.TreeName == treeName
                            select b;

                foreach(var item in query)
                {
                    if (item.TreeName == treeName)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }
    }
}
