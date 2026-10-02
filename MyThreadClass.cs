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
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(500); 
            }
        }

        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;

            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(1500); 
            }
        }
    }
}