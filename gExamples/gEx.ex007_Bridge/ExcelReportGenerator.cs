namespace gEx.ex007_Bridge
{
	public class ExcelReportGenerator : ReportGenerator
	{
		public ExcelReportGenerator(ReportBase data) : base(data)
		{
		}

		public override string GetReport()
		{
			return $"{reportDate.GetReportData()} построен в формате Excel.";
		}
	}
}