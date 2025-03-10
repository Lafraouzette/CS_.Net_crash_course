using System;
using System.Collections.Generic;

namespace MyClasses
{
    public class Admin : User
    {
        public bool admin { get; set; }
        public Admin(string name, int age, List<string> to_do, bool admin)
        : base(name, age, to_do) // Appel du constructeur de la classe de base (User)
        {
            this.admin = admin;
        }


    }

}
