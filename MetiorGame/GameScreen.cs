using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using System.Media;

namespace MetiorGame
{
    public partial class GameScreen : UserControl
    {
        Random ranGen = new Random();
        List<Planet> planets = new List<Planet>();
        SolidBrush brownBrush = new SolidBrush(Color.Brown);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        bool rightArrowDown = false;
        bool leftArrowDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool spawnPlanets = true;
        bool playerControls = true;
        bool playerVis = true;
        int winTime = 0;
        int distance = 60;
        int diff = difficulty.diffuicultyLevel;
        bool communism = CommieDifficulty.commieMode;
        int russDiff = CommieDifficulty.diffuicultyLevel;
        Player player;
        Earth earth;
        int earthSize = 120;
        int endTime = 0;

        SoundPlayer explosion = new SoundPlayer();
        SoundPlayer sound = new SoundPlayer();

        public GameScreen()
        {
            InitializeComponent();
            IntializeGame();
        }
        public void IntializeGame()
        {
            earth = new Earth(138, -150);
            player = new Player(190, 450);
            int x = ranGen.Next(10, this.Width - 30);
            int y = ranGen.Next(10, 210);

            explosion = new SoundPlayer(Properties.Resources.Explosion_Sound_Effect__FREE_DOWNLOAD___1_);
            sound = new SoundPlayer(Properties.Resources.National_Anthem_Of_The_USSR);

            if (spawnPlanets == true)
            {
                if (diff == 1 || russDiff == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        x = ranGen.Next(10, this.Width - 30);
                        y = ranGen.Next(10, 210);
                        Planet newPlanet = new Planet(x, y, 3);
                        planets.Add(newPlanet);
                    }
                }
                else if (diff == 2 || russDiff == 2)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        x = ranGen.Next(10, this.Width - 30);
                        y = ranGen.Next(10, 210);
                        Planet newPlanet = new Planet(x, y, 4);
                        planets.Add(newPlanet);
                    }
                }
                else if (diff == 3 || russDiff == 3)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        x = ranGen.Next(10, this.Width - 30);
                        y = ranGen.Next(10, 210);
                        Planet newPlanet = new Planet(x, y, 6);
                        planets.Add(newPlanet);
                    }
                }
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            if (playerControls == true)
            {
                if (upArrowDown)
                {
                    player.Move("up");
                }
                if (downArrowDown)
                {
                    player.Move("down");
                }
                if (leftArrowDown)
                {
                    player.Move("left"); ;
                }
                if (rightArrowDown)
                {
                    player.Move("right"); ;
                }
            }

            foreach (Planet p in planets)
            {
                p.Move(this.Height);
            }


            foreach (Planet p in planets)
            {
                if (p.Collision(player))
                {
                    explosion.Play();
                    gameEngine.Stop();
                    if (communism == false)
                    {
                        Form1.ChangeScreen(this, new fail());
                    }else
                    {
                        Form1.ChangeScreen(this, new failedstalin());
                    }
                }
            }
            int x = ranGen.Next(10, this.Width - 30);
            int y = ranGen.Next(10, this.Height - 50);
            foreach (Planet p in planets)
            {
                if (p.y > this.Height + p.size)
                {
                    planets.Remove(p);
                    x = ranGen.Next(10, this.Width - 30);

                    if (spawnPlanets == true)
                    {
                        Planet newPlanet = new Planet(x, 0, 7);
                        planets.Add(newPlanet);
                    }
                    break;
                }

            }

            if (player.y > this.Height)
            {
                player.y -= player.speed;
            }

            if (planets.Count == 0)
            {
                playerControls = false;
                

                if (player.x < 185)
                {
                    player.Move("right");
                    //player.x += player.speed;
                }
                else if (player.x > 185)
                {
                    player.Move("left");
                }
                if (player.y > 310)
                {
                    player.y -= player.speed;
                }

                //if (earth.y < 190)
                //{
                //    earth.Move(310);
                //}
                if (player.y == 310 && player.x == 185)
                {
                    if (earth.y < 190)
                    {
                        earth.Move(310);
                    }

                    endTimer.Start();
                }

            }

            Refresh();

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach (Planet p in planets)
            {
                e.Graphics.FillEllipse(yellowBrush, p.x, p.y, p.size, p.size);
            }
            if (playerVis == true)
            {
                e.Graphics.FillEllipse(brownBrush, player.x, player.y, player.size, player.size);
            }
            e.Graphics.FillEllipse(blueBrush, earth.x, earth.y, earthSize, earthSize);
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {

            winTime++;
            if (winTime >= 60)
            {

                spawnPlanets = false;
            }

            if (distance > 0)
            {
                distance -= 1;
                if (communism == false)
                {
                    distanceLabel.Text = $"DISTANCE TO EARTH: {distance.ToString()} KM";
                }
                else
                {
                    distanceLabel.Text = $"Расстояние до Америки: {distance.ToString()} км";
                }
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void endTimer_Tick(object sender, EventArgs e)
        {
            endTime++;
            if (endTime == 25 && communism == false)
            {
                explosion.Play();
            }else if (endTime == 25)
            {
                sound.Play();
            }
            if (endTime == 33 && communism == false)
            {
                Form1.ChangeScreen(this, new Win());
            }else if (endTime == 33)
            {
                Form1.ChangeScreen(this, new GreatVictory());
            }
        }
    }
}
