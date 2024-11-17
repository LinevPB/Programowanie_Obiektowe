using ConsoleApp1;

static void run()
{
    int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Sumator sumator = new Sumator(liczby);

    sumator.WypiszWszystkie();

    Console.WriteLine("Suma: " + sumator.Suma());

    Console.WriteLine("Suma liczb podzielnych przez 2: " + sumator.SumaPodziel2());

    Console.WriteLine("Liczba elementów: " + sumator.IleElementów());

    sumator.WypiszZakres(2, 6);
}

run();
