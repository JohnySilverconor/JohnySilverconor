using System;
using System.Windows.Forms;

namespace ParalaxScrollingAS3
{
    public class ParalaxScrollingAS3 : Form
    {
        private PictureBox distantBackgroundImage = new PictureBox();
        private PictureBox foregroundImage = new PictureBox();
        private PictureBox characterImage = new PictureBox();
        private PictureBox character = new PictureBox();

        private int vx = 0;
        private uint rightInnerBoundary;
        private uint leftInnerBoundary;

        public ParalaxScrollingAS3()
        {
            distantBackgroundImage.Image = Properties.Resources.distantBackground;
            distantBackgroundImage.Location = new Point(-1155, 0);
            Controls.Add(distantBackgroundImage);

            foregroundImage.Image = Properties.Resources.foreground;
            foregroundImage.Location = new Point(-1155, 0);
            Controls.Add(foregroundImage);

            characterImage.Image = Properties.Resources.character;
            characterImage.Location = new Point(225, 290);
            Controls.Add(characterImage);

            rightInnerBoundary = (uint)(ClientSize.Width / 2 + ClientSize.Width / 4);
            leftInnerBoundary = (uint)(ClientSize.Width / 2 - ClientSize.Width / 4);

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
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                vx = 0;
            }
        }

        private void EnterFrameHandler(object sender, EventArgs e)
        {
            character.Left += vx;

            if (character.Left < leftInnerBoundary)
            {
                character.Left = (int)leftInnerBoundary;
                rightInnerBoundary = (uint)(ClientSize.Width / 2 + ClientSize.Width / 4);
                distantBackgroundImage.Left -= vx / 2;
                foregroundImage.Left -= vx;
            }
            else if (character.Right > rightInnerBoundary)
            {
                character.Left = (int)(rightInnerBoundary - character.Width);
                leftInnerBoundary = (uint)(ClientSize.Width / 2 - ClientSize.Width / 4);
                distantBackgroundImage.Left -= vx / 2;
                foregroundImage.Left -= vx;
            }

            if (foregroundImage.Left > 0)
            {
                foregroundImage.Left = 0;
                distantBackgroundImage.Left = -distantBackgroundImage.Width / 4;
                leftInnerBoundary = 0;
            }
            else if (foregroundImage.Right < ClientSize.Width)
            {
                foregroundImage.Left = ClientSize.Width - foregroundImage.Width;
                distantBackgroundImage.Left = (-distantBackgroundImage.Width / 4) * 3 + ClientSize.Width / 2;
                rightInnerBoundary = (uint)ClientSize.Width;
            }
        }
    }
}