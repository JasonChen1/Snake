using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeForm : Form
    {
        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();

        public SnakeForm()
        {
            
            InitializeComponent();
            
            //labelScore.BackColor = System.Drawing.Color.Transparent;
            new Settings();
            
            GameTimer.Interval = 1000 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();
            StartGame();
        }

        private void StartGame()
        {
            lbGameOver.Visible = false;

            //reset everything everytime a new game starts
            new Settings();

            //start with 1 circle
            snake.Clear();
            Circle head = new Circle { x = 10, y = 5 };
            snake.Add(head);

            labelScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        //randomly generate food on the screen
        private void GenerateFood()
        {
            int maxXPos = snakeCanvas.Size.Width / Settings.width;
            int maxYPos = snakeCanvas.Size.Height / Settings.Height;

            Random ran = new Random();
            food = new Circle { x = ran.Next(0, maxXPos), y = ran.Next(0, maxYPos) };
        }

        private void UpdateScreen(object sender, System.EventArgs e)
        {
 
            //check for if its gameover
            if (Settings.GameOver)
            {
                //check if enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }

                MovePlayer();
            }
            snakeCanvas.Invalidate();//make sure all the data in the canvas get clean
        }

        private void snakeCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {

                //draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    //set colour of snake
                    Brush snakeColor;
                    if (i == 0)
                    {
                        snakeColor = Brushes.Blue; //draw head
                    }
                    else
                    {
                        snakeColor = Brushes.Black;//draw body
                    }

                    //Draw snake
                    canvas.FillEllipse(snakeColor,
                        new Rectangle(snake[i].x * Settings.width,
                            snake[i].y * Settings.Height,
                            Settings.width, Settings.Height));

                    //draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.x * Settings.width,
                            food.y * Settings.Height,
                            Settings.width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score +
                    "\nPress Enter to try again";
                lbGameOver.Text = gameOver;
                lbGameOver.Visible = true;
            }

        }

        private void MovePlayer()
        {
            //loop backwards
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            snake[i].x++;
                            break;
                        case Direction.Left:
                            snake[i].x--;
                            break;
                        case Direction.Up:
                            snake[i].y--;
                            break;
                        case Direction.Down:
                            snake[i].y++;
                            break;
                        default:
                            break;
                    }

                    //max x and y position
                    int maxXPos = snakeCanvas.Size.Width / Settings.width;
                    int maxYPos = snakeCanvas.Size.Height / Settings.Height;

                    //snake must move inside the canvas
                    if (snake[i].x < 0 || snake[i].y < 0
                        || snake[i].x >= maxXPos || snake[i].y >= maxYPos)
                    {

                        Die();
                    }

                    //snake can not eat itself
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x &&
                            snake[i].y == snake[j].y)
                        {
                            Die();
                        }
                    }

                    //if the food is at the starting point eat it
                    if (snake[0].x == food.x &&
                        snake[0].y == food.y)
                    {
                        Eat();
                    }


                }
                else
                {
                    //move body
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }

            }
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            //add circle to body
            Circle food = new Circle();
            food.x = snake[snake.Count - 1].x;
            food.y = snake[snake.Count - 1].y;

            snake.Add(food);

            //update score
            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void SnakeForm_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

    }
}
