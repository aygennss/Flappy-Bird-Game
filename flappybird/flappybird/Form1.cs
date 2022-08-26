using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class Form1 : Form
    {

        int boruHizi = 8;
        int gravity = 10;
        int skor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            borua.Left -= boruHizi;
            boruy.Left -= boruHizi;
            skortext.Text = "Skor: " + skor;

                if(borua.Left<-150)
            {
                borua.Left = 400;
                skor++;
            }
            if (boruy.Left < -180)
            {
                boruy.Left = 450;
                skor++;
            }
            if(bird.Bounds.IntersectsWith(borua.Bounds)|| bird.Bounds.IntersectsWith(boruy.Bounds)|| bird.Bounds.IntersectsWith(zemin.Bounds))
            { endGame(); }
            if(skor>5)
            {
            boruHizi= 15;

            }
            if(bird.Top<-25)
            {
                endGame();
            }
       
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

          
        }
        private void endGame()
        {
            gametimer.Stop();
            skortext.Text = "Game Over";
        }
    }
}
