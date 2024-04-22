using System;
using System.Windows.Forms;

namespace EvenBetterScrolling
{
    public class EvenBetterScrolling : Form
    {
        private PictureBox backgroundImage = new PictureBox();
        private PictureBox characterImage = new PictureBox();
        private Timer timer = new Timer();
        private int vx = 0;
        private int vy = 0;
        private int rightInnerBoundary;
        private int leftInnerBoundary;
        private int topInnerBoundary;
        private int bottomInnerBoundary;

        public EvenBetterScrolling()
        {
            // Set up the form
            this.Size = new Size(550, 400);
            this.BackColor = Color.White;
            this.DoubleBuffered = true;

            // Set up the background image
            backgroundImage.Image = Image.FromFile(@"../images/background.png");
            backgroundImage.Location = new Point(-1325, -961);
            backgroundImage.Size = new Size(2750, 1922);
            this.Controls.Add(backgroundImage);

            // Set up the character image
            characterImage.Image = Image.FromFile(@"../images/character.png");
            characterImage.Location = new Point(225, 150);
            characterImage.Size = new Size(50, 50);
            this.Controls.Add(characterImage);

            // Define the inner boundaries
            rightInnerBoundary = (this.Width / 2) + (this.Width / 4);
            leftInnerBoundary = (this.Width / 2) - (this.Width / 4);
            topInnerBoundary = (this.Height / 2) - (this.Height / 4);
            bottomInnerBoundary = (this.Height / 2) + (this.Height / 4);

            // Set up the timer
            timer.Interval = 16; // 60 FPS
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            characterImage.Location = new Point(characterImage.Location.X + vx, characterImage.Location.Y + vy);

            // Check inner boundaries
            if (characterImage.Location.X < leftInnerBoundary)
            {
                characterImage.Location = new Point(leftInnerBoundary, characterImage.Location.Y);
                rightInnerBoundary = (this.Width / 2) + (this.Width / 4);
                backgroundImage.Location = new Point(backgroundImage.Location.X - vx, backgroundImage.Location.Y);
            }
            else if (characterImage.Location.X + characterImage.Width > rightInnerBoundary)
            {
                characterImage.Location = new Point(rightInnerBoundary - characterImage.Width, characterImage.Location.Y);
                leftInnerBoundary = (this.Width / 2) - (this.Width / 4);
                backgroundImage.Location = new Point(backgroundImage.Location.X - vx, backgroundImage.Location.Y);
            }
            if (characterImage.Location.Y < topInnerBoundary)
            {
                characterImage.Location = new Point(characterImage.Location.X, topInnerBoundary);
                bottomInnerBoundary = (this.Height / 2) + (this.Height / 4);
                backgroundImage.Location = new Point(backgroundImage.Location.X, backgroundImage.Location.Y - vy);
            }
            else if (characterImage.Location.Y + characterImage.Height > bottomInnerBoundary)
            {
                characterImage.Location = new Point(characterImage.Location.X, bottomInnerBoundary - characterImage.Height);
                topInnerBoundary = (this.Height / 2) - (this.Height / 4);
                backgroundImage.Location = new Point(backgroundImage.Location.X, backgroundImage.Location.Y - vy);
            }

            // Check stage boundaries
            if (backgroundImage.Location.X > 0)
            {
                backgroundImage.Location = new Point(0, backgroundImage.Location.Y);
                leftInnerBoundary = 0;
            }
            else if (backgroundImage.Location.Y > 0)
            {
                backgroundImage.Location = new Point(backgroundImage.Location.X, 0);
                topInnerBoundary = 0;
            }
            else if (backgroundImage.Location.X < this.Width - backgroundImage.Width)
            {
                backgroundImage.Location = new Point(this.Width - backgroundImage.Width, backgroundImage.Location.Y);
                rightInnerBoundary = this.Width;
            }
            else if (backgroundImage.Location.Y < this.Height - backgroundImage.Height)
            {
                backgroundImage.Location = new Point(backgroundImage.Location.X, this.Height - backgroundImage.Height);
                bottomInnerBoundary = this.Height;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    vx = -5;
                    break;
                case Keys.Right:
                    vx = 5;
                    break;
                case Keys.Up:
                    vy = -5;
                    break;
                case Keys.Down:
                    vy = 5;
                    break;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                    vx = 0;
                    break;
                case Keys.Up:
                case Keys.Down:
                    vy = 0;
                    break;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScrollingGame());
        }
    }
}