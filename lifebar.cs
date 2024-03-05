using System;
using System.Drawing;

public class LifeBar : MovieClip
{
    protected int maxHealth;
    protected int currentHealth;

    public LifeBar(Point param1, int param2, int param3)
    {
        base();
        this.x = param1.X;
        this.y = param1.Y;
        this.maxHealth = param2;
        this.currentHealth = param3;
    }

    public void updateMaxHealth(int param1, int param2)
    {
        this.maxHealth = param1;
        this.currentHealth = param2;
    }

    public void updateProgress(int param1)
    {
    }

    public void flip(int param1)
    {
        this.scaleX = param1;
    }

    public void show()
    {
        this.visible = true;
    }

    public void hide()
    {
        this.visible = false;
    }
//javascript
public class LifeBar extends MovieClip
   {
       
      
      protected var maxHealth:int;
      
      protected var currentHealth:int;
      
      public function LifeBar(param1:Point, param2:int, param3:int)
      {
         super();
         this.x = param1.x;
         this.y = param1.y;
         this.maxHealth = param2;
         this.currentHealth = param3;
      }
      
      public function updateMaxHealth(param1:int, param2:int) : void
      {
         this.maxHealth = param1;
         this.currentHealth = param2;
      }
      
      public function updateProgress(param1:int) : void
      {
      }
      
      public function flip(param1:int) : void
      {
         this.scaleX = param1;
      }
      
      public function show() : void
      {
         this.visible = true;
      }
      
      public function hide() : void
      {
         this.visible = false;
      }
   }