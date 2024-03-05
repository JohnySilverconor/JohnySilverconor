public class GameUpgrades
{
    public int archersUpLevel = 0;
    public bool archersUpSalvage = false;
    public bool archersUpEagleEye = false;
    public bool archersUpPiercing = false;
    public bool archersUpFarShots = false;
    public bool archersUpPrecision = false;
    public int barracksUpLevel = 0;
    public bool barracksUpSurvival = false;
    public bool barracksUpBetterArmor = false;
    public bool barracksUpImprovedDeployment = false;
    public bool barracksUpBarbedArmor = false;
    public bool barracksUpSurvival2 = false;
    public int magesUpLevel = 0;
    public bool magesUpSpellReach = false;
    public bool magesUpArcaneShatter = false;
    public bool magesUpHermeticStudy = false;
    public bool magesUpEmpoweredMagic = false;
    public bool magesUpSlowCurse = false;
    public int magesUpArcaneShatterDamage = 3;
    public int engineersUpLevel = 0;
    public bool engineersUpConcentratedFire = false;
    public bool engineersUpRangeFinder = false;
    public bool engineersUpFieldLogistics = false;
    public bool engineersUpIndustrialization = false;
    public bool engineersUpEfficiency = false;
    public int rainUpLevel = 0;
    public bool rainUpBlazingSkies = false;
    public bool rainUpScorchedEarth = false;
    public bool rainsUpBiggerAndMeaner = false;
    public bool rainUpBlazingEarth = false;
    public bool rainUpCataclysm = false;
    public int reinforcementLevel = 0;
    public Game game;

    public GameUpgrades(Game game)
    {
        this.game = game;
    }

    public void ResetUpgrades()
    {
        archersUpLevel = 0;
        archersUpSalvage = false;
        archersUpEagleEye = false;
        archersUpPiercing = false;
        archersUpFarShots = false;
        archersUpPrecision = false;
        barracksUpLevel = 0;
        barracksUpSurvival = false;
        barracksUpBetterArmor = false;
        barracksUpImprovedDeployment = false;
        barracksUpBarbedArmor = false;
        barracksUpSurvival2 = false;
        magesUpLevel = 0;
        magesUpSpellReach = false;
        magesUpArcaneShatter = false;
        magesUpHermeticStudy = false;
        magesUpEmpoweredMagic = false;
        magesUpSlowCurse = false;
        engineersUpLevel = 0;
        engineersUpConcentratedFire = false;
        engineersUpRangeFinder = false;
        engineersUpFieldLogistics = false;
        engineersUpIndustrialization = false;
        engineersUpEfficiency = false;
        rainUpLevel = 0;
        rainUpBlazingSkies = false;
        rainUpScorchedEarth = false;
        rainsUpBiggerAndMeaner = false;
        rainUpBlazingEarth = false;
        rainUpCataclysm = false;
        reinforcementLevel = 0;
    }

    public void Upgrade(string upgradeName)
    {
        switch (upgradeName)
        {
            case "archersUpSalvage":
                archersUpLevel = 1;
                archersUpSalvage = true;
                break;
            case "archersUpEagleEye":
                archersUpLevel = 2;
                archersUpEagleEye = true;
                break;
            case "archersUpPiercing":
                archersUpLevel = 3;
                archersUpPiercing = true;
                break;
            case "archersUpFarShots":
                archersUpLevel = 4;
                archersUpFarShots = true;
                break;
            case "archersUpPrecision":
                archersUpLevel = 5;
                archersUpPrecision = true;
                break;
            case "barracksUpSurvival":
                barracksUpLevel = 1;
                barracksUpSurvival = true;
                break;
            case "barracksUpBetterArmor":
                barracksUpLevel = 2;
                barracksUpBetterArmor = true;
                break;
            case "barracksUpImprovedDeployment":
                barracksUpLevel = 3;
                barracksUpImprovedDeployment = true;
                break;
            case "barracksUpSurvival2":
                barracksUpLevel = 4;
                barracksUpSurvival2 = true;
                break;
            case "barracksUpBarbedArmor":
                barracksUpLevel = 5;
                barracksUpBarbedArmor = true;
                break;
            case "magesUpSpellReach":
                magesUpLevel = 1;
                magesUpSpellReach = true;
                break;
            case "magesUpArcaneShatter":
                magesUpLevel = 2;
                magesUpArcaneShatter = true;
                break;
            case "magesUpHermeticStudy":
                magesUpLevel = 3;
                magesUpHermeticStudy = true;
                break;
            case "magesUpEmpoweredMagic":
                magesUpLevel = 4;
                magesUpEmpoweredMagic = true;
                break;
            case "magesUpSlowCurse":
                magesUpLevel = 5;
                magesUpSlowCurse = true;
                break;
            case "engineersUpConcentratedFire":
                engineersUpLevel = 1;
                engineersUpConcentratedFire = true;
                break;
            case "engineersUpRangeFinder":
                engineersUpLevel = 2;
                engineersUpRangeFinder = true;
                break;
            case "engineersUpFieldLogistics":
                engineersUpLevel = 3;
                engineersUpFieldLogistics = true;
                break;
            case "engineersUpIndustrialization":
                engineersUpLevel = 4;
                engineersUpIndustrialization = true;
                break;
            case "engineersUpEfficiency":
                engineersUpLevel = 5;
                engineersUpEfficiency = true;
                break;
            case "rainUpBlazingSkies":
                rainUpLevel = 1;
                rainUpBlazingSkies = true;
                break;
            case "rainUpScorchedEarth":
                rainUpLevel = 2;
                rainUpScorchedEarth = true;
                break;
            case "rainsUpBiggerAndMeaner":
                rainUpLevel = 3;
                rainsUpBiggerAndMeaner = true;
                break;
            case "rainUpBlazingEarth":
                rainUpLevel = 4;
                rainUpBlazingEarth = true;
                break;
            case "rainUpCataclysm":
                rainUpLevel = 5;
                rainUpCataclysm = true;
                break;
            case "reinforcementLevel1":
                reinforcementLevel = 1;
                break;
            case "reinforcementLevel2":
                reinforcementLevel = 2;
                break;
            case "reinforcementLevel3":
                reinforcementLevel = 3;
                break;
            case "reinforcementLevel4":
                reinforcementLevel = 4;
                break;
            case "reinforcementLevel5":
                reinforcementLevel = 5;
                break;
        }
    }

    public void RemoveUpgrade(string upgradeName)
    {
        switch (upgradeName)
        {
            case "archersUpSalvage":
                archersUpLevel = 0;
                archersUpSalvage = false;
                break;
            case "archersUpEagleEye":
                archersUpLevel = 1;
                archersUpEagleEye = false;
                break;
            case "archersUpPiercing":
                archersUpLevel = 2;
                archersUpPiercing = false;
                break;
            case "archersUpFarShots":
                archersUpLevel = 3;
                archersUpFarShots = false;
                break;
            case "archersUpPrecision":
                archersUpLevel = 4;
                archersUpPrecision = false;
                break;
            case "barracksUpSurvival":
                barracksUpLevel = 0;
                barracksUpSurvival = false;
                break;
            case "barracksUpBetterArmor":
                barracksUpLevel = 1;
                barracksUpBetterArmor = false;
                break;
            case "barracksUpImprovedDeployment":
                barracksUpLevel = 2;
                barracksUpImprovedDeployment = false;
                break;
            case "barracksUpSurvival2":
                barracksUpLevel = 3;
                barracksUpSurvival2 = false;
                break;
            case "barracksUpBarbedArmor":
                barracksUpLevel = 4;
                barracksUpBarbedArmor = false;
                break;
            case "magesUpSpellReach":
                magesUpLevel = 0;
                magesUpSpellReach = false;
                break;
            case "magesUpArcaneShatter":
                magesUpLevel = 1;
                magesUpArcaneShatter = false;
                break;
            case "magesUpHermeticStudy":
                magesUpLevel = 2;
                magesUpHermeticStudy = false;
                break;
            case "magesUpEmpoweredMagic":
                magesUpLevel = 3;
                magesUpEmpoweredMagic = false;
                break;
            case "magesUpSlowCurse":
                magesUpLevel = 4;
                magesUpSlowCurse = false;
                break;
            case "engineersUpConcentratedFire":
                engineersUpLevel = 0;
                engineersUpConcentratedFire = false;
                break;
            case "engineersUpRangeFinder":
                engineersUpLevel = 1;
                engineersUpRangeFinder = false;
                break;
            case "engineersUpFieldLogistics":
                engineersUpLevel = 2;
                engineersUpFieldLogistics = false;
                break;
            case "engineersUpIndustrialization":
                engineersUpLevel = 3;
                engineersUpIndustrialization = false;
                break;
            case "engineersUpEfficiency":
                engineersUpLevel = 4;
                engineersUpEfficiency = false;
                break;
            case "rainUpBlazingSkies":
                rainUpLevel = 0;
                rainUpBlazingSkies = false;
                break;
            case "rainUpScorchedEarth":
                rainUpLevel = 1;
                rainUpScorchedEarth = false;
                break;
            case "rainsUpBiggerAndMeaner":
                rainUpLevel = 2;
                rainsUpBiggerAndMeaner = false;
                break;
            case "rainUpBlazingEarth":
                rainUpLevel = 3;
                rainUpBlazingEarth = false;
                break;
            case "rainUpCataclysm":
                rainUpLevel = 4;
                rainUpCataclysm = false;
                break;
            case "reinforcementLevel1":
                reinforcementLevel = 0;
                break;
            case "reinforcementLevel2":
                reinforcementLevel = 1;
                break;
            case "reinforcementLevel3":
                reinforcementLevel = 2;
                break;
            case "reinforcementLevel4":
                reinforcementLevel = 3;
                break;
            case "reinforcementLevel5":
                reinforcementLevel = 4;
                break;
        }
    }

    public void SaveData()
    {
        if (!game.isLocal)
        {
            // Save data to server
        }
        else
        {
            // Save data to local storage
        }
    }

    public void LoadData()
    {
        if (!game.isLocal)
        {
            // Load data from server
        }
        else
        {
            // Load data from local storage
        }
    }

    public void Destroy()
    {
        game = null;
    }
}

//javascript

public class GameUpgrades
   {
       
      
      public var archersUpLevel:int = 0;
      
      public var archersUpSalvage:Boolean = false;
      
      public var archersUpEagleEye:Boolean = false;
      
      public var archersUpPiercing:Boolean = false;
      
      public var archersUpFarShots:Boolean = false;
      
      public var archersUpPrecision:Boolean = false;
      
      public var barracksUpLevel:int = 0;
      
      public var barracksUpSurvival:Boolean = false;
      
      public var barracksUpBetterArmor:Boolean = false;
      
      public var barracksUpImprovedDeployment:Boolean = false;
      
      public var barracksUpBarbedArmor:Boolean = false;
      
      public var barracksUpSurvival2:Boolean = false;
      
      public var magesUpLevel:int = 0;
      
      public var magesUpSpellReach:Boolean = false;
      
      public var magesUpArcaneShatter:Boolean = false;
      
      public var magesUpHermeticStudy:Boolean = false;
      
      public var magesUpEmpoweredMagic:Boolean = false;
      
      public var magesUpSlowCurse:Boolean = false;
      
      public var magesUpArcaneShatterDamage:int = 3;
      
      public var engineersUpLevel:int = 0;
      
      public var engineersUpConcentratedFire:Boolean = false;
      
      public var engineersUpRangeFinder:Boolean = false;
      
      public var engineersUpFieldLogistics:Boolean = false;
      
      public var engineersUpIndustrialization:Boolean = false;
      
      public var engineersUpEfficiency:Boolean = false;
      
      public var rainUpLevel:int = 0;
      
      public var rainUpBlazingSkies:Boolean = false;
      
      public var rainUpScorchedEarth:Boolean = false;
      
      public var rainsUpBiggerAndMeaner:Boolean = false;
      
      public var rainUpBlazingEarth:Boolean = false;
      
      public var rainUpCataclysm:Boolean = false;
      
      public var reinforcementLevel:int = 0;
      
      public var game:Game;
      
      public function GameUpgrades(param1:Game)
      {
         super();
         this.game = param1;
      }
      
      public function §_-k§() : void
      {
         this.archersUpLevel = 0;
         this.archersUpSalvage = false;
         this.archersUpEagleEye = false;
         this.archersUpPiercing = false;
         this.archersUpFarShots = false;
         this.archersUpPrecision = false;
         this.barracksUpLevel = 0;
         this.barracksUpSurvival = false;
         this.barracksUpBetterArmor = false;
         this.barracksUpImprovedDeployment = false;
         this.barracksUpBarbedArmor = false;
         this.barracksUpSurvival2 = false;
         this.magesUpLevel = 0;
         this.magesUpSpellReach = false;
         this.magesUpArcaneShatter = false;
         this.magesUpHermeticStudy = false;
         this.magesUpEmpoweredMagic = false;
         this.magesUpSlowCurse = false;
         this.engineersUpLevel = 0;
         this.engineersUpConcentratedFire = false;
         this.engineersUpRangeFinder = false;
         this.engineersUpFieldLogistics = false;
         this.engineersUpIndustrialization = false;
         this.engineersUpEfficiency = false;
         this.rainUpLevel = 0;
         this.rainUpBlazingSkies = false;
         this.rainUpScorchedEarth = false;
         this.rainsUpBiggerAndMeaner = false;
         this.rainUpBlazingEarth = false;
         this.rainUpCataclysm = false;
         this.reinforcementLevel = 0;
      }
      
      public function §_-Kn§(param1:String) : void
      {
         switch(param1)
         {
            case "archersUpSalvage":
               this.archersUpLevel = 1;
               this.archersUpSalvage = true;
               break;
            case "archersUpEagleEye":
               this.archersUpLevel = 2;
               this.archersUpEagleEye = true;
               break;
            case "archersUpPiercing":
               this.archersUpLevel = 3;
               this.archersUpPiercing = true;
               break;
            case "archersUpFarShots":
               this.archersUpLevel = 4;
               this.archersUpFarShots = true;
               break;
            case "archersUpPrecision":
               this.archersUpLevel = 5;
               this.archersUpPrecision = true;
               break;
            case "barracksUpSurvival":
               this.barracksUpLevel = 1;
               this.barracksUpSurvival = true;
               break;
            case "barracksUpBetterArmor":
               this.barracksUpLevel = 2;
               this.barracksUpBetterArmor = true;
               break;
            case "barracksUpImprovedDeployment":
               this.barracksUpLevel = 3;
               this.barracksUpImprovedDeployment = true;
               break;
            case "barracksUpSurvival2":
               this.barracksUpLevel = 4;
               this.barracksUpSurvival2 = true;
               break;
            case "barracksUpBarbedArmor":
               this.barracksUpLevel = 5;
               this.barracksUpBarbedArmor = true;
               break;
            case "magesUpSpellReach":
               this.magesUpLevel = 1;
               this.magesUpSpellReach = true;
               break;
            case "magesUpArcaneShatter":
               this.magesUpLevel = 2;
               this.magesUpArcaneShatter = true;
               break;
            case "magesUpHermeticStudy":
               this.magesUpLevel = 3;
               this.magesUpHermeticStudy = true;
               break;
            case "magesUpEmpoweredMagic":
               this.magesUpLevel = 4;
               this.magesUpEmpoweredMagic = true;
               break;
            case "magesUpSlowCurse":
               this.magesUpLevel = 5;
               this.magesUpSlowCurse = true;
               break;
            case "engineersUpConcentratedFire":
               this.engineersUpLevel = 1;
               this.engineersUpConcentratedFire = true;
               break;
            case "engineersUpRangeFinder":
               this.engineersUpLevel = 2;
               this.engineersUpRangeFinder = true;
               break;
            case "engineersUpFieldLogistics":
               this.engineersUpLevel = 3;
               this.engineersUpFieldLogistics = true;
               break;
            case "engineersUpIndustrialization":
               this.engineersUpLevel = 4;
               this.engineersUpIndustrialization = true;
               break;
            case "engineersUpEfficiency":
               this.engineersUpLevel = 5;
               this.engineersUpEfficiency = true;
               break;
            case "rainUpBlazingSkies":
               this.rainUpLevel = 1;
               this.rainUpBlazingSkies = true;
               break;
            case "rainUpScorchedEarth":
               this.rainUpLevel = 2;
               this.rainUpScorchedEarth = true;
               break;
            case "rainsUpBiggerAndMeaner":
               this.rainUpLevel = 3;
               this.rainsUpBiggerAndMeaner = true;
               break;
            case "rainUpBlazingEarth":
               this.rainUpLevel = 4;
               this.rainUpBlazingEarth = true;
               break;
            case "rainUpCataclysm":
               this.rainUpLevel = 5;
               this.rainUpCataclysm = true;
               break;
            case "reinforcementLevel1":
               this.reinforcementLevel = 1;
               break;
            case "reinforcementLevel2":
               this.reinforcementLevel = 2;
               break;
            case "reinforcementLevel3":
               this.reinforcementLevel = 3;
               break;
            case "reinforcementLevel4":
               this.reinforcementLevel = 4;
               break;
            case "reinforcementLevel5":
               this.reinforcementLevel = 5;
         }
      }
      
      public function §_-AO§(param1:String) : void
      {
         switch(param1)
         {
            case "archersUpSalvage":
               this.archersUpLevel = 0;
               this.archersUpSalvage = false;
               break;
            case "archersUpEagleEye":
               this.archersUpLevel = 1;
               this.archersUpEagleEye = false;
               break;
            case "archersUpPiercing":
               this.archersUpLevel = 2;
               this.archersUpPiercing = false;
               break;
            case "archersUpFarShots":
               this.archersUpLevel = 3;
               this.archersUpFarShots = false;
               break;
            case "archersUpPrecision":
               this.archersUpLevel = 4;
               this.archersUpPrecision = false;
               break;
            case "barracksUpSurvival":
               this.barracksUpLevel = 0;
               this.barracksUpSurvival = false;
               break;
            case "barracksUpBetterArmor":
               this.barracksUpLevel = 1;
               this.barracksUpBetterArmor = false;
               break;
            case "barracksUpImprovedDeployment":
               this.barracksUpLevel = 2;
               this.barracksUpImprovedDeployment = false;
               break;
            case "barracksUpSurvival2":
               this.barracksUpLevel = 3;
               this.barracksUpSurvival2 = false;
               break;
            case "barracksUpBarbedArmor":
               this.barracksUpLevel = 4;
               this.barracksUpBarbedArmor = false;
               break;
            case "magesUpSpellReach":
               this.magesUpLevel = 0;
               this.magesUpSpellReach = false;
               break;
            case "magesUpArcaneShatter":
               this.magesUpLevel = 1;
               this.magesUpArcaneShatter = false;
               break;
            case "magesUpHermeticStudy":
               this.magesUpLevel = 2;
               this.magesUpHermeticStudy = false;
               break;
            case "magesUpEmpoweredMagic":
               this.magesUpLevel = 3;
               this.magesUpEmpoweredMagic = false;
               break;
            case "magesUpSlowCurse":
               this.magesUpLevel = 4;
               this.magesUpSlowCurse = false;
               break;
            case "engineersUpConcentratedFire":
               this.engineersUpLevel = 0;
               this.engineersUpConcentratedFire = false;
               break;
            case "engineersUpRangeFinder":
               this.engineersUpLevel = 1;
               this.engineersUpRangeFinder = false;
               break;
            case "engineersUpFieldLogistics":
               this.engineersUpLevel = 2;
               this.engineersUpFieldLogistics = false;
               break;
            case "engineersUpIndustrialization":
               this.engineersUpLevel = 3;
               this.engineersUpIndustrialization = false;
               break;
            case "engineersUpEfficiency":
               this.engineersUpLevel = 4;
               this.engineersUpEfficiency = false;
               break;
            case "rainUpBlazingSkies":
               this.rainUpLevel = 0;
               this.rainUpBlazingSkies = false;
               break;
            case "rainUpScorchedEarth":
               this.rainUpLevel = 1;
               this.rainUpScorchedEarth = false;
               break;
            case "rainsUpBiggerAndMeaner":
               this.rainUpLevel = 2;
               this.rainsUpBiggerAndMeaner = false;
               break;
            case "rainUpBlazingEarth":
               this.rainUpLevel = 3;
               this.rainUpBlazingEarth = false;
               break;
            case "rainUpCataclysm":
               this.rainUpLevel = 4;
               this.rainUpCataclysm = false;
               break;
            case "reinforcementLevel1":
               this.reinforcementLevel = 0;
               break;
            case "reinforcementLevel2":
               this.reinforcementLevel = 1;
               break;
            case "reinforcementLevel3":
               this.reinforcementLevel = 2;
               break;
            case "reinforcementLevel4":
               this.reinforcementLevel = 3;
               break;
            case "reinforcementLevel5":
               this.reinforcementLevel = 4;
         }
      }
      
      public function saveData() : void
      {
         var my_so:SharedObject = null;
         if(!this.game.§_-Ll§)
         {
            try
            {
               my_so = SharedObject.getLocal(this.game.selectedSlot);
               my_so.data.upgrades.archersUpLevel = this.archersUpLevel;
               my_so.data.upgrades.archersUpSalvage = this.archersUpSalvage;
               my_so.data.upgrades.archersUpEagleEye = this.archersUpEagleEye;
               my_so.data.upgrades.archersUpPiercing = this.archersUpPiercing;
               my_so.data.upgrades.archersUpFarShots = this.archersUpFarShots;
               my_so.data.upgrades.archersUpPrecision = this.archersUpPrecision;
               my_so.data.upgrades.barracksUpLevel = this.barracksUpLevel;
               my_so.data.upgrades.barracksUpSurvival = this.barracksUpSurvival;
               my_so.data.upgrades.barracksUpBetterArmor = this.barracksUpBetterArmor;
               my_so.data.upgrades.barracksUpImprovedDeployment = this.barracksUpImprovedDeployment;
               my_so.data.upgrades.barracksUpBarbedArmor = this.barracksUpBarbedArmor;
               my_so.data.upgrades.barracksUpSurvival2 = this.barracksUpSurvival2;
               my_so.data.upgrades.magesUpLevel = this.magesUpLevel;
               my_so.data.upgrades.magesUpSpellReach = this.magesUpSpellReach;
               my_so.data.upgrades.magesUpArcaneShatter = this.magesUpArcaneShatter;
               my_so.data.upgrades.magesUpHermeticStudy = this.magesUpHermeticStudy;
               my_so.data.upgrades.magesUpEmpoweredMagic = this.magesUpEmpoweredMagic;
               my_so.data.upgrades.magesUpSlowCurse = this.magesUpSlowCurse;
               my_so.data.upgrades.engineersUpLevel = this.engineersUpLevel;
               my_so.data.upgrades.engineersUpConcentratedFire = this.engineersUpConcentratedFire;
               my_so.data.upgrades.engineersUpRangeFinder = this.engineersUpRangeFinder;
               my_so.data.upgrades.engineersUpFieldLogistics = this.engineersUpFieldLogistics;
               my_so.data.upgrades.engineersUpIndustrialization = this.engineersUpIndustrialization;
               my_so.data.upgrades.engineersUpEfficiency = this.engineersUpEfficiency;
               my_so.data.upgrades.rainUpLevel = this.rainUpLevel;
               my_so.data.upgrades.rainUpBlazingSkies = this.rainUpBlazingSkies;
               my_so.data.upgrades.rainUpScorchedEarth = this.rainUpScorchedEarth;
               my_so.data.upgrades.rainsUpBiggerAndMeaner = this.rainsUpBiggerAndMeaner;
               my_so.data.upgrades.rainUpBlazingEarth = this.rainUpBlazingEarth;
               my_so.data.upgrades.rainUpCataclysm = this.rainUpCataclysm;
               my_so.data.upgrades.reinforcementLevel = this.reinforcementLevel;
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
            this.archersUpLevel = § 0§.data.upgrades.archersUpLevel;
            this.archersUpSalvage = § 0§.data.upgrades.archersUpSalvage;
            this.archersUpEagleEye = § 0§.data.upgrades.archersUpEagleEye;
            this.archersUpPiercing = § 0§.data.upgrades.archersUpPiercing;
            this.archersUpFarShots = § 0§.data.upgrades.archersUpFarShots;
            this.archersUpPrecision = § 0§.data.upgrades.archersUpPrecision;
            this.barracksUpLevel = § 0§.data.upgrades.barracksUpLevel;
            this.barracksUpSurvival = § 0§.data.upgrades.barracksUpSurvival;
            this.barracksUpBetterArmor = § 0§.data.upgrades.barracksUpBetterArmor;
            this.barracksUpImprovedDeployment = § 0§.data.upgrades.barracksUpImprovedDeployment;
            this.barracksUpBarbedArmor = § 0§.data.upgrades.barracksUpBarbedArmor;
            this.barracksUpSurvival2 = § 0§.data.upgrades.barracksUpSurvival2;
            this.magesUpLevel = § 0§.data.upgrades.magesUpLevel;
            this.magesUpSpellReach = § 0§.data.upgrades.magesUpSpellReach;
            this.magesUpArcaneShatter = § 0§.data.upgrades.magesUpArcaneShatter;
            this.magesUpHermeticStudy = § 0§.data.upgrades.magesUpHermeticStudy;
            this.magesUpEmpoweredMagic = § 0§.data.upgrades.magesUpEmpoweredMagic;
            this.magesUpSlowCurse = § 0§.data.upgrades.magesUpSlowCurse;
            this.engineersUpLevel = § 0§.data.upgrades.engineersUpLevel;
            this.engineersUpConcentratedFire = § 0§.data.upgrades.engineersUpConcentratedFire;
            this.engineersUpRangeFinder = § 0§.data.upgrades.engineersUpRangeFinder;
            this.engineersUpFieldLogistics = § 0§.data.upgrades.engineersUpFieldLogistics;
            this.engineersUpIndustrialization = § 0§.data.upgrades.engineersUpIndustrialization;
            this.engineersUpEfficiency = § 0§.data.upgrades.engineersUpEfficiency;
            this.rainUpLevel = § 0§.data.upgrades.rainUpLevel;
            this.rainUpBlazingSkies = § 0§.data.upgrades.rainUpBlazingSkies;
            this.rainUpScorchedEarth = § 0§.data.upgrades.rainUpScorchedEarth;
            this.rainsUpBiggerAndMeaner = § 0§.data.upgrades.rainsUpBiggerAndMeaner;
            this.rainUpBlazingEarth = § 0§.data.upgrades.rainUpBlazingEarth;
            this.rainUpCataclysm = § 0§.data.upgrades.rainUpCataclysm;
            this.reinforcementLevel = § 0§.data.upgrades.reinforcementLevel;
            § 0§.flush();
            § 0§.close();
         }
         catch(err:Error)
         {
         }
      }
      
      public function §_-MM§(param1:Object) : void
      {
         this.archersUpLevel = param1.archersUpLevel;
         this.archersUpSalvage = param1.archersUpSalvage;
         this.archersUpEagleEye = param1.archersUpEagleEye;
         this.archersUpPiercing = param1.archersUpPiercing;
         this.archersUpFarShots = param1.archersUpFarShots;
         this.archersUpPrecision = param1.archersUpPrecision;
         this.barracksUpLevel = param1.barracksUpLevel;
         this.barracksUpSurvival = param1.barracksUpSurvival;
         this.barracksUpBetterArmor = param1.barracksUpBetterArmor;
         this.barracksUpImprovedDeployment = param1.barracksUpImprovedDeployment;
         this.barracksUpBarbedArmor = param1.barracksUpBarbedArmor;
         this.barracksUpSurvival2 = param1.barracksUpSurvival2;
         this.magesUpLevel = param1.magesUpLevel;
         this.magesUpSpellReach = param1.magesUpSpellReach;
         this.magesUpArcaneShatter = param1.magesUpArcaneShatter;
         this.magesUpHermeticStudy = param1.magesUpHermeticStudy;
         this.magesUpEmpoweredMagic = param1.magesUpEmpoweredMagic;
         this.magesUpSlowCurse = param1.magesUpSlowCurse;
         this.engineersUpLevel = param1.engineersUpLevel;
         this.engineersUpConcentratedFire = param1.engineersUpConcentratedFire;
         this.engineersUpRangeFinder = param1.engineersUpRangeFinder;
         this.engineersUpFieldLogistics = param1.engineersUpFieldLogistics;
         this.engineersUpIndustrialization = param1.engineersUpIndustrialization;
         this.engineersUpEfficiency = param1.engineersUpEfficiency;
         this.rainUpLevel = param1.rainUpLevel;
         this.rainUpBlazingSkies = param1.rainUpBlazingSkies;
         this.rainUpScorchedEarth = param1.rainUpScorchedEarth;
         this.rainsUpBiggerAndMeaner = param1.rainsUpBiggerAndMeaner;
         this.rainUpBlazingEarth = param1.rainUpBlazingEarth;
         this.rainUpCataclysm = param1.rainUpCataclysm;
         this.reinforcementLevel = param1.reinforcementLevel;
      }
      
      public function §_-8G§() : Object
      {
         var _loc1_:Object = new Object();
         _loc1_.archersUpLevel = this.archersUpLevel;
         _loc1_.archersUpSalvage = this.archersUpSalvage;
         _loc1_.archersUpEagleEye = this.archersUpEagleEye;
         _loc1_.archersUpPiercing = this.archersUpPiercing;
         _loc1_.archersUpFarShots = this.archersUpFarShots;
         _loc1_.archersUpPrecision = this.archersUpPrecision;
         _loc1_.barracksUpLevel = this.barracksUpLevel;
         _loc1_.barracksUpSurvival = this.barracksUpSurvival;
         _loc1_.barracksUpBetterArmor = this.barracksUpBetterArmor;
         _loc1_.barracksUpImprovedDeployment = this.barracksUpImprovedDeployment;
         _loc1_.barracksUpBarbedArmor = this.barracksUpBarbedArmor;
         _loc1_.barracksUpSurvival2 = this.barracksUpSurvival2;
         _loc1_.magesUpLevel = this.magesUpLevel;
         _loc1_.magesUpSpellReach = this.magesUpSpellReach;
         _loc1_.magesUpArcaneShatter = this.magesUpArcaneShatter;
         _loc1_.magesUpHermeticStudy = this.magesUpHermeticStudy;
         _loc1_.magesUpEmpoweredMagic = this.magesUpEmpoweredMagic;
         _loc1_.magesUpSlowCurse = this.magesUpSlowCurse;
         _loc1_.engineersUpLevel = this.engineersUpLevel;
         _loc1_.engineersUpConcentratedFire = this.engineersUpConcentratedFire;
         _loc1_.engineersUpRangeFinder = this.engineersUpRangeFinder;
         _loc1_.engineersUpFieldLogistics = this.engineersUpFieldLogistics;
         _loc1_.engineersUpIndustrialization = this.engineersUpIndustrialization;
         _loc1_.engineersUpEfficiency = this.engineersUpEfficiency;
         _loc1_.rainUpLevel = this.rainUpLevel;
         _loc1_.rainUpBlazingSkies = this.rainUpBlazingSkies;
         _loc1_.rainUpScorchedEarth = this.rainUpScorchedEarth;
         _loc1_.rainsUpBiggerAndMeaner = this.rainsUpBiggerAndMeaner;
         _loc1_.rainUpBlazingEarth = this.rainUpBlazingEarth;
         _loc1_.rainUpCataclysm = this.rainUpCataclysm;
         _loc1_.reinforcementLevel = this.reinforcementLevel;
         return _loc1_;
      }
      
      public function destroyThis() : void
      {
         this.game = null;
      }
   }