using System;
using System.Collections.Generic;

namespace ZamowieniaApp
{
    class Program
    {
        public enum StatusZamowienia
        {
            Oczekujące,
            Przyjęte,
            Zrealizowane,
            Anulowane
        }

        public class ZamowieniaManager
        {
            private Dictionary<int, (List<string> Produkty, StatusZamowienia Status)> zamowienia;

            public ZamowieniaManager()
            {
                zamowienia = new Dictionary<int, (List<string> Produkty, StatusZamowienia Status)>();
            }

            public void DodajZamowienie(int numerZamowienia, List<string> produkty)
            {
                if (zamowienia.ContainsKey(numerZamowienia))
                {
                    Console.WriteLine($"Zamówienie o numerze {numerZamowienia} już istnieje.");
                }
                else
                {
                    zamowienia[numerZamowienia] = (produkty, StatusZamowienia.Oczekujące);
                    Console.WriteLine($"Dodano zamówienie o numerze {numerZamowienia}.");
                }
            }

            public void ZmienStatusZamowienia(int numerZamowienia, StatusZamowienia nowyStatus)
            {
                if (!zamowienia.ContainsKey(numerZamowienia))
                {
                    throw new KeyNotFoundException($"Zamówienie o numerze {numerZamowienia} nie istnieje.");
                }

                var aktualnyStatus = zamowienia[numerZamowienia].Status;
                if (aktualnyStatus == nowyStatus)
                {
                    throw new ArgumentException($"Status zamówienia {numerZamowienia} jest już ustawiony na {nowyStatus}. Nie można go zmienić na ten sam.");
                }

                zamowienia[numerZamowienia] = (zamowienia[numerZamowienia].Produkty, nowyStatus);
                Console.WriteLine($"Status zamówienia {numerZamowienia} zmieniono na {nowyStatus}.");
            }

            public void WyswietlZamowienia()
            {
                if (zamowienia.Count == 0)
                {
                    Console.WriteLine("Brak zamówień w systemie.");
                }
                else
                {
                    foreach (var zamowienie in zamowienia)
                    {
                        Console.WriteLine($"Zamówienie {zamowienie.Key}:");
                        Console.WriteLine($"Status: {zamowienie.Value.Status}");
                        Console.WriteLine("Produkty:");
                        foreach (var produkt in zamowienie.Value.Produkty)
                        {
                            Console.WriteLine($"- {produkt}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ZamowieniaManager manager = new ZamowieniaManager();

            manager.DodajZamowienie(1, new List<string> { "Produkt1", "Produkt2" });
            manager.DodajZamowienie(2, new List<string> { "Produkt3", "Produkt4" });

            manager.WyswietlZamowienia();

            try
            {
                manager.ZmienStatusZamowienia(1, StatusZamowienia.Przyjęte);
                manager.ZmienStatusZamowienia(1, StatusZamowienia.Przyjęte);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            manager.WyswietlZamowienia();
        }
    }
}
