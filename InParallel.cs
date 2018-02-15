using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace dotnetasync
{
	public class InParallel
	{
		public static async Task RunFunStuff()
		{
			var sw = new Stopwatch();
			sw.Start();
			var aTask =  Delayer.Get(2000);
			var bTask =  Delayer.Get(1000);
			var cTask =  Delayer.Get(5);

			var a = await aTask;
			var b = await bTask;
			var c = await cTask;
			sw.Stop();

			Console.WriteLine($"Async completed - got {a} {b} {c} in {sw.ElapsedMilliseconds}\n");
		}
	}
}
