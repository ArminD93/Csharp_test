using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();//

            for (; ; )//pętla nieskończona
            {
                Przywitanie();
                Wiek();
                Ustawienia();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MinValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        private static void Ustawienia()
        {
            Console.ReadKey();//czeka,aż użytkownik naciśnie klawisz
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemu komunikat zależny od wieku
        /// </summary>
        private static void Wiek()
        {
            Console.Write("Wpisz, ile masz lat: ");
            int age; //zmienna age, która przechowuje wiek
            bool result = int.TryParse(Console.ReadLine(), out age);
            //jeśli użytkownik poda litery,
            //to zmienna age zostanie ustawiona na 0,
            //a w zmiennej bool zostanie ustawione false

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green; //kolor tekstu
                Console.WriteLine("Jesteś pełnoletni");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek");
            }
            else
            {
                Console.WriteLine("Jesteś niepoełnoletni");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Przywitanie()
        {
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
 