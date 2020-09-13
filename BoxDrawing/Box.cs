using System;
using System.Text;

namespace BoxDrawing
{
	class Box
	{
		public enum Line
		{
			HORIZONTAL = '─',
			VERTICAL = '│',
			NW_CORNER = '┌',
			NE_CORNER = '┐',
			SW_CORNER = '└',
			SE_CORNER = '┘'
		}

		public int Height { get; set; }
		public int Width { get; set; }

		public Box(int height = 8, int width = 8)
		{
			this.Height = height;
			this.Width = width;
		}

		public string DrawLine(int length, char character = (char)Line.HORIZONTAL)
		{
			StringBuilder line = new StringBuilder();

			for (int ii = 0; ii < length; ++ii) 
			{
				line.Append(character);
			}

			return line.ToString();
		}

		public string Draw()
		{
			StringBuilder box = new StringBuilder();

			box.Append((char)Line.NW_CORNER);
			box.Append(DrawLine(this.Width));
			box.Append((char)Line.NE_CORNER + "\n");

			for (int ii = 1; ii < this.Height - 1; ++ii) 
			{
				box.Append((char)Line.VERTICAL);
				box.Append(DrawLine(this.Width, ' '));
				box.Append((char)Line.VERTICAL + "\n");
			}

			box.Append((char)Line.SW_CORNER);
			box.Append(DrawLine(this.Width));
			box.Append((char)Line.SE_CORNER);

			return box.ToString();
		}

		// public string Message { get; set; }

		// public Box(string message)
		// {
		// 	this.Message = message;
		// }

		// public string Draw()
		// {
		// 	StringBuilder result = new StringBuilder("┌");

		// 	for (int ii = 0; ii < this.Message.Length + 2; ++ii) 
		// 	{
		// 		result.Append("─");
		// 	}

		// 	result.Append("┐\n");
		// 	result.Append($"│ {this.Message} │\n");
		// 	result.Append("└");

		// 	for (int ii = 0; ii < this.Message.Length + 2; ++ii) 
		// 	{
		// 		result.Append("─");
		// 	}

		// 	result.Append("┘");

		// 	return result.ToString();
		// }
	}
}