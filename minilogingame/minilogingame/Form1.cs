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

namespace minilogingame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cupcake_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            picbox.Image = Properties.Resources.cupcake;
        }

        private void btn_Cake_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            picbox.Image = Properties.Resources.cake;
        }

        private void btn_Pie_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            picbox.Image = Properties.Resources.pie;
        }

        private void btn_Cakepop_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            picbox.Image = Properties.Resources.cakepop;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            if (textBox_Name.Text == "" || textBox_Password.Text == "" )
            {
                MessageBox.Show("please provide yout Name and Password");
            }
         else
            {
                var message = new StringBuilder();
                message.AppendLine("Good Job!");
                message.AppendLine("Your Name is: " + textBox_Name.Text);
                MessageBox.Show(message.ToString());
                textBox_Name.Text = "";
                textBox_Password.Text = "";
                picbox.Image = Properties.Resources.gg;
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer();
            Simple.SoundLocation = "C:\\Users\\Админ\\Desktop\\shkola\\Mouse - Click - 00 - c - FesliyanStudios.com.mp3";
            textBox_Name.Text = "";
            textBox_Password.Text = "";
            picbox.Image = Properties.Resources.gg;
        }
    }
}
