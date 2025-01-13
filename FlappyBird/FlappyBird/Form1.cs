using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FlappyBird : Form
    { 

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public FlappyBird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            scoreLabel.Text = "Score: " + score;

            if (pipeDown.Left < -150)
            {
                pipeDown.Left = 800;
                score++;
            }

            if (pipeUp.Left < -180)
            {
                pipeUp.Left = 950;
                score++;
            }


            if (bird.Bounds.IntersectsWith(pipeDown.Bounds) || bird.Bounds.IntersectsWith(pipeUp.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }

            if (score > 6)
            {
                pipeSpeed = 13;
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void EndGame()
        {

            gameTimer.Stop();
            scoreLabel.Text = "Game Over !!! Score : " + score;

        }

    }
}
