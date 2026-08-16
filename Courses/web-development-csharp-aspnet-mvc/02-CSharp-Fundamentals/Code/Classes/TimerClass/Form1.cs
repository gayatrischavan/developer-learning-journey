using System;
using System.Windows.Forms;

namespace TimerClassDemo
{
    public partial class Form1 : Form
    {
        // Timer and counter - declared OUTSIDE the Tick handler so the
        // counter's value is preserved between ticks.
        private Timer timer;
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();

            // Creating the Timer and setting its Interval (in milliseconds)
            timer = new Timer();
            timer.Interval = 1000; // approximately 1 second

            // Connecting the Tick event to its handler
            timer.Tick += timer_Tick;
        }

        // Start button - begins the timer
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        // Stop button - halts the timer
        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        // Runs once per Interval, only while the timer is running
        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }
    }
}
