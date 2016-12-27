using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_6
{
    class Trojkat:Figura
    {
        public Trojkat() { }
        public Trojkat(double a,double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double ObliczPole()
        {
            return a * b * c;
        }
        public override void wypiszWszystko()
        {
            Console.WriteLine("A: {0}, B:{1} , C: {2}", a, b,c);
            Console.WriteLine("Pole trojkata : " + ObliczPole());
        }
    }
}
