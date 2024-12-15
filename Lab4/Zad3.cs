using System;
using System.Collections.Generic;

public interface IOsoba
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    string ZwrocPelnaNazwe();
}

public class Osoba : IOsoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public string ZwrocPelnaNazwe()
    {
        return $"{Imie} {Nazwisko}";
    }

    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
}

public interface IStudent : IOsoba
{
    string Uczelnia { get; set; }
    string Kierunek { get; set; }
    int Rok { get; set; }
    int Semestr { get; set; }

    string WypiszPelnaNazweIUczelnie();
}

public class Student : IStudent
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Uczelnia { get; set; }
    public string Kierunek { get; set; }
    public int Rok { get; set; }
    public int Semestr { get; set; }

    public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Uczelnia = uczelnia;
        Kierunek = kierunek;
        Rok = rok;
        Semestr = semestr;
    }

    public string ZwrocPelnaNazwe()
    {
        return $"{Imie} {Nazwisko}";
    }

    public virtual string WypiszPelnaNazweIUczelnie()
    {
        return $"{ZwrocPelnaNazwe()} – {Kierunek} {Rok} {Semestr} {Uczelnia}";
    }
}

public class StudentWSIiZ : Student
{
    public StudentWSIiZ(string imie, string nazwisko, string kierunek, int rok, int semestr)
        : base(imie, nazwisko, "WSIiZ", kierunek, rok, semestr)
    {
    }

    public override string WypiszPelnaNazweIUczelnie()
    {
        return $"{ZwrocPelnaNazwe()} – {Kierunek} {Rok} {Semestr} WSIiZ";
    }
}

public class Program
{
    public static void Main()
    {
        List<IStudent> studenci = new List<IStudent>();

        studenci.Add(new Student("Jan", "Kowalski", "AGH", "Informatyka", 4, 1));
        studenci.Add(new Student("Anna", "Nowak", "AGH", "Matematyka", 2, 3));
        studenci.Add(new StudentWSIiZ("Marek", "Wiśniewski", "Informatyka", 2, 1));
        studenci.Add(new StudentWSIiZ("Zofia", "Szymańska", "Fizyka", 3, 2));

        foreach (var student in studenci)
        {
            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
        }
    }
}
