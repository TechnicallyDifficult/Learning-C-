using System;

namespace TextBox
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
			string result = "";

			result += "┌";

			for (var i = 0; i < this.Message.Length + 2; i++) 
			{
				result += "─";
			}

			result += "┐\n";
			result += $"│ {this.Message} │\n";
			result += "└";

			for (var i = 0; i < this.Message.Length + 2; i++) 
			{
				result += "─";
			}

			result += "┘";

			return result;
		}
	}
}