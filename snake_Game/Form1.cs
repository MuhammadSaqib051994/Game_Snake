using System;
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
    public partial class Form1 : Form
    {
        private List<circle>snake_Game = new List<circle>();
        private circle food = new circle(); 

        public Form1()
        {
            InitializeComponent();

            new Settings();
            gameTimer.interval = 1000 / Settings.speed;

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
