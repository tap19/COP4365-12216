using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {

        AIOpponent aIOpponent = new AIOpponent();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // based on code found at http://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]") && !textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                aIOpponent.giveChoice(int.Parse(textBox1.Text));

                // check if too high, too low, or just right
                if (aIOpponent.isTooHigh)
                {
                    // current guess is too high
                    label2.Visible = true;
                    label3.Visible = false;
                }
                else if (aIOpponent.isTooLow)
                {
                    // current guess is too low
                    label2.Visible = false;
                    label3.Visible = true;
                }
                else
                {
                    // current guess is correct
                    label2.Visible = false;
                    label3.Visible = false;
                }

                // check if correct, colder, or warmer
                if (aIOpponent.isCorrect)
                {
                    // current guess is correct
                    textBox1.BackColor = Color.Green;
                    textBox1.Enabled = false;
                    MessageBox.Show("Correct!");
                }
                else if (aIOpponent.isColder)
                {
                    // current guess is colder
                    textBox1.BackColor = Color.Blue;
                }
                else if (aIOpponent.isWarmer)
                {
                    // current guess is warmer
                    textBox1.BackColor = Color.Red;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0000";
            textBox1.BackColor = Color.White;
            textBox1.Enabled = true;
            label2.Visible = false;
            label3.Visible = false;

            aIOpponent = new AIOpponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
