using System;

namespace BoxDrawing
{
	class Program
	{
		static void Main(string[] args)
		{
			var box = new Box();
			
			Console.WriteLine(box.Draw());
		}
	}
}
