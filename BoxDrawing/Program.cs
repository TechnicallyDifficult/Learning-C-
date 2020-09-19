using System;

namespace BoxDrawing
{
	class Program
	{
		static void Main(string[] args)
		{
			var box = new Box(8, 16);
			
			Console.WriteLine(box.Draw());
		}
	}
}
