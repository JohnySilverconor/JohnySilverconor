using System;
using System.Windows.Forms;

public class BetterScrolling : Form
{
    private PictureBox backgroundImage = new PictureBox();
    private PictureBox characterImage = new PictureBox();
    private int vx = 0;
    private int vy = 0;
    private int rightInnerBoundary;
    private int leftInnerBoundary;
    private int topInnerBoundary;
    private int bottomInnerBoundary;

    public BetterScrolling()
    {
        // Add the background
        backgroundImage.Image = Image.FromFile(@"../images/background.png");
        Controls.Add(backgroundImage);
        backgroundImage.Location = new Point(-1325, -961);

        // Add the character
        characterImage.Image = Image.FromFile(@"../images/character.png");
        Controls.Add(characterImage);
        characterImage.Location = new Point(225, 150);

        // Define the inner boundary variables
        rightInnerBoundary = (ClientSize.Width / 2) + (ClientSize.Width / 4);
        leftInnerBoundary = (ClientSize.Width / 2) - (ClientSize.Width / 4);
        topInnerBoundary = (ClientSize.Height / 2) - (ClientSize.Height / 4);
        bottomInnerBoundary = (ClientSize.Height / 2) + (ClientSize.Height / 4);

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
        // Move the player
        characterImage.Location = new Point(characterImage.Location.X + vx, characterImage.Location.Y + vy);

        // Stop character at the inner boundary edges
        if (characterImage.Location.X < leftInnerBoundary)
        {
            characterImage.Location = new Point(leftInnerBoundary, characterImage.Location.Y);
            backgroundImage.Location = new Point(backgroundImage.Location.X - vx, backgroundImage.Location.Y);
        }
        else if (characterImage.Location.X + characterImage.Width > rightInnerBoundary)
        {
            characterImage.Location = new Point(rightInnerBoundary - characterImage.Width, characterImage.Location.Y);
            backgroundImage.Location = new Point(backgroundImage.Location.X - vx, backgroundImage.Location.Y);
        }
        if (characterImage.Location.Y < topInnerBoundary)
        {
            characterImage.Location = new Point(characterImage.Location.X, topInnerBoundary);
            backgroundImage.Location = new Point(backgroundImage.Location.X, backgroundImage.Location.Y - vy);
        }
        else if (characterImage.Location.Y + characterImage.Height > bottomInnerBoundary)
        {
            characterImage.Location = new Point(characterImage.Location.X, bottomInnerBoundary - characterImage.Height);
            backgroundImage.Location = new Point(backgroundImage.Location.X, backgroundImage.Location.Y - vy);
        }

        // Check the stage boundaries
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

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new BetterScrolling());
    }
}