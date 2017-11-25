using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); //zadeklarowalismy zmienna typu Diary (dzienniczek) - jak nazwa klasy Diary
                                       // =  new Diary(); - tworzymy instancje obiektu klasy dzienniczka
                                       // Diary(); to jest konstruktor domyślny (nie posiada argumentów), który potrafi zbudować nowy obiekt dzieniczka
            //diary.AddRating(5);
            //diary.AddRating(8.5f); // dodając na koncu wartosci f, kompilator wie, ze przekazujemy wartosc typu float
                                   // tak jak chcielismy, by lista w diary.cs przechowywała float
                                   // domyslnie wartosc traktowana jest jako typ double
            //diary.AddRating(4.7f);
            //float  avg = diary.CalculateAverage(); // deklaryjemy zmienna typu float i przypisyjemy  obiekt srednią
            //float max = diary.giveMaxRating();      // metody te nie przyjmują żadnych parametrów
           // float min = diary.GiveMinRating();

            for (; ; ) // pętla nieskonczona
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 do 10");

                float rating;
                //Zabezpieczenie przed wprowadzeniem liter
                bool result = float.TryParse(Console.ReadLine(), out rating); //korzystamy z parsowania floata
                                                                //i przekazujemy to, co użytkownik wprowadzi z klaiwatury
              //TryParse zabezpiecza by nie było bledu kiedy uzytkownika poda litere zamiast cyfry

                if (rating == 11)
                {
                    break; // spowoduje wyjscie z petli
                }

                if (result) // tutaj doajemy ocene, gdy result jest true, zapis (result == true ) odpowiada (result)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating); // ocene wpisana z klawiatury dodajemy do dzienniczka
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbe z zakresu 1 - 10");
                    }
                    

                }

            }
            Console.WriteLine("Średnia twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.giveMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating()); //diary to obiekt, a giveMinrating() to metoda
            Console.ReadKey(); // zatrzymujemy program


            // tworzymy kolejne obiekty naszej klasy, kzdy obiekt jest niezalezny i przechowuje swoje wlasne oceny
            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();

        }
    }
}
