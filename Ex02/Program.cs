using System;

namespace Ex02
{
    internal class Program
    {
        public static void Main()
        {
            Student s = new Student();
            s = s.Input();
            s.DisplayStudent();
            Console.ReadLine();
        }
    }
}
