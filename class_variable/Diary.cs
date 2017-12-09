using System;
using System.Collections.Generic;
using System.Linq;


namespace class_variable
{
    class Diary
    {
        public Diary() // to jest konstruktor, wpisujemy ctor i dwa razy tab
        {
            ratings = new List<float>(); // tutaj w konstruktorze, zamiast w Program.cs można dokonać inicjalizacji naszej listy ocen
        }
        //stan (zmienne - pola)
        List<float> ratings; //zadeklarowana lista ocen typu float (zmiennoprzecinkowe), 
                             //możemy tutaj przechowywać listę ocen

        //zachowania

        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">nowa ocena</param> 
        public void AddRating(float rating)//metoda
        {
            ratings.Add(rating);//dodaje ocene do dziennika
        }
        

        internal DiaryStatistics ComputeStatistis()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;//zmienna pomocnicza, w której przechowujemy sume 

            foreach (var rating in ratings)
            {
                sum = sum + rating;
            }
            stats.AverageGrade = sum / ratings.Count();//wykorzystujac count na kolekcji elementów, to count da ilosc elementów w kolekcji
            stats.MaxGrade = ratings.Max();         
            stats.MinGrade = ratings.Min();

            return stats; //chcemy by zwracała obiekt DiaryStatistics
        }

    }
}