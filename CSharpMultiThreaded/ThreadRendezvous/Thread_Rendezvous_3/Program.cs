using System;
using System.Threading;

namespace Thread_Rendezvous_3
{
	class MainClass
	{
		// wait handles to rendezvous threads
		public static Barrier barrier = new Barrier(3, barrier => Console.WriteLine() );

		// thread work method
		public static void DoWork()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write (i + " ");

				// rendezvous with other threads
				barrier.SignalAndWait ();
			}
		}

		public static void Main (string[] args)
		{
			// start three threads
			new Thread (DoWork).Start ();
			new Thread (DoWork).Start ();
			new Thread (DoWork).Start ();
		}
	}
}
