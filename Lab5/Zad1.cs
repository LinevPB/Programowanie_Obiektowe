using System;
using System.Collections.Generic;

namespace Kalkulator
{
    public enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnożenie,
        Dzielenie
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<double> wyniki = new List<double>();
            
            while (true)
            {
                try
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    double liczba1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Podaj drugą liczbę: ");
                    double liczba2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("1 - Dodawanie");
                    Console.WriteLine("2 - Odejmowanie");
                    Console.WriteLine("3 - Mnożenie");
                    Console.WriteLine("4 - Dzielenie");
                    int wybor = Convert.ToInt32(Console.ReadLine());

                    Operacja operacja = (Operacja)(wybor - 1);

                    double wynik = 0;
                    switch (operacja)
                    {
                        case Operacja.Dodawanie:
                            wynik = liczba1 + liczba2;
                            break;
                        case Operacja.Odejmowanie:
                            wynik = liczba1 - liczba2;
                            break;
                        case Operacja.Mnożenie:
                            wynik = liczba1 * liczba2;
                            break;
                        case Operacja.Dzielenie:
                            if (liczba2 == 0)
                            {
                                throw new DivideByZeroException("Nie można dzielić przez zero!");
                            }
                            wynik = liczba1 / liczba2;
                            break;
                    }

                    wyniki.Add(wynik);

                    Console.WriteLine($"Wynik operacji: {wynik}");

                    Console.WriteLine("Poprzednie wyniki:");
                    foreach (var r in wyniki)
                    {
                        Console.WriteLine(r);
                    }

                    Console.Write("Czy chcesz wykonać kolejne obliczenie? (t/n): ");
                    char odpowiedz = Console.ReadKey().KeyChar;
                    if (odpowiedz != 't' && odpowiedz != 'T')
                    {
                        break;
                    }
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Wprowadzono niepoprawny format liczby.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
                }
            }
        }
    }
}
