using System;
using System.Threading;

namespace Thread_No_Rendezvous
{
	class MainClass
	{
		// thread work method
		public static void DoWork()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write (i + " ");
			}
		}

		public static void Main (string[] args)
		{
			// start three threads
			new Thread (DoWork).Start ();
			new Thread (DoWork).Start ();
		}
	}
}
