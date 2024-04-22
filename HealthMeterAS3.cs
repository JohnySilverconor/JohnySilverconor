using System;
using System.Windows.Forms;

namespace 
{
    public class HealthMeter : Form
    {
        private PictureBox characterImage = new PictureBox();
        private PictureBox monsterNormalImage = new PictureBox();
        private PictureBox meterInsideImage = new PictureBox();
        private PictureBox meterOutsideImage = new PictureBox();
        private PictureBox meter = new PictureBox();
        private int vx = 0;
        private int vy = 0;

        public HealthMeter()
        {
            CreateGameObjects();
            SetupEventListeners();
        }

        private void CreateGameObjects()
        {
            // Add the monster to the form
            monster.Controls.Add(monsterNormalImage);
            Controls.Add(monster);
            monster.Location = new Point(125, 150);

            // Add the character to the form
            character.Controls.Add(characterImage);
            Controls.Add(character);
            character.Location = new Point(300, 150);

            // Compose the health meter
            meter.Controls.Add(meterInsideImage);
            meter.Controls.Add(meterOutsideImage);
            Controls.Add(meter);
            meter.Location = new Point(125, 65);
        }

        private void SetupEventListeners()
        {
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
            // Move the player
            character.Location = new Point(character.Location.X + vx, character.Location.Y + vy);

            // Collision detection
            if (character.Bounds.IntersectsWith(monster.Bounds))
            {
                if (meterInsideImage.Width > 0)
                {
                    meterInsideImage.Width--;
                }
            }

            if (meterInsideImage.Width < 1)
            {
                MessageBox.Show("Game over");
            }
        }
    }
}