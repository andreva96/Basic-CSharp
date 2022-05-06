using System;
using System.Threading;

namespace Thread_Rendezvous_2
{
	class MainClass
	{
		// wait handles to rendezvous threads
		public static CountdownEvent handle = new CountdownEvent (3);

		// thread work method
		public static void DoWork()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write (i + " ");

				// rendezvous with other threads
				if (i == 3)
				{
					handle.Signal ();
					handle.Wait ();
				}
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
