using System;

namespace gEx.ex012_Proxy
{
	public class Proxy : Subject
	{
		protected Subject Subject { get; set; }

		public Proxy()
		{
			Subject = new RealObject();
		}

		public override void DoSomething()
		{
			Console.WriteLine("Выполнение на прокси.");
			Subject.DoSomething();
		}
	}
}