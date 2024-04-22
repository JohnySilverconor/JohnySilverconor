using System;
using System.Net;
using System.Windows.Forms;

public class GameWorld : Form
{
    private PictureBox backgroundPictureBox = new PictureBox();
    private PictureBox characterPictureBox = new PictureBox();
    private Button upButton = new Button();
    private Button downButton = new Button();
    private Button growButton = new Button();
    private Button shrinkButton = new Button();
    private Button vanishButton = new Button();
    private Button spinButton = new Button();

    public GameWorld()
    {
        // Add the background to the form
        backgroundPictureBox.ImageLocation = "../images/background.png";
        backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        backgroundPictureBox.Size = new Size(550, 400);
        Controls.Add(backgroundPictureBox);

        // Add the character to the form
        characterPictureBox.ImageLocation = "../images/character.png";
        characterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        characterPictureBox.Size = new Size(50, 50);
        characterPictureBox.Location = new Point(225, 150);
        Controls.Add(characterPictureBox);

        // Add the upButton
        upButton.BackgroundImage = Image.FromFile("../images/up.png");
        upButton.Size = new Size(50, 50);
        upButton.Location = new Point(25, 25);
        upButton.Click += UpButton_Click;
        Controls.Add(upButton);

        // Add the downButton
        downButton.BackgroundImage = Image.FromFile("../images/down.png");
        downButton.Size = new Size(50, 50);
        downButton.Location = new Point(25, 85);
        downButton.Click += DownButton_Click;
        Controls.Add(downButton);

        // Add the growButton
        growButton.BackgroundImage = Image.FromFile("../images/grow.png");
        growButton.Size = new Size(50, 50);
        growButton.Location = new Point(25, 145);
        growButton.Click += GrowButton_Click;
        Controls.Add(growButton);

        // Add the shrinkButton
        shrinkButton.BackgroundImage = Image.FromFile("../images/shrink.png");
        shrinkButton.Size = new Size(50, 50);
        shrinkButton.Location = new Point(25, 205);
        shrinkButton.Click += ShrinkButton_Click;
        Controls.Add(shrinkButton);

        // Add the vanishButton
        vanishButton.BackgroundImage = Image.FromFile("../images/vanish.png");
        vanishButton.Size = new Size(50, 50);
        vanishButton.Location = new Point(25, 265);
        vanishButton.Click += VanishButton_Click;
        Controls.Add(vanishButton);

        // Add the spinButton
        spinButton.BackgroundImage = Image.FromFile("../images/spin.png");
        spinButton.Size = new Size(50, 50);
        spinButton.Location = new Point(25, 325);
        spinButton.Click += SpinButton_Click;
        Controls.Add(spinButton);
    }

    private void UpButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked the up button");
    }

    private void DownButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked the down button");
    }

    private void GrowButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked the grow button");
    }

    private void ShrinkButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked the shrink button");
    }

    private void VanishButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked the vanish button");
    }

    private void SpinButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked the spin button");
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new GameWorld());
    }
}