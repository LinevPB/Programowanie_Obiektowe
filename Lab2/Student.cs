using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private string _imie;
        private string _nazwisko;
        private List<int> _oceny;

        public Student(string imie, string nazwisko)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _oceny = new List<int>();
        }

        public string Imie => _imie;

        public string Nazwisko => _nazwisko;

        public double SredniaOcen
        {
            get
            {
                if (_oceny.Count == 0) return 0;
                return _oceny.Average();
            }
        }

        public void DodajOcene(int ocena)
        {
            if (ocena < 2 || ocena > 5)
            {
                Console.WriteLine("Ocena musi być liczbą całkowitą pomiędzy 2 a 5.");
                return;
            }
            _oceny.Add(ocena);
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Student: {Imie} {Nazwisko}");
            Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}");
            Console.WriteLine("Oceny: " + string.Join(", ", _oceny));
        }
    }
}
