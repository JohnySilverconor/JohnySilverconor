 public class Bullet : Sprite
{
    protected static readonly int HITERATIONS = 4;
    internal double speedY;
    internal double §\x01\x01\x0b\x01§;
    internal bool §\x01\x01\x0b\x02§ = false;
    internal int counter = 0;
    internal bool AP = false;
    internal double range;
    internal int speed;
    internal double damage;
    internal double pointsMult;
    internal bool deleteMarker = false;
    internal double speedX;
    internal SAS game;

    public Bullet()
    {
        counter = 0;
        deleteMarker = false;
        AP = false;
        §\x01\x01\x0b\x02§ = false;
        base();
    }
public void Init(SAS param1, int param2, int param3, double param4, double param5, double param6 = 1)
{
    double _loc7_;
    game = param1;
    pointsMult = param6;
    damage = param2;
    range = param5;
    if (this is LichBolt)
    {
        speed = 10;
    }
    else
    {
        speed = game.bulletSpeed;
    }
    _loc7_ = (param4 + param3 - 90) * Math.PI / 180;
    speedX = Math.Cos(_loc7_) * speed;
    speedY = Math.Sin(_loc7_) * speed;
    addEventListener(Event.ENTER_FRAME, update, false, 0, true);
}
public void deleteMe()
    {
        stop();
        removeEventListener(Event.ENTER_FRAME, update);
        game.backGround.bulletHolder.removeChild(this);
        game = null;
    }
public void Update() { double loc2; double loc3; int loc4; int loc5; int loc6; double loc7; double loc8;

if (x > 3000)
{
    deleteMarker = true;
}
else if (x < 0)
{
    deleteMarker = true;
}
else if (y > 3000)
{
    deleteMarker = true;
}
else if (y < 0)
{
    deleteMarker = true;
}
else
{
    loc2 = x;
    loc3 = y;
    loc4 = x;
    loc5 = y;
    loc4 += speedX;
    loc5 += speedY;
    loc6 = 1;
    while (loc6 <= HITERATIONS)
    {
        loc7 = (loc4 - loc2) / 10;
        loc8 = (loc5 - loc3) / 10;
        loc2 += loc7;
        loc3 += loc8;
        if (game.HitObjects(game.backGround.x + loc2, game.backGround.y + loc3, this))
        {
            deleteMarker = true;
            Spark(loc2, loc3);
            break;
        }
        if (game.HitBaddies(game.backGround.x + loc2, game.backGround.y + loc3, damage, null, pointsMult, AP))
        {
            if (!AP)
            {
                deleteMarker = true;
            }
            BloodSplatter(loc2, loc3);
            break;
        }
        loc6++;
    }
    x = loc4;
    y = loc5;
    if (counter < Math.Floor(range))
    {
        counter++;
    }
    else if (counter >= Math.Floor(range))
    {
        counter = 0;
        damage *= 0.65;
    }
}
if (deleteMarker)
{
    DeleteMe();
}
}
protected void bloodSplatter(double param1, double param2) { 
MovieClip loc3 = new Splatter(); 
loc3.x = param1; 
loc3.y = param2; 
loc3.rotation = this.rotation; 
loc3.cacheAsBitmap = true; 
game.backGround.effectsHolder.addChild(loc3); }

protected void spark(double param1, double param2) { 
MovieClip loc3 = new Spark(); 
loc3.x = param1; 
loc3.y = param2; 
loc3.rotation = new Random().Next(0, 360);
 loc3.cacheAsBitmap = true;
 game.backGround.effectsHolder.addChild(loc3);
 }
}
//javascript

public class Bullet extends MovieClip
   {
      
      protected static const HITERATIONS:* = 4;
       
      
      internal var speedY:Number;
      
      internal var §\x01\x01\x0b\x01§:Number;
      
      internal var §\x01\x01\x0b\x02§:Boolean = false;
      
      internal var counter:int = 0;
      
      internal var AP:Boolean = false;
      
      internal var range:Number;
      
      internal var speed:int;
      
      internal var damage:Number;
      
      internal var pointsMult:Number;
      
      internal var deleteMarker:Boolean = false;
      
      internal var speedX:Number;
      
      internal var game:SAS;
      
      public function Bullet()
      {
         counter = 0;
         deleteMarker = false;
         AP = false;
         §\x01\x01\x0b\x02§ = false;
         super();
      }
      
      public function init(param1:SAS, param2:int, param3:int, param4:Number, param5:Number, param6:Number = 1) : *
      {
         var _loc7_:Number = NaN;
         game = param1;
         pointsMult = param6;
         damage = param2;
         range = param5;
         if(this is LichBolt)
         {
            speed = 10;
         }
         else
         {
            speed = game.bulletSpeed;
         }
         _loc7_ = (param4 + param3 - 90) * Math.PI / 180;
         speedX = Math.cos(_loc7_) * speed;
         speedY = Math.sin(_loc7_) * speed;
         addEventListener(Event.ENTER_FRAME,update,false,0,true);
      }
      
      public function deleteMe() : *
      {
         stop();
         removeEventListener(Event.ENTER_FRAME,update);
         game.backGround.bulletHolder.removeChild(this);
         game = null;
      }
      
      public function update(param1:Event) : *
      {
         var _loc2_:Number = NaN;
         var _loc3_:Number = NaN;
         var _loc4_:int = 0;
         var _loc5_:int = 0;
         var _loc6_:int = 0;
         var _loc7_:Number = NaN;
         var _loc8_:Number = NaN;
         if(x > 3000)
         {
            deleteMarker = true;
         }
         else if(x < 0)
         {
            deleteMarker = true;
         }
         else if(y > 3000)
         {
            deleteMarker = true;
         }
         else if(y < 0)
         {
            deleteMarker = true;
         }
         else
         {
            _loc2_ = x;
            _loc3_ = y;
            _loc4_ = x;
            _loc5_ = y;
            _loc4_ += speedX;
            _loc5_ += speedY;
            _loc6_ = 1;
            while(_loc6_ <= HITERATIONS)
            {
               _loc7_ = (_loc4_ - _loc2_) / 10;
               _loc8_ = (_loc5_ - _loc3_) / 10;
               _loc2_ += _loc7_;
               _loc3_ += _loc8_;
               if(game.hitObjects(game.backGround.x + _loc2_,game.backGround.y + _loc3_,this))
               {
                  deleteMarker = true;
                  spark(_loc2_,_loc3_);
                  break;
               }
               if(game.hitBaddies(game.backGround.x + _loc2_,game.backGround.y + _loc3_,damage,null,pointsMult,AP))
               {
                  if(!AP)
                  {
                     deleteMarker = true;
                  }
                  bloodSplatter(_loc2_,_loc3_);
                  break;
               }
               _loc6_++;
            }
            x = _loc4_;
            y = _loc5_;
            if(counter < Math.floor(range))
            {
               ++counter;
            }
            else if(counter >= Math.floor(range))
            {
               counter = 0;
               damage *= 0.65;
            }
         }
         if(deleteMarker)
         {
            deleteMe();
         }
      }
      
      protected function bloodSplatter(param1:*, param2:*) : *
      {
         var _loc3_:MovieClip = null;
         _loc3_ = new Splatter();
         _loc3_.x = param1;
         _loc3_.y = param2;
         _loc3_.rotation = this.rotation;
         _loc3_.cacheAsBitmap = true;
         game.backGround.effectsHolder.addChild(_loc3_);
      }
      
      protected function spark(param1:*, param2:*) : *
      {
         var _loc3_:MovieClip = null;
         _loc3_ = new Spark();
         _loc3_.x = param1;
         _loc3_.y = param2;
         _loc3_.rotation = Math.random() * 360;
         _loc3_.cacheAsBitmap = true;
         game.backGround.effectsHolder.addChild(_loc3_);
      }
   }