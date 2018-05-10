using System;

namespace gEx.ex009_Decorator
{
	public class ConsolePrinter : Printer
	{
		public override void Print(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}