using System;

namespace CharacterGame
{
    public class Character
    {
        private readonly Image characterImage = Image.FromFile("character.png");
        private readonly PictureBox characterPictureBox = new PictureBox();
        
        public double Vx { get; set; } = 0;
        public double Vy { get; set; } = 0;
        public double AccelerationX { get; set; } = 0;
        public double AccelerationY { get; set; } = 0;
        public double SpeedLimit { get; set; } = 5;
        public double Friction { get; set; } = 0.96;
        public double Bounce { get; set; } = -0.7;
        public double Gravity { get; set; } = 0.3;
        public double JumpForce { get; set; } = -10;
        public bool IsOnGround { get; set; } = false;
        
        public Character()
        {
            characterPictureBox.Image = characterImage;
            Controls.Add(characterPictureBox);
        }
    }
    
    public class MouseControlledPlatformGame : Form
    {
        private readonly Character character = new Character();
        private readonly List<Box> boxes = new List<Box>();
        private readonly List<int[]> boxPositions = new List<int[]>()
        {
            new int[] {0, 200}, new int[] {100, 100}, new int[] {100, 250},
            new int[] {150, 50}, new int[] {150, 250}, new int[] {200, 50},
            new int[] {300, 200}, new int[] {350, 150}, new int[] {400, 150},
            new int[] {400, 300}, new int[] {450, 150}, new int[] {450, 300},
            new int[] {500, 250}
        };
        
        public MouseControlledPlatformGame()
        {
            foreach (var position in boxPositions)
            {
                Box box = new Box();
                Controls.Add(box);
                box.Location = new Point(position[0], position[1]);
                boxes.Add(box);
            }
            
            Controls.Add(character);
            character.Location = new Point(150, 300);
            Cursor.Hide();
        }
	 public void MoveCharacter(double mouseX, double mouseY, double stageWidth, double stageHeight)
        {
            vx = (mouseX - (vx + 1 / 2)) * 0.2;

            // Apply gravity
            vy += gravity;

            // Limit the speed, except when the character is moving upwards
            if (vx > speedLimit)
            {
                vx = speedLimit;
            }
            if (vx < -speedLimit)
            {
                vx = -speedLimit;
            }
            if (vy > speedLimit * 2)
            {
                vy = speedLimit * 2;
            }

            // Force the velocity to zero after it falls below 0.1
            if (Math.Abs(vx) < 0.1)
            {
                vx = 0;
            }
            if (Math.Abs(vy) < 0.1)
            {
                vy = 0;
            }

            // Move the character
            vx += vx;
            vy += vy;

            // Check stage boundaries
            if (vx < 0)
            {
                vx = 0;
            }
            if (vy < 0)
            {
                vy = 0;
            }
            if (vx + 1 > stageWidth)
            {
                vx = 0;
            }
            if (vy + 1 > stageHeight)
            {
                vy = 0;
                isOnGround = true;
            }
       	 }
for (int i = 0; i < _boxes.Length; i++)
            {
                Collision.Block(_character, _boxes[i]);
                if (Collision.CollisionSide == "Bottom")
                {
                    _character.IsOnGround = true;
                    _character.Vy = -_character.Gravity;
                }
                else if (Collision.CollisionSide == "Top")
                {
                    _character.Vy = 0;
                }
                else if (Collision.CollisionSide == "Right" || Collision.CollisionSide == "Left")
                {
                    _character.Vx = 0;
                }
            }
    	}
private void MouseDownHandler()
        {
            if (_character.IsOnGround)
            {
                _character.Vy += _character.JumpForce;
                _character.Gravity = 0.3;
                _character.IsOnGround = false;
            }
        }
    }
}
/*
package
{
	import flash.display.Sprite;
	import flash.events.Event;
	import flash.events.MouseEvent;
	import flash.ui.Mouse;

	[SWF(width="550", height="400", 
    backgroundColor="#FFFFFF", frameRate="60")]
	public class Character extends Sprite
	{
		//Embed the image
		[Embed(source="../images/character.png")]
		private var CharacterImage:Class;
		
		//Private properties
		private var _characterImage:DisplayObject = new CharacterImage();
		private var _character:Sprite = new Sprite();
		
		//Public properties
		public var vx:Number = 0;
		public var vy:Number = 0;
		public var accelerationX:Number = 0; 
		public var accelerationY:Number = 0; 
		public var speedLimit:Number = 5; 
		public var friction:Number = 0.96;
		public var bounce:Number = -0.7;
		public var gravity:Number = 0.3; 
		public var isOnGround:Boolean = undefined; 
		public var jumpForce:Number = -10;

		public function Character()
		{
			//Display the image in this class
			_character.addChild(_characterImage);
			this.addChild(_character);
		}
	}
	public class MouseControlledPlatformGame extends Sprite
	{	
		private var _character:Character = new Character();
		private var _boxes:Array = new Array();
		private var _boxPositions:Array = new Array();
		
		public function MouseControlledPlatformGame()
		{
			//Set the box x and y positions
			_boxPositions 
			= [
				[0, 200],
				[100, 100],
				[100, 250],
				[150, 50],
				[150, 250],
				[200, 50],
				[300, 200],
				[350, 150],
				[400, 150],
				[400, 300],
				[450, 150],
				[450, 300],
				[500, 250]
			]; 
			
			//Make the boxes
			for(var i:int = 0; i < _boxPositions.length; i++)
			{
				//Create a box object
				var box:Box = new Box();
				
				//Add the box to the stage
				addChild(box);
				box.x = _boxPositions[i][0];
				box.y = _boxPositions[i][1];
				
				//Add it to the boxes array
				//for future use
				_boxes.push(box);
			}
			
			//Add the character
			addChild(_character);
			_character.x = 150;
			_character.y = 300;
			
			//Hide the mouse
			Mouse.hide();
			
			//Add the event listeners
			stage.addEventListener(Event.ENTER_FRAME, enterFrameHandler);
			stage.addEventListener(MouseEvent.MOUSE_DOWN, mouseDownHandler);
		}
		public function enterFrameHandler(event:Event):void
		{
			
			_character.vx = (stage.mouseX - (_character.x + _character.width / 2)) * 0.2;
			
			//Apply gravity
			_character.vy += _character.gravity;
			
			//Limit the speed, except when the character
			//is moving upwards
			if (_character.vx > _character.speedLimit)
			{
				_character.vx = _character.speedLimit;
			}
			if (_character.vx < -_character.speedLimit)
			{
				_character.vx = -_character.speedLimit;
			}
			if (_character.vy > _character.speedLimit * 2)
			{
				_character.vy = _character.speedLimit * 2;
			} 
			
			//Force the velocity to zero
			//after it falls below 0.1
			if (Math.abs(_character.vx) < 0.1)
			{
				_character.vx = 0;
			}
			if (Math.abs(_character.vy) < 0.1)
			{
				_character.vy = 0;
			}
			
			//Move the character 
			_character.x += _character.vx;
			_character.y += _character.vy;
			
			//Check stage boundaries
			if (_character.x < 0)
			{
				_character.vx = 0;
				_character.x = 0;
			}
			if (_character.y < 0)
			{
				_character.vy = 0;
				_character.y = 0;
			}
			if (_character.x + _character.width > stage.stageWidth)
			{
				_character.vx = 0;
				_character.x = stage.stageWidth - _character.width;
			}
			if (_character.y + _character.height > stage.stageHeight)
			{
				_character.vy = 0;
				_character.y = stage.stageHeight - _character.height;
				_character.isOnGround = true;
			}
			
			for(var i:int = 0; i < _boxes.length; i++)
			{
				Collision.block(_character, _boxes[i]);
				if(Collision.collisionSide == "Bottom")
				{
					_character.isOnGround = true;
					_character.vy = -_character.gravity;
				}
				else if(Collision.collisionSide == "Top")
				{
					_character.vy = 0;
				}
				else if(Collision.collisionSide == "Right"
					|| Collision.collisionSide == "Left")
				{
					_character.vx = 0;
				}
			}
		} 
		private function mouseDownHandler(event:MouseEvent):void
		{
			if(_character.isOnGround)
			{
				_character.vy += _character.jumpForce;
				_character.gravity = 0.3;
				_character.isOnGround = false;
			}
		}
	}
}*/


