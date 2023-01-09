using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Student : Person
    {
        double gpa;
        public Student()
        {

        }

        public Student(string name, int age, double gpa) : base(name, age)
        {
            name = name;
            this.Age = age;
            this.gpa = gpa;
        }

        public Student Input()
        {
            Console.Write("Enter name of student: ");
            String name = Console.ReadLine();
            Console.Write("Enter age of student: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter GPA of student: ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Student s = new Student(name, age, gpa);
            return s;
        }
        public void DisplayStudent()
        {
            Console.WriteLine(base.ToString()+" GPA: "+gpa);
        }
    }
}
