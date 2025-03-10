using System;
using System.Collections.Generic;
using MyClasses;

namespace MonPremierProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin1 = new Admin("admin1", 22, new List<string> {"eat", "sleep", "code"}, true);
            User user1 = new User ("user1", 22, new List<string> {"eat", "sleep", "code"});
            User user2 = new User ("user2", 22, new List<string> {"eat", "sleep", "code"});
            User user3 = new User ("user3", 22, new List<string> {"eat", "sleep", "code"});
            /* Vous pouvez utiliser une liste :
                List <User> users = new List<User> {user1, user2, user3};
                User user4 = new User ("user4", 22, new List<string> {"eat", "sleep", "code"});\
                users.Add(user4);
                users.Remove(user2);
                users.find(u => u.name == "user1");
                ...
             */

            
            User [] users = {user1, user2, user3};

            bool is_admin = admin1.admin;
            if (is_admin)
            {
                Console.WriteLine("les utilisateurs sont : ");
                foreach (User u in users)
                {
                    Console.WriteLine(u.name);
                }
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas accéder à liste des utilisateurs");
            }

            
        Console.ReadLine();
        }
    }
}
