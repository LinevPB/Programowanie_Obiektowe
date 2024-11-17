using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class BankAccount
	{
		private decimal _saldo;
		private string _wlasciciel;

		public string Wlasciciel
		{
			get { return _wlasciciel; }
		}

		public decimal Saldo
		{
			get { return _saldo; }
		}

		public BankAccount(string wlasc, decimal saldo = 0) 
		{
			_wlasciciel = wlasc;
			_saldo = saldo;
		}

		public void Wplata(decimal amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine("Nie mozna wplacic 0 i mniej");
				return;
			}

			_saldo += amount;
			Console.WriteLine($"Wpłacono {amount:C}.\t Nowe saldo: {_saldo:C}");
		}

		public void Wyplata(decimal amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine("Aby wyplacic podaj wartosc wieksza niz 0");
				return;
			}
			
			if (amount > _saldo)
			{
				Console.WriteLine("Niewystarczajace srodki na koncie");
				return;
			}

			_saldo -= amount;
			Console.WriteLine($"Wypłacono {amount:C}.\t Pozostałe środki na koncie: {_saldo:C}");
		}
	}
}
