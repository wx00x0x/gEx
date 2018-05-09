using System;

namespace gEx.ex007_Bridge
{
	/*
	 * Мост
	 * Данный паттерн применяется чтобы разделять абстракцию и реализацию так,
	 * чтобы они могли изменяться независимо.
	 * 
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Bridge (Мост)";

			ReportGenerator generator;
			var chartReport = new ChartReport();
			var tableReport = new TableReport();

			generator = new PdfReportGenerator(chartReport);
			Console.WriteLine(generator.GetReport());
			generator = new PdfReportGenerator(tableReport);
			Console.WriteLine(generator.GetReport());

			generator = new XmlReportGenerator(chartReport);
			Console.WriteLine(generator.GetReport());
			generator = new XmlReportGenerator(tableReport);
			Console.WriteLine(generator.GetReport());

			generator = new DocReportGenerator(chartReport);
			Console.WriteLine(generator.GetReport());
			generator = new DocReportGenerator(tableReport);
			Console.WriteLine(generator.GetReport());

			generator = new ExcelReportGenerator(chartReport);
			Console.WriteLine(generator.GetReport());
			generator = new ExcelReportGenerator(tableReport);
			Console.WriteLine(generator.GetReport());

			Console.ReadKey();
		}
	}
}
