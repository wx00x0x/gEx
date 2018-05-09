using System;

namespace gEx.ex006_Adapter
{
	/// <summary>
	/// Адаптируемый класс
	/// </summary>
	public class ConsoleColorSwitcher
	{
		public void SetColor(ConsoleColor color)
		{
			Console.ForegroundColor = color;
		}

		public void SetDefaultColor()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}