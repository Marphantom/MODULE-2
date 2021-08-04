using System;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch mystw = new StopWatch();
            int text = 2;
            if (text == 2)
            {
                text++;
            }
            System.Console.WriteLine("Star!");
            mystw.Start();
            string mystwstar = Console.ReadLine();
            System.Console.WriteLine("Stop!");
            mystw.Stop();
            TimeSpan elapse = mystw.GetElapsedTime();
            System.Console.WriteLine(elapse);
        }
    }
}
