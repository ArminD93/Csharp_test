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
            diary.AddRating(2);
            diary.AddRating(1);


            DiaryStatistics stats = diary.ComputeStatistis(); //metoda wyliczajaca wszystkie statyski: srednia, max, min
                                                              // tworzymy nowa klase DiaryStatistics, gdzie statystki będą przechowywane
                                                              // stats to zmienna
            Console.WriteLine("Pierwszy dzienniczek");
            Console.WriteLine("Srednia wartosc: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna wartosc: " + stats.MaxGrade);
            Console.WriteLine("Minimalna wartosc: " + stats.MinGrade);


//#########################################################################################################################

            Diary diary2 = new Diary(); // do zmiennej przypisujemy nowy obiekt
                                        // zmienna wskazuje na nowy obiekt
            diary2.AddRating(3);
            diary2.AddRating(4);
            diary2.AddRating(6);


            stats = diary2.ComputeStatistis();

            Console.WriteLine("");
            Console.WriteLine("Drugi dzienniczek");
            Console.WriteLine("Srednia wartosc: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna wartosc: " + stats.MaxGrade);
            Console.WriteLine("Minimalna wartosc: " + stats.MinGrade);


//#########################################################################################################################

            Diary diary3 = new Diary();

            diary3.AddRating(3.5f); //f oznacza float
            diary3.AddRating(2);
            diary3.AddRating(4.5f);

            stats = diary3.ComputeStatistis();

            Console.WriteLine("");
            Console.WriteLine("Trzeci dzienniczek");
            Console.WriteLine("Srednia wartosc: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna wartosc: " + stats.MaxGrade);
            Console.WriteLine("Minimalna wartosc: " + stats.MinGrade);



            int liczba = 4; //zmienna typu prostego, nie przechowuje wskaźnika do obiektu
                            //przechowuje wartość, a zmienna referencyjna - typu klasy
                            //przechowuje wskaźnik do obiektu


      
          
        }
    }
}
