using System;
using System.Collections.Generic;

namespace gEx.ex008_Composite
{
	class Composite : Component
	{
		List<Component> children = new List<Component>();

		public Composite(string name)
			: base(name)
		{ }

		public override Component Add(Component component)
		{
			component.Root = this;
			children.Add(component);
			return this;
		}

		public override void Remove(Component component)
		{
			children.Remove(component);
		}

		public override void Display()
		{
			Console.WriteLine($"{new string(LEVEL_DISPLAY_SYMBOL, Level)}{name}");

			foreach (Component component in children)
			{
				component.Display();
			}
		}
	}
}