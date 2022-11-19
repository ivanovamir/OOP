using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Rational
    {
        public int a;
        public int b;
        public Rational(int a, int b)
        {
            this.a = a;
            this.b = b;
            Reduce();
        }
        public static Rational operator +(Rational f1, Rational f2)
        {
            return new Rational(f1.a * f2.b + f2.a * f1.b, f1.b * f2.b);
        }

        public static Rational operator -(Rational f1, Rational f2)
        {
            return new Rational(f1.a * f2.b - f2.a * f1.b, f1.b * f2.b);
        }

        public static Rational operator *(Rational f1, Rational f2)
        {
            return new Rational(f1.a * f2.a, f1.b * f2.b);
        }

        public static Rational operator /(Rational f1, Rational f2)
        {
            return new Rational(f1.a * f2.b, f1.b * f2.a);
        }

        public static bool operator >(Rational f1, Rational f2)
        {
            return (double)f1.a / f1.b > (double)f2.a / f2.b;
        }

        public static bool operator <(Rational f1, Rational f2)
        {
            return (double)f1.a / f1.b < (double)f2.a / f2.b;
        }

        // Функция, возвращающая наибольшой общий делитель
        // используется для сокращения дроби
        private int Nod(int n, int d)
        {
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return 0;
        }

        private void Reduce()
        {
            int max_d = Nod(a, b);
            if (max_d != 0)
            {
                a = a / max_d;
                b = b / max_d;
            }
        }
    }
}
