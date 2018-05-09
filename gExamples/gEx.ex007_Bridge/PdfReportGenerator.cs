namespace gEx.ex007_Bridge
{
	public class PdfReportGenerator : ReportGenerator
	{
		public PdfReportGenerator(ReportBase data) : base(data)
		{
		}

		public override string GetReport()
		{
			return $"{reportDate.GetReportData()} построен в формате PDF.";
		}
	}
}