using System;
using System.Collections.Generic;

namespace classes
{
	class Program
	{
		static void Main(string[] args)
		{
			var accounts = new List<BankAccount>();

			accounts.Add(new BankAccount("potato", 1000));
			accounts.Add(new BankAccount("Potted Plant", 1000));
			accounts.Add(new BankAccount("nobody", 1000));

			Console.WriteLine("Printing account database...");
			
			foreach (var account in accounts)
			{
				Console.WriteLine($"{account.Number} | {account.Owner} | ${account.Balance}");
			}
		}

	}
}
