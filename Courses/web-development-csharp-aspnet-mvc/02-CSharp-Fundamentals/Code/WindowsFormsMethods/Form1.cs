using System;
using System.Windows.Forms;

namespace WindowsFormsMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hide GroupBox
        public void HideRadioButtons()
        {
            groupBox1.Visible = false;
        }

        // Clear TextBoxes
        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        // Copy Text
        public void FillTextBox(string text)
        {
            textBox2.Text = text;
        }

        // Display Age
        public void SetNumber(int age)
        {
            label1.Text = $"You are {age} years old.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example 1
            HideRadioButtons();

            // Example 2
            ClearAllText();

            // Example 3
            FillTextBox(textBox1.Text);

            // Example 4
            SetNumber(23);
        }
    }
}