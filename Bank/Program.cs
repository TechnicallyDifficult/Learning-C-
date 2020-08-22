using System;
using System.Collections.Generic;

namespace Bank
{
	class Program
	{
		static void Main(string[] args)
		{
			var accounts = new List<BankAccount>();

			accounts.Add(new BankAccount("potato", 1000));
			accounts.Add(new BankAccount("Potted Plant", 5));
			accounts.Add(new BankAccount("nobody", 9999));

			Console.WriteLine("Printing account database...");
			
			foreach (var account in accounts)
			{
				Console.WriteLine($"{account.Number} | {account.Owner} | ${account.Balance}");
			}

			accounts[0].MakeWithdrawal(500, DateTime.Now, "Rent payment");
			Console.WriteLine($"{accounts[0].Owner}: ${accounts[0].Balance}");
			accounts[0].MakeDeposit(100, DateTime.Now, "Friend paid me back");
			Console.WriteLine($"{accounts[0].Owner}: ${accounts[0].Balance}");
		}

	}
}
