using System;
using System.Drawing;
using System.Windows.Forms;

public class MyClass
{
    public int Padding { get; set; } = 6;
    public int Margin { get; set; } = 5;
    public Point Position { get; set; }
    public Point PositionAux { get; set; }
    public Sprite TFill { get; set; }
    public Sprite Pointer { get; set; }
    public int Side { get; set; } = 1;
}

using System;
using System.Drawing;


    public Sprite TFill { get; set; }
    public Sprite Pointer { get; set; }
    public Point Position { get; set; }
    public Point PositionAux { get; set; }

    public Tooltip(Point param1, Point param2, bool param3 = false, bool param4 = false)
    {
        this.TFill = new Sprite();
        this.Position = param1;
        this.PositionAux = param2;

        if (!param4)
        {
            if (!param3)
            {
                this.Pointer = new Sprite(); // Replace with appropriate type
            }
            else
            {
                this.Pointer = new Sprite(); // Replace with appropriate type
            }
        }
        else
        {
            this.Pointer = new Sprite(); // Replace with appropriate type
        }

        // Add the pointer to the display hierarchy
        // You'll need to define the appropriate method for adding a child in your actual implementation
        this.AddChild(this.Pointer);

        // Attach an event listener for when this tooltip is added to the stage
        // You'll need to define the appropriate event and handler in your actual implementation
        this.AddedToStage += this.Init;


    private void Init(object sender, EventArgs e)
    {
        // Initialization logic (if needed)
    }
}

  protected function init(param1:Event) : void
      {
      }

public void CreateFill(double param1, double param2)
    {
        Matrix loc3 = new Matrix();
        loc3.CreateGradientBox((float)param1, (float)param2, (float)(Math.PI / 2), 0, 0);
        
        this.TFill.Graphics.LineStyle(1);
        this.TFill.Graphics.LineGradientStyle(GradientType.Linear, new int[] { 13027014, 0 }, new float[] { 1, 1 }, 0, loc3);
        this.TFill.Graphics.BeginFill(2236178);
        this.TFill.Graphics.DrawRoundRect(0, 0, (float)param1, (float)param2, 5);
        this.TFill.Graphics.EndFill();
        
        this.TFill.Alpha = 0.85;
        this.Pointer.Alpha = 0.85;
    }
    
    // You'll need to define the Sprite and MovieClip classes or replace them with appropriate types.

    public Sprite TFill { get; set; }
    public Sprite Pointer { get; set; }
    public Point Position { get; set; }
    public Point PositionAux { get; set; }
    public int Margin { get; set; } = 5;
    public int Side { get; set; } = 1;

    public void PositionToolTip()
    {
        this.X = this.Position.X + this.Margin;
        this.Y = this.Position.Y - this.Margin;
        this.Pointer.X = -5;
        this.Pointer.Y = 5;
        this.Pointer.ScaleY = -1;
        this.TFill.Y = 0 - this.TFill.Height;

        if (this.X + this.Margin + this.TFill.Width > Stage.StageWidth)
        {
            this.X = this.PositionAux.X - this.Margin;
            this.Pointer.X = 5;
            this.Pointer.ScaleX = -1;
            this.Side = -1;
            this.TFill.X = 0 - this.TFill.Width;
        }

        if (this.Y - this.Margin - this.TFill.Height < Stage.Y)
        {
            this.Y = this.PositionAux.Y + this.Margin;
            this.Pointer.Y = -5;
            this.Pointer.ScaleY = 1;
            this.TFill.Y = 0;
        }
    }
// Assuming you're using Windows Forms
/*A few notes:

In C#, we use events and event handlers (like Init) instead of overriding functions like in AS3.

I’ve assumed that this refers to a control container (e.g., a Form or a Panel). Adjust accordingly based on your actual implementation.
*/
    protected void Init(object sender, EventArgs e)
    {
        // Initialization logic (if needed)
    }

    public void DestroyThis()
    {
        if (this.Pointer != null)
        {
            this.Controls.Remove(this.Pointer); // Assuming this is a control container
            this.Pointer = null;
        }

        this.RemovedFromStage -= this.Init; // Assuming this event exists
        this.Parent.Controls.Remove(this); // Assuming this is a control container
    }



//javascript

package onhide.utils.tooltip
{
   import flash.display.GradientType;
   import flash.display.MovieClip;
   import flash.display.Sprite;
   import flash.events.Event;
   import flash.geom.Matrix;
   import flash.geom.Point;
   
   public class Tooltip extends MovieClip
   {
       
      
      public var padding:int = 6;
      
      public var margin:int = 5;
      
      public var position:Point;
      
      public var positionAux:Point;
      
      public var tFill:Sprite;
      
      public var pointer:MovieClip;
      
      public var side:int = 1;
      
      public function Tooltip(param1:Point, param2:Point, param3:Boolean = false, param4:Boolean = false)
      {
         this.tFill = new Sprite();
         super();
         this.position = param1;
         this.positionAux = param2;
         if(!param4)
         {
            if(!param3)
            {
// new Movieclip
               this.pointer = new §_-0k§();
            }
            else
            {
// new Movieclip
               this.pointer = new §_-Gr§();
            }
         }
         else
         {
// new Movieclip
            this.pointer = new §_-O8§();
         }
         this.addChild(this.pointer);
         this.addEventListener(Event.ADDED_TO_STAGE,this.init,false,0,true);
      }
      
      protected function init(param1:Event) : void
      {
      }
      
      public function createFill(param1:Number, param2:Number) : *
      {
         var _loc3_:Matrix = new Matrix();
         _loc3_.createGradientBox(param1,param2,Math.PI / 2,0,0);
         this.tFill.graphics.lineStyle(1);
         this.tFill.graphics.lineGradientStyle(GradientType.LINEAR,[13027014,0],[1,1],[0,255],_loc3_);
         this.tFill.graphics.beginFill(2236178);
         this.tFill.graphics.drawRoundRect(0,0,param1,param2,5);
         this.tFill.graphics.endFill();
         this.tFill.alpha = 0.85;
         this.pointer.alpha = 0.85;
      }
      
      public function positionToolTip() : *
      {
         this.x = this.position.x + this.margin;
         this.y = this.position.y - this.margin;
         this.pointer.x = -5;
         this.pointer.y = 5;
         this.pointer.scaleY = -1;
         this.tFill.y = 0 - this.tFill.height;
         if(this.x + this.margin + this.tFill.width > stage.stageWidth)
         {
            this.x = this.positionAux.x - this.margin;
            this.pointer.x = 5;
            this.pointer.scaleX = -1;
            this.side = -1;
            this.tFill.x = 0 - this.tFill.width;
         }
         if(this.y - this.margin - this.tFill.height < stage.y)
         {
            this.y = this.positionAux.y + this.margin;
            this.pointer.y = -5;
            this.pointer.scaleY = 1;
            this.tFill.y = 0;
         }
      }
      
      public function destroyThis() : void
      {
         this.removeChild(this.pointer);
         this.pointer = null;
         this.removeEventListener(Event.ADDED_TO_STAGE,this.init);
         this.parent.removeChild(this);
      }
   }
}