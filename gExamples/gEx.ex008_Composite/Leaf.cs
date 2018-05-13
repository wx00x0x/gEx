using System;

namespace gEx.ex008_Composite
{
	class Leaf : Component
	{
		public Leaf(string name)
			: base(name)
		{ }

		public override void Display()
		{
			Console.WriteLine($"{new string(LEVEL_DISPLAY_SYMBOL, Level)}{name}");
		}

		public override Component Add(Component component)
		{
			throw new NotImplementedException();
		}

		public override void Remove(Component component)
		{
			throw new NotImplementedException();
		}
	}
}