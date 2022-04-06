namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score.ToString(); 

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if(PipeTop.Left < -180)
            {
                PipeTop.Left = 950;
                score++;
            }

            if(FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                FlappyBird.Top < -25
                )
            {
                endGame();
            }

            if(score > pipeSpeed)
            {
                pipeSpeed += 5;
            }

        }

        private void gameKeysUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void gameKeysDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text += " Game Over!";
        }

    }
}