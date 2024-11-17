using ConsoleApp1;

static void run()
{
    Student student = new Student("Jan", "Kowalski");

    student.DodajOcene(4);
    student.DodajOcene(5);
    student.DodajOcene(3);

    student.WyswietlInformacje();
}

run();
