using System;

namespace gEx.ex008_Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Composite (Компоновщик)";

			Component root = new Composite("main")
				.Add(new Composite("1")
					.Add(new Composite("1.0")
						.Add(new Leaf("1.0.1"))
						.Add(new Leaf("1.0.2"))
					)
					.Add(new Composite("1.1"))
					.Add(new Composite("1.2"))
				)
				.Add(new Composite("2")
					.Add(new Composite("2.0"))
					.Add(new Composite("2.1"))
				);

			root.Display();

			Console.ReadKey();
		}
	}
}
