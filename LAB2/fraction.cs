using System;

namespace Task1
{

    public class Fraction
    {
        public int Numerator { get; private set; }

        public int Denominator { get; private set; }

       

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0 && numerator!=0)
                throw new DivideByZeroException("В знаменателе не может быть нуля");    
            Numerator = numerator;
            Denominator = denominator;
            Reduction();
            

        }

        public Fraction(int a) : this(a, 1) { }
      

        public bool isFraction()
        {
            if (Numerator == 0 || Denominator == 0)
                return false;
            else
                return true;
        }



        public static int NOD(int m, int n)
        {
            int temp;
            m = Math.Abs(m);
            n = Math.Abs(n);
            while (n != 0 && m != 0)
            {
                if (m % n > 0)
                {
                    temp = m;
                    m = n;
                    n = temp % n;
                }
                else break;
            }
            if (n != 0 && n != 0) return n;
            else return 0;
        }

        public static bool Equals(Fraction a, Fraction b)
        {
            a.Reduction();
            b.Reduction();
            if (a.Numerator * a.Denominator < 0 && b.Numerator * b.Denominator < 0)
                if (Math.Abs(a.Numerator) == Math.Abs(b.Numerator) && Math.Abs(a.Denominator) == Math.Abs(b.Denominator))
                    return true;
            if (a.Numerator * a.Denominator > 0 && b.Numerator * b.Denominator > 0)
                if ((a.Numerator == b.Numerator) && (a.Denominator == b.Denominator))
                    return true;
            return false;
        }

        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }

        public Fraction Reduction()
        {
            int nod = NOD(Numerator, Denominator);
            if (nod > 1)
            {
                Numerator /= nod;
                Denominator /= nod;
            }
            return this;

        }




        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator,
            fraction1.Denominator * fraction2.Denominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator == fraction2.Numerator && fraction2.Denominator == fraction1.Denominator)
                return new Fraction(0, 0);
            return new Fraction(fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator,
               fraction1.Denominator * fraction2.Denominator);
        }

       

            public static Fraction operator *(Fraction fraction1, Fraction fraction2)
            {
                return new Fraction(fraction1.Numerator * fraction2.Numerator, fraction1.Denominator * fraction2.Denominator);
            }

            public static Fraction operator /(Fraction fraction1, Fraction fraction2)
            {
                return new Fraction(fraction1.Numerator * fraction2.Denominator, fraction1.Denominator * fraction2.Numerator);
            }

            public static Fraction Pow(Fraction fraction1, int n)
            {
                return new Fraction((int)Math.Pow(fraction1.Numerator, n), (int)Math.Pow(fraction1.Denominator, n));
            }

        }
	}
	

