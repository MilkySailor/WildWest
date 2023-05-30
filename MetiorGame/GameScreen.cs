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

        int gameTime = 0;
        int threeSecondCount = 3;
        public GameScreen()
        {
            InitializeComponent();
            IntializeGame();
        }
        public void IntializeGame()
        {
            ShuffleWords();
            List<string> activeWords = easyWords.GetRange(0, 10);
            incomingWordsBox.Text = "";
            for (int i = 0; i < activeWords.Count; i++)
            {
                incomingWordsBox.Text += $"{activeWords[i]} ";
            }
            typingBox.Focus();
        }
        public void ShuffleWords()
        {

            List<string> wordsTemp = new List<string>();
            Random randGen = new Random();

            while (easyWords.Count > 0)
            {
                int index = randGen.Next(0, easyWords.Count);
                wordsTemp.Add(easyWords[index]);
                easyWords.RemoveAt(index);
            }

            easyWords = wordsTemp;
  
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            if(gameTime == 3)
            {
                blackBar1.Visible = false;
                blackBar2.Visible = false;
                
                typingBox.Visible = true;
                streakLabel.Visible = true;
                readyLabel.Visible = true;
                timer1.Start();
            }
            if(gameTime == 6)
            {
                holdLabel.Visible = true;
                threeSecondTimerLabel.Visible = false;
                timer1.Stop();
                incomingWordsBox.Visible = true;

            }
            

           
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            

        }

        private void endTimer_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //threeSecondCount -- 1;
            threeSecondTimerLabel.Text = threeSecondCount.ToString();

        }
    }
}
