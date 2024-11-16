//Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek, oraz wartości
//funkcji trygonometrycznych dla zadanego kąta. Użyj biblioteki Math np. Math.Sin(2.5). Proszę
//pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową. Wyniki działania
//algorytmów wyświetlaj na konsoli. Do obsługi menu proszę użyć konstrukcji switch-case oraz
//pętli while.



zadanie2();

static void zadanie2()
{
    menu();

}

static void menu()
{
ViewMenu:
    Console.WriteLine("""
        ***KALKULATOR***
        1. +
        2. -
        3. *
        4. /
        5. Potega
        6. Pierwiastek
        7. Funkcje trygonometryczne
        8. Koniec

        """);
    Console.Write("Twój wybór: ");

    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    switch(choice)
    {
        case 1: Total(); break;
        case 2: Diff(); break;
        case 3: Product(); break;
        case 4: Quation(); break;
        case 5: Potentation(); break;
        case 6: Square(); break;
        case 7: Trigonometry(); break;
        case 8: Close(); break;

        default:
            Console.WriteLine("Bledny wybor, wybierz ponownie");
            goto ViewMenu;
    }
}

static double DoubleInput()
{
    Console.Write("Podaj liczbe: ");
    double temp = Convert.ToDouble(Console.ReadLine());

    return temp;
}

static void Trigonometry()
{
    double a = DoubleInput();
    double convA = a * Math.PI / 180;

    Console.WriteLine($"sin({a}) = {Math.Sin(convA)}");
    Console.WriteLine($"cos({a}) = {Math.Cos(convA)}");
    Console.WriteLine($"tg({a}) = {Math.Tan(convA)}");
    Console.WriteLine($"ctg({a}) = {1/Math.Tan(convA)}");
}

static void Square()
{
    double a = DoubleInput();

    Console.WriteLine($"sqrt({a}) = {Math.Sqrt(a)}");
}

static void Potentation()
{
    double a = DoubleInput();
    double b = DoubleInput();

    Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
}

static void Quation()
{
    double a = DoubleInput();
    double b = DoubleInput();

    Console.WriteLine($"{a} / {b} = {a / b}");
}

static void Product()
{
    double a = DoubleInput();
    double b = DoubleInput();

    Console.WriteLine($"{a} * {b} = {a * b}");
}

static void Diff()
{
    double a = DoubleInput();
    double b = DoubleInput();

    Console.WriteLine($"{a} - {b} = {a - b}");
}

static void Total()
{
    double a = DoubleInput();
    double b = DoubleInput();

    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Close()
{
    Console.WriteLine("Koniec programu");
    System.Environment.Exit(1);
}
