using System;
using System.Threading.Tasks;

namespace dotnetasync
{
	public static class Delayer
	{
		public static async Task<int> Get(int id)
		{
			Console.WriteLine($"Starting task nr {id}");

			await Task.Delay(id);

			Console.WriteLine($"Completed task nr {id}");

			return id;
		}
	}
}
