using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_6
{
    class Kwadrat:Figura
    {
        public Kwadrat() { }
        public Kwadrat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double ObliczPole()
        {
            return a * b;
        }
        public override void wypiszWszystko()
        {
            Console.WriteLine("A: {0}, B:{1}",a,b);
            Console.WriteLine("Pole kwadratu : "+ObliczPole());
        }
        //Z konstruktorem typu BASE(arg1,arg2...,arg N) nie da rady. BO klasa abstrakcyjna nie potrzebuje konstruktora wiec Base nie bedzie
        // mialo mozliwosci przejecia go z klasy bazowej
      
    }
}
