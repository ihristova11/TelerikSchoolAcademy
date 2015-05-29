//Using delegates write a class Timer that
//has can execute certain method at each t seconds.

namespace _07.TimerProgram
{
    using System;
    using System.Linq;
    public class TimerProgram
    {
        static void Main()
        {
            SampleDelegate test = new SampleDelegate(DelegateTimer.TimerTest);
            test(2);
        }
    }
}
