using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Razlomak
    {
        int brojnik, nazivnik;
        public static Razlomak operator +(Razlomak a, Razlomak b)
            => new(a.Brojnik * b.Nazivnik + a.Nazivnik * b.Brojnik,
                a.Nazivnik * b.Nazivnik);
        public static Razlomak operator -(Razlomak a, Razlomak b)
            => new(a.Brojnik * b.Nazivnik - a.Nazivnik * b.Brojnik,
                a.Nazivnik * b.Nazivnik);
        public static Razlomak operator *(Razlomak a, Razlomak b)
            => new(a.Brojnik * b.Brojnik,
                a.Nazivnik * b.Nazivnik);
        public static Razlomak operator /(Razlomak a, Razlomak b)
        {
            if (b.Brojnik == 0)
                throw new DivideByZeroException("Dijeljenje nulom!");
            return (b.Brojnik < 0) ?
                new(-a.Brojnik * b.Nazivnik, a.Nazivnik * -b.Brojnik) :
                new(a.Brojnik * b.Nazivnik, a.Nazivnik * b.Brojnik);
        }
        public static explicit operator Razlomak(int n)
            => new Razlomak(n, 1);
        /* public static implicit operator double(Razlomak a)
            => a.Brojnik / (1.0 * a.Nazivnik); */
        public static bool operator true(Razlomak a)
            => a.Brojnik == 1 && a.Nazivnik == 1;
        public static bool operator false(Razlomak a)
            => a.Brojnik == 0;
        public static Razlomak operator !(Razlomak a)
        {
            if (a.Brojnik == 0)
                return new(1, 1);
            else if (a.Brojnik == 1 && a.Nazivnik == 1)
                return new(0, 1);
            else
                return new(2, 1);
        }
        public override string ToString()
            => Brojnik + " / " + Nazivnik;
        void Skrati()
        {
            for (int i = 2; i <= nazivnik; i++)
            {
                while (brojnik % i == 0 && nazivnik % i == 0)
                {
                    brojnik /= i;
                    nazivnik /= i;
                }
            }
        }
        public int Brojnik
        {
            get => brojnik;
            set
            {
                brojnik = value;
                Skrati();
            }
        }
        public int Nazivnik
        {
            get => nazivnik;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Nazivnik nije pozitivan!");
                }
                nazivnik = value;
                Skrati();
            }
        }
        public Razlomak(int brojnik, int nazivnik)
        {
            Brojnik = brojnik;
            Nazivnik = nazivnik;
        }

        /* public static bool operator ==(Razlomak a, Razlomak b)
            => a.Brojnik == b.Brojnik && a.Nazivnik == b.Nazivnik;
        public static bool operator !=(Razlomak a, Razlomak b)
            => !(a == b); */
        public override bool Equals(object? obj)
        {
            return obj is Razlomak && Equals(obj);
        }
        public bool Equals(Razlomak a)
            => Brojnik == a.Brojnik && Nazivnik == a.Nazivnik;
        public override int GetHashCode()
        {
            return HashCode.Combine(Brojnik, Nazivnik);
        }
    }
}
