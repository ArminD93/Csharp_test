using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); //Diary diary - >zmienna referencyjna typu Diary
                                       //zmienna - wskaźnik, który wskuzej na określony obiekt
                                       // Tworzymy obiekt, czyli zostaje przypisane coś do zmiennej
                                       //new Diary - tworzona jest nowa instancja klasy Diary
            diary.AddRating(4); //do obiektu przypisujemy jakies oceny
            diary.AddRating(5);


            Diary diary2 = new Diary(); // do zmiennej przypisujemy nowy obiekt
                                        // zmienna wskazuje na nowy obiekt
            diary2.AddRating(3);

            Diary diary3 = diary;
            diary3.AddRating(5);

            int liczba = 4; //zmienna typu prostego, nie przechowuje wskaźnika do obiektu
                            //przechowuje wartość, a zmienna referencyjna - typu klasy
                            //przechowuje wskaźnik do obiektu

          
        }
    }
}
