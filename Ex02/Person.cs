using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Person
    {
        private string name;
        private int age;
        private double gpa;

        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, double gpa) : this(name, age)
        {
            this.gpa = gpa;
        }

        private string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void DisplayPerson()
        {
            Console.WriteLine("Name: "+name +" Age: "+age);
        }
        public Person Input()
        {
            Console.Write("Enter name: ");
            String name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Person p = new Person(name, age);
            return p;
        }
        public String ToString()
        {
            return "Name: " + name + " Age: " + age;
        }
    }
}
