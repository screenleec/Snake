using System;
using System.Drawing;
using System.Windows.Forms;


namespace Snake
{
    public partial class Game : Form
    {
        int highScore;
        string Player;

        private int rI, rJ;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400];
        private int dirX, dirY;
        private int _width = 680;
        private int _height = 480;
        private int _sizeOfSides = 32;
        private int score=0;

        private bool isGameOver = false;
        private bool isStartGame = false;
        public Game(string player)
        {
            InitializeComponent();
            
            Player = player;
            highScore = HighScore_get(Player);

            User_label.Text += Player;
            HighScore_label.Text += highScore;

            this.Text = "Snake";
            this.Width = _width;
            this.Height = _height + 48;
            this.BackColor = Images.BackGroundC;

            Restart_label.Visible = false;

            dirX = 1;
            dirY = 0;

            labelScore.Text = "Score: 0";

            snake[0] = new PictureBox();
            snake[0].Image = Images.HeadRIGHT;
            snake[0].Location = new Point(129, 257);
            snake[0].Size = new Size(_sizeOfSides-1, _sizeOfSides-1);
            this.Controls.Add(snake[0]);

            fruit = new PictureBox();
            fruit.Image = Images.Fruit;
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);

            timer.Tick += new EventHandler(_update);
            timer.Interval = 200;
            
            this.KeyDown += new KeyEventHandler(OKP);
        }

        private int HighScore_get (string player)
        {
            Database us = new Database("Data Source = dataBase.db; Version = 3;");
            int HScore = us.UserHighScore(player);
            return HScore;
        }
        private void gameOver()
        {
            isGameOver = true;
            Restart_label.Visible = true;
            Restart_label.Text = "Хи-хи, проиграл :)\n R - начать заново";

            timer.Interval = 200;

            if (score > highScore)
            {
                highScore = score;
                HighScore_label.Text = "Рекорд: " + highScore;

                Database us = new Database("Data Source = dataBase.db; Version = 3;");
                us.WriteUserHighScore(Player, highScore);
            }
        }
        private void restart()
        {
            Restart_label.Visible = false;
            isGameOver = false;
            
            for (int _i = 1; _i <= score; _i++)
            {
                this.Controls.Remove(snake[_i]);
            }
            score = 0;
            labelScore.Text = "Score: " + score;

            snake[0].Location = new Point(129, 257);
            _generateFruit();

            dirX = 1;
            dirY = 0;
            snake[0].Image = Images.HeadRIGHT;
        }

        private void start()
        {
            isStartGame = true;
            Start_label.Visible = false;
            timer.Start();
            _generateMap();
            _generateFruit();
        }

        private bool _checkColFruit(int rI, int rJ) 
        {
            for (int i = 0; i < score; i++)
            {
                if (snake[i].Location.X == rI && snake[i].Location.Y == rJ) return true;
            }
            return false;
        }

        private void _generateFruit()
        {
            Random r = new Random();

            do
            {
                rI = r.Next(0, _height - _sizeOfSides);
                int tempI = rI % _sizeOfSides;
                rI -= tempI;
                rJ = r.Next(0, _height - _sizeOfSides);
                int tempJ = rJ % _sizeOfSides;
                rJ -= tempJ;
                rI++;
                rJ++;
            } while (_checkColFruit(rI, rJ));

            fruit.Location = new Point(rI, rJ);
            this.Controls.Add(fruit);
        }

        private void _checkBorders()
        {
            if (snake[0].Location.X < 0)
            {
                snake[0].Location = new Point(1, snake[0].Location.Y);
                gameOver();
            }
            if (snake[0].Location.X > _height- _sizeOfSides+1)
            {
                snake[0].Location = new Point(_height - _sizeOfSides + 1, snake[0].Location.Y);
                gameOver();
            }
            if (snake[0].Location.Y < 0)
            {
                snake[0].Location = new Point(snake[0].Location.X, 1);
                gameOver();
            }
            if (snake[0].Location.Y > _height- _sizeOfSides + 1)
            {
                snake[0].Location = new Point(snake[0].Location.X, _height - _sizeOfSides + 1);
                gameOver();
            }
        }

        private void _eatItself()
        {
            for(int _i=1;_i< score; _i++)
            {
                if(snake[0].Location == snake[_i].Location)
                {
                    gameOver();
                }
            }
        }

        private void _eatFruit()
        {
            if(snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                labelScore.Text = "Score: " + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
                snake[score].Size = new Size(_sizeOfSides-1, _sizeOfSides-1);
                this.Controls.Add(snake[score]);

                if (timer.Interval >= 120) timer.Interval = 200 - score;

                _generateFruit();
            }
        }

        private void _generateMap()
        {
            for(int i = 0; i < _height / _sizeOfSides+1; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Images.BorderC;
                pic.Location = new Point(0, _sizeOfSides * i);
                pic.Size = new Size(_height, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i <= _height / _sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Images.BorderC;
                pic.Location = new Point( _sizeOfSides * i,0);
                pic.Size = new Size(1,_height);
                this.Controls.Add(pic);
            }
        }

        private void _moveSnake()
        {
            for(int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
                snake[i].Image = Images.Body;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * (_sizeOfSides), snake[0].Location.Y + dirY * (_sizeOfSides));
            
            _eatItself();
        }

        private void ChangeUser_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void _update(Object myObject,EventArgs eventsArgs)
        {
            if (!isGameOver)
            {
                _eatFruit();
                _moveSnake();
                _checkBorders();
            }
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "R":
                    if (isGameOver) restart();
                    break;
                case "E":
                    if (!isStartGame) start();
                    break;

                case "D":
                    if (dirX != -1 && !isGameOver)
                    {
                        dirX = 1;
                        dirY = 0;
                        snake[0].Image = Images.HeadRIGHT;
                    }
                    break;
                case "A":
                    if (dirX != 1 && !isGameOver)
                    {
                        dirX = -1;
                        dirY = 0;
                        snake[0].Image = Images.HeadLEFT;
                    }
                    break;
                case "W":
                    if (dirY != 1 && !isGameOver) 
                    {
                        dirY = -1;
                        dirX = 0;
                        snake[0].Image = Images.HeadUP;
                    }
                    break;
                case "S":
                    if (dirY != -1 && !isGameOver)
                    {
                        dirY = 1;
                        dirX = 0;
                        snake[0].Image = Images.HeadDOWN;
                    }
                    break; 
            }
        }
    }
}
