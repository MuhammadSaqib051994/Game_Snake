using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_Game
{
    public partial class Game_Form : Form
    {
        private List<circle>snake_Game = new List<circle>();
        private circle food = new circle(); 

        public Game_Form()
        {
            InitializeComponent();

            new Settings();
            Gametimer.Interval = 1000 / Settings.speed;
            //Gametimer.Tick +=UpdateScreen();
            Gametimer.Start();

            StartGame();
         
        }
        private void StartGame()
        {
            snake_Game.Clear();
            circle head = new circle();
            head.X = 10;
            head.Y = 5;
            snake_Game.Add(head);


        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelscore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
