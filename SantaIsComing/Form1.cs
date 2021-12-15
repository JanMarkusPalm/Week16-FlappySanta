using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaIsComing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        int gravity = 10;
        int pipespeed = 10;
        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            topPipe.Left -= pipespeed;
            bottomPipe.Left -= pipespeed;

            if (topPipe.Left < -30)
            {
                topPipe.Left = 700;
                score++;
            }
            if (bottomPipe.Left < -30)
            {
                bottomPipe.Left = 700;
            }
            if (Bird.Top < -25)
            {
                GameOver();
            }

            if (Bird.Bounds.IntersectsWith(topPipe.Bounds) || Bird.Bounds.IntersectsWith(bottomPipe.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                GameOver();
            }


        }

         private void Form1_KeyPress(object sender, KeyPressEventArgs e)
         {

         }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +10;
            }
         }
        private void Bird_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void GameOver()
        {
            timer1.Stop();
            ScoreLabel.Text = $"game over. Score {score}";
        }

        private void timer1_tick(object sender, EventArgs e)
        {

        }

        
    }
}

