using System;
using System.Collections.Generic;

public class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pesel { get; set; }

    public void SetFirstName(string firstName)
    {
        Imie = firstName;
    }

    public void SetLastName(string lastName)
    {
        Nazwisko = lastName;
    }

    public void SetPesel(string pesel)
    {
        Pesel = pesel;
    }
    public int GetAge()
    {
        int rok = int.Parse(Pesel.Substring(0, 2));
        int miesiac = int.Parse(Pesel.Substring(2, 2));
        int dzien = int.Parse(Pesel.Substring(4, 2));

        if (miesiac > 80 && miesiac < 93)
        {
            rok += 1800;
            miesiac -= 80;
        }
        else if (miesiac > 20 && miesiac < 33)
        {
            rok += 2000;
            miesiac -= 20;
        }
        else if (miesiac > 0 && miesiac < 13)
        {
            rok += 1900;
        }
        else
        {
            throw new ArgumentException("Nieprawidłowy miesiąc w numerze PESEL.");
        }

        DateTime dataUrodzenia = new DateTime(rok, miesiac, dzien);
        DateTime dzis = DateTime.Now;
        int wiek = dzis.Year - dataUrodzenia.Year;

        if (dzis.Month < dataUrodzenia.Month || (dzis.Month == dataUrodzenia.Month && dzis.Day < dataUrodzenia.Day))
        {
            wiek--;
        }

        return wiek;
    }

    public string GetGender()
    {
        return (int.Parse(Pesel.Substring(9, 1)) % 2 == 0) ? "Female" : "Male";
    }

    public virtual string GetFullName()
    {
        return $"{Imie} {Nazwisko}";
    }

    public virtual bool CanGoAloneToHome()
    {
        return GetAge() >= 12;
    }
}

public class Uczen : Osoba
{
    public string Szkola { get; set; }
    public bool MozeSamWracacDoDomu { get; set; }

    public void SetSchool(string school)
    {
        Szkola = school;
    }

    public void ChangeSchool(string newSchool)
    {
        Szkola = newSchool;
    }

    public void SetCanGoHomeAlone(bool canGoAlone)
    {
        MozeSamWracacDoDomu = canGoAlone;
    }

    public override bool CanGoAloneToHome()
    {
        return GetAge() >= 12 || MozeSamWracacDoDomu;
    }
}

public class Nauczyciel : Uczen
{
    public string TytulNaukowy { get; set; }
    public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

    public void AddStudent(Uczen student)
    {
        PodwladniUczniowie.Add(student);
    }

    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        foreach (var student in PodwladniUczniowie)
        {
            if (student.CanGoAloneToHome())
            {
                Console.WriteLine($"{student.GetFullName()} moze wracac");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Uczen student1 = new Uczen { Imie = "Jan", Nazwisko = "Kowalski", Pesel = "20220183734" };
        Uczen student2 = new Uczen { Imie = "Anna", Nazwisko = "Nowak", Pesel = "02020254321" };
        Uczen student3 = new Uczen { Imie = "Kamil", Nazwisko = "Stonoga", Pesel = "60122981753" };
        Uczen student4 = new Uczen { Imie = "Adrian", Nazwisko = "Borowiec", Pesel = "01241896791" };
        Uczen student5 = new Uczen { Imie = "Bartek", Nazwisko = "Zieliński", Pesel = "60032368194" };
        Uczen student6 = new Uczen { Imie = "Ola", Nazwisko = "Stefan", Pesel = "06281488425" };
        Uczen student7 = new Uczen { Imie = "Ala", Nazwisko = "Szafka", Pesel = "08272753783" };
        Uczen student8 = new Uczen { Imie = "Karol", Nazwisko = "Wiktor", Pesel = "98041126412" };
        
        Nauczyciel teacher = new Nauczyciel { Imie = "Marek", Nazwisko = "Zielinski", Pesel = "03030398765", TytulNaukowy = "Dr" };
        teacher.AddStudent(student1);
        teacher.AddStudent(student2);
        teacher.AddStudent(student3);
        teacher.AddStudent(student4);
        teacher.AddStudent(student5);
        teacher.AddStudent(student6);
        teacher.AddStudent(student7);
        teacher.AddStudent(student8);

        teacher.WhichStudentCanGoHomeAlone(DateTime.Now);
    }
}
