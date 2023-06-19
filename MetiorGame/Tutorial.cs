using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MetiorGame
{
    public partial class Tutorial : UserControl
    {
        SoundPlayer shot = new SoundPlayer();
        SoundPlayer gtbtgTheme = new SoundPlayer();
        SoundPlayer gameStart = new SoundPlayer();
        List<string> properWords = new List<string>();

        List<string> easyWords = new List<string> {"help", "love", "life", "time", "like", "good", "home", "work", "baby", "mind", "need", "play", "song", "book", "cool", "jump",
            "kiss", "moon", "rain", "calm", "fire", "girl", "hope", "idea", "joke", "kind", "luck", "meet", "open", "park", "quiet", "read", "star", "talk", "walk", "year", "zone",
            "cake", "door", "edge", "face", "game", "hair", "idea", "join", "kite", "late", "moon", "nice", "oven", "pink", "quiz", "rule", "song", "time", "urge", "vast", "wake", "yoga",
            "zero", "apple", "blend", "charm", "dance", "early", "faith", "glass", "happy", "image", "juice", "kitty", "laugh", "money", "noble", "ocean", "peace", "quick", "roast", "smile",
            "taste", "unity", "value", "water", "xenon", "youth", "zebra", "alive", "brave", "cheer", "dream", "eager", "fancy", "gifts", "haste", "jolly", "knees", "loved", "magic", "never",
            "oasis", "peace", "quick", "royal", "shine", "tooth", "unity", "vivid", "witty", "xerox", "yield", "zebra", "acute", "bliss", "candy", "drift", "eager", "faith", "grace", "honor",
            "ideal", "jolly", "keen", "lucky", "merry", "noble", "order", "proud", "quest", "rapid", "serene", "trust", "unite", "value", "wispy", "xenon", "youth", "zebra", "agile", "bliss",
            "calm", "dawn", "eager", "flame", "grace", "heart", "ideal", "jolly", "keen", "lucid", "magic", "noble", "order", "peace", "quick", "roam", "serene", "thrive", "unite", "vivid",
            "witty", "xenon", "yield", "zebra", "amaze", "blaze", "chill", "dream", "early", "flair", "grace", "hasty", "ideal", "jolly", "keen", "lucid", "magic", "noble", "order", "peace",
            "quick", "roam", "serene", "thrive", "unique", "vivid", "witty", "xenon", "yield", "zebra", "acute", "bliss", "calm", "dawn", "eager", "flame", "grace", "heart", "ideal", "jolly",
            "keen", "lucid", "magic", "noble", "order", "peace", "quick", "roam", "serene", "thrive", "unique", "vivid", "witty", "xenon", "yield", "zebra"};
        List<string> activeWords;

        bool gameOn = false;
        int gameTime = 0;
        int threeSecondCount = 3;
        bool endGame = false;
        int endGameTimer = 0;
        double typingTimerTick = 0.00;
        public Tutorial()
        {
            InitializeComponent();
            IntializeGame();
        }
        public void IntializeGame()
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            gtbtgTheme = new SoundPlayer(Properties.Resources.GoodBadUglyTheme);
            gameStart = new SoundPlayer(Properties.Resources.gameStart);
            ShuffleWords();
            if (DiffSelectScreen.diffuicultyLevel == 1)
            {
                activeWords = easyWords.GetRange(0, 10);
            }
           
            incomingWordsBox.Text = "";
            for (int i = 0; i < activeWords.Count; i++)
            {
                incomingWordsBox.Text += $"{activeWords[i]} ";
            }


        }
        public void ShuffleWords()
        {
            List<string> wordsTemp = new List<string>();
            Random randGen = new Random();
            if (DiffSelectScreen.diffuicultyLevel == 1)
            {
                while (easyWords.Count > 0)
                {
                    int index = randGen.Next(0, easyWords.Count);
                    wordsTemp.Add(easyWords[index]);
                    easyWords.RemoveAt(index);
                }

                easyWords = wordsTemp;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

        }
        private void typingTimer_Tick(object sender, EventArgs e)
        {
            typingTimerTick++;
        }

        private void endTimer_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //threeSecondCount -- 1;
            threeSecondTimerLabel.Text = threeSecondCount.ToString();

        }

        private void gameEngine_Tick_1(object sender, EventArgs e)
        {

            gameTime++;
            if (gameTime == 1)
            {
                gameStart.Play();
            }

            if (gameOn == true)
            {
                typingBox.Focus();
                for (int i = 0; i < activeWords.Count; i++)
                {
                    if (typingBox.Text == activeWords[i])
                    {
                        activeWords.RemoveAt(i);
                        typingBox.Text = "";
                        incomingWordsBox.Text = "";
                        for (int u = 0; u < activeWords.Count; u++)
                        {
                            incomingWordsBox.Text += $"{activeWords[u]} ";
                        }
                    }

                }
                if(activeWords.Count == 0)
                {
                    endGame = true;
                }
            }
            if (endGame == true)
            {
                if (endGameTimer == 0)
                {
                 label8.BringToFront();
                 label8.Visible = true;
                }
                
                label7.Visible = false;
                tutSkipButton2.Visible = false;
                tutorialLabel.Visible = false;
                if (endGameTimer == 1)
                {
                    shot.Play();
                }
                if (endGameTimer == 50)
                {
                    gtbtgTheme.Play();
                }
                if (endGameTimer == 150)
                {
                    label8.Visible = false;
                    menuButton.Visible = true;
                    retryButton.Visible = true;
                }
                endGameTimer++;

                playerBox.Visible = false;
                    playerWinBox.Visible = true;
                    enemyDeathPictureBox.Visible = true;
                    enemyBox.Visible = false;
                    drawLabel.Visible = false;
                    readyLabel.Visible = false;
                    holdLabel.Visible = false;
                    incomingWordsBox.Visible = false;
                    typingBox.Visible = false;
                    endLabel.Text = $"YOU \n WIN";
                    endLabel.Visible = true;
                    menuButton.Visible = true;
                    retryButton.Visible = true;
            }

            Refresh();
        }

        private void retryButton_Click_1(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            Form1.ChangeScreen(this, new Tutorial());
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            Form1.ChangeScreen(this, new Menu());
        }

        private void tutSkipButton1_Click(object sender, EventArgs e)
        {
            typingBox.Visible = true;
            label3.Visible = true;
            streakLabel.Visible = true;
            readyLabel.Visible = true;
            threeSecondTimerLabel.Visible = true;
            label6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            tutSkipButton1.Enabled = false;
            tutSkipButton1.Visible = false;
            tutSkipButton2.Enabled = true;
            tutSkipButton2.Visible = true;
        }

        private void tutSkipButton2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label1.Visible=false;
            label3.Visible=false;
            label6.Visible=false;
            tutorialLabel.Visible = true;
            typingTimer.Enabled = true;
            incomingWordsBox.Visible = true;
            gameOn = true;
            label7.Visible = true;
            threeSecondTimerLabel.Visible = false;
        }
    }
}

