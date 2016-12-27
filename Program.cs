using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Piotr", "Jaroslawowicz");
            osoba1.WypiszInfo();
            Student student1 = new Student(1994, 3, 1);
            student1.WypiszInfo();
            // Rzutowanie w gore z new jest problem , override i virtual zalatwiaja go
            Osoba student2 = new Student(1993,3,4);
            student2.WypiszInfo();

            // figura1 = new Figura(); Zabronione
            Trojkat trojkat1 = new Trojkat(1, 3, 4);
            Kwadrat kwadrat1 = new Kwadrat(2, 2);
            trojkat1.ObliczPole();
            kwadrat1.ObliczPole();
            trojkat1.wypiszWszystko();
            kwadrat1.wypiszWszystko();



            List<Trojkat> ListaTrojkatow = new List<Trojkat>();
            ListaTrojkatow.Add(new Trojkat(1, 3, 2));
            ListaTrojkatow.Add(new Trojkat(2, 2, 2));
            ListaTrojkatow.Add(new Trojkat(3, 4, 7));
            ListaTrojkatow.Add(new Trojkat(2, 3, 2));
            ListaTrojkatow.Add(new Trojkat(4, 2, 2));
            ListaTrojkatow.Add(new Trojkat(5, 4, 7));
            foreach (var element in ListaTrojkatow)
            {
                element.wypiszWszystko();
            }

            Console.ReadKey();
        }
    }
}
