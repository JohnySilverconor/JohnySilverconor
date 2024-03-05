using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class GameEncyclopedia
{
    public bool notificationTowerArchersLevel2;
    public bool notificationTowerArchersLevel3;
    public bool notificationTowerArchersRanger;
    public bool notificationTowerArchersMusketeer;
    public bool notificationTowerSoldiersLevel2;
    public bool notificationTowerSoldiersLevel3;
    public bool notificationTowerSoldiersPaladin;
    public bool notificationTowerSoldiersBarbarian;
    public bool notificationTowerMagesLevel2;
    public bool notificationTowerMagesLevel3;
    public bool notificationTowerMagesArcane;
    public bool notificationTowerMagesSorcerer;
    public bool notificationTowerEngineersLevel2;
    public bool notificationTowerEngineersLevel3;
    public bool notificationTowerEngineersBfg;
    public bool notificationTowerEngineersTesla;
    public bool notificationEnemyGoblin;
    public bool notificationEnemyFatOrc;
    public bool notificationEnemyShaman;
    public bool notificationEnemyOgre;
    public bool notificationEnemyBandit;
    public bool notificationEnemyBrigand;
    public bool notificationEnemyMarauder;
    public bool notificationEnemySpider;
    public bool notificationEnemySpiderSmall;
    public bool notificationEnemyGargoyle;
    public bool notificationEnemyShadowArcher;
    public bool notificationEnemyDarkKnight;
    public bool notificationEnemySmallWolf;
    public bool notificationEnemyWolf;
    public bool notificationEnemyGolemHead;
    public bool notificationEnemyWhiteWolf;
    public bool notificationEnemyTroll;
    public bool notificationEnemyTrollAxeThrower;
    public bool notificationEnemyTrollChieftain;
    public bool notificationEnemyYeti;
    public bool notificationEnemyRocketeer;
    public bool notificationEnemyDarkSlayer;
    public bool notificationEnemyDemon;
    public bool notificationEnemyDemonMage;
    public bool notificationEnemyDemonWolf;
    public bool notificationEnemyDemonImp;
    public bool notificationEnemyNecromancer;
    public bool notificationEnemySkeletor;
    public bool notificationEnemySkeletorBig;
    public bool notificationEnemyLavaElemental;
    public bool notificationEnemyJuggernaut;
    public bool notificationEnemyYetiBoss;
    public bool notificationEnemyVeznan;
    public bool notificationEnemySarelgazSmall;
    public bool notificationEnemySarelgaz;
    public bool notificationEnemyOrcArmored;
    public bool notificationEnemyGoblinZapper;
    public bool notificationEnemyOrcWolfRider;
    public bool notificationEnemyForestTroll;
    public bool notificationEnemyBossGoblinChieftain;

    private Game game;

    public GameEncyclopedia(Game game)
    {
        this.game = game;
    }

    public void SaveData()
    {
        if (!game.§_-Ll§)
        {
            try
            {
                using (FileStream fileStream = new FileStream(game.selectedSlot, FileMode.OpenOrCreate))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    EncyclopediaData encyclopediaData = new EncyclopediaData();
                    encyclopediaData.notificationTowerArchersLevel2 = this.notificationTowerArchersLevel2;
                    encyclopediaData.notificationTowerArchersLevel3 = this.notificationTowerArchersLevel3;
                    encyclopediaData.notificationTowerArchersRanger = this.notificationTowerArchersRanger;
                    encyclopediaData.notificationTowerArchersMusketeer = this.notificationTowerArchersMusketeer;
                    encyclopediaData.notificationTowerSoldiersLevel2 = this.notificationTowerSoldiersLevel2;
                    encyclopediaData.notificationTowerSoldiersLevel3 = this.notificationTowerSoldiersLevel3;
                    encyclopediaData.notificationTowerSoldiersPaladin = this.notificationTowerSoldiersPaladin;
                    encyclopediaData.notificationTowerSoldiersBarbarian = this.notificationTowerSoldiersBarbarian;
                    encyclopediaData.notificationTowerMagesLevel2 = this.notificationTowerMagesLevel2;
                    encyclopediaData.notificationTowerMagesLevel3 = this.notificationTowerMagesLevel3;
                    encyclopediaData.notificationTowerMagesArcane = this.notificationTowerMagesArcane;
                    encyclopediaData.notificationTowerMagesSorcerer = this.notificationTowerMagesSorcerer;
                    encyclopediaData.notificationTowerEngineersLevel2 = this.notificationTowerEngineersLevel2;
                    encyclopediaData.notificationTowerEngineersLevel3 = this.notificationTowerEngineersLevel3;
                    encyclopediaData.notificationTowerEngineersBfg = this.notificationTowerEngineersBfg;
                    encyclopediaData.notificationTowerEngineersTesla = this.notificationTowerEngineersTesla;
                    encyclopediaData.notificationEnemyGoblin = this.notificationEnemyGoblin;
                    encyclopediaData.notificationEnemyFatOrc = this.notificationEnemyFatOrc;
                    encyclopediaData.notificationEnemyShaman = this.notificationEnemyShaman;
                    encyclopediaData.notificationEnemyOgre = this.notificationEnemyOgre;
                    encyclopediaData.notificationEnemyBandit = this.notificationEnemyBandit;
                    encyclopediaData.notificationEnemyBrigand = this.notificationEnemyBrigand;
                    encyclopediaData.notificationEnemyMarauder = this.notificationEnemyMarauder;
                    encyclopediaData.notificationEnemySpider = this.notificationEnemySpider;
                    encyclopediaData.notificationEnemySpiderSmall = this.notificationEnemySpiderSmall;
                    encyclopediaData.notificationEnemyGargoyle = this.notificationEnemyGargoyle;
                    encyclopediaData.notificationEnemyShadowArcher = this.notificationEnemyShadowArcher;
                    encyclopediaData.notificationEnemyDarkKnight = this.notificationEnemyDarkKnight;
                    encyclopediaData.notificationEnemySmallWolf = this.notificationEnemySmallWolf;
                    encyclopediaData.notificationEnemyWolf = this.notificationEnemyWolf;
                    encyclopediaData.notificationEnemyGolemHead = this.notificationEnemyGolemHead;
                    encyclopediaData.notificationEnemyWhiteWolf = this.notificationEnemyWhiteWolf;
                    encyclopediaData.notificationEnemyTroll = this.notificationEnemyTroll;
                    encyclopediaData.notificationEnemyTrollAxeThrower = this.notificationEnemyTrollAxeThrower;
                    encyclopediaData.notificationEnemyTrollChieftain = this.notificationEnemyTrollChieftain;
                    encyclopediaData.notificationEnemyYeti = this.notificationEnemyYeti;
                    encyclopediaData.notificationEnemyRocketeer = this.notificationEnemyRocketeer;
                    encyclopediaData.notificationEnemyDarkSlayer = this.notificationEnemyDarkSlayer;
                    encyclopediaData.notificationEnemyDemon = this.notificationEnemyDemon;
                    encyclopediaData.notificationEnemyDemonMage = this.notificationEnemyDemonMage;
                    encyclopediaData.notificationEnemyDemonWolf = this.notificationEnemyDemonWolf;
                    encyclopediaData.notificationEnemyDemonImp = this.notificationEnemyDemonImp;
                    encyclopediaData.notificationEnemyNecromancer = this.notificationEnemyNecromancer;
                    encyclopediaData.notificationEnemySkeletor = this.notificationEnemySkeletor;
                    encyclopediaData.notificationEnemySkeletorBig = this.notificationEnemySkeletorBig;
                    encyclopediaData.notificationEnemyLavaElemental = this.notificationEnemyLavaElemental;
                    encyclopediaData.notificationEnemyJuggernaut = this.notificationEnemyJuggernaut;
                    encyclopediaData.notificationEnemyYetiBoss = this.notificationEnemyYetiBoss;
                    encyclopediaData.notificationEnemyVeznan = this.notificationEnemyVeznan;
                    encyclopediaData.notificationEnemySarelgazSmall = this.notificationEnemySarelgazSmall;
                    encyclopediaData.notificationEnemySarelgaz = this.notificationEnemySarelgaz;
                    encyclopediaData.notificationEnemyOrcArmored = this.notificationEnemyOrcArmored;
                    encyclopediaData.notificationEnemyGoblinZapper = this.notificationEnemyGoblinZapper;
                    encyclopediaData.notificationEnemyOrcWolfRider = this.notificationEnemyOrcWolfRider;
                    encyclopediaData.notificationEnemyForestTroll = this.notificationEnemyForestTroll;
                    encyclopediaData.notificationEnemyBossGoblinChieftain = this.notificationEnemyBossGoblinChieftain;
                    binaryFormatter.Serialize(fileStream, encyclopediaData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while saving data: " + e.Message);
            }
        }
    }

    public void LoadData()
    {
        try
        {
            using (FileStream fileStream = new FileStream(game.selectedSlot, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                EncyclopediaData encyclopediaData = (EncyclopediaData)binaryFormatter.Deserialize(fileStream);
                this.notificationTowerArchersLevel2 = encyclopediaData.notificationTowerArchersLevel2;
                this.notificationTowerArchersLevel3 = encyclopediaData.notificationTowerArchersLevel3;
                this.notificationTowerArchersRanger = encyclopediaData.notificationTowerArchersRanger;
                this.notificationTowerArchersMusketeer = encyclopediaData.notificationTowerArchersMusketeer;
                this.notificationTowerSoldiersLevel2 = encyclopediaData.notificationTowerSoldiersLevel2;
                this.notificationTowerSoldiersLevel3 = encyclopediaData.notificationTowerSoldiersLevel3;
                this.notificationTowerSoldiersPaladin = encyclopediaData.notificationTowerSoldiersPaladin;
                this.notificationTowerSoldiersBarbarian = encyclopediaData.notificationTowerSoldiersBarbarian;
                this.notificationTowerMagesLevel2 = encyclopediaData.notificationTowerMagesLevel2;
                this.notificationTowerMagesLevel3 = encyclopediaData.notificationTowerMagesLevel3;
                this.notificationTowerMagesArcane = encyclopediaData.notificationTowerMagesArcane;
                this.notificationTowerMagesSorcerer = encyclopediaData.notificationTowerMagesSorcerer;
                this.notificationTowerEngineersLevel2 = encyclopediaData.notificationTowerEngineersLevel2;
                this.notificationTowerEngineersLevel3 = encyclopediaData.notificationTowerEngineersLevel3;
                this.notificationTowerEngineersBfg = encyclopediaData.notificationTowerEngineersBfg;
                this.notificationTowerEngineersTesla = encyclopediaData.notificationTowerEngineersTesla;
                this.notificationEnemyGoblin = encyclopediaData.notificationEnemyGoblin;
                this.notificationEnemyFatOrc = encyclopediaData.notificationEnemyFatOrc;
                this.notificationEnemyShaman = encyclopediaData.notificationEnemyShaman;
                this.notificationEnemyOgre = encyclopediaData.notificationEnemyOgre;
                this.notificationEnemyBandit = encyclopediaData.notificationEnemyBandit;
                this.notificationEnemyBrigand = encyclopediaData.notificationEnemyBrigand;
                this.notificationEnemyMarauder = encyclopediaData.notificationEnemyMarauder;
                this.notificationEnemySpider = encyclopediaData.notificationEnemySpider;
                this.notificationEnemySpiderSmall = encyclopediaData.notificationEnemySpiderSmall;
                this.notificationEnemyGargoyle = encyclopediaData.notificationEnemyGargoyle;
                this.notificationEnemyShadowArcher = encyclopediaData.notificationEnemyShadowArcher;
                this.notificationEnemyDarkKnight = encyclopediaData.notificationEnemyDarkKnight;
                this.notificationEnemySmallWolf = encyclopediaData.notificationEnemySmallWolf;
                this.notificationEnemyWolf = encyclopediaData.notificationEnemyWolf;
                this.notificationEnemyGolemHead = encyclopediaData.notificationEnemyGolemHead;
                this.notificationEnemyWhiteWolf = encyclopediaData.notificationEnemyWhiteWolf;
                this.notificationEnemyTroll = encyclopediaData.notificationEnemyTroll;
                this.notificationEnemyTrollAxeThrower = encyclopediaData.notificationEnemyTrollAxeThrower;
                this.notificationEnemyTrollChieftain = encyclopediaData.notificationEnemyTrollChieftain;
                this.notificationEnemyYeti = encyclopediaData.notificationEnemyYeti;
                this.notificationEnemyRocketeer = encyclopediaData.notificationEnemyRocketeer;
                this.notificationEnemyDarkSlayer = encyclopediaData.notificationEnemyDarkSlayer;
                this.notificationEnemyDemon = encyclopediaData.notificationEnemyDemon;
                this.notificationEnemyDemonMage = encyclopediaData.notificationEnemyDemonMage;
                this.notificationEnemyDemonWolf = encyclopediaData.notificationEnemyDemonWolf;
                this.notificationEnemyDemonImp = encyclopediaData.notificationEnemyDemonImp;
                this.notificationEnemyNecromancer = encyclopediaData.notificationEnemyNecromancer;
                this.notificationEnemySkeletor = encyclopediaData.notificationEnemySkeletor;
                this.notificationEnemySkeletorBig = encyclopediaData.notificationEnemySkeletorBig;
                this.notificationEnemyLavaElemental = encyclopediaData.notificationEnemyLavaElemental;
                this.notificationEnemyJuggernaut = encyclopediaData.notificationEnemyJuggernaut;
                this.notificationEnemyYetiBoss = encyclopediaData.notificationEnemyYetiBoss;
                this.notificationEnemyVeznan = encyclopediaData.notificationEnemyVeznan;
                this.notificationEnemySarelgazSmall = encyclopediaData.notificationEnemySarelgazSmall;
                this.notificationEnemySarelgaz = encyclopediaData.notificationEnemySarelgaz;
                this.notificationEnemyOrcArmored = encyclopediaData.notificationEnemyOrcArmored;
                this.notificationEnemyGoblinZapper = encyclopediaData.notificationEnemyGoblinZapper;
                this.notificationEnemyOrcWolfRider = encyclopediaData.notificationEnemyOrcWolfRider;
                this.notificationEnemyForestTroll = encyclopediaData.notificationEnemyForestTroll;
                this.notificationEnemyBossGoblinChieftain = encyclopediaData.notificationEnemyBossGoblinChieftain;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while loading data: " + e.Message);
        }
    }

    public void DestroyThis()
    {
        this.game = null;
    }
}

[Serializable]
public class EncyclopediaData
{
    public bool notificationTowerArchersLevel2;
    public bool notificationTowerArchersLevel3;
    public bool notificationTowerArchersRanger;
    public bool notificationTowerArchersMusketeer;
    public bool notificationTowerSoldiersLevel2;
    public bool notificationTowerSoldiersLevel3;
    public bool notificationTowerSoldiersPaladin;
    public bool notificationTowerSoldiersBarbarian;
    public bool notificationTowerMagesLevel2;
    public bool notificationTowerMagesLevel3;
    public bool notificationTowerMagesArcane;
    public bool notificationTowerMagesSorcerer;
    public bool notificationTowerEngineersLevel2;
    public bool notificationTowerEngineersLevel3;
    public bool notificationTowerEngineersBfg;
    public bool notificationTowerEngineersTesla;
    public bool notificationEnemyGoblin;
    public bool notificationEnemyFatOrc;
    public bool notificationEnemyShaman;
    public bool notificationEnemyOgre;
    public bool notificationEnemyBandit;
    public bool notificationEnemyBrigand;
    public bool notificationEnemyMarauder;
    public bool notificationEnemySpider;
    public bool notificationEnemySpiderSmall;
    public bool notificationEnemyGargoyle;
    public bool notificationEnemyShadowArcher;
    public bool notificationEnemyDarkKnight;
    public bool notificationEnemySmallWolf;
    public bool notificationEnemyWolf;
    public bool notificationEnemyGolemHead;
    public bool notificationEnemyWhiteWolf;
    public bool notificationEnemyTroll;
    public bool notificationEnemyTrollAxeThrower;
    public bool notificationEnemyTrollChieftain;
    public bool notificationEnemyYeti;
    public bool notificationEnemyRocketeer;
    public bool notificationEnemyDarkSlayer;
    public bool notificationEnemyDemon;
    public bool notificationEnemyDemonMage;
    public bool notificationEnemyDemonWolf;
    public bool notificationEnemyDemonImp;
    public bool notificationEnemyNecromancer;
    public bool notificationEnemySkeletor;
    public bool notificationEnemySkeletorBig;
    public bool notificationEnemyLavaElemental;
    public bool notificationEnemyJuggernaut;
    public bool notificationEnemyYetiBoss;
    public bool notificationEnemyVeznan;
    public bool notificationEnemySarelgazSmall;
    public bool notificationEnemySarelgaz;
    public bool notificationEnemyOrcArmored;
    public bool notificationEnemyGoblinZapper;
    public bool notificationEnemyOrcWolfRider;
    public bool notificationEnemyForestTroll;
    public bool notificationEnemyBossGoblinChieftain;
}

public class Game
{
    public bool §_-Ll§;
    public string selectedSlot;
}
//javascript

package
{
   import flash.net.SharedObject;
   
   public class GameEncyclopedia
   {
       
      
      public var notificationTowerArchersLevel2:Boolean;
      
      public var notificationTowerArchersLevel3:Boolean;
      
      public var notificationTowerArchersRanger:Boolean;
      
      public var notificationTowerArchersMusketeer:Boolean;
      
      public var notificationTowerSoldiersLevel2:Boolean;
      
      public var notificationTowerSoldiersLevel3:Boolean;
      
      public var notificationTowerSoldiersPaladin:Boolean;
      
      public var notificationTowerSoldiersBarbarian:Boolean;
      
      public var notificationTowerMagesLevel2:Boolean;
      
      public var notificationTowerMagesLevel3:Boolean;
      
      public var notificationTowerMagesArcane:Boolean;
      
      public var notificationTowerMagesSorcerer:Boolean;
      
      public var notificationTowerEngineersLevel2:Boolean;
      
      public var notificationTowerEngineersLevel3:Boolean;
      
      public var notificationTowerEngineersBfg:Boolean;
      
      public var notificationTowerEngineersTesla:Boolean;
      
      public var notificationEnemyGoblin:Boolean;
      
      public var notificationEnemyFatOrc:Boolean;
      
      public var notificationEnemyShaman:Boolean;
      
      public var notificationEnemyOgre:Boolean;
      
      public var notificationEnemyBandit:Boolean;
      
      public var notificationEnemyBrigand:Boolean;
      
      public var notificationEnemyMarauder:Boolean;
      
      public var notificationEnemySpider:Boolean;
      
      public var notificationEnemySpiderSmall:Boolean;
      
      public var notificationEnemyGargoyle:Boolean;
      
      public var notificationEnemyShadowArcher:Boolean;
      
      public var notificationEnemyDarkKnight:Boolean;
      
      public var notificationEnemySmallWolf:Boolean;
      
      public var notificationEnemyWolf:Boolean;
      
      public var notificationEnemyGolemHead:Boolean;
      
      public var notificationEnemyWhiteWolf:Boolean;
      
      public var notificationEnemyTroll:Boolean;
      
      public var notificationEnemyTrollAxeThrower:Boolean;
      
      public var notificationEnemyTrollChieftain:Boolean;
      
      public var notificationEnemyYeti:Boolean;
      
      public var notificationEnemyRocketeer:Boolean;
      
      public var notificationEnemyDarkSlayer:Boolean;
      
      public var notificationEnemyDemon:Boolean;
      
      public var notificationEnemyDemonMage:Boolean;
      
      public var notificationEnemyDemonWolf:Boolean;
      
      public var notificationEnemyDemonImp:Boolean;
      
      public var notificationEnemyNecromancer:Boolean;
      
      public var notificationEnemySkeletor:Boolean;
      
      public var notificationEnemySkeletorBig:Boolean;
      
      public var notificationEnemyLavaElemental:Boolean;
      
      public var notificationEnemyJuggernaut:Boolean;
      
      public var notificationEnemyYetiBoss:Boolean;
      
      public var notificationEnemyVeznan:Boolean;
      
      public var notificationEnemySarelgazSmall:Boolean;
      
      public var notificationEnemySarelgaz:Boolean;
      
      public var notificationEnemyOrcArmored:Boolean;
      
      public var notificationEnemyGoblinZapper:Boolean;
      
      public var notificationEnemyOrcWolfRider:Boolean;
      
      public var notificationEnemyForestTroll:Boolean;
      
      public var notificationEnemyBossGoblinChieftain:Boolean;
      
      private var game:Game;
      
      public function GameEncyclopedia(param1:Game)
      {
         super();
         this.game = param1;
      }
      
      public function saveData() : void
      {
         var my_so:SharedObject = null;
         if(!this.game.§_-Ll§)
         {
            try
            {
               my_so = SharedObject.getLocal(this.game.selectedSlot);
               if(my_so.data.encyclopedia == undefined)
               {
                  my_so.data.encyclopedia = new Object();
               }
               my_so.data.encyclopedia.notificationTowerArchersLevel2 = this.notificationTowerArchersLevel2;
               my_so.data.encyclopedia.notificationTowerArchersLevel3 = this.notificationTowerArchersLevel3;
               my_so.data.encyclopedia.notificationTowerArchersRanger = this.notificationTowerArchersRanger;
               my_so.data.encyclopedia.notificationTowerArchersMusketeer = this.notificationTowerArchersMusketeer;
               my_so.data.encyclopedia.notificationTowerSoldiersLevel2 = this.notificationTowerSoldiersLevel2;
               my_so.data.encyclopedia.notificationTowerSoldiersLevel3 = this.notificationTowerSoldiersLevel3;
               my_so.data.encyclopedia.notificationTowerSoldiersPaladin = this.notificationTowerSoldiersPaladin;
               my_so.data.encyclopedia.notificationTowerSoldiersBarbarian = this.notificationTowerSoldiersBarbarian;
               my_so.data.encyclopedia.notificationTowerMagesLevel2 = this.notificationTowerMagesLevel2;
               my_so.data.encyclopedia.notificationTowerMagesLevel3 = this.notificationTowerMagesLevel3;
               my_so.data.encyclopedia.notificationTowerMagesArcane = this.notificationTowerMagesArcane;
               my_so.data.encyclopedia.notificationTowerMagesSorcerer = this.notificationTowerMagesSorcerer;
               my_so.data.encyclopedia.notificationTowerEngineersLevel2 = this.notificationTowerEngineersLevel2;
               my_so.data.encyclopedia.notificationTowerEngineersLevel3 = this.notificationTowerEngineersLevel3;
               my_so.data.encyclopedia.notificationTowerEngineersBfg = this.notificationTowerEngineersBfg;
               my_so.data.encyclopedia.notificationTowerEngineersTesla = this.notificationTowerEngineersTesla;
               my_so.data.encyclopedia.notificationEnemyGoblin = this.notificationEnemyGoblin;
               my_so.data.encyclopedia.notificationEnemyFatOrc = this.notificationEnemyFatOrc;
               my_so.data.encyclopedia.notificationEnemyShaman = this.notificationEnemyShaman;
               my_so.data.encyclopedia.notificationEnemyOgre = this.notificationEnemyOgre;
               my_so.data.encyclopedia.notificationEnemyBandit = this.notificationEnemyBandit;
               my_so.data.encyclopedia.notificationEnemyBrigand = this.notificationEnemyBrigand;
               my_so.data.encyclopedia.notificationEnemyMarauder = this.notificationEnemyMarauder;
               my_so.data.encyclopedia.notificationEnemySpider = this.notificationEnemySpider;
               my_so.data.encyclopedia.notificationEnemySpiderSmall = this.notificationEnemySpiderSmall;
               my_so.data.encyclopedia.notificationEnemyGargoyle = this.notificationEnemyGargoyle;
               my_so.data.encyclopedia.notificationEnemyShadowArcher = this.notificationEnemyShadowArcher;
               my_so.data.encyclopedia.notificationEnemyDarkKnight = this.notificationEnemyDarkKnight;
               my_so.data.encyclopedia.notificationEnemySmallWolf = this.notificationEnemySmallWolf;
               my_so.data.encyclopedia.notificationEnemyWolf = this.notificationEnemyWolf;
               my_so.data.encyclopedia.notificationEnemyGolemHead = this.notificationEnemyGolemHead;
               my_so.data.encyclopedia.notificationEnemyWhiteWolf = this.notificationEnemyWhiteWolf;
               my_so.data.encyclopedia.notificationEnemyTroll = this.notificationEnemyTroll;
               my_so.data.encyclopedia.notificationEnemyTrollAxeThrower = this.notificationEnemyTrollAxeThrower;
               my_so.data.encyclopedia.notificationEnemyTrollChieftain = this.notificationEnemyTrollChieftain;
               my_so.data.encyclopedia.notificationEnemyYeti = this.notificationEnemyYeti;
               my_so.data.encyclopedia.notificationEnemyRocketeer = this.notificationEnemyRocketeer;
               my_so.data.encyclopedia.notificationEnemyDarkSlayer = this.notificationEnemyDarkSlayer;
               my_so.data.encyclopedia.notificationEnemyDemon = this.notificationEnemyDemon;
               my_so.data.encyclopedia.notificationEnemyDemonMage = this.notificationEnemyDemonMage;
               my_so.data.encyclopedia.notificationEnemyDemonWolf = this.notificationEnemyDemonWolf;
               my_so.data.encyclopedia.notificationEnemyDemonImp = this.notificationEnemyDemonImp;
               my_so.data.encyclopedia.notificationEnemyNecromancer = this.notificationEnemyNecromancer;
               my_so.data.encyclopedia.notificationEnemySkeletor = this.notificationEnemySkeletor;
               my_so.data.encyclopedia.notificationEnemySkeletorBig = this.notificationEnemySkeletorBig;
               my_so.data.encyclopedia.notificationEnemyLavaElemental = this.notificationEnemyLavaElemental;
               my_so.data.encyclopedia.notificationEnemyVeznan = this.notificationEnemyVeznan;
               my_so.data.encyclopedia.notificationEnemyJuggernaut = this.notificationEnemyJuggernaut;
               my_so.data.encyclopedia.notificationEnemyYetiBoss = this.notificationEnemyYetiBoss;
               my_so.data.encyclopedia.notificationEnemySarelgazSmall = this.notificationEnemySarelgazSmall;
               my_so.data.encyclopedia.notificationEnemySarelgaz = this.notificationEnemySarelgaz;
               my_so.data.encyclopedia.notificationEnemyOrcArmored = this.notificationEnemyOrcArmored;
               my_so.data.encyclopedia.notificationEnemyGoblinZapper = this.notificationEnemyGoblinZapper;
               my_so.data.encyclopedia.notificationEnemyOrcWolfRider = this.notificationEnemyOrcWolfRider;
               my_so.data.encyclopedia.notificationEnemyForestTroll = this.notificationEnemyForestTroll;
               my_so.data.encyclopedia.notificationEnemyBossGoblinChieftain = this.notificationEnemyBossGoblinChieftain;
               my_so.flush();
               my_so.close();
            }
            catch(err:Error)
            {
            }
         }
      }
      
      public function §_-55§() : void
      {
         var § 0§:SharedObject = null;
         try
         {
            § 0§ = SharedObject.getLocal(this.game.selectedSlot);
            if(§ 0§.data.encyclopedia == undefined)
            {
               § 0§.data.encyclopedia = new Object();
            }
            this.notificationTowerArchersLevel2 = § 0§.data.encyclopedia.notificationTowerArchersLevel2;
            this.notificationTowerArchersLevel3 = § 0§.data.encyclopedia.notificationTowerArchersLevel3;
            this.notificationTowerArchersRanger = § 0§.data.encyclopedia.notificationTowerArchersRanger;
            this.notificationTowerArchersMusketeer = § 0§.data.encyclopedia.notificationTowerArchersMusketeer;
            this.notificationTowerSoldiersLevel2 = § 0§.data.encyclopedia.notificationTowerSoldiersLevel2;
            this.notificationTowerSoldiersLevel3 = § 0§.data.encyclopedia.notificationTowerSoldiersLevel3;
            this.notificationTowerSoldiersPaladin = § 0§.data.encyclopedia.notificationTowerSoldiersPaladin;
            this.notificationTowerSoldiersBarbarian = § 0§.data.encyclopedia.notificationTowerSoldiersBarbarian;
            this.notificationTowerMagesLevel2 = § 0§.data.encyclopedia.notificationTowerMagesLevel2;
            this.notificationTowerMagesLevel3 = § 0§.data.encyclopedia.notificationTowerMagesLevel3;
            this.notificationTowerMagesArcane = § 0§.data.encyclopedia.notificationTowerMagesArcane;
            this.notificationTowerMagesSorcerer = § 0§.data.encyclopedia.notificationTowerMagesSorcerer;
            this.notificationTowerEngineersLevel2 = § 0§.data.encyclopedia.notificationTowerEngineersLevel2;
            this.notificationTowerEngineersLevel3 = § 0§.data.encyclopedia.notificationTowerEngineersLevel3;
            this.notificationTowerEngineersBfg = § 0§.data.encyclopedia.notificationTowerEngineersBfg;
            this.notificationTowerEngineersTesla = § 0§.data.encyclopedia.notificationTowerEngineersTesla;
            this.notificationEnemyGoblin = § 0§.data.encyclopedia.notificationEnemyGoblin;
            this.notificationEnemyFatOrc = § 0§.data.encyclopedia.notificationEnemyFatOrc;
            this.notificationEnemyShaman = § 0§.data.encyclopedia.notificationEnemyShaman;
            this.notificationEnemyOgre = § 0§.data.encyclopedia.notificationEnemyOgre;
            this.notificationEnemyBandit = § 0§.data.encyclopedia.notificationEnemyBandit;
            this.notificationEnemyBrigand = § 0§.data.encyclopedia.notificationEnemyBrigand;
            this.notificationEnemyMarauder = § 0§.data.encyclopedia.notificationEnemyMarauder;
            this.notificationEnemySpider = § 0§.data.encyclopedia.notificationEnemySpider;
            this.notificationEnemySpiderSmall = § 0§.data.encyclopedia.notificationEnemySpiderSmall;
            this.notificationEnemyGargoyle = § 0§.data.encyclopedia.notificationEnemyGargoyle;
            this.notificationEnemyShadowArcher = § 0§.data.encyclopedia.notificationEnemyShadowArcher;
            this.notificationEnemyDarkKnight = § 0§.data.encyclopedia.notificationEnemyDarkKnight;
            this.notificationEnemySmallWolf = § 0§.data.encyclopedia.notificationEnemySmallWolf;
            this.notificationEnemyWolf = § 0§.data.encyclopedia.notificationEnemyWolf;
            this.notificationEnemyGolemHead = § 0§.data.encyclopedia.notificationEnemyGolemHead;
            this.notificationEnemyWhiteWolf = § 0§.data.encyclopedia.notificationEnemyWhiteWolf;
            this.notificationEnemyTroll = § 0§.data.encyclopedia.notificationEnemyTroll;
            this.notificationEnemyTrollAxeThrower = § 0§.data.encyclopedia.notificationEnemyTrollAxeThrower;
            this.notificationEnemyTrollChieftain = § 0§.data.encyclopedia.notificationEnemyTrollChieftain;
            this.notificationEnemyYeti = § 0§.data.encyclopedia.notificationEnemyYeti;
            this.notificationEnemyRocketeer = § 0§.data.encyclopedia.notificationEnemyRocketeer;
            this.notificationEnemyDarkSlayer = § 0§.data.encyclopedia.notificationEnemyDarkSlayer;
            this.notificationEnemyDemon = § 0§.data.encyclopedia.notificationEnemyDemon;
            this.notificationEnemyDemonMage = § 0§.data.encyclopedia.notificationEnemyDemonMage;
            this.notificationEnemyDemonWolf = § 0§.data.encyclopedia.notificationEnemyDemonWolf;
            this.notificationEnemyDemonImp = § 0§.data.encyclopedia.notificationEnemyDemonImp;
            this.notificationEnemyNecromancer = § 0§.data.encyclopedia.notificationEnemyNecromancer;
            this.notificationEnemySkeletor = § 0§.data.encyclopedia.notificationEnemySkeletor;
            this.notificationEnemySkeletorBig = § 0§.data.encyclopedia.notificationEnemySkeletorBig;
            this.notificationEnemyLavaElemental = § 0§.data.encyclopedia.notificationEnemyLavaElemental;
            this.notificationEnemyJuggernaut = § 0§.data.encyclopedia.notificationEnemyJuggernaut;
            this.notificationEnemyYetiBoss = § 0§.data.encyclopedia.notificationEnemyYetiBoss;
            this.notificationEnemyVeznan = § 0§.data.encyclopedia.notificationEnemyVeznan;
            this.notificationEnemySarelgazSmall = § 0§.data.encyclopedia.notificationEnemySarelgazSmall;
            this.notificationEnemySarelgaz = § 0§.data.encyclopedia.notificationEnemySarelgaz;
            this.notificationEnemyOrcArmored = § 0§.data.encyclopedia.notificationEnemyOrcArmored;
            this.notificationEnemyGoblinZapper = § 0§.data.encyclopedia.notificationEnemyGoblinZapper;
            this.notificationEnemyOrcWolfRider = § 0§.data.encyclopedia.notificationEnemyOrcWolfRider;
            this.notificationEnemyForestTroll = § 0§.data.encyclopedia.notificationEnemyForestTroll;
            this.notificationEnemyBossGoblinChieftain = § 0§.data.encyclopedia.notificationEnemyBossGoblinChieftain;
            § 0§.flush();
            § 0§.close();
         }
         catch(err:Error)
         {
         }
      }
      
      public function §_-MM§(param1:Object) : void
      {
         this.notificationTowerArchersLevel2 = param1.notificationTowerArchersLevel2;
         this.notificationTowerArchersLevel3 = param1.notificationTowerArchersLevel3;
         this.notificationTowerArchersRanger = param1.notificationTowerArchersRanger;
         this.notificationTowerArchersMusketeer = param1.notificationTowerArchersMusketeer;
         this.notificationTowerSoldiersLevel2 = param1.notificationTowerSoldiersLevel2;
         this.notificationTowerSoldiersLevel3 = param1.notificationTowerSoldiersLevel3;
         this.notificationTowerSoldiersPaladin = param1.notificationTowerSoldiersPaladin;
         this.notificationTowerSoldiersBarbarian = param1.notificationTowerSoldiersBarbarian;
         this.notificationTowerMagesLevel2 = param1.notificationTowerMagesLevel2;
         this.notificationTowerMagesLevel3 = param1.notificationTowerMagesLevel3;
         this.notificationTowerMagesArcane = param1.notificationTowerMagesArcane;
         this.notificationTowerMagesSorcerer = param1.notificationTowerMagesSorcerer;
         this.notificationTowerEngineersLevel2 = param1.notificationTowerEngineersLevel2;
         this.notificationTowerEngineersLevel3 = param1.notificationTowerEngineersLevel3;
         this.notificationTowerEngineersBfg = param1.notificationTowerEngineersBfg;
         this.notificationTowerEngineersTesla = param1.notificationTowerEngineersTesla;
         this.notificationEnemyGoblin = param1.notificationEnemyGoblin;
         this.notificationEnemyFatOrc = param1.notificationEnemyFatOrc;
         this.notificationEnemyShaman = param1.notificationEnemyShaman;
         this.notificationEnemyOgre = param1.notificationEnemyOgre;
         this.notificationEnemyBandit = param1.notificationEnemyBandit;
         this.notificationEnemyBrigand = param1.notificationEnemyBrigand;
         this.notificationEnemyMarauder = param1.notificationEnemyMarauder;
         this.notificationEnemySpider = param1.notificationEnemySpider;
         this.notificationEnemySpiderSmall = param1.notificationEnemySpiderSmall;
         this.notificationEnemyGargoyle = param1.notificationEnemyGargoyle;
         this.notificationEnemyShadowArcher = param1.notificationEnemyShadowArcher;
         this.notificationEnemyDarkKnight = param1.notificationEnemyDarkKnight;
         this.notificationEnemySmallWolf = param1.notificationEnemySmallWolf;
         this.notificationEnemyWolf = param1.notificationEnemyWolf;
         this.notificationEnemyGolemHead = param1.notificationEnemyGolemHead;
         this.notificationEnemyWhiteWolf = param1.notificationEnemyWhiteWolf;
         this.notificationEnemyTroll = param1.notificationEnemyTroll;
         this.notificationEnemyTrollAxeThrower = param1.notificationEnemyTrollAxeThrower;
         this.notificationEnemyTrollChieftain = param1.notificationEnemyTrollChieftain;
         this.notificationEnemyYeti = param1.notificationEnemyYeti;
         this.notificationEnemyRocketeer = param1.notificationEnemyRocketeer;
         this.notificationEnemyDarkSlayer = param1.notificationEnemyDarkSlayer;
         this.notificationEnemyDemon = param1.notificationEnemyDemon;
         this.notificationEnemyDemonMage = param1.notificationEnemyDemonMage;
         this.notificationEnemyDemonWolf = param1.notificationEnemyDemonWolf;
         this.notificationEnemyDemonImp = param1.notificationEnemyDemonImp;
         this.notificationEnemyNecromancer = param1.notificationEnemyNecromancer;
         this.notificationEnemySkeletor = param1.notificationEnemySkeletor;
         this.notificationEnemySkeletorBig = param1.notificationEnemySkeletorBig;
         this.notificationEnemyLavaElemental = param1.notificationEnemyLavaElemental;
         this.notificationEnemyJuggernaut = param1.notificationEnemyJuggernaut;
         this.notificationEnemyYetiBoss = param1.notificationEnemyYetiBoss;
         this.notificationEnemyVeznan = param1.notificationEnemyVeznan;
         this.notificationEnemySarelgazSmall = param1.notificationEnemySarelgazSmall;
         this.notificationEnemySarelgaz = param1.notificationEnemySarelgaz;
         this.notificationEnemyOrcArmored = param1.notificationEnemyOrcArmored;
         this.notificationEnemyGoblinZapper = param1.notificationEnemyGoblinZapper;
         this.notificationEnemyOrcWolfRider = param1.notificationEnemyOrcWolfRider;
         this.notificationEnemyForestTroll = param1.notificationEnemyForestTroll;
         this.notificationEnemyBossGoblinChieftain = param1.notificationEnemyBossGoblinChieftain;
      }
      
      public function §_-BZ§() : Object
      {
         var _loc1_:Object = new Object();
         _loc1_.notificationTowerArchersLevel2 = this.notificationTowerArchersLevel2;
         _loc1_.notificationTowerArchersLevel3 = this.notificationTowerArchersLevel3;
         _loc1_.notificationTowerArchersRanger = this.notificationTowerArchersRanger;
         _loc1_.notificationTowerArchersMusketeer = this.notificationTowerArchersMusketeer;
         _loc1_.notificationTowerSoldiersLevel2 = this.notificationTowerSoldiersLevel2;
         _loc1_.notificationTowerSoldiersLevel3 = this.notificationTowerSoldiersLevel3;
         _loc1_.notificationTowerSoldiersPaladin = this.notificationTowerSoldiersPaladin;
         _loc1_.notificationTowerSoldiersBarbarian = this.notificationTowerSoldiersBarbarian;
         _loc1_.notificationTowerMagesLevel2 = this.notificationTowerMagesLevel2;
         _loc1_.notificationTowerMagesLevel3 = this.notificationTowerMagesLevel3;
         _loc1_.notificationTowerMagesArcane = this.notificationTowerMagesArcane;
         _loc1_.notificationTowerMagesSorcerer = this.notificationTowerMagesSorcerer;
         _loc1_.notificationTowerEngineersLevel2 = this.notificationTowerEngineersLevel2;
         _loc1_.notificationTowerEngineersLevel3 = this.notificationTowerEngineersLevel3;
         _loc1_.notificationTowerEngineersBfg = this.notificationTowerEngineersBfg;
         _loc1_.notificationTowerEngineersTesla = this.notificationTowerEngineersTesla;
         _loc1_.notificationEnemyGoblin = this.notificationEnemyGoblin;
         _loc1_.notificationEnemyFatOrc = this.notificationEnemyFatOrc;
         _loc1_.notificationEnemyShaman = this.notificationEnemyShaman;
         _loc1_.notificationEnemyOgre = this.notificationEnemyOgre;
         _loc1_.notificationEnemyBandit = this.notificationEnemyBandit;
         _loc1_.notificationEnemyBrigand = this.notificationEnemyBrigand;
         _loc1_.notificationEnemyMarauder = this.notificationEnemyMarauder;
         _loc1_.notificationEnemySpider = this.notificationEnemySpider;
         _loc1_.notificationEnemySpiderSmall = this.notificationEnemySpiderSmall;
         _loc1_.notificationEnemyGargoyle = this.notificationEnemyGargoyle;
         _loc1_.notificationEnemyShadowArcher = this.notificationEnemyShadowArcher;
         _loc1_.notificationEnemyDarkKnight = this.notificationEnemyDarkKnight;
         _loc1_.notificationEnemySmallWolf = this.notificationEnemySmallWolf;
         _loc1_.notificationEnemyWolf = this.notificationEnemyWolf;
         _loc1_.notificationEnemyGolemHead = this.notificationEnemyGolemHead;
         _loc1_.notificationEnemyWhiteWolf = this.notificationEnemyWhiteWolf;
         _loc1_.notificationEnemyTroll = this.notificationEnemyTroll;
         _loc1_.notificationEnemyTrollAxeThrower = this.notificationEnemyTrollAxeThrower;
         _loc1_.notificationEnemyTrollChieftain = this.notificationEnemyTrollChieftain;
         _loc1_.notificationEnemyYeti = this.notificationEnemyYeti;
         _loc1_.notificationEnemyRocketeer = this.notificationEnemyRocketeer;
         _loc1_.notificationEnemyDarkSlayer = this.notificationEnemyDarkSlayer;
         _loc1_.notificationEnemyDemon = this.notificationEnemyDemon;
         _loc1_.notificationEnemyDemonMage = this.notificationEnemyDemonMage;
         _loc1_.notificationEnemyDemonWolf = this.notificationEnemyDemonWolf;
         _loc1_.notificationEnemyDemonImp = this.notificationEnemyDemonImp;
         _loc1_.notificationEnemyNecromancer = this.notificationEnemyNecromancer;
         _loc1_.notificationEnemySkeletor = this.notificationEnemySkeletor;
         _loc1_.notificationEnemySkeletorBig = this.notificationEnemySkeletorBig;
         _loc1_.notificationEnemyLavaElemental = this.notificationEnemyLavaElemental;
         _loc1_.notificationEnemyVeznan = this.notificationEnemyVeznan;
         _loc1_.notificationEnemyJuggernaut = this.notificationEnemyJuggernaut;
         _loc1_.notificationEnemyYetiBoss = this.notificationEnemyYetiBoss;
         _loc1_.notificationEnemySarelgazSmall = this.notificationEnemySarelgazSmall;
         _loc1_.notificationEnemySarelgaz = this.notificationEnemySarelgaz;
         _loc1_.notificationEnemyOrcArmored = this.notificationEnemyOrcArmored;
         _loc1_.notificationEnemyGoblinZapper = this.notificationEnemyGoblinZapper;
         _loc1_.notificationEnemyOrcWolfRider = this.notificationEnemyOrcWolfRider;
         _loc1_.notificationEnemyForestTroll = this.notificationEnemyForestTroll;
         _loc1_.notificationEnemyBossGoblinChieftain = this.notificationEnemyBossGoblinChieftain;
         return _loc1_;
      }
      
      public function destroyThis() : void
      {
         this.game = null;
      }
   }
}