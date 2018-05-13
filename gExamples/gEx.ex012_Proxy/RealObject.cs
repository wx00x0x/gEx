using System;

namespace gEx.ex012_Proxy
{
	public class RealObject: Subject
	{
		public override void DoSomething()
		{
			Console.WriteLine("Действие на реальном объекте");
		}
	}
}