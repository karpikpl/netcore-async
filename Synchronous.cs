using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace dotnetasync
{
	public static class Synchronous
	{
		public static async Task RunFunStuff()
		{
			var sw = new Stopwatch();
			sw.Start();
			var a = await Delayer.Get(2000);
			var b = await Delayer.Get(1000);
			var c = await Delayer.Get(5);
			sw.Stop();

			Console.WriteLine($"Async completed - got {a} {b} {c} in {sw.ElapsedMilliseconds}\n");
		}
	}
}
