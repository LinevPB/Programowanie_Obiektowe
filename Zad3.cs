//Napisz program umożliwiający wprowadzanie 10-ciu liczb rzeczywistych do tablicy. Następnie
//utwórz następujące funkcjonalności używając pętli for:
//• Wyświetlanie tablicy od pierwszego do ostatniego indeksu.
//• Wyświetlanie tablicy od ostatniego do pierwszego indeksu.
//• Wyświetlanie elementów o nieparzystych indeksach.
//• Wyświetlanie elementów o parzystych indeksach.

zadanie3();

static void zadanie3()
{
    main();
}

static void main()
{
    const short N = 3;
    double[] nums = new double[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write("Podaj liczbe: ");
        nums[i] = Convert.ToDouble(Console.ReadLine());
    }

    for (int i = 0; i < N; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();

    for (int i = N - 1; i >= 0; i--)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < N; i=i+2)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();

    for (int i = 1; i < N; i=i+2)
    {
        Console.Write(nums[i] + " ");
    }
}