using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_6
{
    class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        public Osoba() { }
        public Osoba(string Imie,string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;

        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie: " + Imie);
            Console.WriteLine("Nazwisko :" + Nazwisko);
        }
    }
}
