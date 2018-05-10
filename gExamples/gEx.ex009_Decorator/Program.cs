using System;

namespace gEx.ex009_Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Decorator (Декоратор)";
			var message = "Мама мыла раму.";

			var ptr = new WhiteSpacePrinter(new CapsPrinter(new ConsolePrinter()));
			ptr.Print(message);

			var filePrinter = new WhiteSpacePrinter(new CapsPrinter(new FilePrinter("Decorator.txt")));
			filePrinter.Print(message);

			Console.ReadKey();
		}
	}
}
