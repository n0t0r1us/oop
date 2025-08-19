/*
 * Flappy Bird game
 * Reference: "https://www.mooict.com/create-flappy-bird-game-in-visual-studio-using-c/"
 */
using System.Media;
using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // Tốc độ di chuyển (từ phải sang trái) của các trụ
        int gravity = 15;  // Giá trị trọng lực (càng lớn -> chim rơi tự do càng nhanh)
        int score = 0;     // Lưu điểm của lượt chơi
        SoundPlayer sound = new SoundPlayer("F://nhac//ting.wav");//thêm âm thanh

        public Form1()
        {
            InitializeComponent();
            lblhscore.Text = Properties.Settings.Default.h_score;
            panel1.Hide();
          //  level.Hide();
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;
            if (pipeBottom.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeBottom.Left = 800;
                score++;
                sound.Play();


            }
            if (pipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                pipeTop.Left = 950;
                score++;
                sound.Play();

            }
            

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                EndGame();
            }


            // if score is greater then 5 then we will increase the pipe speed to 15
        
            if (score > 3)
            {
                pipeSpeed = 15;
                pipeTop.Height =190;
          


            }
            if (score >10)
            {
                pipeSpeed = 20;
                pipeTop.Height = 230;
          
               

            }
            if(score>20)
            {
                pipeSpeed = 25;
                pipeTop.Height = 250;
       

            }
            if (score > 30)
            {
                pipeSpeed = 30;
                pipeTop.Height = 300;
 
            }
   
        }

        private void EndGame()
        {
            gameTimer.Stop();
            panel1.Show();
            // thiết kế điểm cao nhất
            int hscore = Int32.Parse(lblhscore.Text);
            if (score > hscore)
            {
                lblhscore.Text = score.ToString();
                Properties.Settings.Default.h_score = lblhscore.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
               
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

    }
}
