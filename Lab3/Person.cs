using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Person
    {
        private string firstName;
        private string lastName;
        private int wiek;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        public Person(string firstName, string lastName, int wiek)
        {
            FirstName = firstName;
            LastName = lastName;
            Wiek = wiek;
        }

        public void View()
        {
            Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Wiek}");
        }
    }
}
