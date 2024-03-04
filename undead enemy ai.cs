public class enemy{

private const int BANSHEE_DAMAGE = 17;
private const int DECISION_INT = 4;
private const int LICHBOLT_RANGE = 100;
private const int LICHBOLT_DAMAGE = 4;
private const int BADDIE_OFFSET = 10;
private const bool GO_FOR_TURRETS = false;

internal List<int> prevdestArray;
internal int points;
internal int currentHealth = 1;
internal int yOff = 0;
internal int level;
internal int type;
internal int xOff = 0;
internal int totalHealth = 1;
internal bool inside = false;
internal bool dying = false;
internal bool attackingTurret = false;
internal bool beingHit = false;
internal bool attacking = false;
internal bool decisionFrame = true;
internal bool canSeeSpook = false;
internal uint attackDistance;
internal uint damage;
internal uint frameCounter = 0;
internal double speed;
internal double pointsMult = 1;
internal Point spookSighting;
internal MovieClip dest;
internal MovieClip dest2;
internal game:SAS;
internal Barricade attackingBarricade;
public enemy()
    {
        totalHealth = 1;
        currentHealth = 1;
        pointsMult = 1;
        frameCounter = 0;
        decisionFrame = true;
        xOff = 0;
        yOff = 0;
        attacking = false;
        beingHit = false;
        dying = false;
        inside = false;
        attackingTurret = false;
        canSeeSpook = false;
        prevdestArray = new List<int>();
    }
private MovieClip GetNearestWP() { 
double x = this.x; 
double y = this.y; 
double nearestDistance = double.MaxValue; 
MovieClip nearestWP = null;

for (int i = 0; i < game.WPArray.Length; i++)
{
    double deltaX = game.WPArray[i].x - x;
    double deltaY = game.WPArray[i].y - y;
    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

    if (i == 0)
    {
        nearestDistance = distance;
        nearestWP = game.WPArray[i];
    }

    if (prevdestArray[0] == game.WPArray[i] || prevdestArray[1] == game.WPArray[i])
    {
        if (i == 0)
        {
            nearestWP = game.WPArray[1];
            deltaX = game.WPArray[1].x - x;
            deltaY = game.WPArray[1].y - y;
            distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            nearestDistance = distance;
        }
        else if (false && game.WPArray[i].name == "ohGosh" && prevdestArray[prevdestArray.Length - 2].name == "howdy")
        {
            nearestWP = prevdestArray[prevdestArray.Length - 2];
            break;
        }
    }
    else if (!(inside && game.WPArray[i].isWindow))
    {
        if (distance < nearestDistance)
        {
            nearestDistance = distance;
            nearestWP = game.WPArray[i];
        }
    }
}

return nearestWP;
}
private function zombieAttack() : *
      {
         if(!dying && !game.spookIsDead)
         {
            if(Boolean(this.zombiedetect_mc.hitTestObject(game.spook.spookbody)) || this is Lich && !(this is Banshee))
            {
               if(!attacking)
               {
                  attacking = true;
                  gotoAndPlay("attack");
               }
            }
            else if(this is Banshee)
            {
               damageSpook(BANSHEE_DAMAGE);
               killMe();
            }
         }
      }
 public object init(object param1, object param2, object param3) { 
double loc1 = double.NaN; 
double loc2 = param1; 
double loc3 = param2; 
double loc4 = param3; 
Sprite loc5 = null; 

loc1 = new Random().NextDouble() + 1.5;
        switch (type)
        {
            case 1:
                totalHealth = 270;
                points = 10;
                speed = random;
                attackDistance = 45;
                damage = 2;
                break;
            case 2:
                totalHealth = 240;
                points = 15;
                speed = random + 1.5;
                attackDistance = 45;
                damage = 2;
                break;
            case 3:
                totalHealth = 2000;
                points = 50;
                speed = random - 0.5;
                attackDistance = 50;
                damage = 8;
                break;
            case 4:
                totalHealth = 100;
                points = 50;
                speed = random;
                attackDistance = 50;
                damage = 1;
                break;
            case 5:
                totalHealth = 2500;
                points = 100;
                speed = random + 2;
                attackDistance = 300;
                damage = 4;
                break;
            case 6:
                totalHealth = 190;
                points = 0;
                speed = random * 1.5;
                attackDistance = 45;
                damage = 1;
                break;
            default:
                Console.WriteLine("monster type fucknuckle");
                break;
        }

        totalHealth *= game.difficulty;
        currentHealth = totalHealth;

        if (game.mode == "nightmare")
        {
            speed *= 1.2;
        }

        xOff = new Random().NextDouble() * BADDIE_OFFSET;
        yOff = new Random().NextDouble() * BADDIE_OFFSET;
    }

 public void ZombieMove()
    {
        double deltaX;
        double deltaY;
        double distance;
        double directionX;
        double directionY;
        
        if (spookSighting)
        {
            deltaX = spookSighting.x - x + xOff;
            deltaY = spookSighting.y - y + yOff;
        }
        else
        {
            deltaX = destX - x + xOff;
            deltaY = destY - y + yOff;
        }
        
        distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        
        if (distance == 0)
        {
            distance = 0.001;
        }
        
        directionX = deltaX / distance;
        directionY = deltaY / distance;
        
        x += directionX * speed;
        y += directionY * speed;
        
        if (decisionFrame)
        {
            if (spookSighting)
            {
                rotation = Math.Atan2(deltaY - yOff, deltaX - xOff) * 180 / Math.PI + 90;
            }
            else
            {
                rotation = Math.Atan2(deltaY, deltaX) * 180 / Math.PI + 90;
            }
        }
    }
private void DetectSpook()
    {
        int _loc1 = 0;
        Rectangle _loc2;
        Point _loc3;
        Point _loc4;
        bool canSeeSpook = true;

        _loc1 = 0;
        while (_loc1 < game.obsArray.Length)
        {
            _loc2 = game.obsArray[_loc1].GetRect(game.backGround);
            _loc3 = new Point(x, y);
            _loc4 = new Point(game.spook.x, game.spook.y);

            if (game.LineIntersectsRect(_loc3, _loc4, _loc2))
            {
                canSeeSpook = false;
                break;
            }

            _loc1++;
        }

        if (canSeeSpook)
        {
            if (spookSighting == null)
            {
                spookSighting = new Point();
            }

            spookSighting.x = game.spook.x;
            spookSighting.y = game.spook.y;
            attackingTurret = false;
        }
    }

private MovieClip GetNearestSentry() { 
double nearestDistance = double.MaxValue; 
MovieClip nearestSentry = null;

for (int i = 0; i < game.backGround.turretHolder.numChildren; i++)
{
    MovieClip sentry = game.backGround.turretHolder.getChildAt(i);
    double distanceX = sentry.x - x;
    double distanceY = sentry.y - y;
    double distance = distanceX * distanceX + distanceY * distanceY;

    if (i == 0)
    {
        nearestDistance = distance;
        nearestSentry = sentry;
    }

    if (distance < nearestDistance)
    {
        nearestDistance = distance;
        nearestSentry = sentry;
    }
}

return nearestSentry;
 }
private void LichStrike()
{
    LichBolt loc1 = new LichBolt();
    double loc2, loc3, loc4, loc5, loc6, loc7, loc8;
    loc2 = game.spook.x - x;
    loc3 = game.spook.y - y;
    rotation = Math.Atan2(loc3, loc2) * 180 / Math.PI + 90;
    loc4 = Convert.ToDouble(this.bulletPoint.x);
    loc5 = Convert.ToDouble(this.bulletPoint.y);
    loc6 = rotation * Math.PI / 180;
    loc7 = loc4 * Math.Cos(loc6) - loc5 * Math.Sin(loc6);
    loc8 = loc5 * Math.Cos(loc6) + loc4 * Math.Sin(loc6);
    loc1.init(game, LICHBOLT_DAMAGE, 0, this.rotation, LICHBOLT_RANGE);
    loc1.x = this.x + loc7;
    loc1.y = this.y + loc8;
    loc1.rotation = this.rotation;
    game.backGround.badBulletHolder.addChild(loc1);
}
private void SmashBarricade()
{
    int i = 0;
    Sound loc2 = null;
    SoundChannel loc3 = null;
    if (attackingBarricade)
    {
        if (!attacking)
        {
            attacking = true;
            gotoAndPlay("attack");
        }
    }
    else if (!inside)
    {
        i = 0;
        while (i < game.barrArray.Length)
        {
            if (!game.barrArray[i].barricadeDead || this is Banshee)
            {
                if (this.zombiedetect_mc.hitTestObject(game.barrArray[i].barricade_hitBit))
                {
                    if (this is Banshee)
                    {
                        game.removeBarricade(game.barrArray[i]);
                        dying = true;
                        loc2 = new BarrSmashedSnd();
                        loc3 = loc2.play(0, 1);
                        gotoAndPlay("death");
                        game.removeDot(this);
                    }
                    else
                    {
                        attacking = true;
                        attackingBarricade = game.barrArray[i];
                        gotoAndPlay("attack");
                    }
                    break;
                }
            }
            i++;
        }
    }
}
private bool DetectSentry()
{
    bool isSentryDetected = false;
    int index = 0;
    Rectangle rect;
    Point point1;
    Point point2;
    
    if (dest2 != null)
    {
        isSentryDetected = true;
        index = 0;
        
        while (index < game.obsArray.Length)
        {
            rect = game.obsArray[index].GetRect(game.backGround);
            point1 = new Point(x, y);
            point2 = new Point(dest2.x, dest2.y);
            
            if (game.LineIntersectsRect(point1, point2, rect))
            {
                isSentryDetected = false;
                break;
            }
            
            isSentryDetected = true;
            index++;
        }
        
        if (!attacking && isSentryDetected)
        {
            attackingTurret = false;
        }
        
        return isSentryDetected;
    }
    
    return false;
}
private void VisitedWP()
{
    double loc1 = 0;
    double loc2 = 0;
    double loc3 = 0;
    int loc4 = 0;
    
    if (spookSighting)
    {
        loc1 = spookSighting.x - x + xOff;
        loc2 = spookSighting.y - y + yOff;
        loc3 = Math.Sqrt(loc1 * loc1 + loc2 * loc2);
        
        if (loc3 <= speed)
        {
            spookSighting = null;
        }
    }
    
    loc4 = 0;
    
    while (loc4 < game.WPArray.Length)
    {
        loc1 = game.WPArray[loc4].x - x + xOff;
        loc2 = game.WPArray[loc4].y - y + yOff;
        loc3 = Math.Sqrt(loc1 * loc1 + loc2 * loc2);
        
        if (loc3 <= speed * DECISION_INT * 2)
        {
            if (game.WPArray[loc4] == prevdestArray[prevdestArray.Length - 1])
            {
                break;
            }
            
            decisionFrame = true;
            
            if (game.WPArray[loc4].isWindow)
            {
                inside = true;
            }
            
            if (prevdestArray.Length < 2)
            {
                prevdestArray.Add(game.WPArray[loc4]);
            }
            else
            {
                prevdestArray.RemoveAt(0);
                prevdestArray.Add(game.WPArray[loc4]);
            }
            
            break;
        }
        
        loc4++;
    }
}

private void RaiseSkellies()
{
    uint loc1 = 0;
    uint loc2 = 0;
    uint loc3 = 0;
    Sound loc4 = null;
    SoundChannel loc5 = null;
    uint loc6 = 0;
    loc1 = 22;
    loc2 = (uint)Math.Floor(new Random().NextDouble() * 4) + 2;
    loc3 = (loc2 - 1) * loc1 / 2;
    loc5 = (loc4 = new SkelSnd()).play(0, 1);
    loc6 = 0;
    while (loc6 < loc2)
    {
        game.spawnBaddie(6, x - loc3 + loc6 * loc1, y - loc3 + loc6 * loc1);
        loc6++;
    }
}
public void DoHit()
{
    Sound loc1 = null;
    SoundChannel loc2 = null;
    Sound loc3 = null;
    SoundChannel loc4 = null;
    if (attackingBarricade != null)
    {
        if (!attackingBarricade.fuxxored)
        {
            attackingBarricade.barricade_inner.gotoAndPlay("hit");
            attackingBarricade.currentHealth -= damage;
            if (Barricade.level == 5)
            {
                currentHealth -= Barricade.BARBIE_DAM;
                pointsMult = Barricade.POINTS_MULT;
            }
            if (attackingBarricade.currentHealth <= 0)
            {
                attacking = false;
                attackingBarricade.barricadeDead = true;
                loc3 = new BarrSmashedSnd();
                loc4 = loc3.play(0, 1);
                attackingBarricade.gotoAndStop("busted");
                attackingBarricade = null;
            }
        }
        else
        {
            attackingBarricade = null;
        }
    }
    else if (this is Lich)
    {
        if (new Random().NextDouble() < 0.2)
        {
            RaiseSkellies();
        }
        else
        {
            LichStrike();
        }
    }
    else if (!game.spookIsDead && !game.menuOut)
    {
        DamageSpook(damage);
    }
}

public void DeleteMe()
{
    game.Stop();
    game.RemoveZombie(this);
    game = null;
}
public void KillMe()
{
    dying = true;
    game.EarnPoints(this);
    gotoAndPlay("death");
}
public void Update()
{
    Sound loc1 = null;
    SoundChannel loc2 = null;
    double loc3 = double.NaN;
    double loc4 = double.NaN;
    double loc5 = double.NaN;
    if (!dying)
    {
        if (currentHealth <= 0)
        {
            dying = true;
            loc1 = new ZombieDieSnd();
            loc2 = loc1.play(0, 1);
            game.earnPoints(this);
            gotoAndPlay("death");
        }
        else
        {
            if (decisionFrame)
            {
                detectSpook();
            }
            if (canSeeSpook)
            {
                loc3 = game.spook.x - x + xOff;
                loc4 = game.spook.y - y + yOff;
                if ((loc5 = Math.Sqrt(loc3 * loc3 + loc4 * loc4)) > attackDistance)
                {
                    dest = game.spook;
                    if (!beingHit || this is Fester)
                    {
                        zombieMove();
                    }
                }
                else
                {
                    zombieAttack();
                }
            }
            else if (GO_FOR_TURRETS && game.backGround.turretHolder.numChildren > 0)
            {
                dest2 = getNearestSentry();
                if (detectSentry())
                {
                    smashSentry();
                    if (!attackingTurret)
                    {
                        dest = dest2;
                        if (!beingHit || this is Fester)
                        {
                            zombieMove();
                        }
                    }
                }
            }
            else
            {
                dest2 = null;
                smashBarricade();
                if (!attackingBarricade)
                {
                    if (decisionFrame)
                    {
                        visitedWP();
                    }
                    if (decisionFrame && !spookSighting)
                    {
                        dest = getNearestWP();
                    }
                    if (!beingHit || this is Fester)
                    {
                        zombieMove();
                    }
                }
            }
            checkDecisionFrame();
        }
    }
}
private void SmashSentry()
{
    int index = 0;
    MovieClip turret = null;
    
    if (game.backGround.turretHolder.numChildren > 0)
    {
        while (index < game.backGround.turretHolder.numChildren)
        {
            turret = game.backGround.turretHolder.getChildAt(index);
            
            if (this.zombiedetect_mc.hitTestObject(turret))
            {
                if (!attacking)
                {
                    attacking = true;
                    attackingTurret = true;
                    gotoAndPlay("attack");
                    turret.currentHealth -= damage;
                    
                    if (turret.currentHealth <= 0)
                    {
                        attacking = false;
                        attackingTurret = false;
                        game.backGround.turretHolder.removeChild(turret);
                        turret = null;
                    }
                }
                break;
            }
            
            index++;
        }
    }
}
private void CheckDecisionFrame()
{
    frameCounter++;
    decisionFrame = (frameCounter & DECISION_INT - 1) == 0;
}
private void DamageSpook(float param1) { 
 float loc2;
 HitSnd hitSnd = new HitSnd();
 SoundChannel hitSndChannel = hitSnd.Play(0, 1);
 game.painscreen.gotoAndPlay(2);
 game.spook.currentHealth -= param1;
 loc2 = game.spook.currentHealth / game.spook.totalHealth;
 game.health_mc.healthBar.scaleX = loc2; game.CheckDeath(); 
 }
}o
// javascript;
public class laddie extends MovieClip
   {
      
      private static const BANSHEE_DAMAGE:* = 17;
      
      private static const DECISION_INT:* = 4;
      
      private static const LICHBOLT_RANGE:* = 100;
      
      private static const GO_FOR_TURRETS:* = false;
      
      private static const LICHBOLT_DAMAGE:* = 4;
      
      private static const BADDIE_OFFSET:* = 10;
       
      
      internal var prevdestArray:Array;
      
      internal var points:int;
      
      internal var inside:Boolean = false;
      
      internal var dying:Boolean = false;
      
      internal var attackingTurret:Boolean = false;
      
      internal var currentHealth:int = 1;
      
      internal var yOff:int = 0;
      
      internal var beingHit:Boolean = false;
      
      internal var attackDistance:uint;
      
      internal var speed:Number;
      
      internal var canSeeSpook:Boolean = false;
      
      internal var spookSighting:Point;
      
      internal var damage:uint;
      
      internal var level:int;
      
      internal var attackingBarricade:Barricade;
      
      internal var attacking:Boolean = false;
      
      internal var type:int;
      
      internal var dest:MovieClip;
      
      internal var pointsMult:Number = 1;
      
      internal var totalHealth:int = 1;
      
      internal var dest2:MovieClip;
      
      internal var frameCounter:uint = 0;
      
      internal var xOff:int = 0;
      
      internal var decisionFrame:Boolean = true;
      
      internal var game:SAS;
      
      public function laddie()
      {
         totalHealth = 1;
         currentHealth = 1;
         pointsMult = 1;
         frameCounter = 0;
         decisionFrame = true;
         xOff = 0;
         yOff = 0;
         attacking = false;
         beingHit = false;
         dying = false;
         inside = false;
         attackingTurret = false;
         canSeeSpook = false;
         super();
         prevdestArray = new Array();
      }
      
      private function getNearestWP() : MovieClip
      {
         var _loc1_:Number = NaN;
         var _loc2_:Number = NaN;
         var _loc3_:Number = NaN;
         var _loc4_:Number = NaN;
         var _loc5_:MovieClip = null;
         var _loc6_:int = 0;
         _loc6_ = 0;
         while(_loc6_ < game.WPArray.length)
         {
            _loc1_ = game.WPArray[_loc6_].x - x;
            _loc2_ = game.WPArray[_loc6_].y - y;
            _loc3_ = Math.sqrt(_loc1_ * _loc1_ + _loc2_ * _loc2_);
            if(_loc6_ == 0)
            {
               _loc4_ = _loc3_;
               _loc5_ = game.WPArray[_loc6_];
            }
            if(prevdestArray[0] == game.WPArray[_loc6_] || prevdestArray[1] == game.WPArray[_loc6_])
            {
               if(_loc6_ == 0)
               {
                  _loc5_ = game.WPArray[1];
                  _loc1_ = game.WPArray[1].x - x;
                  _loc2_ = game.WPArray[1].y - y;
                  _loc3_ = Math.sqrt(_loc1_ * _loc1_ + _loc2_ * _loc2_);
                  _loc4_ = _loc3_;
               }
               else if(false && game.WPArray[_loc6_].name == "ohGosh" && prevdestArray[prevdestArray.length - 2].name == "howdy")
               {
                  _loc5_ = prevdestArray[prevdestArray.length - 2];
                  break;
               }
            }
            else if(!(Boolean(inside) && Boolean(game.WPArray[_loc6_].isWindow)))
            {
               if(_loc3_ < _loc4_)
               {
                  _loc4_ = _loc3_;
                  _loc5_ = game.WPArray[_loc6_];
               }
            }
            _loc6_++;
         }
         return _loc5_;
      }
      
      private function zombieAttack() : *
      {
         if(!dying && !game.spookIsDead)
         {
            if(Boolean(this.zombiedetect_mc.hitTestObject(game.spook.spookbody)) || this is Lich && !(this is Banshee))
            {
               if(!attacking)
               {
                  attacking = true;
                  gotoAndPlay("attack");
               }
            }
            else if(this is Banshee)
            {
               damageSpook(BANSHEE_DAMAGE);
               killMe();
            }
         }
      }
      
      public function init(param1:*, param2:*, param3:*) : *
      {
         var _loc4_:Number = NaN;
         game = param1;
         type = param2;
         level = param3;
         _loc4_ = Math.random() + 1.5;
         switch(type)
         {
            case 1:
               totalHealth = 270;
               points = 10;
               speed = _loc4_;
               attackDistance = 45;
               damage = 2;
               break;
            case 2:
               totalHealth = 240;
               points = 15;
               speed = _loc4_ + 1.5;
               attackDistance = 45;
               damage = 2;
               break;
            case 3:
               totalHealth = 2000;
               points = 50;
               speed = _loc4_ - 0.5;
               attackDistance = 50;
               damage = 8;
               break;
            case 4:
               totalHealth = 100;
               points = 50;
               speed = _loc4_;
               attackDistance = 50;
               damage = 1;
               break;
            case 5:
               totalHealth = 2500;
               points = 100;
               speed = _loc4_ + 2;
               attackDistance = 300;
               damage = 4;
               break;
            case 6:
               totalHealth = 190;
               points = 0;
               speed = _loc4_ * 1.5;
               attackDistance = 45;
               damage = 1;
               break;
            default:
               trace("monster type fucknuckle");
         }
         totalHealth *= game.difficulty;
         currentHealth = totalHealth;
         if(game.mode == "nightmare")
         {
            speed *= 1.2;
         }
         xOff = Math.random() * BADDIE_OFFSET;
         yOff = Math.random() * BADDIE_OFFSET;
      }
      
      private function zombieMove() : *
      {
         var _loc1_:int = 0;
         var _loc2_:int = 0;
         var _loc3_:Number = NaN;
         var _loc4_:Number = NaN;
         var _loc5_:Number = NaN;
         if(spookSighting)
         {
            _loc1_ = spookSighting.x - x + xOff;
            _loc2_ = spookSighting.y - y + yOff;
         }
         else
         {
            _loc1_ = dest.x - x + xOff;
            _loc2_ = dest.y - y + yOff;
         }
         _loc3_ = Math.sqrt(_loc1_ * _loc1_ + _loc2_ * _loc2_);
         if(_loc3_ == 0)
         {
            trace("poo");
            _loc3_ = 0.001;
         }
         _loc4_ = _loc1_ / _loc3_;
         _loc5_ = _loc2_ / _loc3_;
         x += _loc4_ * speed;
         y += _loc5_ * speed;
         if(decisionFrame)
         {
            if(spookSighting)
            {
               rotation = Math.atan2(_loc2_ - yOff,_loc1_ - xOff) * 180 / Math.PI + 90;
            }
            else
            {
               rotation = Math.atan2(_loc2_,_loc1_) * 180 / Math.PI + 90;
            }
         }
      }
      
      private function detectSpook() : *
      {
         var _loc1_:int = 0;
         var _loc2_:Rectangle = null;
         var _loc3_:Point = null;
         var _loc4_:Point = null;
         canSeeSpook = true;
         _loc1_ = 0;
         while(_loc1_ < game.obsArray.length)
         {
            _loc2_ = game.obsArray[_loc1_].getRect(game.backGround);
            _loc3_ = new Point(x,y);
            _loc4_ = new Point(game.spook.x,game.spook.y);
            if(game.LineIntersectsRect(_loc3_,_loc4_,_loc2_))
            {
               canSeeSpook = false;
               break;
            }
            _loc1_++;
         }
         if(canSeeSpook)
         {
            if(spookSighting == null)
            {
               spookSighting = new Point();
            }
            spookSighting.x = game.spook.x;
            spookSighting.y = game.spook.y;
            attackingTurret = false;
         }
      }
      
      private function getNearestSentry() : MovieClip
      {
         var _loc1_:Number = NaN;
         var _loc2_:MovieClip = null;
         var _loc3_:MovieClip = null;
         var _loc4_:int = 0;
         var _loc5_:Number = NaN;
         var _loc6_:Number = NaN;
         var _loc7_:Number = NaN;
         _loc4_ = 0;
         while(_loc4_ < game.backGround.turretHolder.numChildren)
         {
            _loc3_ = game.backGround.turretHolder.getChildAt(_loc4_);
            _loc5_ = _loc3_.x - x;
            _loc6_ = _loc3_.y - y;
            _loc7_ = _loc5_ * _loc5_ + _loc6_ * _loc6_;
            if(_loc4_ == 0)
            {
               _loc1_ = _loc7_;
               _loc2_ = _loc3_;
            }
            if(_loc7_ < _loc1_)
            {
               _loc1_ = _loc7_;
               _loc2_ = _loc3_;
            }
            _loc4_++;
         }
         return _loc2_;
      }
      
      private function lichStrike() : *
      {
         var _loc1_:LichBolt = null;
         var _loc2_:Number = NaN;
         var _loc3_:Number = NaN;
         var _loc4_:Number = NaN;
         var _loc5_:Number = NaN;
         var _loc6_:Number = NaN;
         var _loc7_:* = undefined;
         var _loc8_:* = undefined;
         _loc1_ = new LichBolt();
         _loc2_ = game.spook.x - x;
         _loc3_ = game.spook.y - y;
         rotation = Math.atan2(_loc3_,_loc2_) * 180 / Math.PI + 90;
         _loc4_ = Number(this.bulletPoint.x);
         _loc5_ = Number(this.bulletPoint.y);
         _loc6_ = rotation * Math.PI / 180;
         _loc7_ = _loc4_ * Math.cos(_loc6_) - _loc5_ * Math.sin(_loc6_);
         _loc8_ = _loc5_ * Math.cos(_loc6_) + _loc4_ * Math.sin(_loc6_);
         _loc1_.init(game,LICHBOLT_DAMAGE,0,this.rotation,LICHBOLT_RANGE);
         _loc1_.x = this.x + _loc7_;
         _loc1_.y = this.y + _loc8_;
         _loc1_.rotation = this.rotation;
         game.backGround.badBulletHolder.addChild(_loc1_);
      }
      
      private function smashBarricade() : *
      {
         var _loc1_:int = 0;
         var _loc2_:Sound = null;
         var _loc3_:SoundChannel = null;
         if(attackingBarricade)
         {
            if(!attacking)
            {
               attacking = true;
               gotoAndPlay("attack");
            }
         }
         else if(!inside)
         {
            _loc1_ = 0;
            while(_loc1_ < game.barrArray.length)
            {
               if(!game.barrArray[_loc1_].barricadeDead || this is Banshee)
               {
                  if(this.zombiedetect_mc.hitTestObject(game.barrArray[_loc1_].barricade_hitBit))
                  {
                     if(this is Banshee)
                     {
                        game.removeBarricade(game.barrArray[_loc1_]);
                        dying = true;
                        _loc2_ = new BarrSmashedSnd();
                        _loc3_ = _loc2_.play(0,1);
                        gotoAndPlay("death");
                        game.removeDot(this);
                     }
                     else
                     {
                        attacking = true;
                        attackingBarricade = game.barrArray[_loc1_];
                        gotoAndPlay("attack");
                     }
                     break;
                  }
               }
               _loc1_++;
            }
         }
      }
      
      private function detectSentry() : Boolean
      {
         var _loc1_:Boolean = false;
         var _loc2_:int = 0;
         var _loc3_:Rectangle = null;
         var _loc4_:Point = null;
         var _loc5_:Point = null;
         if(dest2 != null)
         {
            _loc1_ = true;
            _loc2_ = 0;
            while(_loc2_ < game.obsArray.length)
            {
               _loc3_ = game.obsArray[_loc2_].getRect(game.backGround);
               _loc4_ = new Point(x,y);
               _loc5_ = new Point(dest2.x,dest2.y);
               if(game.LineIntersectsRect(_loc4_,_loc5_,_loc3_))
               {
                  _loc1_ = false;
                  break;
               }
               _loc1_ = true;
               _loc2_++;
            }
            if(!attacking && _loc1_)
            {
               attackingTurret = false;
            }
            return _loc1_;
         }
         return false;
      }
      
      private function visitedWP() : *
      {
         var _loc1_:Number = NaN;
         var _loc2_:Number = NaN;
         var _loc3_:Number = NaN;
         var _loc4_:int = 0;
         if(spookSighting)
         {
            _loc1_ = spookSighting.x - x + xOff;
            _loc2_ = spookSighting.y - y + yOff;
            _loc3_ = Math.sqrt(_loc1_ * _loc1_ + _loc2_ * _loc2_);
            if(_loc3_ <= speed)
            {
               spookSighting = null;
            }
         }
         _loc4_ = 0;
         while(_loc4_ < game.WPArray.length)
         {
            _loc1_ = game.WPArray[_loc4_].x - x + xOff;
            _loc2_ = game.WPArray[_loc4_].y - y + yOff;
            _loc3_ = Math.sqrt(_loc1_ * _loc1_ + _loc2_ * _loc2_);
            if(_loc3_ <= speed * DECISION_INT * 2)
            {
               if(game.WPArray[_loc4_] == prevdestArray[prevdestArray.length - 1])
               {
                  break;
               }
               decisionFrame = true;
               if(game.WPArray[_loc4_].isWindow)
               {
                  inside = true;
               }
               if(prevdestArray.length < 2)
               {
                  prevdestArray.push(game.WPArray[_loc4_]);
               }
               else
               {
                  prevdestArray.splice(0,1);
                  prevdestArray.push(game.WPArray[_loc4_]);
               }
               break;
            }
            _loc4_++;
         }
      }
      
      private function raiseSkellies() : *
      {
         var _loc1_:uint = 0;
         var _loc2_:uint = 0;
         var _loc3_:uint = 0;
         var _loc4_:Sound = null;
         var _loc5_:SoundChannel = null;
         var _loc6_:uint = 0;
         _loc1_ = 22;
         _loc2_ = Math.floor(Math.random() * 4) + 2;
         _loc3_ = (_loc2_ - 1) * _loc1_ / 2;
         _loc5_ = (_loc4_ = new SkelSnd()).play(0,1);
         _loc6_ = 0;
         while(_loc6_ < _loc2_)
         {
            game.spawnBaddie(6,x - _loc3_ + _loc6_ * _loc1_,y - _loc3_ + _loc6_ * _loc1_);
            _loc6_++;
         }
      }
      
      public function doHit() : *
      {
         var _loc1_:Sound = null;
         var _loc2_:SoundChannel = null;
         var _loc3_:Sound = null;
         var _loc4_:SoundChannel = null;
         if(attackingBarricade)
         {
            if(!attackingBarricade.fuxxored)
            {
               attackingBarricade.barricade_inner.gotoAndPlay("hit");
               attackingBarricade.currentHealth -= damage;
               if(Barricade.level == 5)
               {
                  currentHealth -= Barricade.BARBIE_DAM;
                  pointsMult = Barricade.POINTS_MULT;
               }
               if(attackingBarricade.currentHealth <= 0)
               {
                  attacking = false;
                  attackingBarricade.barricadeDead = true;
                  _loc3_ = new BarrSmashedSnd();
                  _loc4_ = _loc3_.play(0,1);
                  attackingBarricade.gotoAndStop("busted");
                  attackingBarricade = null;
               }
            }
            else
            {
               attackingBarricade = null;
            }
         }
         else if(this is Lich)
         {
            if(Math.random() < 0.2)
            {
               raiseSkellies();
            }
            else
            {
               lichStrike();
            }
         }
         else if(!game.spookIsDead && !game.menuOut)
         {
            damageSpook(damage);
         }
      }
      
      public function deleteMe() : *
      {
         stop();
         game.removeZombie(this);
         game = null;
      }
      
      public function killMe() : *
      {
         dying = true;
         game.earnPoints(this);
         gotoAndPlay("death");
      }
      
      public function update() : *
      {
         var _loc1_:Sound = null;
         var _loc2_:SoundChannel = null;
         var _loc3_:Number = NaN;
         var _loc4_:Number = NaN;
         var _loc5_:Number = NaN;
         if(!dying)
         {
            if(currentHealth <= 0)
            {
               dying = true;
               _loc1_ = new ZombieDieSnd();
               _loc2_ = _loc1_.play(0,1);
               game.earnPoints(this);
               gotoAndPlay("death");
            }
            else
            {
               if(decisionFrame)
               {
                  detectSpook();
               }
               if(canSeeSpook)
               {
                  _loc3_ = game.spook.x - x + xOff;
                  _loc4_ = game.spook.y - y + yOff;
                  if((_loc5_ = Math.sqrt(_loc3_ * _loc3_ + _loc4_ * _loc4_)) > attackDistance)
                  {
                     dest = game.spook;
                     if(!beingHit || this is Fester)
                     {
                        zombieMove();
                     }
                  }
                  else
                  {
                     zombieAttack();
                  }
               }
               else if(Boolean(GO_FOR_TURRETS) && game.backGround.turretHolder.numChildren > 0)
               {
                  dest2 = getNearestSentry();
                  if(detectSentry())
                  {
                     smashSentry();
                     if(!attackingTurret)
                     {
                        dest = dest2;
                        if(!beingHit || this is Fester)
                        {
                           zombieMove();
                        }
                     }
                  }
               }
               else
               {
                  dest2 = null;
                  smashBarricade();
                  if(!attackingBarricade)
                  {
                     if(decisionFrame)
                     {
                        visitedWP();
                     }
                     if(Boolean(decisionFrame) && !spookSighting)
                     {
                        dest = getNearestWP();
                     }
                     if(!beingHit || this is Fester)
                     {
                        zombieMove();
                     }
                  }
               }
               checkDecisionFrame();
            }
         }
      }
      
      private function smashSentry() : *
      {
         var _loc1_:int = 0;
         var _loc2_:MovieClip = null;
         if(game.backGround.turretHolder.numChildren > 0)
         {
            _loc1_ = 0;
            while(_loc1_ < game.backGround.turretHolder.numChildren)
            {
               _loc2_ = game.backGround.turretHolder.getChildAt(_loc1_);
               if(this.zombiedetect_mc.hitTestObject(_loc2_))
               {
                  if(!attacking)
                  {
                     attacking = true;
                     attackingTurret = true;
                     gotoAndPlay("attack");
                     _loc2_.currentHealth -= damage;
                     if(_loc2_.currentHealth <= 0)
                     {
                        attacking = false;
                        attackingTurret = false;
                        game.backGround.turretHolder.removeChild(_loc2_);
                        _loc2_ = null;
                     }
                  }
                  break;
               }
               _loc1_++;
            }
         }
      }
      
      private function checkDecisionFrame() : *
      {
         ++frameCounter;
         decisionFrame = (frameCounter & DECISION_INT - 1) == 0;
      }
      
      private function damageSpook(param1:Number) : *
      {
         var _loc2_:Number = NaN;
         hitSnd = new HitSnd();
         hitSndChannel = hitSnd.play(0,1);
         game.painscreen.gotoAndPlay(2);
         game.spook.currentHealth -= param1;
         _loc2_ = game.spook.currentHealth / game.spook.totalHealth;
         game.health_mc.healthBar.scaleX = _loc2_;
         game.checkDeath();
      }
   }
}