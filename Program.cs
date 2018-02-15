using System;

namespace dotnetasync
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Starting async test for dotnet");

			string command = string.Empty;

			while (command != "e") {

				switch (command)
				{
					case "1":
						Synchronous.RunFunStuff().Wait();
						command = string.Empty;
						break;
			
					case "2":
						InParallel.RunFunStuff().Wait();
						command = string.Empty;
						break;

					default:
						Console.WriteLine("What operations would you like to run?\n\t1 - synchronous\n\t2 - parallel\n\te - exit\n");
						command = Console.ReadLine();
						break;
				}
			}
		}
	}
}
