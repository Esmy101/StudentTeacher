using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    internal class Student : Person
    {
        public double mGPA;
        public int mClasses;

        public Student(int age, string name): base(age, name) 
        {
            mGPA = 0;
            mClasses = 0;
        }

        public Student(double GPA, int Classes, int age, string name): base(age, name) 
        {
            mGPA = GPA;
            mClasses = Classes;

        }

        public void day()
        {
            Console.WriteLine(mAge);
            Console.WriteLine(mName);
            Console.WriteLine(mClasses);
            Console.WriteLine(mGPA);
        }

    }
}
