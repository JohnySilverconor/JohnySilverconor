using System;
using System.Net;
using System.Windows.Forms;

public class Buttons : Form
{
    // Create WebClient objects to download the images
    private WebClient webClient = new WebClient();
    
    // Paths to the images
    private string buttonUpURL = "../images/buttonUp.png";
    private string buttonOverURL = "../images/buttonOver.png";
    private string buttonDownURL = "../images/buttonDown.png";
    
    // Image variables
    private Image buttonUpImage;
    private Image buttonOverImage;
    private Image buttonDownImage;
    
    // Create a single PictureBox to contain the images
    private PictureBox button = new PictureBox();
    
    public Buttons()
    {
        MakeButton();
    }
    
    public void MakeButton()
    {
        // Download the images
        buttonUpImage = Image.FromStream(webClient.OpenRead(buttonUpURL));
        buttonDownImage = Image.FromStream(webClient.OpenRead(buttonDownURL));
        buttonOverImage = Image.FromStream(webClient.OpenRead(buttonOverURL));
        
        // Make the images invisible, except for the up image
        buttonUpImage.Visible = true;
        buttonDownImage.Visible = false;
        buttonOverImage.Visible = false;
        
        // Add the images to the button PictureBox
        button.Controls.Add(buttonUpImage);
        button.Controls.Add(buttonDownImage);
        button.Controls.Add(buttonOverImage);
        
        // Set the PictureBox's button properties
        button.Cursor = Cursors.Hand;
        button.Enabled = true;
        button.SizeMode = PictureBoxSizeMode.AutoSize;
        
        // Add the button PictureBox to the form
        Controls.Add(button);
        button.Location = new Point(225, 175);
        
        // Add the button event handlers
        button.MouseEnter += OverHandler;
        button.MouseDown += DownHandler;
        button.MouseLeave += ResetHandler;
        button.Click += ClickHandler;
    }
    
    private void OverHandler(object sender, EventArgs e)
    {
        buttonUpImage.Visible = false;
        buttonDownImage.Visible = false;
        buttonOverImage.Visible = true;
        Console.WriteLine("over");
    }
    
    private void DownHandler(object sender, MouseEventArgs e)
    {
        buttonUpImage.Visible = false;
        buttonDownImage.Visible = true;
        buttonOverImage.Visible = false;
        Console.WriteLine("down");
    }
    
    private void ClickHandler(object sender, EventArgs e)
    {
        buttonUpImage.Visible = true;
        buttonDownImage.Visible = false;
        buttonOverImage.Visible = false;
        Console.WriteLine("click");
    }
    
    private void ResetHandler(object sender, EventArgs e)
    {
        buttonUpImage.Visible = true;
        buttonDownImage.Visible = false;
        buttonOverImage.Visible = false;
        Console.WriteLine("reset");
    }
}


/*
package
{
	import flash.net.URLRequest;
	import flash.display.Loader;
	import flash.display.Sprite;
	import flash.events.MouseEvent;
	
	[SWF(width="550", height="400", 
    backgroundColor="#FFFFFF", frameRate="60")]
	
	public class Buttons extends Sprite
	{
		//Create URLRequest objects to get the paths to the images
		public var buttonUpURL:URLRequest = new URLRequest("../images/buttonUp.png");
		public var buttonOverURL:URLRequest = new URLRequest("../images/buttonOver.png");
		public var buttonDownURL:URLRequest = new URLRequest("../images/buttonDown.png");
		
		//Create Loaders for the images
		public var buttonUpImage:Loader = new Loader();
		public var buttonOverImage:Loader = new Loader();
		public var buttonDownImage:Loader = new Loader();
		
		//Create a single Sprite to contain the images
		public var button:Sprite = new Sprite();
		
		public function Buttons()
		{
			makeButton();
		}
		public function makeButton():void
		{
			//Load the images
			buttonUpImage.load(buttonUpURL);
			buttonDownImage.load(buttonDownURL);
			buttonOverImage.load(buttonOverURL);
			
			//Make the images invisible, except
			//for the up image
			buttonUpImage.visible = true;
			buttonDownImage.visible = false;
			buttonOverImage.visible = false;
			
			//Add the images to the button Sprite
			button.addChild(buttonUpImage);
			button.addChild(buttonDownImage);
			button.addChild(buttonOverImage);
			
			//Set the Sprite's button properties
			button.buttonMode = true;
			button.mouseEnabled = true;
			button.useHandCursor = true;
			button.mouseChildren = false;
			
			//Add the button Sprite to the stage
			stage.addChild(button);
			button.x = 225;
			button.y = 175;
			
			//Add the button event listeners
			button.addEventListener(MouseEvent.ROLL_OVER, overHandler);
			button.addEventListener(MouseEvent.MOUSE_DOWN, downHandler);
			button.addEventListener(MouseEvent.ROLL_OUT, resetHandler);
			button.addEventListener(MouseEvent.CLICK, clickHandler);
		}
		public function overHandler(event:MouseEvent):void
		{
			buttonUpImage.visible = false;
			buttonDownImage.visible = false;
			buttonOverImage.visible = true;
			trace("over");
		}
		public function downHandler(event:MouseEvent):void
		{
			buttonUpImage.visible = false;
			buttonDownImage.visible = true;
			buttonOverImage.visible = false;
			trace("down");
		}
		public function clickHandler(event:MouseEvent):void
		{
			buttonUpImage.visible = true;
			buttonDownImage.visible = false;
			buttonOverImage.visible = false;
			trace("click");
		}
		public function resetHandler(event:MouseEvent):void
		{
			buttonUpImage.visible = true;
			buttonDownImage.visible = false;
			buttonOverImage.visible = false;
			trace("reset");
		}
		
	}
}*/