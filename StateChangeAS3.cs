using System;
using System.Windows.Forms;

namespace StateChange
{
    public class StateChange : Form
    {
        private PictureBox characterImage = new PictureBox();
        private PictureBox monsterNormalImage = new PictureBox();
        private PictureBox monsterScaredImage = new PictureBox();
        private PictureBox monster = new PictureBox();
        
        private int vx = 0;
        private int vy = 0;
        
        public StateChange()
        {
            CreateGameObjects();
            SetupEventListeners();
        }
        
        public void CreateGameObjects()
        {
            monster.Controls.Add(monsterNormalImage);
            monster.Controls.Add(monsterScaredImage);
            monsterScaredImage.Visible = false;
            Controls.Add(monster);
            monster.Location = new Point(125, 150);
            
            character.Controls.Add(characterImage);
            Controls.Add(character);
            character.Location = new Point(300, 150);
        }
        
        public void SetupEventListeners()
        {
            KeyDown += new KeyEventHandler(KeyDownHandler);
            KeyUp += new KeyEventHandler(KeyUpHandler);
            Timer timer = new Timer();
            timer.Interval = 16; // 60 FPS
            timer.Tick += new EventHandler(EnterFrameHandler);
            timer.Start();
        }
        
        public void KeyDownHandler(object sender, KeyEventArgs e)
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
        
        public void KeyUpHandler(object sender, KeyEventArgs e)
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
        
        public void EnterFrameHandler(object sender, EventArgs e)
        {
            character.Location = new Point(character.Location.X + vx, character.Location.Y + vy);
            
            if (character.Bounds.IntersectsWith(monster.Bounds))
            {
                monsterScaredImage.Visible = true;
                monsterNormalImage.Visible = false;
            }
            else
            {
                monsterScaredImage.Visible = false;
                monsterNormalImage.Visible = true;
            }
        }
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StateChange());
        }
    }
}