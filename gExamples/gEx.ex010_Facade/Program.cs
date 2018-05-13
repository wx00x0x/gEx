using System;

namespace gEx.ex010_Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Facade (Фасад)";

			Facade facade = new Facade();
			facade.OperationAB();
			facade.OperationBC();

			Console.ReadKey();
		}
	}
}
