using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // utoworzone zostały cztery obiekty klasy Osoba, ale do każdego obiektu wykorzystaliśmy inny konstruktor
            Osoba osoba =  new Osoba(); //tworzymy obiekt klasy Osoba, nie przujumuje parametrów
            Osoba osoba2 = new Osoba(1, "Tomek");
            Osoba osoba3 = new Osoba(2, "Tomek", "Nowak");
            Osoba osoba4 = new Osoba(2, "Tomek", "Nowak", "Gdynia", 18, "male");
        }
    }
}
