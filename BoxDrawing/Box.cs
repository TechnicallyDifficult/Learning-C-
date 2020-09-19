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

		public int Height { get; set; } // includes the edges
		public int Width { get; set; } // includes the edges
		public string Content { get; set; }

		public Box(string content)
		{
			this.Content = content;
			this.Width = content.Length + 4;
		}

		public Box(int height, int width)
		{
			this.Height = height;
			this.Width = width;
		}

		public string Draw()
		{
			StringBuilder box = new StringBuilder();

			box.Append((char)Line.NW_CORNER);
			box.Append((char)Line.HORIZONTAL, this.Width - 2);
			box.Append((char)Line.NE_CORNER + "\n");

			for (int ii = 1; ii < this.Height - 1; ++ii) 
			{
				box.Append((char)Line.VERTICAL);
				box.Append(' ', this.Width - 2);
				box.Append((char)Line.VERTICAL + "\n");
			}

			box.Append((char)Line.SW_CORNER);
			box.Append((char)Line.HORIZONTAL, this.Width - 2);
			box.Append((char)Line.SE_CORNER);

			return box.ToString();
		}
	}
}