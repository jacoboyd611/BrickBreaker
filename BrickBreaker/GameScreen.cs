using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        //player movement variables
        bool rightDown = false;
        bool leftDown = false;

        int brickNum = Form1.brickNum;
        int brickSize = 26;

        //posible brick positions
        int[] positionX = new int[308];
        int[] positionY = new int[308];

        List<Brick> bricks = new List<Brick>();
        List<int> takenPositions = new List<int>();

        Random randGen = new Random();

        //brushes and pens
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.PaleVioletRed);
        SolidBrush grayBrush = new SolidBrush(Color.LightGray);
        Pen blackPen = new Pen(Color.Black);

        //global player and ball
        Player player;
        Ball ball; 
        public GameScreen()
        {
            InitializeComponent();

            //establish posible positions
            int x = 0;
            int y = 10;
            for (int i = 0; i < positionX.Length; i++)
            {
                positionX[i] = x;
                positionY[i] = y;
                x += brickSize;

                //move down rows at the end of the screen
                if (x + brickSize >= this.Width) { y += brickSize; x = 0; }
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            player = new Player(this.Width/2 - 20, this.Height - 40, 50, 15);
            ball = new Ball(this.Width / 2, this.Height - 100, 10);

            //create bricks
            for (int i = 0; i < brickNum; i++)
            {
                int x = randGen.Next(positionX.Length);
                //prevent duplicate positions
                while (takenPositions.Contains(x)) { x = randGen.Next(positionX.Length); }    
                
                Brick brick = new Brick(positionX[x], positionY[x], brickSize);
                takenPositions.Add(x);
                bricks.Add(brick);            
            }
            Refresh();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //moev screen objects and check collison
            player.Move(leftDown, rightDown, this.Width);
            ball.Move(this.Width);
            ball.Collison(player);

            for(int i = 0; i<bricks.Count; i++)
            {
                if (ball.Collison(bricks[i].rec)) { bricks.RemoveAt(i); }
            }

            //gameover 
            if (ball.y > this.Height) { GameOver(false); }
            if (bricks.Count == 0) { GameOver(true); }

            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw player
            e.Graphics.FillRectangle(redBrush, player.rec);
            e.Graphics.DrawRectangle(blackPen, player.rec);

            //draw ball
            e.Graphics.FillEllipse(whiteBrush, ball.rec);
            e.Graphics.DrawEllipse(blackPen, ball.rec);

            //draw bricks
            foreach (Brick brick in bricks)
            {
                e.Graphics.FillRectangle(grayBrush, brick.rec);
                e.Graphics.DrawRectangle(blackPen, brick.rec);
            }
        }
        private void GameOver(bool won) 
        {
            gameTimer.Enabled = false;
            outputLabel.Visible = true;
            Cursor.Show();

            if (won) { outputLabel.Text = "Congrats you won!!";  }
            else { outputLabel.Text = "Game over"; }
            Refresh();
            Thread.Sleep(1000);

            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }
    }
}
