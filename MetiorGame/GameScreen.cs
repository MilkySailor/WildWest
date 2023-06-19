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

            List<string> mediumWords = new List<string> { "kindly", "chicken", "freedom", "balance", "journey", "bravery", "justice", "honesty", "ability", "believe", "deserve", "awesome", "healthy",
            "wonder", "sunset", "safely", "victory", "perfect", "smiling", "silence", "respect", "sunrise", "happiness", "purpose", "beloved", "promise", "achieve", "fortune", "breathe",
            "freely", "mystery", "healing", "fantasy", "loyalty", "success", "forgive", "gratitude", "content", "graceful", "genuine", "patient", "explore", "adventure", "control", "courage",
            "freeway", "balance", "musical", "endless", "fashion", "support", "charity", "prepare", "feeling", "belong", "feather", "morning", "warming", "comfort", "deliver", "wishing", "journey",
            "outcome", "precise", "release", "healing", "moment", "pleased", "hearing", "respond", "inspire", "display", "embrace", "scenery", "realize", "awesome", "devoted", "freedom", "honesty",
            "fulfill", "freely", "promise", "deserve", "believe", "victory", "healthy", "wonder", "silence", "purpose", "justice", "respect", "balance", "perfect", "kindly", "journey", "fortune",
            "achieve", "breathe", "content", "patient", "control", "graceful", "loyalty", "adventure", "explore", "forgive", "courage", "success", "fantasy", "genuine", "musical", "prepare",
            "charity", "support", "endless", "feeling", "feather", "morning", "freeway", "belong", "outcome", "pleased", "hearing", "wishing", "deliver", "scenery", "moment", "inspire", "realize",
            "release", "display", "embrace", "precise", "awesome", "respond", "devoted", "healing", "freedom", "promise", "believe", "healthy", "silence", "balance", "purpose", "perfect", "victory",
            "honesty", "respect", "content", "patient", "graceful", "deserve", "freely", "journey", "charity", "wonder", "achieve", "fulfill", "control", "genuine", "success", "forgive", "loyalty"
            , "courage", "adventure", "explore", "fantasy", "prepare", "support", "musical", "endless", "feeling", "morning", "belong", "feather", "freeway", "outcome", "pleased", "hearing", "deliver",
            "wishing", "scenery", "moment", "inspire", "realize", "release", "display", "embrace", "precise", "awesome", "respond", "devoted", "healing" };

            List<string> hardWords = new List<string> { "beautiful", "wonderful", "important", "happiness", "brilliant", "adventure", "grateful", "delicious", "potential", "fantastic", "favorite", "inspiring",
            "knowledge", "memorable", "colorful", "exciting", "creative", "energetic", "friendly", "music", "awesome", "laughter", "freedom", "positive", "success", "sunshine", "blessings", "courageous",
            "adore", "progress", "vibrant", "tranquil", "proud", "content", "dreaming", "beloved", "cherish", "comfort", "genuine", "graceful", "harmony", "bloom", "eternal", "miracle", "promise", "whisper",
            "balance", "loyalty", "imagine", "journey", "cuddle", "blissful", "champion", "purpose", "victory", "precious", "radiant", "sparkle", "sunrise", "wonder", "awesome", "festival", "freedom",
            "kindness", "laughter", "meaning", "vibrant", "excited", "fantasy", "charming", "fashion", "healing", "healthy", "sincere", "loyalty", "powerful", "promise", "blessing", "smiling", "strength",
            "tranquil", "fortune", "inspire", "glowing", "serenity", "treasure", "triumph", "angelic", "paradise", "positive", "awesome", "victory", "gratitude", "elegant", "radiant", "miracle", "eternal",
            "blossom", "sunbeam", "kindness", "content", "peaceful", "gentle", "sparkle", "freedom", "wonder", "graceful", "beloved", "harmony", "journey", "fantasy", "laughter", "promise", "vibrant", "passion",
            "precious", "blissful", "healing", "loyalty", "excited", "sincere", "sunrise", "purpose", "charming", "triumph", "fortune", "fashion", "whisper", "glowing", "balance", "inspire", "powerful", "success",
            "radiant", "treasure", "serenity", "awesome", "gratitude", "elegant", "positive", "miracle", "eternal", "blossom", "content", "paradise", "gentle", "harmony", "peaceful", "kindness", "journey", "laughter",
            "promise", "sparkle", "vibrant", "freedom", "wonder", "beloved", "graceful", "sincere", "passion", "precious", "healing", "purpose", "charming", "triumph", "fortune", "fashion", "glowing", "sunrise",
            "whisper", "inspire", "balance", "powerful", "radiant", "treasure", "awesome", "serenity", "gratitude", "positive", "miracle", "eternal", "blossom", "paradise", "gentle", "content", "peaceful", "kindness",
            "journey", "laughter", "promise", "sparkle" };
        List<string> activeWords;

        bool gameOn = false;
        int gameTime = 0;
        int threeSecondCount = 3;
        bool endGame = false;
        int endGameTimer = 0;
        int gameOnTimer = 0;
        int charactorRandom = 0;
        double typingTimerTick = 0.00;
        int difficulty;
        bool playerWon;
        String enemyName = "";
        public GameScreen()
        {
            InitializeComponent();
            IntializeGame();
        }
        public void IntializeGame()
        {
            difficulty = DiffSelectScreen.diffuicultyLevel;
            Random randgen = new Random();
            charactorRandom = randgen.Next(1,3);
            if(charactorRandom == 1 && difficulty == 1)
            {
                enemyBox.Visible = false;
                gobBox.Visible = true;
                gobBox.Image = Properties.Resources.gobIdle;
                enemyName = "Goblin";
            }
            else if (charactorRandom == 2 && difficulty == 1)
            {
                enemyBox.Visible = false;
                adventBox.Visible = true;
                adventBox.Image = Properties.Resources.adventurerIdle;
                enemyName = "Adventurer";
            }
            if (charactorRandom == 1 && difficulty == 2)
            {
                enemyBox.Visible = false;
                reaperBox.Visible = true;
                reaperBox.Image = Properties.Resources.idleReaper;
                enemyName = "Reaper";
                
            }
            else if (charactorRandom == 2 && difficulty == 2)
            {
                enemyBox.Visible = true;
                enemyBox.Image= Properties.Resources.Idle__3_ ;
                enemyName = "Ninja";
            }
            if (charactorRandom == 1 && difficulty == 3)
            {
                enemyBox.Visible = false;
                kingBox.Visible = true;
                enemyName = "King";
            }
            else if (charactorRandom == 2 && difficulty == 3)
            {
                enemyBox.Visible = false;
                kingBox.Visible = true;
                enemyName = "King";
            }
            
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            gtbtgTheme = new SoundPlayer(Properties.Resources.GoodBadUglyTheme);
            gameStart = new SoundPlayer(Properties.Resources.gameStart);
            ShuffleWords();
            if (difficulty == 1)
            {
                activeWords = easyWords.GetRange(0, 10);
            }
            else if (difficulty == 2)
            {
                activeWords = mediumWords.GetRange(0, 10);
            }
            else
            {
                activeWords = hardWords.GetRange(0, 10);
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
            if (difficulty == 1)
            {
                while (easyWords.Count > 0)
                {
                    int index = randGen.Next(0, easyWords.Count);
                    wordsTemp.Add(easyWords[index]);
                    easyWords.RemoveAt(index);
                }

            easyWords = wordsTemp;
            }
            else if (difficulty == 2)
            {
                while (mediumWords.Count > 0)
                {
                    int index = randGen.Next(0, mediumWords.Count);
                    wordsTemp.Add(mediumWords[index]);
                    mediumWords.RemoveAt(index);
                }

                mediumWords = wordsTemp;
            }
            else
            {
                while (hardWords.Count > 0)
                {
                    int index = randGen.Next(0, hardWords.Count);
                    wordsTemp.Add(hardWords[index]);
                    hardWords.RemoveAt(index);
                }

                hardWords = wordsTemp;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            gameTime++;
            if(gameTime == 1)
            {
                gameStart.Play();
            }
            if (gameTime == 200)
            {
                blackBar1.Visible = false;
                blackBar2.Visible = false;
                
                typingBox.Visible = true;
                readyLabel.Visible = true;
                threeSecondTimerLabel.Visible = true;
                
            }
            if(gameTime ==250)
            {
                threeSecondTimerLabel.Text = "3";
            }
            if (gameTime == 280)
            {
                threeSecondTimerLabel.Text = "2";
            } 
            if(gameTime == 310)
            {
                threeSecondTimerLabel.Text = "1";
                typingBox.Text = "";
            }
            if (gameTime == 340)
            {
               
                typingTimer.Enabled = true;
                holdLabel.Visible = true;
                incomingWordsBox.Visible = true;
                gameOn = true;
            }
            if (gameTime == 370)
            {
                threeSecondTimerLabel.Visible = false;            
            }
            //if (gameTime == 1200)
            //{
            //    drawLabel.Visible = true;
            //    typingBox.Visible = false;
            //    endGame = true;
            //    shot.Play();
            //    //gtbtgTheme.Play();
            //}
            if (gameOn == true)
            {
                gameOnTimer++;

                if(gameOnTimer == 700 && difficulty == 1)
                {
                    endGame = true;
                }
                if (gameOnTimer == 650 && difficulty == 2)
                {
                    endGame = true;
                }
                if (gameOnTimer == 550 && difficulty == 3)
                {
                    endGame = true;
                }

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
                
            }
            if (endGame == true)
            {
                if (endGameTimer == 1)
                {
                    shot.Play();
                    offscreentypingbox.Focus();
                    typingBox.Enabled = false;
                }
                if (endGameTimer == 50)
                {
                    gtbtgTheme.Play();
                }
                endGameTimer++;
                if (endGameTimer < 260)
                {
                    blackBox.BringToFront();
                    blackBox.Visible = true;
                }else
                {
                    blackBox.Visible = false;
                }
                if(activeWords.Count > 0)
                {
                    playerDeathBox.Visible = true;
                    playerBox.Visible = false;
                    enemyWinBox.Visible = true;
                    enemyBox.Visible = false;
                    drawLabel.Visible = false;
                    readyLabel.Visible = false;
                    holdLabel.Visible = false;
                    incomingWordsBox.Visible = false;
                    typingBox.Visible = false;
                    endLabel.Text = $"YOU \n LOSE";
                    endLabel.Visible = true;
                    menuButton.Visible = true;
                    retryButton.Visible = true;
                    if (difficulty == 1)
                    {
                        if (enemyName == "Goblin")
                        {
                            enemyWinBox.Visible = false;
                            gobBox.Visible = false;
                            gobWinBox.Visible = true;
                        }
                        else
                        {
                            enemyWinBox.Visible = false;
                            adventBox.Visible = false;
                            adventWinBox.Visible = true;

                        }
                    }
                    else if (difficulty == 2)
                    {
                        if (enemyName == "Reaper")
                        {
                            enemyWinBox.Visible = false;
                            reaperWinBox.Visible = true;
                            reaperBox.Visible = false;
                        }
                        else
                        {
                            enemyWinBox.Image = Properties.Resources.Attack1__3_;
                        }
                    }
                    else
                    {
                        if (enemyName == "King")
                        {
                            enemyWinBox.Visible = false;
                            kingBox.Visible = false;
                            kingWinBox.Visible = true;
                            kingWinBox.Image = Properties.Resources.Attack1;
                        }
                    }
                         
                }
                else if (activeWords.Count == 0)
                {
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
                    if (difficulty == 1)
                    {
                        if (enemyName == "Goblin")
                        {
                            gobBox.Visible = false;
                            gobDeathBox.Visible = true;
                            enemyDeathPictureBox.Visible = false;
                        }
                        else
                        {
                            enemyDeathPictureBox.Visible = false;
                            adventBox.Visible = false;
                            adventDeathBox.Visible = true;
                            adventDeathBox.Image = Properties.Resources.adventurerDeath;
                        }
                    }
                    else if (difficulty == 2)
                    {
                        if (enemyName == "Reaper")
                        {
                            enemyDeathPictureBox.Visible = false;
                            reaperBox.Visible = true;
                            reaperBox.Image = Properties.Resources.DeathReaper;
                        }
                        else
                        {
                            enemyDeathPictureBox.Image = Properties.Resources.Death__2_;
                        }
                    }
                    else
                    {
                        if (enemyName == "King")
                        {
                            enemyDeathPictureBox.Visible = false;
                            kingBox.Visible = false;
                            kingDeathBox.Visible = true;
                        }
                    }
                }
                
                
            }
            
            Refresh();
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

        }

        private void typingBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            Form1.ChangeScreen(this, new Menu());
        }
    }
}
