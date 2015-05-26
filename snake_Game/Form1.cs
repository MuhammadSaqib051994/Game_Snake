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
            
            Gametimer.Interval = 1000 / Settings.Speed;
            Gametimer.Tick += UpdateScreen;
            Gametimer.Start();

            StartGame(); 
        }
 
        private void StartGame()
        {
            lblGameOver.Visible = false;
            new Settings();
            snake_Game.Clear();
            circle head = new circle();
            {
                head.X = 10;
                head.Y = 5;
            }
            snake_Game.Add(head);

            labelscore.Text = Settings.Score.ToString();
            GenerateFood();


        }
        private void GenerateFood()
        {
            int maxXPos = pbcanvas.Size.Width / Settings.Width;
            int maxYPos = pbcanvas.Size.Height / Settings.Height;

            Random random = new Random();

            food = new circle
            {
                X = random.Next(0, maxXPos),Y = random.Next(0, maxYPos)
            };

        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.Gameover)
            {
                if (Inputs.KeyPressed(Keys.Enter))
                {
                    StartGame();

                }

            }
            else 
            {
                if (Inputs.KeyPressed(Keys.Right) && Settings.direction != Direction.left)
                    Settings.direction = Direction.right;

                else if (Inputs.KeyPressed(Keys.Left) && Settings.direction != Direction.right)
                    Settings.direction = Direction.left;

                else if (Inputs.KeyPressed(Keys.Up) && Settings.direction != Direction.down)
                    Settings.direction = Direction.up;

                else if (Inputs.KeyPressed(Keys.Down) && Settings.direction != Direction.up)
                    Settings.direction = Direction.down;

               MovePlayer();
            }
            pbcanvas.Invalidate();
        
        }
        private void pbcanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.Gameover)
            {
                for (int i = 0; i < snake_Game.Count; i++)
                { 
                Brush snake_Gamecolour;
                
                if (i == 0)
                    {
                        snake_Gamecolour = Brushes.Black;
                    }
                    else
                    snake_Gamecolour = Brushes.Green;    //Rest of body

                //Draw snake
                canvas.FillEllipse(snake_Gamecolour,
                    new Rectangle(snake_Game[i].X * Settings.Width,
                                  snake_Game[i].Y * Settings.Height,
                                  Settings.Width, Settings.Height));


                //Draw Food
                canvas.FillEllipse(Brushes.Red,
                    new Rectangle(food.X * Settings.Width,
                         food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }

            
            else
            {
                string Gameover ="Game Over \n Your Score is: "+ Settings.Score + "\nPress Enter To Try Again";
                lblGameOver.Text = Gameover;
                lblGameOver.Visible = true;
            }
        }

        private void MovePlayer()
        {
            for (int i = snake_Game.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.right:
                            snake_Game[i].X++;
                            break;

                        case Direction.left:
                            snake_Game[i].X--;
                            break;

                        case Direction.up:
                            snake_Game[i].Y--;
                            break;

                        case Direction.down:
                            snake_Game[i].Y++;
                            break;
                    }

                    int maxXpos = pbcanvas.Size.Width / Settings.Width;
                    int maxYpos = pbcanvas.Size.Height / Settings.Height;

                    if (snake_Game[i].X < 0 || snake_Game[i].Y < 0
                        || snake_Game[i].X >= maxXpos
                        || snake_Game[i].Y >= maxYpos)
                    {
                        Die();
                    }
                   
                    for (int j = 1; j < snake_Game.Count; j++)
                    {
                        if (snake_Game[i].X == snake_Game[j].X &&
                            snake_Game[i].Y == snake_Game[j].Y)
                        {
                            Die();
                        }
                    }

                    if (snake_Game[0].X == food.X && snake_Game[0].Y == food.Y)
                    {
                        Eat();
                    }

                }


                else
                {
                    snake_Game[i].X = snake_Game[i - 1].X;
                    snake_Game[i].Y = snake_Game[i - 1].Y;

                    
                }
            }
        }

        private void Game_Form_KeyDown(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, true);
        }

        private void Game_Form_KeyUp(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, false);
        }
        private void Eat()
        {
            circle Circle = new circle
        {
            X = snake_Game[snake_Game.Count - 1].X,Y = snake_Game[snake_Game.Count - 1].Y
        };
        snake_Game.Add(Circle);


                    Settings.Score += Settings.Points;
                    labelscore.Text = Settings.Score.ToString();
                    GenerateFood();
        }
        
        private void Die()
        {
            Settings.Gameover = true;
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

        private void Game_Form_Load(object sender, EventArgs e)
        {

        }

        

        private void Gametimer_Tick(object sender, EventArgs e)
        {

        }

        

       
    }
}
