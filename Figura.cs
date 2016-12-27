using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_6
{
    abstract class Figura
    {
        // Tworzenie obiektow klasy abstrakcyjnej jest niemozliwe
        protected double a, b, c;
        public abstract double ObliczPole();
        public Figura() { }
        public abstract void wypiszWszystko();
    }
}
