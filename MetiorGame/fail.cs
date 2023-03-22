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
    public partial class fail : UserControl
    {
        public fail()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Menu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new difficulty());
        }
    }
}
