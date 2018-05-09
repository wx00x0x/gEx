using System;

namespace gEx.ex006_Adapter
{
	public class ConsoleMessageWriter : IConsoleMessageWriter
	{
		private ConsoleColorSwitcher colorSwitcher;

		public ConsoleMessageWriter()
		{
			colorSwitcher = new ConsoleColorSwitcher();
		}

		public void WriteError(string msg)
		{
			colorSwitcher.SetColor(ConsoleColor.Red);
			Console.WriteLine(msg);
			colorSwitcher.SetDefaultColor();
		}

		public void WriteInfo(string msg)
		{
			colorSwitcher.SetColor(ConsoleColor.Yellow);
			Console.WriteLine(msg);
			colorSwitcher.SetDefaultColor();
		}

		public void WriteSuccess(string msg)
		{
			colorSwitcher.SetColor(ConsoleColor.Green);
			Console.WriteLine(msg);
			colorSwitcher.SetDefaultColor();
		}
	}
}