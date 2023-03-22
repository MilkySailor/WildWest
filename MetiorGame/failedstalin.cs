using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetiorGame
{
    public partial class failedstalin : UserControl
    {
        
        public failedstalin()
        {
            InitializeComponent();
            failLabel.Text = "ты потерпел \n неудачу";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new CommieDifficulty());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new blyat());
        }
    }
}
