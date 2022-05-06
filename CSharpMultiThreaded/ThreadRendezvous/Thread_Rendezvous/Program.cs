using System;
using System.Threading;

namespace Thread_Rendezvous
{
	class MainClass
	{
		// wait handles to rendezvous threads
		public static EventWaitHandle handle1 = new AutoResetEvent (false);
		public static EventWaitHandle handle2 = new AutoResetEvent (false);

		// thread work method
		public static void DoWork1()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write (i + " ");

				// rendezvous with other threads
				EventWaitHandle.SignalAndWait (handle1, handle2);
			}
		}

		// work method with rendezvous
		public static void DoWork2()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write (i + " ");

				// rendezvous with other threads
				EventWaitHandle.SignalAndWait (handle2, handle1);
			}
		}

		public static void Main (string[] args)
		{
			// start three threads
			new Thread (DoWork1).Start ();
			new Thread (DoWork2).Start ();
		}
	}
}
