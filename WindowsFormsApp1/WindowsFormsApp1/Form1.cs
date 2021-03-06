using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int timeRerRound = 6;
        bool GameOver = false;

        string[] CPUchoiceList = { "rock", "paper", "scissor", "rock", "paper", "scissor" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUChoice;

        string PlayerChoice;

        int CPUScore;
        int PlayerScore;
                
        public Form1()
        {
            InitializeComponent();

            countDownTimer.Enabled = true;
            PlayerChoice = "none";
            txtCountdown.Text = "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            Simple.Play();
            pictureBox1.Image = Properties.Resources.NaOH;
            PlayerChoice = "paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.HCl;
            PlayerChoice = "scissor";
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            Simple.Play();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.H2SO4;
            PlayerChoice = "rock";
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            Simple.Play();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //PlayerScore = 0;
           ///CPUScore = 0;
            rounds = 3;
           // txtScore.Text = "Player: " + PlayerScore + "-" + "Robot: " + CPUScore;
            PlayerChoice = "none";
            countDownTimer.Enabled = true;
            pictureBox1.Image = Properties.Resources.qq;
            pictureBox2.Image = Properties.Resources.qq;
            GameOver = false;
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timeRerRound -= 1;

            txtCountdown.Text = timeRerRound.ToString();

            txtRounds.Text = "Reaction Number " + rounds;

            if (timeRerRound < 1)
            {
                countDownTimer.Enabled = false;
                timeRerRound = 6;
                randomNumber = rnd.Next(0, CPUchoiceList.Length);
                CPUChoice = CPUchoiceList[randomNumber];

                switch (CPUChoice)
                {
                    case "rock":
                        pictureBox2.Image = Properties.Resources.H2SO4;

                        break;
                    case "paper":
                        pictureBox2.Image = Properties.Resources.NaOH;
                        break;
                    case "scissor":
                        pictureBox2.Image = Properties.Resources.HCl;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if(PlayerScore > CPUScore)
                    {
                        MessageBox.Show("restart");
                    }
                    else
                    {
                        MessageBox.Show("Restart");
                    }
                    GameOver = true;
                }
            }


        }

        private void checkGame()
        {
            if (PlayerChoice == "rock" && CPUChoice == "paper")
            {
                //CPUScore += 1;
                rounds -= 1;

                MessageBox.Show("H2SO4 + NaOH = NaSO4 + H2O");
            } 
            else if(PlayerChoice == "paper" && CPUChoice == "paper")
            {
                rounds -= 1;

                MessageBox.Show("NaOH + NaOH = 2NaOH");
            }
            else if(PlayerChoice == "scissor" && CPUChoice == "paper")
            {
                //PlayerScore += 1;
                rounds -= 1;

                MessageBox.Show("HCl + NaOH = NaCl + H2O");
            }
            else if(PlayerChoice == "rock" && CPUChoice == "rock")
            {
                rounds -= 1;

                MessageBox.Show("H2SO4 + H2SO4 = 2H2SO4");
            }
            else if(PlayerChoice == "paper" && CPUChoice == "rock")
            {
                //PlayerScore += 1;
                rounds -= 1;

                MessageBox.Show("H2SO4 + NaOH = NaSO4 + H2O");
            }
            else if(PlayerChoice == "scissor" && CPUChoice == "rock")
            {
               // CPUScore += 1;
                rounds -= 1;

                MessageBox.Show("HCl + H2SO4 = SO2 + Cl2 + 2H2O");
            }
            else if(PlayerChoice == "rock" && CPUChoice == "scissor")
            {
               // PlayerScore += 1;
                rounds -= 1;

                MessageBox.Show("H2SO4 + HCl = SO2 + Cl2 + 2H2O");
            }
            else if(PlayerChoice == "paper" && CPUChoice == "scissor")
            {
               // CPUScore += 1;
                rounds -= 1;

                MessageBox.Show("NaOH + HCl = NaCl + H2O");
            }
            else if(PlayerChoice == "scissor" && CPUChoice == "scissor")
            {
                rounds -= 1;

                MessageBox.Show("HCl + HCl = 2HCl");
            }
            else if(PlayerChoice == "none")
            {
                MessageBox.Show("make a choice");
            }
            else
            {
                MessageBox.Show("nothing");
            }
            startNextRound();
        }

        private void startNextRound()
        {
            if (GameOver == true)
            {
                return;
            }

           // txtScore.Text = "Player: " + PlayerScore + "-" + "Robot: " + CPUScore;
            PlayerChoice = "none";
            countDownTimer.Enabled = true;
            pictureBox1.Image = Properties.Resources.qq;
            pictureBox2.Image = Properties.Resources.qq;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRounds_Click(object sender, EventArgs e)
        {

        }
    }
}
