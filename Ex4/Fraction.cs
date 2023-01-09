namespace Exercise04
{
    class Fraction
    {
        private int denominator;
        private int numerator;
        public Fraction()
        {
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public int Denominator { get => denominator; set => denominator = value; }
        public int Numerator { get => numerator; set => numerator = value; }
        public void InputFraction()
        {
            Console.Write("Enter numerator: "); Numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            Denominator = int.Parse(Console.ReadLine());
        }
        public int UCLN()
        {
            int a = Math.Abs(numerator);
            int b = Math.Abs(denominator);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public Fraction ReduceFractions()
        {
            Fraction singleFraction = new Fraction();
            int uoc = UCLN();
            if (uoc != 0)
            {
                Numerator = numerator / uoc;
                Denominator = denominator / uoc;
            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;
            }
            return new Fraction(Numerator, Denominator);
        }
        public void ShowFraction()
        {
            Console.WriteLine("Fraction: " + numerator + "/" + denominator);
            Console.WriteLine("Decimal number: " + (Decimal)numerator / denominator);
        }
    }

}