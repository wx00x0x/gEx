using System;

namespace gEx.ex006_Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Adapter (Адаптер)";

			IConsoleMessageWriter messageWriter = new ConsoleMessageWriter();
			messageWriter.WriteError("Ошибка");
			messageWriter.WriteInfo("Инфо");
			messageWriter.WriteSuccess("Успех");

			Console.ReadKey();
		}
	}
}
