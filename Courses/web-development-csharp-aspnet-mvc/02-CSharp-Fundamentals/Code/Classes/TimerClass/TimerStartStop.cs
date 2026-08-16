using System;
using System.Windows.Forms;

namespace TimerClassDemo
{
    // Reference example: Start() and Stop().
    class TimerStartStop
    {
        public static void Demo()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;

            // Start() begins the timer - Tick will fire repeatedly every
            // "Interval" milliseconds while the timer is running inside
            // an actual running Windows Forms application (see Form1.cs).
            timer.Start();
            Console.WriteLine("Timer started - it will tick every Interval while running.");

            // Stop() halts the timer - no further Tick events fire until
            // Start() is called again.
            timer.Stop();
            Console.WriteLine("Timer stopped - ticking has been halted.");
        }
    }
}
