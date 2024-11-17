using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Osoba
	{
		private string _firstName;
		private string _lastName;
		private int _age;

		public Osoba(string firstName, string lastName, int age)
		{
			this._firstName = firstName;
			this._lastName = lastName;
			this._age = age;
		}

		public string firstName
		{ 
			get { return _firstName; } 
			set 
			{
				if (value.Length < 2)
				{
					Console.WriteLine("Imie musi miec minimum 2 znaki");
				}
				else
				{
					_firstName = value;
				}
			} 
		}

		public string lastName
		{ 
			get { return _lastName; } 
			set 
			{
				if (value.Length < 2)
				{
					Console.WriteLine("Nazwisko musi miec minimum 2 znaki");
				}
				else
				{
					_lastName = value; 
				}
			} 
		}

		public int age
		{
			get { return _age; }
			set
			{
				if (value < 0)
				{
					Console.WriteLine("Wiek nie moze byc liczba ujemna");
				}
				else
				{
					_age = value;
				}
			}
		}

		public void WyswietlInformacje()
		{
			Console.WriteLine($"Imie: {firstName} \t Nazwisko: {lastName} \t Wiek: {age}");
		}
	}
}
