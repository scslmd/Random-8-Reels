using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Random_8_Reels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomizeBTN_Click(object sender, EventArgs e)
        {
            // very simple app, no need to use List<int>
            // initialize array to sort the 8 reels
            int[] Reels = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            RandomizeReels(Reels);

            UpdateReelOrderInWindow(Reels);
        }

        private void UpdateReelOrderInWindow(int[] Reels)
        {
            // Don't make it complicated, just push the data into the text box.
            textBox1.Text = Reels[0].ToString();
            textBox2.Text = Reels[1].ToString();
            textBox3.Text = Reels[2].ToString();
            textBox4.Text = Reels[3].ToString();
            textBox5.Text = Reels[4].ToString();
            textBox6.Text = Reels[5].ToString();
            textBox7.Text = Reels[6].ToString();
            textBox8.Text = Reels[7].ToString();
        }

        private static void RandomizeReels(int[] Reels)
        {
            // randomize seed
            var rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                int swapPositions = rnd.Next(0, 8);
                int tempValue = Reels[i];
                Reels[i] = Reels[swapPositions];
                Reels[swapPositions] = tempValue;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://en.wikipedia.org/wiki/The_Age_of_the_Earth");
            Process.Start(sInfo);
        }
    }
}
