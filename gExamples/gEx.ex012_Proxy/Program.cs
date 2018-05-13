using System;

namespace gEx.ex012_Proxy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Proxy (Заместитель / Сурагат)";

			(new Proxy()).DoSomething();

			Console.ReadKey();
		}
	}
}
