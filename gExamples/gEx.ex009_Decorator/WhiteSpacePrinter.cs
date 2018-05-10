namespace gEx.ex009_Decorator
{
	public class WhiteSpacePrinter : FormatablePrinter
	{
		public WhiteSpacePrinter(Printer printer): base(printer)
		{
			
		}

		public override void Print(string msg)
		{
			var newMsg = msg.Replace(" ", "_");
			base.Print(newMsg);
		}
	}
}