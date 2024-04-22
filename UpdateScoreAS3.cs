using System;
using System.Windows.Forms;

namespace UpdateScore
{
    public partial class UpdateScore : Form
    {
        private TextFormat format = new TextFormat();
        private TextField output = new TextField();
        private TextField input = new TextField();

        private PictureBox characterImage = new PictureBox();
        private PictureBox monsterNormalImage = new PictureBox();
        private PictureBox monster = new PictureBox();
        private PictureBox character = new PictureBox();

        private int vx = 0;
        private int vy = 0;

        private uint score = 0;
        private bool collisionHasOccurred = false;

        public UpdateScore()
        {
            SetupTextfields();
            CreateGameObjects();
            SetupEventListeners();
        }

        private void SetupTextfields()
        {
            format.Font = new Font("Helvetica", 32, FontStyle.Regular);
            format.Color = Color.FromArgb(255, 0, 0);
            format.Alignment = StringAlignment.Near;

            output.DefaultTextFormat = format;
            output.Width = 60;
            output.Height = 36;
            output.BorderStyle = BorderStyle.FixedSingle;
            output.Text = "";

            Controls.Add(output);
            output.Location = new Point(125, 65);
        }

        private void CreateGameObjects()
        {
            monster.Controls.Add(monsterNormalImage);
            Controls.Add(monster);
            monster.Location = new Point(125, 150);

            character.Controls.Add(characterImage);
            Controls.Add(character);
            character.Location = new Point(300, 150);
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
            character.Location = new Point(character.Location.X + vx, character.Location.Y + vy);

            if (character.Bounds.IntersectsWith(monster.Bounds))
            {
                if (!collisionHasOccurred)
                {
                    score++;
                    output.Text = score.ToString();
                    collisionHasOccurred = true;
                }
            }
            else
            {
                collisionHasOccurred = false;
            }

            if (score == 5)
            {
                MessageBox.Show("Game over");
            }
/*
			//This version of the code prevets the game from
			//continuing if score reaches 5
			if(score < 5)
			{	
				if (character.hitTestObject(monster))
				{
					if(! collisionHasOccurred)
					{
						score++;
						output.text = String(score); 
						collisionHasOccurred = true;
					}
				}
				else 
				{
					collisionHasOccurred = false;
				}
			
				//Check for the end of the game
				if(score == 5)
				{
					trace("Game over");
				}
			}
			*/
        }
    }
}