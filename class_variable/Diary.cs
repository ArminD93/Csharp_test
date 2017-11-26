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

        /// <summary>
        /// Obliczanie średniej
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()//metoda wylicza średnią, zwraca tylko średnią
        {
            float sum = 0, avg = 0;//zmienna pomocnicza, w której przechowujemy sume i avg

            foreach (var rating in ratings)
            {
                sum = sum + rating;
            }
            avg = sum / ratings.Count();//wykorzystujac count na kolekcji elementów, to count da ilosc elementów w kolekcji

            return avg;
        }

        /// <summary>
        /// Pobiera najwyższą ocenę.
        /// </summary>
        /// <returns></returns>
        public float giveMaxRating() //metoda pobiera maksymalną ocene - zwraca typ float
        {
            return ratings.Max();//metoda zwraca maksymalny element na liście
        }

        /// <summary>
        ///  Pobiera najniższą ocenę.
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}