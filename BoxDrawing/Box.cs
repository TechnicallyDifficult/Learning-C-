using System;
using System.Text;

namespace BoxDrawing
{
	class Box
	{
		public string Message { get; set; }

		public Box(string message)
		{
			this.Message = message;
		}

		public string Draw()
		{
			StringBuilder result = new StringBuilder("┌");

			for (int ii = 0; ii < this.Message.Length + 2; ++ii) 
			{
				result.Append("─");
			}

			result.Append("┐\n");
			result.Append($"│ {this.Message} │\n");
			result.Append("└");

			for (int ii = 0; ii < this.Message.Length + 2; ++ii) 
			{
				result.Append("─");
			}

			result.Append("┘");

			return result.ToString();
		}
	}
}