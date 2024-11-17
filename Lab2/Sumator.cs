using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int Suma()
        {
            int suma = 0;
            foreach (var liczba in Liczby)
            {
                suma += liczba;
            }
            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (var liczba in Liczby)
            {
                if (liczba % 2 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }

        public int IleElementów()
        {
            return Liczby.Length;
        }

        public void WypiszWszystkie()
        {
            Console.WriteLine(string.Join(", ", Liczby));
        }

        public void WypiszZakres(int lowIndex, int highIndex)
        {
            for (int i = lowIndex; i <= highIndex; i++)
            {
                if (i >= 0 && i < Liczby.Length)
                {
                    Console.Write(Liczby[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
