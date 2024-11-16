//Napisz program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego.


zadanie1();

static void zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();

    double delta, x1, x2;

    if (a == 0)
    {
        Console.WriteLine("To nie jest rownanie kwadratowe");
        return;
    }

    delta = Math.Pow(b, 2) - (4 * a * c);
    
    if (delta < 0)
    {
        Console.WriteLine("Brak rozwiazania");
        return;
    }

    if (delta == 0)
    {
        Console.WriteLine(Math.Sqrt(delta)/(2*a));
        return;
    }

    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);

    Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
    Console.WriteLine("x1 = {0} x2 = {1}", Math.Round(x1, 2), Math.Round(x2, 2));
    Console.WriteLine($"x1 = {x1} x2 = {x2}");
    Console.WriteLine($"x1 = {x1:F2} x2 = {x2:F2}");
}

static double DoubleInput()
{
    Console.WriteLine("Podaj liczbe: ");
    double temp = Convert.ToDouble(Console.ReadLine());

    return temp;
}