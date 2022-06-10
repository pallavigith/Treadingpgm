using System;
using System.Threading;

namespace MultiThreadingDemo

{
    public void Run() 
        {
            Thread t = Thread.CurrentThread;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    
    class Program
    {
       

        static void Main(string[] args)
        {
            MultiThreadingDemo demo = new MultiThreadingDemo();
            
            Thread t1 = new Thread(new ThreadStart(demo.Run));
            Thread t2 = new Thread(new ThreadStart(demo.Run));
            Thread t3 = new Thread(new ThreadStart(demo.Run));

            

            t1.Name = "t1 Thread";
            t2.Name = "t2 Thread";
            t3.Name = "t3 Thread";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.AboveNormal;
            t3.Priority = ThreadPriority.Highest;
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();


        }
    }
}
