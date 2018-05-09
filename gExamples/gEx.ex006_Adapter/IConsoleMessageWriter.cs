namespace gEx.ex006_Adapter
{
	/// <summary>
	/// Целевой интерфейс
	/// </summary>
	public interface IConsoleMessageWriter
	{
		void WriteInfo(string msg);

		void WriteError(string msg);

		void WriteSuccess(string msg);
	}
}