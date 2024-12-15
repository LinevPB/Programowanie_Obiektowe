using System;
using System.Collections.Generic;

namespace KolorZgaduj
{
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Kolor> kolory = new List<Kolor>
            {
                Kolor.Czerwony,
                Kolor.Niebieski,
                Kolor.Zielony,
                Kolor.Żółty,
                Kolor.Fioletowy
            };

            Random random = new Random();
            Kolor wylosowanyKolor = kolory[random.Next(kolory.Count)];

            Console.WriteLine("Witaj w grze! Zgadnij kolor.");
            Console.WriteLine("Dostępne kolory: Czerwony, Niebieski, Zielony, Żółty, Fioletowy");

            bool zgaduj = true;

            while (zgaduj)
            {
                try
                {
                    string odpowiedz = Console.ReadLine();

                    Kolor kolorUzytkownika = (Kolor)Enum.Parse(typeof(Kolor), odpowiedz, true);

                    if (kolorUzytkownika == wylosowanyKolor)
                    {
                        Console.WriteLine("Brawo! Zgadłeś kolor.");
                        zgaduj = false;
                    }
                    else
                    {
                        Console.WriteLine("Niestety, to nie jest prawidłowy kolor. Spróbuj ponownie.");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Błąd! Wpisz jeden z dostępnych kolorów: Czerwony, Niebieski, Zielony, Żółty, Fioletowy.");
                }
            }
        }
    }
}
