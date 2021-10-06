using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class MainScreen : UserControl
    {        
        public MainScreen()
        {
            InitializeComponent();           
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            //get input for brick number
            try
            {
                Form1.brickNum = Convert.ToInt32(inputBox.Text);
                if (Form1.brickNum > 308) { Form1.brickNum = 308; }
                else if (Form1.brickNum == 0) { Form1.brickNum = 150; }
            }
            catch { Form1.brickNum = 150; }

            //change to game screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            gs.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //end game
            Application.Exit();
        }
    }
}
