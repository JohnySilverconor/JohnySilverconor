using System;
using System.Windows.Forms;

namespace KeyboardControlAS3
{
    public class KeyboardControlAS3 : Form
    {
        private PictureBox character = new PictureBox();
        private int vx = 0;
        private int vy = 0;

        public KeyboardControlAS3()
        {
            character.Image = Image.FromFile(@"../images/character.png");
            Controls.Add(character);
            character.Location = new Point(225, 150);

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
            character.Location = new Point(character.Location.X + vx, character.Location.Y + vy);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterMovement());
        }
    }
}