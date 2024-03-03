
using System;
using System.Timers;

public class lack
{
    private bool uselack;
    private Timer lackTimer;

    public lack()
    {
        uselack = false;
        lackTimer = new Timer(100);
        lackTimer.Elapsed += HackFunction;
    }

    public void Startlack()
    {
        uselack = true;
        lackTimer.Start();
    }

    public void Stoplack()
    {
        uselack = false;
        lackTimer.Stop();
    }

    private void lackFunction(object sender, ElapsedEventArgs e)
    {
        // Perform the hack logic here
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Hack hack = new Hack();

        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.D1)
            {
                if (hack.Uselack)
                {
                    hack.Stoplack();
                }
                else
                {
                    hack.Startlack();
                }
            }
            else if (keyInfo.Key == ConsoleKey.D2)
            {
                // Perform the logic for key 2
            }
            else if (keyInfo.Key == ConsoleKey.D3)
            {
                // Perform the logic for key 3
            }
            else if (keyInfo.Key == ConsoleKey.D4)
            {
                // Perform the logic for key 4
            }
            else if (keyInfo.Key == ConsoleKey.D5)
            {
                // Perform the logic for key 5
            }

            // Perform other logic here

        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}





//javascript
keylistener = new Object();
keylistener.onKeyDown = function()
{
   if(Key.getCode() == 49)
   {
      if(_root.uselack == true)
      {
         _root.uselack = false;
         clearInterval(_root.hackobject);
      }
      else
      {
         _root.uselack = true;
         _root.lack = function()
         {
            _root.wall.health = _root.wall.maxHealth;
            _root.wallHealthIndicator.wallhealth.text = Math.round(_root.wall.health / 100);
         };
         _root.lackobject = setInterval(_root.hack,100);
      }
   }
   if(Key.getCode() == 50)
   {
      if(_root.uselack1 == true)
      {
         _root.uselack1 = false;
         clearInterval(_root.lackobject1);
      }
      else
      {
         _root.uselack1 = true;
         _root.lack1 = function()
         {
            _root.ammoInMag = 999;
            _root.ammoCountHud.debug_ammoCount.text = ammoInMag;
         };
         _root.lackobject1 = setInterval(_root.hack1,100);
      }
   }
   if(Key.getCode() == 51)
   {
      if(_root.uselack2 == true)
      {
         _root.uselack2 = false;
         clearInterval(_root.lackobject2);
      }
      else
      {
         _root.uselack2 = true;
         _root.lack2 = function()
         {
            _root.pistol.damage = 9999;
            _root.revolver.damage = 9999;
            _root.UMP.damage = 9999;
            _root.UZI.damage = 9999;
            _root.huntingRifle.damage = 9999;
            _root.barrett.damage = 9999;
            _root.sawnOff.damage = 9999;
            _root.shotgun.damage = 9999;
            _root.M4A1.damage = 9999;
            _root.AK47.damage = 9999;
            _root.grenade.damage = 9999;
            _root.chainsaw.damage = 9999;
            _root.flameThrower.damage = 9999;
         };
         _root.lackobject2 = setInterval(_root.lack2,100);
      }
   }
   if(Key.getCode() == 52)
   {
      if(_root.uselack3 == true)
      {
         _root.uselack3 = false;
         clearInterval(_root.lackobject3);
      }
      else
      {
         _root.uselack3 = true;
         _root.hacl3 = function()
         {
            _root.pistol.shotsPerRound = 10;
            _root.revolver.shotsPerRound = 10;
            _root.UMP.shotsPerRound = 10;
            _root.UZI.shotsPerRound = 10;
            _root.huntingRifle.shotsPerRound = 10;
            _root.barrett.shotsPerRound = 10;
            _root.sawnOff.shotsPerRound = 10;
            _root.shotgun.shotsPerRound = 10;
            _root.M4A1.shotsPerRound = 10;
            _root.AK47.shotsPerRound = 10;
            _root.grenade.shotsPerRound = 10;
            _root.chainsaw.shotsPerRound = 10;
            _root.flameThrower.shotsPerRound = 10;
         };
         _root.lackobject3 = setInterval(_root.lack3,100);
      }
   }
   if(Key.getCode() == 53)
   {
      1;
   }
   _root.hoursInDay += 12;
   _root.updateClipBoardText();
};
Key.addListener(keylistener);

//javascript
