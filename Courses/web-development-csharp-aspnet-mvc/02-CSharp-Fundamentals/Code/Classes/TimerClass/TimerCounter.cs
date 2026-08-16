using System;
using System.Windows.Forms;

namespace TimerClassDemo
{
    // Reference example: the counter pattern used live in Form1.cs.
    // "counter" is declared OUTSIDE the Tick handler (as a field) so its
    // value is preserved between ticks. Only "counter++" happens inside Tick.
    class TimerCounter
    {
        private static int counter = 0;

        public static void Demo()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // ~1 second between ticks
            timer.Tick += timer_Tick;

            Console.WriteLine("Counter demo configured.");
            Console.WriteLine("See Form1.cs for the live, ticking version with a Label.");
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");

            // In Form1.cs, this same pattern updates a Label instead:
            // label1.Text = counter.ToString();
        }
    }
}
