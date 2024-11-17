using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        private int przebieg;

        public int Przebieg
        {
            get { return przebieg; }
            set
            {
                if (value >= 0)
                    przebieg = value;
                else
                    Console.WriteLine("Przebieg nie może być ujemny.");
            }
        }

        public Samochod()
        {
            Console.Write("Podaj markę: ");
            Marka = Console.ReadLine();

            Console.Write("Podaj model: ");
            Model = Console.ReadLine();

            Console.Write("Podaj nadwozie: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Podaj kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Podaj rok produkcji: ");
            RokProdukcji = int.Parse(Console.ReadLine());

            Console.Write("Podaj przebieg: ");
            Przebieg = int.Parse(Console.ReadLine());
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Nadwozie: {Nadwozie}");
            Console.WriteLine($"Kolor: {Kolor}");
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
            Console.WriteLine($"Przebieg: {Przebieg} km");
        }
    }
}
