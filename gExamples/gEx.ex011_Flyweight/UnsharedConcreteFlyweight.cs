﻿using System;

namespace gEx.ex011_Flyweight
{
	class UnsharedConcreteFlyweight : Flyweight
	{
		string allState = "UnsharedConcreteFlyweight ";

		public override void Operation(ConsoleColor extrinsicState)
		{
			Console.ForegroundColor = extrinsicState;
			Console.WriteLine(allState + GetHashCode());
		}
	}
}