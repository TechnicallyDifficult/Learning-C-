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

			for (int ii = 0; ii < this.Message.Length + 2; ++ii) 
			{
				result += "─";
			}

			result += "┐\n";
			result += $"│ {this.Message} │\n";
			result += "└";

			for (int ii = 0; ii < this.Message.Length + 2; ++ii) 
			{
				result += "─";
			}

			result += "┘";

			return result;
		}
	}
}