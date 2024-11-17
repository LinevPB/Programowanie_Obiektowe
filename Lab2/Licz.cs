using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Licz
    {
        private int value;

        public Licz(int initialValue)
        {
            value = initialValue;
        }

        public void Dodaj(int liczba)
        {
            value += liczba;
        }

        public void Odejmij(int liczba)
        {
            value -= liczba;
        }

        public void WypiszStan()
        {
            Console.WriteLine($"Wartość: {value}");
        }
    }
}
