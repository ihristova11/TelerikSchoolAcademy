using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _11.UsersAndGroups
{
    class UsersAndGroups
    {
        public static void InsertUser(string userName)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using ( var context = new UsersAndGroupsEntities())
                {
                    Groups adminGroup = new Groups { Name = "Admins" };
                    if (context.Groups.Count(x => x.Name == "Admins") == 0)
                    {
                        context.Groups.Add(adminGroup);
                        context.SaveChanges();
                        scope.Complete();
                    }
                    else
                    {
                        if (context.Users.Count(x => x.Name == userName) > 0)
                        {
                            Console.WriteLine("User already exists.");
                            scope.Dispose();
                        }
                        Groups currentgroup = context.Groups
                        .Where(x => x.Name == "Adminss").First();
                        Users newUser = new Users()
                        {
                            Name = userName,
                            ID = currentgroup.ID
                        };
                        context.Users.Add(newUser);
                        context.SaveChanges();
                        scope.Complete();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            InsertUser("Peter Malinkov");
            InsertUser("Atanas Gogichev");
            InsertUser("Kalina Malinova");
            InsertUser("Venelina Aleksandrova");
        }
    }
}