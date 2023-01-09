using Exercise04;

namespace Ex4
{
    class ProcessFraction
    {
        private Fraction f1;
        private Fraction f2;
        public ProcessFraction(Fraction f1, Fraction f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }
        public Fraction AddFraction()
        {
            int Denominator = f1.Denominator * f2.Denominator;
            int Numerator = (f1.Numerator * f2.Denominator) + (f2.Numerator *
            f1.Denominator);
            return new Fraction(Numerator, Denominator);
        }
        public Fraction SubtractFraction()
        {
            int Denominator = f1.Denominator * f2.Denominator;
            int Numerator = (f1.Numerator * f2.Denominator) - (f2.Numerator * f1.Denominator);
            return new Fraction(Numerator, Denominator);
        }
        public Fraction MultiplyFractions()
        {
            int Denominator = f1.Denominator * f2.Denominator;
            int Numerator = f1.Numerator * f2.Numerator;
            return new Fraction(Numerator, Denominator);
        }
        public Fraction DivideFractions()
        {
            int Denominator = f1.Denominator * f2.Numerator;
            int Numerator = f1.Numerator * f2.Denominator;
            return new Fraction(Numerator, Denominator);
        }
    }
}
