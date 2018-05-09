namespace gEx.ex007_Bridge
{
	public class XmlReportGenerator : ReportGenerator
	{
		public XmlReportGenerator(ReportBase data): base(data)
		{
		}

		public override string GetReport()
		{
			return $"{reportDate.GetReportData()} построен в формате XML.";
		}
	}
}