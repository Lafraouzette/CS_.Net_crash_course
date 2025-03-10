using System;
using System.Collections.Generic;

namespace MyClasses
{
    public class User
    {
        public string name { get; set; }
        public int age { get; set; }

        public List<string> to_do { get; set; }
        public User(string name, int age, List<string> to_do)
        {
            this.name = name;
            this.age = age;
            this.to_do = to_do ?? new List<string>();
        }
    }
}
