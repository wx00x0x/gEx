namespace gEx.ex007_Bridge
{
	public abstract class ReportGenerator
	{
		protected ReportBase reportDate;

		protected ReportGenerator(ReportBase data)
		{
			reportDate = data;
		}

		public abstract string GetReport();
	}
}