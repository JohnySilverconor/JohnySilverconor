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

/* javascript
public class WeaponData
   {
      
      public static const NONE:int = -1;
      
      public static const CANNONBALL:int = 0;
      
      public static const SCATTERSHOT:int = 1;
      
      public static const FIREBALL:int = 2;
      
      public static const NET:int = 3;
      
      public static const GIGABALL:int = 4;
      
      public static const OIL:int = 5;
      
      public static const FRONTCANNON:int = 6;
      
      public static const BOSSCANNON:int = 21;
      
      public static const BOSSWAVE:int = 22;
      
      public static const BOSSCIRCULAR:int = 23;
      
      public static const BOSSCROSS:int = 24;
      
      public static const BOSSCROSS_ALT:int = 25;
      
      public static const BOSSHOMING:int = 26;
      
      public static const BOSSTRIDENT:int = 27;
      
      public static const RAM:int = 6;
      
      public static const GALLERY:int = 7;
      
      public static const SHIELD:int = 8;
      
      public static const HUNTER:int = 9;
      
      public static const HUMAN:int = 10;
      
      public static var wCannon:int = -1;
      
      public static var wFire:int = -1;
      
      public static var wGiga:int = -1;
      
      public static var wRam:int = -1;
      
      public static var wHuman:int = -1;
      
      public static var wShield:int = -1;
      
      public static var wGallery:int = -1;
      
      public static var wTreasure:int = -1;
      
      public static var aFire:int = 0;
      
      public static var aGiga:int = 0;
      
      public static var aHuman:int = 0;
      
      public static var aShield:int = 0;
      
      public static var aRam:Number = 0;
      
      public static var aGallery:int = 0;
      
      public static var priceCannon:Vector.<uint>;
      
      public static var dmgCannon:Vector.<uint>;
      
      public static var rangeCannon:Vector.<uint>;
      
      public static var dmgScatter:Vector.<uint>;
      
      public static var rangeScatter:Vector.<uint>;
      
      public static var priceFire:Vector.<uint>;
      
      public static var dmgFire:Vector.<uint>;
      
      public static var dpsFire:Vector.<uint>;
      
      public static var rangeFire:Vector.<uint>;
      
      public static var ammoFire:Vector.<uint>;
      
      public static var dmgNet:Vector.<uint>;
      
      public static var rangeNet:Vector.<uint>;
      
      public static var dmgOil:Vector.<uint>;
      
      public static var durOil:Vector.<uint>;
      
      public static var rangeOil:Vector.<uint>;
      
      public static var priceGiga:Vector.<uint>;
      
      public static var dmgGiga:Vector.<uint>;
      
      public static var rangeGiga:Vector.<uint>;
      
      public static var ammoGiga:Vector.<uint>;
      
      public static var priceRam:Vector.<uint>;
      
      public static var dmgRam:Vector.<uint>;
      
      public static var chanceRam:Vector.<uint>;
      
      public static var dmgRevenge:Vector.<uint>;
      
      public static var chanceRevenge:Vector.<uint>;
      
      public static var chanceCloak:Vector.<uint>;
      
      public static var speedBonus:Vector.<uint>;
      
      public static var priceGallery:Vector.<uint>;
      
      public static var dmgGallery:Vector.<uint>;
      
      public static var ammoGallery:Vector.<uint>;
      
      public static var priceShield:Vector.<uint>;
      
      public static var chanceShield:Vector.<uint>;
      
      public static var reduceShield:Vector.<uint>;
      
      public static var priceHunter:Vector.<uint>;
      
      public static var chanceHunter:Vector.<uint>;
      
      public static var itemHunter:Vector.<uint>;
      
      public static var priceHuman:Vector.<int>;
      
      public static var durHuman:Vector.<int>;
      
      public static var dpsHuman:Vector.<int>;
      
      public static var rangeHuman:Vector.<int>;
      
      public static var ammoHuman:Vector.<uint>;
       
      
      public function WeaponData()
      {
         super();
      }
      
      public static function ResetData() : void
      {
         wCannon = 1;
         wFire = 0;
         wRam = 0;
         wHuman = 0;
         wGiga = 0;
         wShield = 0;
         wGallery = 0;
         wTreasure = 0;
         priceCannon = new Vector.<uint>();
         priceCannon.push(0,1000,2500,3500,5000);
         dmgCannon = new Vector.<uint>();
         dmgCannon.push(10,15,19,23,27);
         rangeCannon = new Vector.<uint>();
         rangeCannon.push(125,125,125,125,125);
         dmgScatter = new Vector.<uint>();
         dmgScatter.push(8,10,15,20,25);
         rangeScatter = new Vector.<uint>();
         rangeScatter.push(120,120,120,120,120);
         priceFire = new Vector.<uint>();
         priceFire.push(1200,2500,3250,4500,5000);
         dmgFire = new Vector.<uint>();
         dmgFire.push(18,25,32,38,44);
         dpsFire = new Vector.<uint>();
         dpsFire.push(6,8,10,12,15);
         rangeFire = new Vector.<uint>();
         rangeFire.push(120,120,120,120,120);
         ammoFire = new Vector.<uint>();
         ammoFire.push(10,15,20,25,30);
         priceGiga = new Vector.<uint>();
         priceGiga.push(2000,3000,4000,5000,6000);
         dmgGiga = new Vector.<uint>();
         dmgGiga.push(35,44,58,65,70);
         rangeGiga = new Vector.<uint>();
         rangeGiga.push(140,140,140,140,140);
         ammoGiga = new Vector.<uint>();
         ammoGiga.push(5,7,10,12,15);
         dmgOil = new Vector.<uint>();
         dmgOil.push(10,12,14,16,18);
         durOil = new Vector.<uint>();
         durOil.push(8,10,15,20,25);
         rangeOil = new Vector.<uint>();
         rangeOil.push(150,150,150,150,150);
         dmgNet = new Vector.<uint>();
         dmgNet.push(5,10,15,20,25);
         rangeNet = new Vector.<uint>();
         rangeNet.push(150,150,150,150,150);
         dmgRevenge = new Vector.<uint>();
         dmgRevenge.push(100,120,150,180,200);
         chanceRevenge = new Vector.<uint>();
         chanceRevenge.push(20,24,28,32,35);
         chanceCloak = new Vector.<uint>();
         chanceCloak.push(20,25,30,35,40);
         speedBonus = new Vector.<uint>();
         speedBonus.push(2,3,4,5,6);
         priceRam = new Vector.<uint>();
         priceRam.push(2000,3500,4500,5000,6000);
         dmgRam = new Vector.<uint>();
         dmgRam.push(40,60,80,100,120);
         chanceRam = new Vector.<uint>();
         chanceRam.push(8,9,10,11,12);
         priceShield = new Vector.<uint>();
         priceShield.push(500,1500,2400,3800,4500);
         chanceShield = new Vector.<uint>();
         chanceShield.push(30,35,40,45,50);
         reduceShield = new Vector.<uint>();
         reduceShield.push(1,4,6,8,10);
         priceHuman = new Vector.<int>();
         priceHuman.push(1000,2000,3000,4000,5000);
         durHuman = new Vector.<int>();
         durHuman.push(10,14,21,25,30);
         dpsHuman = new Vector.<int>();
         dpsHuman.push(1,2,4,6,8);
         rangeHuman = new Vector.<int>();
         rangeHuman.push(150,150,150,150,150);
         ammoHuman = new Vector.<uint>();
         ammoHuman.push(10,15,20,25,30);
         priceHunter = new Vector.<uint>();
         priceHunter.push(1000,2300,3500,4800,5000);
         chanceHunter = new Vector.<uint>();
         chanceHunter.push(1,2,3,4,5);
         itemHunter = new Vector.<uint>();
         itemHunter.push(20,25,35,45,55);
         priceGallery = new Vector.<uint>();
         priceGallery.push(1000,2000,3000,4000,5000);
         dmgGallery = new Vector.<uint>();
         dmgGallery.push(5,6,7,8,9);
         ammoGallery = new Vector.<uint>();
         ammoGallery.push(100,100,120,120,150);
      }
      
      public static function SetType(type:int) : void
      {
      }
   }
*/