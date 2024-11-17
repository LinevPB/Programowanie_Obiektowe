using ConsoleApp1;

static void run()
{
    Person person1 = new Person("Jan", "Kowalski", 45);
    Reader reader1 = new Reader("Anna", "Nowak", 30);
    Reviewer reviewer1 = new Reviewer("Piotr", "Zieliński", 35);

    Book book1 = new Book("Programowanie C#", person1, new DateTime(2020, 5, 15));
    Book book2 = new Book("Wprowadzenie do C#", person1, new DateTime(2019, 3, 10));

    AdventureBook adventureBook1 = new AdventureBook("Podróże po świecie", person1, new DateTime(2021, 7, 10), "Ekscytujące przygody w dżungli.");
    DocumentaryBook documentaryBook1 = new DocumentaryBook("Historia Polski", person1, new DateTime(2018, 11, 25), "Opowieść o najważniejszych wydarzeniach w Polsce.");

    reader1.BooksRead.Add(book1);
    reader1.BooksRead.Add(book2);
    reader1.BooksRead.Add(adventureBook1); 
    reviewer1.BooksRead.Add(book1);

    List<Person> people = new List<Person> { person1, reader1, reviewer1 };

    foreach (var person in people)
    {
        person.View();
        Console.WriteLine();
    }

    reviewer1.Wypisz();

    adventureBook1.View();
    documentaryBook1.View();
}

run();
