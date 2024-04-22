using System;
using System.Windows.Forms;

namespace BasicScrolling
{
    public class BasicScrolling : Form
    {
        private PictureBox backgroundImage = new PictureBox();
        private PictureBox characterImage = new PictureBox();
        private int vx = 0;
        private int vy = 0;

        public BasicScrolling()
        {
            // Add the background image
            backgroundImage.Image = Properties.Resources.background;
            Controls.Add(backgroundImage);
            backgroundImage.Location = new Point(-1325, -961);

            // Add the character image
            characterImage.Image = Properties.Resources.character;
            Controls.Add(characterImage);
            characterImage.Location = new Point(225, 150);

            // Add the event listeners
            KeyDown += new KeyEventHandler(KeyDownHandler);
            KeyUp += new KeyEventHandler(KeyUpHandler);
            Timer timer = new Timer();
            timer.Interval = 16; // 60 FPS
            timer.Tick += new EventHandler(EnterFrameHandler);
            timer.Start();
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                vx = -5;
            }
            else if (e.KeyCode == Keys.Right)
            {
                vx = 5;
            }
            else if (e.KeyCode == Keys.Up)
            {
                vy = -5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                vy = 5;
            }
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                vx = 0;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                vy = 0;
            }
        }

        private void EnterFrameHandler(object sender, EventArgs e)
        {
            // Move the background
            backgroundImage.Location = new Point(backgroundImage.Location.X - vx, backgroundImage.Location.Y - vy);

            // Check the form boundaries
            if (backgroundImage.Location.X > 0)
            {
                backgroundImage.Location = new Point(0, backgroundImage.Location.Y);
            }
            else if (backgroundImage.Location.Y > 0)
            {
                backgroundImage.Location = new Point(backgroundImage.Location.X, 0);
            }
            else if (backgroundImage.Location.X < ClientSize.Width - backgroundImage.Width)
            {
                backgroundImage.Location = new Point(ClientSize.Width - backgroundImage.Width, backgroundImage.Location.Y);
            }
            else if (backgroundImage.Location.Y < ClientSize.Height - backgroundImage.Height)
            {
                backgroundImage.Location = new Point(backgroundImage.Location.X, ClientSize.Height - backgroundImage.Height);
            }
        }
    }
}