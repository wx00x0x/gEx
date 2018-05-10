using System.IO;

namespace gEx.ex009_Decorator
{
	public class FilePrinter : Printer
	{
		private string fileName;

		public FilePrinter()
		{
			fileName = "test.txt";
		}

		public FilePrinter(string fileName)
		{
			this.fileName = fileName;
		}

		public override void Print(string msg)
		{
			using (var file = new StreamWriter(fileName, true))
			{
				file.Write(msg);
			}
		}
	}
}