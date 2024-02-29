public class cannondata
   {
      
      public static const int NONE = -1;
      
      public static const int CANNONBALL = 0;
      
      public static const int SCATTERSHOT = 1;
      
      public static const int FIREBALL = 2;
      
      public static const int NET = 3;
      
      public static const int GIGABALL = 4;
      
      public static const int OIL = 5;
      
      public static const int FRONTCANNON = 6;
      
      public static const int BOSSCANNON = 21;
      
      public static const int BOSSWAVE = 22;
      
      public static const int BOSSCIRCULAR = 23;
      
      public static const int BOSSCROSS = 24;
      
      public static const int BOSSCROSS_ALT = 25;
      
      public static const int BOSSHOMING = 26;
      
      public static const int BOSSTRIDENT = 27;
      
      public static const int RAM = 6;
      
      public static const int GALLERY = 7;
      
      public static const int SHIELD = 8;
      
      public static const int HUNTER = 9;
      
      public static const int HUMAN = 10;
      
      public static int wCannon = -1;
      
      public static int wFire = -1;
      
      public static int wGiga = -1;
      
      public static int wRam = -1;
      
      public static int wHuman = -1;
      
      public static int wShield = -1;
      
      public static int wGallery = -1;
      
      public static int wTreasure = -1;
      
      public static int aFire = 0;
      
      public static int aGiga = 0;
      
      public static int aHuman = 0;
      
      public static int aShield = 0;
      
      public static double aRam = 0;
      
      public static int aGallery = 0;
      
      public static int[] priceCannon = new int[10]{0,1000,2500,3500,5000};
      
      public static int[] dmgCannon = new int[10]{10,15,19,23,27};
      
      public static int[] rangeCannon = new int[10]{125,125,125,125,125};
      
      public static int[] dmgScatter = new int[10]{8,10,15,20,25};
      
      public static int[] rangeScatter = new int[10]{120,120,120,120,120};
      
      public static int[] priceFire = new int[10]{1200,2500,3250,4500,5000};
      
      public static int[] dmgFire= new int[10]{18,25,32,38,44};
      
      public static int[] dpsFire = new int[10]{6,8,10,12,15};
      
      public static int[] rangeFire = new int[10]{120,120,120,120,120};
      
      public static int[] ammoFire = new int[10]{10,15,20,25,30};
      
      public static int[] dmgNet = new int[10]{5,10,15,20,25};
      
      public static int[] rangeNet = new int[10]{150,150,150,150,150};
      
      public static int[] dmgOil =new int[10] {10,12,14,16,18};
      
      public static int[] durOil = new int[10] {8,10,15,20,25};
      
      public static int[] rangeOil = new int[10]{150,150,150,150,150};
      
      public static int[] priceGiga = new int[10]{2000,3000,4000,5000,6000};
      
      public static int[] dmgGiga = new int[10]{35,44,58,65,70};
      
      public static int[] rangeGiga = new int[10]{140,140,140,140,140};
      
      public static int[] ammoGiga = new int[10]{5,7,10,12,15};
      
      public static int[] priceRam = new int[10]{2000,3500,4500,5000,6000};
      
      public static int[] dmgRam = new int[10]{40,60,80,100,120};
      
      public static int[] chanceRam = new int[10]{8,9,10,11,12};
      
      public static int[] dmgRevenge = new int[10] {100,120,150,180,200};
      
      public static int[] chanceRevenge = new int[10] {20,24,28,32,35};
      
      public static int[] chanceCloak = new int[10] {20,25,30,35,40};
      
      public static int[] speedBonus = new int[10] {2,3,4,5,6};
      
      public static int[] priceGallery = new int[10] {1000,2000,3000,4000,5000};
      
      public static int[] dmgGallery = new int[10] {5,6,7,8,9};
      
      public static int[] ammoGallery = new int[10] {100,100,120,120,150};
      
      public static int[] priceShield = new int[10] {500,1500,2400,3800,4500};
      
      public static int[] chanceShield = new int[10] {30,35,40,45,50};
      
      public static int[] reduceShield = new int[10] {1,4,6,8,10};
      
      public static int[] priceHunter = new int[10] {1000,2300,3500,4800,5000};
      
      public static int[] chanceHunter = new int[10] {1,2,3,4,5};
      
      public static int[] itemHunter = new int[10] {20,25,35,45,55};
      public static int[] priceHuman = new int[10] {1000,2000,3000,4000,5000};
      
      public static int[] durHuman = new int[10]{10,14,21,25,30};
      
      public static int[] dpsHuman = new int[10] {1,2,4,6,8};
      
      public static int[] rangeHuman = new int[10] {150,150,150,150,150};
      
      public static int[] ammoHuman = new int[10] {10,15,20,25,30};
       
      
      public cannondata()
      {
       
      }
      
      public static void ResetData() 
      {
         wCannon = 1;
         wFire = 0;
         wRam = 0;
         wHuman = 0;
         wGiga = 0;
         wShield = 0;
         wGallery = 0;
         wTreasure = 0;
      }
      
      public static function SetType(type:int) : void
      {
      }
   }