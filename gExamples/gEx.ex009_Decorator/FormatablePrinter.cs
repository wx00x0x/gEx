namespace gEx.ex009_Decorator
{
	public abstract class FormatablePrinter : Printer
	{
		public Printer Printer { get; set; }

		protected FormatablePrinter(Printer printer)
		{
			Printer = printer;
		}

		public override void Print(string msg)
		{
			Printer?.Print(msg);
		}
	}
}