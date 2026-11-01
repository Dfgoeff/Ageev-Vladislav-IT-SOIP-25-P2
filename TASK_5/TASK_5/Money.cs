using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Money
    {
        int Rubles;
        int Kopecks;

        public override string ToString()
        {
            return $"{Rubles}.{Math.Abs(Kopecks)}";
        }
        public Money(int rubles, int kopecks)
        {
            int extra = kopecks / 100;
            int remain = kopecks % 100;

            Rubles = rubles + extra;
            Kopecks = remain;
        }
        public Money Sum(Money m)
        {
            return new Money(Rubles + m.Rubles,Kopecks + m.Kopecks);
        }
        public Money Subtract(Money m)
        {
            return new Money(Rubles - m.Rubles, Kopecks - m.Kopecks);
        }
        public static bool operator <(Money m1, Money m2)
        {
            double val1 = m1.Rubles * 100 + m1.Kopecks;
            double val2 = m2.Rubles * 100 + m2.Kopecks;
            return val1 < val2;
        }
        public static bool operator >(Money m1, Money m2)
        {
            double val1 = m1.Rubles * 100 + m1.Kopecks;
            double val2 = m2.Rubles * 100 + m2.Kopecks;
            return val1 > val2;
        }
    }
}
