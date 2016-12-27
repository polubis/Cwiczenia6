using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_6
{
    class Student:Osoba
    {
        protected int rokStudiow;
        protected int nrGrupy;
        protected int nrAlbumu;
        public Student() { }
        public Student(string Imie,string Nazwisko,int rokStudiow,int nrGrupy,int nrAlbumu):base(Imie,Nazwisko)
        {
            this.rokStudiow = rokStudiow;
            this.nrGrupy = nrGrupy;
            this.nrAlbumu = nrAlbumu;
        }
        public Student(int rokStudiow,int nrGrupy,int nrAlbumu)
        {
            this.rokStudiow = rokStudiow;
            this.nrGrupy = nrGrupy;
            this.nrAlbumu = nrAlbumu;
        }
        /*
        public new void WypiszInfo()   // Takie rozwiazanie powoduje ukrycie metody w klasie bazowej podczas rzutowania w gore
        {
            Console.WriteLine("Rok studiow: " + rokStudiow);111
            Console.WriteLine("Nr grupy: " + nrGrupy);
            Console.WriteLine("Nralbumu :" + nrAlbumu);
        }
         */
        public override void WypiszInfo()   
        {
            base.WypiszInfo();                                  // pobiera metode z klasy bazowej bez koniecznosci stworzenia instancji 
            Console.WriteLine("Rok studiow: " + rokStudiow);
            Console.WriteLine("Nr grupy: " + nrGrupy);
            Console.WriteLine("Nralbumu :" + nrAlbumu);
        }
    }
}
