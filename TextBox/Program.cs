using System;

namespace TextBox
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input:");

			var box = new Box(Console.ReadLine());
			
			Console.WriteLine(box.Draw());
		}
	}
}
