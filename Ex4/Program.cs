using Ex4;
namespace Exercise04
{


    internal class Program
    {
        public static void Main(String[] args)
        {
            Fraction fraction1 = new Fraction();
            fraction1.InputFraction();
            Fraction fraction2 = new Fraction();
            fraction2.InputFraction();
            ProcessFraction pf = new ProcessFraction(fraction1, fraction2);
            Console.WriteLine(" ADD: ");
            pf.AddFraction().ReduceFractions().ShowFraction();
            Console.WriteLine(" SUBTRACT: ");
            pf.SubtractFraction().ReduceFractions().ShowFraction();
            Console.WriteLine(" MULTIPLY: "); pf.MultiplyFractions().ReduceFractions().ShowFraction();
            Console.WriteLine(" DIVIDE: ");
            pf.DivideFractions().ReduceFractions().ShowFraction();
            Console.ReadLine();
        }
    }
}