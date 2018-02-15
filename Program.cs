using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace dotnet_async
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting async test for dotnet");
			RunFuntuff().Wait();
		}

		static async Task RunFuntuff()
		{
			var sw = new Stopwatch();
			sw.Start();
			var aTask = await Get(2000);
			var bTask = await Get(500);
			var cTask = await Get(5);
			sw.Stop();

			Console.WriteLine($"Async completed - got ${aTask} ${bTask} ${cTask} in ${sw.ElapsedMilliseconds}");
		}

		static async Task<int> Get(int id)
		{
			Console.WriteLine($"Starting task nr {id}");

			await Task.Delay(id);

			Console.WriteLine($"Completed task nr {id}");

			return id;
		}
	}
}
