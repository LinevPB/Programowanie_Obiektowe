using ConsoleApp1;
using System;

static void run()
{
    Console.WriteLine("Tworzenie samochodu osobowego przez użytkownika:");
    SamochodOsobowy samochodOsobowy = new SamochodOsobowy();

    Console.WriteLine("\nTworzenie samochodów przez konstruktor:");
    Samochod samochod1 = new Samochod("Toyota", "Corolla", "Sedan", "Czarny", 2018, 50000);
    Samochod samochod2 = new Samochod("BMW", "X5", "SUV", "Biały", 2020, 30000);

    Console.WriteLine("\nInformacje o samochodzie osobowym:");
    samochodOsobowy.WyswietlInformacje();

    Console.WriteLine("\n\nInformacje o samochodach:");
    samochod1.WyswietlInformacje();
    Console.WriteLine("");
    samochod2.WyswietlInformacje();
}

run();
