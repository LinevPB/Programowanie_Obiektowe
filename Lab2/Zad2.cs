using ConsoleApp1;

static void run()
{
    BankAccount konto = new BankAccount("Jan Kowalski", 1000);
    konto.Wplata(500);
    konto.Wyplata(200);
    Console.WriteLine($"Saldo: {konto.Saldo}");
}

run();
