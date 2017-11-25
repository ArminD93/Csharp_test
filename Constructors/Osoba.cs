using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Osoba
    {
        //Pola poniżej to jest stan naszej klasy
        int id;
        string firstname;
        string lastname;
        string adress;
        int age;
        string gender;

        //Pola poniżej to są KONSTRUKTORY -> ctor i dwa razy tab
        public Osoba() // utworzony kostruktor, w którym ustawiamy nasze pola przez wartości domyślne
        {
            //dla każdej zmiennej można zadeklarować wartości początkowe
            // zmienne nie podane tutaj przyjmą wartości domyślne:
            //dla typów prostych będzie to zero, dla klas będzie null, 
            //dla wartości logicznych będzie to bool, dla string też null
            id = 1;
            firstname = "Armin";
            lastname = "Derencz";
            age = 14;
        }
        public Osoba(int id, string firstname, string lastname, string adress, int age, string gender) 
        // konstruktor, który wywoływany jest z parametrami
        // konstruktor w którym będziemy tworzyć obiekt i przekazywać do niego parametry, 
       //inicjujemy takimi wartościami jakie zostały wprowadzone w parametrze
        {
            this.id = id; // this informuje, że te id tyczy się naszej klasy naszego obiektu ??
            this.firstname = firstname;
            this.lastname = lastname;
            this.adress = adress;
            this.age = age;
            this.gender = gender;
        }
        public Osoba(int id, string firstname, string lastname)
        {
            this.id = id; // this informuje, że te id tyczy się naszej klasy naszego obiektu ??
            this.firstname = firstname;
            this.lastname = lastname;
            adress = "Olsztyn";
            age = 18;
        }
        public Osoba(int id, string firstname)
        {
            this.id = id; // this informuje, że te id tyczy się naszej klasy naszego obiektu ??
            this.firstname = firstname;

        }



    }
}
