using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class SamochodOsobowy : Samochod
    {
        private double waga;
        private double pojemnoscSilnika;
        private int iloscOsob;

        public double Waga
        {
            get { return waga; }
            set
            {
                if (value >= 2 && value <= 4.5)
                    waga = value;
                else
                    Console.WriteLine("Waga musi być w przedziale 2 t - 4,5 t.");
            }
        }

        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set
            {
                if (value >= 0.8 && value <= 3.0)
                    pojemnoscSilnika = value;
                else
                    Console.WriteLine("Pojemność silnika musi być w przedziale 0,8-3,0.");
            }
        }

        public int IloscOsob
        {
            get { return iloscOsob; }
            set
            {
                if (value > 0)
                    iloscOsob = value;
                else
                    Console.WriteLine("Ilość osób musi być większa niż 0.");
            }
        }

        public SamochodOsobowy() : base()
        {
            Console.Write("Podaj wagę (w tonach): ");
            Waga = double.Parse(Console.ReadLine());

            Console.Write("Podaj pojemność silnika (w litrach): ");
            PojemnoscSilnika = double.Parse(Console.ReadLine());

            Console.Write("Podaj ilość osób: ");
            IloscOsob = int.Parse(Console.ReadLine());
        }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg, double waga, double pojemnoscSilnika, int iloscOsob)
            : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            Waga = waga;
            PojemnoscSilnika = pojemnoscSilnika;
            IloscOsob = iloscOsob;
        }

        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje(); 
            Console.WriteLine($"Waga: {Waga} t");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika} l");
            Console.WriteLine($"Ilość osób: {IloscOsob}");
        }
    }
}
