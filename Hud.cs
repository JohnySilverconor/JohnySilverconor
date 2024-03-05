public class Hud : MovieClip
{
    public TextField MR;
    public TextField txtWaves;
    public MovieClip Lg;
    public TextField txtLives;
    private Level IY;
    private Tween xtween;

    public Hud(double param1, double param2, int param3, int param4, int param5, Level param6)
    {
        super();
        this.IY = param6;
        this.x = param1;
        this.MR.text = param3.ToString();
        this.txtLives.text = param4.ToString();
        this.updateWaves(0, param5);
        this.xtween = new Tween(this, "y", Strong.easeOut, -20, param2, 0.7, true);
        this.xtween.addEventListener(TweenEvent.MOTION_FINISH, this.animationEnd, false, 0, true);
    }

    public void animationEnd(TweenEvent param1)
    {
        if (this.IY.game.pc && this.IY.game.pcHasGold)
        {
            this.IY.bullets.addChild(new GnomeExtraGold(new Point(186, 26), this.IY));
        }
    }

    public void goOut()
    {
        this.xtween = new Tween(this, "y", Strong.easeOut, this.y, -50, 0.7, true);
    }

    public void updateCash(int param1)
    {
        this.MR.text = param1.ToString();
    }

    public void updateLives(int param1)
    {
        this.txtLives.text = param1.ToString();
        this.Lg.gotoAndPlay(1);
    }

    public void updateWaves(int param1, int param2)
    {
        this.txtWaves.text = "WAVE   " + param1 + "/" + param2;
    }

    protected void destroyThis()
    {
        this.xtween.removeEventListener(TweenEvent.MOTION_FINISH, this.animationEnd);
        this.xtween = null;
        this.IY = null;
        this.parent.removeChild(this);
    }
}
//javascript
public class Hud extends MovieClip
   {
       
      
      public var §_-MR§:TextField;
      
      public var txtWaves:TextField;
      
      public var §_-Lg§:MovieClip;
      
      public var txtLives:TextField;
      
      private var §_-IY§:Level;
      
      private var xtween:Tween;
      
      public function Hud(param1:Number, param2:Number, param3:int, param4:int, param5:int, param6:Level)
      {
         super();
         this.§_-IY§ = param6;
         this.x = param1;
         this.§_-MR§.text = param3.toString();
         this.txtLives.text = param4.toString();
         this.updateWaves(0,param5);
         this.xtween = new Tween(this,"y",Strong.easeOut,-20,param2,0.7,true);
         this.xtween.addEventListener(TweenEvent.MOTION_FINISH,this.animationEnd,false,0,true);
      }
      
      public function animationEnd(param1:TweenEvent) : *
      {
         if(this.§_-IY§.game.pc && this.§_-IY§.game.pcHasGold)
         {
            this.§_-IY§.bullets.addChild(new GnomeExtraGold(new Point(186,26),this.§_-IY§));
         }
      }
      
      public function goOut() : void
      {
         this.xtween = new Tween(this,"y",Strong.easeOut,this.y,-50,0.7,true);
      }
      
      public function updateCash(param1:int) : void
      {
         this.§_-MR§.text = param1.toString();
      }
      
      public function updateLives(param1:int) : void
      {
         this.txtLives.text = param1.toString();
         this.§_-Lg§.gotoAndPlay(1);
      }
      
      public function updateWaves(param1:int, param2:int) : void
      {
         this.txtWaves.text = "WAVE   " + param1 + "/" + param2;
      }
      
      protected function destroyThis() : void
      {
         this.xtween.removeEventListener(TweenEvent.MOTION_FINISH,this.animationEnd);
         this.xtween = null;
         this.§_-IY§ = null;
         this.parent.removeChild(this);
      }
   }