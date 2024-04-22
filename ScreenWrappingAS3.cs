using System;
using System.Windows.Forms;

namespace ScreenWrapping
{
    public class Character
    {
        public string CharacterURL = "../images/character.png";
        public PictureBox CharacterImage = new PictureBox();
        public PictureBox Character = new PictureBox();
        
        public int Vx = 0;
        public int Vy = 0;
        
        public Character()
        {
            CharacterImage.Load(CharacterURL);
            Character.Controls.Add(CharacterImage);
            Form.ActiveForm.Controls.Add(Character);
            Character.Location = new System.Drawing.Point(225, 150);
            
            Form.ActiveForm.KeyDown += new KeyEventHandler(KeyDownHandler);
            Form.ActiveForm.KeyUp += new KeyEventHandler(KeyUpHandler);
            Form.ActiveForm.Paint += new PaintEventHandler(EnterFrameHandler);
        }
        
        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Vx = -5;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Vx = 5;
            }
            else if (e.KeyCode == Keys.Up)
            {
                Vy = -5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                Vy = 5;
            }
        }
        
        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                Vx = 0;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                Vy = 0;
            }
        }
        
        private void EnterFrameHandler(object sender, PaintEventArgs e)
        {
            Character.Location = new System.Drawing.Point(Character.Location.X + Vx, Character.Location.Y + Vy);
            
            if (Character.Location.X + Character.Width < 0)
            {
                Character.Location = new System.Drawing.Point(550, Character.Location.Y);
            }
            else if (Character.Location.Y + Character.Height < 0)
            {
                Character.Location = new System.Drawing.Point(Character.Location.X, 400);
            }
            else if (Character.Location.X > Form.ActiveForm.Width)
            {
                Character.Location = new System.Drawing.Point(0 - Character.Width, Character.Location.Y);
            }
            else if (Character.Location.Y > Form.ActiveForm.Height)
            {
                Character.Location = new System.Drawing.Point(Character.Location.X, 0 - Character.Height);
            }
        }
    }
}