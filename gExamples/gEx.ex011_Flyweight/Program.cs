using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gEx.ex011_Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Flyweight (Легковес / приспособленец)";

			Flyweight[] flyweight = new Flyweight[100];
			FlyweightFactory factory = new FlyweightFactory();

			for (int i = 0; i < flyweight.Length; i++)
			{
				flyweight[i] = factory.GetConcreteFlyweight("1");
				flyweight[i].Operation(ConsoleColor.Yellow);
			}

			for (int i = 0; i < flyweight.Length; i++)
			{
				flyweight[i] = factory.GetUnsharedConcreteFlyweight();
				flyweight[i].Operation(ConsoleColor.Green);
			}

			Console.ReadKey();
		}
	}
}
