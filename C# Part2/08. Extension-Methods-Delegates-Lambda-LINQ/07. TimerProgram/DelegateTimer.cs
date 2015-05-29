namespace _07.TimerProgram
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public delegate void SampleDelegate(int seconds);
    public class DelegateTimer
    {
        public static void TimerTest(int seconds)
        {
            Stopwatch interval = new Stopwatch();
            interval.Start();

            while (true)
            {
                if (interval.ElapsedMilliseconds == seconds * 1000)
                {
                    Console.WriteLine("Pesho");
                    interval.Restart();
                }
            }

        }
    }
}
