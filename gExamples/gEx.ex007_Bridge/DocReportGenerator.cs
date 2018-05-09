namespace gEx.ex007_Bridge
{
	public class DocReportGenerator : ReportGenerator
	{
		public DocReportGenerator(ReportBase data) : base(data)
		{
		}

		public override string GetReport()
		{
			return $"{reportDate.GetReportData()} построен в формате Doc.";
		}
	}
}