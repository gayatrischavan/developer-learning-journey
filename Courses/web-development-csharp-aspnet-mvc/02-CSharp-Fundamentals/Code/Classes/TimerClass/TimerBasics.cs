using System;
using System.Windows.Forms;

namespace TimerClassDemo
{
    // Reference example: Timer creation and Interval.
    // This class only shows the correct syntax - a Timer's Tick event
    // only actually fires while a Windows Forms message loop is running,
    // which is why the full, live, ticking example lives in Form1.cs.
    class TimerBasics
    {
        public static void Demo()
        {
            // Creating a Timer
            Timer timer = new Timer();

            // Setting Interval - measured in MILLISECONDS, not seconds.
            timer.Interval = 1000; // 1000 ms is approximately 1 second

            Console.WriteLine("Timer created.");
            Console.WriteLine($"Interval set to {timer.Interval} ms (~1 second).");
        }
    }
}
