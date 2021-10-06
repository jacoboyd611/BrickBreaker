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
    public partial class Form1 : Form
    {
        //background music and brick number input
        public static int brickNum;
        System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();

        public Form1()
        {
            InitializeComponent();
            backMedia.Open(new Uri(Application.StartupPath + "/Resources/rapBackground.wav"));
            backMedia.MediaEnded += new EventHandler(backMedia_MediaEnded);
        }
        private void backMedia_MediaEnded(object sender, EventArgs e)
        {
            backMedia.Stop();
            backMedia.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //load main menu
            backMedia.Play();
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
