namespace gEx.ex009_Decorator
{
	public class CapsPrinter : FormatablePrinter
	{
		public CapsPrinter(Printer printer) : base(printer)
		{

		}

		public override void Print(string msg)
		{
			base.Print(msg.ToUpper());
		}
	}
}