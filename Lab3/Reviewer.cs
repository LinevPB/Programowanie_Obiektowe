using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek)
        {
        }

        public void Wypisz()
        {
            Random rand = new Random();
            Console.WriteLine($"Recenzje książek przeczytanych przez {FirstName} {LastName}:");

            foreach (var book in BooksRead)
            {
                int rating = rand.Next(1, 6);
                Console.WriteLine($"{book.GetTitle} - Ocena: {rating}/5");
            }
        }
    }
}
