using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    internal class Person
    {
        public int mAge;
        public string mName;

        public Person()
        {
            mAge = 32;
            mName = "James";
        }

        public Person (int age, string name)
        {
            mAge = age;
            mName= name;
        }

    }
}
