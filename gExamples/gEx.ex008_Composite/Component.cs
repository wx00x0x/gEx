namespace gEx.ex008_Composite
{
	abstract class Component
	{
		protected string name;

		public Component Root { get; set; }
		protected int Level => Root?.Level + 1 ?? 0;

		protected const char LEVEL_DISPLAY_SYMBOL = '-';

		protected Component(string name)
		{
			this.name = name;
		}


		public abstract void Display();
		public abstract Component Add(Component c);
		public abstract void Remove(Component c);

	}
}