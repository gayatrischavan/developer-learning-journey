using System;
using System.Windows.Forms;

namespace TimerClassDemo
{
    // Reference example: connecting and understanding the Tick event.
    class TimerTick
    {
        public static void Demo()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;

            // Connecting the Tick event to a handler method.
            // From this point on, "timer_Tick" runs once per Interval
            // while the timer is started.
            timer.Tick += timer_Tick;

            Console.WriteLine("Tick event connected to timer_Tick().");
        }

        // Runs every time the timer ticks.
        private static void timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick! This code runs on every tick.");
        }
    }
}
