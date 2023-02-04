using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    internal class Teacher : Person 
    {
        public int mStudents;
        public int mSalary;

        public Teacher(int age, string name):base(age,name)
        {
            mStudents = 0;
        }

        public Teacher(int students, int salary, int age, string name) :base(age,name)
        {
            mStudents = students;
            mSalary = salary;
        }

        public void yell ()
        {
            Console.WriteLine(mAge);
            Console.WriteLine(mName);
            Console.WriteLine(mSalary);
            Console.WriteLine(mStudents);
        }
    }
}
