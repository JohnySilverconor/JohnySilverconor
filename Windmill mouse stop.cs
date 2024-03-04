using System;
using System.Windows.Forms;

namespace MyApplication
{
    public class BackgroundElementMillBig : Form
    {
        private bool onPause;

        public BackgroundElementMillBig(Point param1)
        {
            InitializeComponent();
            this.onPause = false;
            this.Click += new EventHandler(clickEvents);
        }

        private void clickEvents(object sender, EventArgs e)
        {
            this.freeMenues();
            if (this.onPause)
            {
                this.play();
                this.onPause = false;
            }
            else
            {
                this.stop();
                this.onPause = true;
            }
        }

        private void destroyThis()
        {
            this.Dispose();
        }
    }
}

// javascript 

public class BackgroundElementMillBig extends §_-0P§
   {
       
      
      private var onPause:Boolean;
      
      public function BackgroundElementMillBig(param1:Point)
      {
         super(param1);
         this.§_-0-§ = true;
         this.onPause = false;
         this.addEventListener(MouseEvent.CLICK,this.clickEvents,false,0,true);
      }
      
      override public function clickEvents(param1:MouseEvent) : void
      {
         this.§_-IY§.freeMenues();
         if(this.onPause)
         {
            this.play();
            this.onPause = false;
         }
         else
         {
            this.stop();
            this.onPause = true;
         }
      }
      
      override protected function destroyThis() : void
      {
         this.§_-IY§ = null;
         this.removeEventListener(MouseEvent.ROLL_OVER,rollOver);
         this.removeEventListener(MouseEvent.ROLL_OUT,rollOut);
         this.removeEventListener(MouseEvent.CLICK,this.clickEvents);
         this.removeEventListener(Event.ADDED_TO_STAGE,init);
         this.parent.removeChild(this);
      }
   }