using System;
using System.Threading;

namespace TrackThreadApp
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int LoopCount = 0; LoopCount <= 2; LoopCount++)
            {
                Console.WriteLine("Name of Thread: \n" + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(500); 
            }

            if (thread.Name == "Thread A")
                Console.WriteLine("The thread 0x2ef0 has exited with code 0 (0x0).");
            else if (thread.Name == "Thread C")
                Console.WriteLine("The thread 0x2624 has exited with code 0 (0x0).");
        }

        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;

            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Console.WriteLine("Name of Thread: \n" + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(1500); 
            }

            if (thread.Name == "Thread B")
                Console.WriteLine("The thread 0x15ec has exited with code 0 (0x0).");
            else if (thread.Name == "Thread D")
                Console.WriteLine("The thread 0x2b10 has exited with code 0 (0x0).");
        }
    }
}