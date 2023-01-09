using System;
using System.Text.RegularExpressions;
namespace Ex1
{
    
    public class Program
    {
        static int checkNum()
        {
            String num;
            num = Console.ReadLine();
            while (Regex.IsMatch(num, "\\d") == false)
            {
                Console.Write("Enter your number: ");
                num = Console.ReadLine();
            }
            return Convert.ToInt32(num);
        }
        public static void Main(String[] args)
        {
            Console.Write("Enter your number: "); int n = checkNum();
            Console.WriteLine("Wait for roll the dice......"); int num = new Dice().roll();
            Console.Write("The number of buttons for this roll of the dice: " + num + "\n");
            if (n == num)
                Console.WriteLine("Congratulations! You guessed correctly!");
            else { Console.WriteLine("Wish you luck next time"); }
            Console.ReadLine();
        }
    }
}