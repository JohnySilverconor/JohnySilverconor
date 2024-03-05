using System;

public class GameSettings
{
    private Game game;
    private int maxUpgradeLevel;
    public const double §_-9b§ = 0.3;
    public const int pcStars = 15;
    public const int framesRate = 30;
    public const double rangeRatio = 0.7;
    public const double sellPercent = 0.6;
    public const double §_-Bk§ = 2;
    public const double minSpeed = 2;
    public const int enemyMaxLevel = 99;
    public const int buildingTime = 30;
    private double ModifEnemyHealth;
    private double ModifSoldierHealth;
    public object mages;
    public object archers;
    public object engineers;
    public object soldiers;
    public object powers;
    public object enemies;
    public object specials;
    public const int P_ARMOR = 0;
    public const int M_ARMOR = 1;
    public const int E_ARMOR = 2;
    public const int I_ARMOR = 3;

    public GameSettings(Game param1, bool param2 = true, int param3 = 0)
    {
        this.mages = new object();
        this.archers = new object();
        this.engineers = new object();
        this.soldiers = new object();
        this.powers = new object();
        this.enemies = new object();
        this.specials = new object();
        this.game = param1;
        if (this.game.difficulty == DIFFICULTY_EASY)
        {
            this.ModifEnemyHealth = 0.8;
            this.ModifSoldierHealth = 1.2;
        }
        else if (this.game.difficulty == DIFFICULTY_NORMAL || this.game.difficulty == §_-L1§)
        {
            this.ModifEnemyHealth = 1;
            this.ModifSoldierHealth = 1;
        }
        else if (this.game.difficulty == DIFFICULTY_HARD)
        {
            this.ModifEnemyHealth = 1.2;
            this.ModifSoldierHealth = 1;
        }
        this.maxUpgradeLevel = param3;
        this.§_-9-§();
        this.§_-Mo§();
        this.§_-2V§();
        this.§throw§();
        this.§_-L§();
        this.§_-9D§();
        this.§_-Ke§();
        if (param2)
        {
            this.§_-5E§();
        }
    }

    public object §_-ML§(string param1)
    {
        switch (param1)
        {
            case "EnemyGoblin":
                return Locale.loadStringEx("ENEMY_GOBLIN_NAME", Locale.getDefaultLang());
            case "EnemyFatOrc":
                return Locale.loadStringEx("ENEMY_FAT_ORC_NAME", Locale.getDefaultLang());
            case "EnemyOgre":
                return Locale.loadStringEx("ENEMY_OGRE_NAME", Locale.getDefaultLang());
            case "EnemyWolfSmall":
                return Locale.loadStringEx("ENEMY_WULF_NAME", Locale.getDefaultLang());
            case "EnemyShaman":
                return Locale.loadStringEx("ENEMY_SHAMAN_NAME", Locale.getDefaultLang());
            case "EnemyGargoyle":
                return Locale.loadStringEx("ENEMY_GARGOYLE_NAME", Locale.getDefaultLang());
            case "EnemySpider":
                return Locale.loadStringEx("ENEMY_SPIDER_NAME", Locale.getDefaultLang());
            case "EnemyBandit":
                return Locale.loadStringEx("ENEMY_BANDIT_NAME", Locale.getDefaultLang());
            case "EnemyBrigand":
                return Locale.loadStringEx("ENEMY_BRIGAND_NAME", Locale.getDefaultLang());
            case "EnemyMarauder":
                return Locale.loadStringEx("ENEMY_MARAUDER_NAME", Locale.getDefaultLang());
            case "EnemyWolf":
                return Locale.loadStringEx("ENEMY_WORG_NAME", Locale.getDefaultLang());
            case "EnemySpider":
                return Locale.loadStringEx("ENEMY_SPIDER_NAME", Locale.getDefaultLang());
            case "EnemySpiderSmall":
                return Locale.loadStringEx("ENEMY_SPIDERSMALL_NAME", Locale.getDefaultLang());
            case "EnemySpiderTiny":
                return Locale.loadStringEx("ENEMY_SPIDERTINY_NAME", Locale.getDefaultLang());
            case "EnemyShadowArcher":
                return Locale.loadStringEx("ENEMY_SHADOW_ARCHER_NAME", Locale.getDefaultLang());
            case "EnemyDarkKnight":
                return Locale.loadStringEx("ENEMY_DARK_NIGHT_NAME", Locale.getDefaultLang());
            case "EnemyJuggernaut":
                return Locale.loadStringEx("ENEMY_JUGGERNAUT_NAME", Locale.getDefaultLang());
            case "EnemyGolemHead":
                return Locale.loadStringEx("ENEMY_GOLEM_HEAD_NAME", Locale.getDefaultLang());
            case "EnemyWhiteWolf":
                return Locale.loadStringEx("ENEMY_WHITE_WOLF_NAME", Locale.getDefaultLang());
            case "EnemyTroll":
                return Locale.loadStringEx("ENEMY_TROLL_NAME", Locale.getDefaultLang());
            case "EnemyTrollChieftain":
                return Locale.loadStringEx("ENEMY_TROLL_CHIEFTAIN_NAME", Locale.getDefaultLang());
            case "EnemyTrollAxeThrower":
                return Locale.loadStringEx("ENEMY_TROLL_AXE_THROWER_NAME", Locale.getDefaultLang());
            case "EnemyYeti":
                return Locale.loadStringEx("ENEMY_YETI_NAME", Locale.getDefaultLang());
            case "EnemyBoss":
                return Locale.loadStringEx("ENEMY_YETI_BOSS_NAME", Locale.getDefaultLang());
            case "EnemyYetiBoss":
                return Locale.loadStringEx("ENEMY_YETI_BOSS_NAME", Locale.getDefaultLang());
            case "EnemySlayer":
                return Locale.loadStringEx("ENEMY_SLAYER_NAME", Locale.getDefaultLang());
            case "EnemyRocketeer":
                return Locale.loadStringEx("ENEMY_ROCKETEER_NAME", Locale.getDefaultLang());
            case "EnemyNecromancer":
                return Locale.loadStringEx("ENEMY_NECROMANCER_NAME", Locale.getDefaultLang());
            case "EnemySkeleton":
                return Locale.loadStringEx("ENEMY_SKELETON_NAME", Locale.getDefaultLang());
            case "EnemySkeletonBig":
                return Locale.loadStringEx("ENEMY_SKELETON_BIG_NAME", Locale.getDefaultLang());
            case "EnemyDemonWolf":
                return Locale.loadStringEx("ENEMY_DEMON_WOLF_NAME", Locale.getDefaultLang());
            case "EnemyDemon":
                return Locale.loadStringEx("ENEMY_DEMON_NAME", Locale.getDefaultLang());
            case "EnemyDemonMage":
                return Locale.loadStringEx("ENEMY_DEMON_MAGE_NAME", Locale.getDefaultLang());
            case "EnemyDemonWolf":
                return Locale.loadStringEx("ENEMY_DEMON_WOLF_NAME", Locale.getDefaultLang());
            case "EnemyDemonImp":
                return Locale.loadStringEx("ENEMY_DEMON_IMP_NAME", Locale.getDefaultLang());
            case "EnemyLavaElemental":
                return Locale.loadStringEx("ENEMY_LAVA_ELEMENTAL_NAME", Locale.getDefaultLang());
            case "EnemyVeznan":
                return Locale.loadStringEx("ENEMY_VEZNAN_NAME", Locale.getDefaultLang());
            case "EnemySarelgaz":
                return Locale.loadStringEx("ENEMY_SARELGAZ_NAME", Locale.getDefaultLang());
            case "EnemySarelgazSmall":
                return Locale.loadStringEx("ENEMY_SARELGAZ_SMALL_NAME", Locale.getDefaultLang());
            case "EnemyGoblinZapper":
                return Locale.loadStringEx("ENEMY_GOBLIN_ZAPPER_NAME", Locale.getDefaultLang());
            case "EnemyForestTroll":
                return Locale.loadStringEx("ENEMY_FOREST_TROLL_NAME", Locale.getDefaultLang());
            case "EnemyOrcWolfRider":
                return Locale.loadStringEx("ENEMY_ORC_WOLF_RIDER_NAME", Locale.getDefaultLang());
            case "EnemyOrcArmored":
                return Locale.loadStringEx("ENEMY_ORC_ARMORED_NAME", Locale.getDefaultLang());
            case "EnemyBossGoblinChieftain":
                return Locale.loadStringEx("ENEMY_BOSS_GOBLIN_CHIEFTAIN_NAME", Locale.getDefaultLang());
            default:
                return null;
        }
    }
private void §-Mo§() { var loc1 = new Object(); this.mages.building = loc1; var loc2 = new Object(); loc2.cost = 100; loc2.range = 220; loc2.minDamage = 9; loc2.maxDamage = 17; loc2.reload = 1.5 * this.framesRate; this.mages.level1 = loc2; var loc3 = new Object(); loc3.cost = 160; loc3.range = 250; loc3.minDamage = 23; loc3.maxDamage = 43; loc3.reload = 1.5 * this.framesRate; this.mages.level2 = loc3; var loc4 = new Object(); loc4.cost = 240; loc4.range = 280; loc4.minDamage = 40; loc4.maxDamage = 74; loc4.reload = 1.5 * this.framesRate; this.mages.level3 = loc4; var loc5 = new Object(); loc5.cost = 300; loc5.range = 310; loc5.minDamage = 76; loc5.maxDamage = 140; loc5.reload = 2 * this.framesRate; loc5.leathRayCost = 350; loc5.leathRayCostLevel = 200; loc5.leathRayCoolDown = 22 * this.framesRate; loc5.leathRayLessCoolDown = 2 * this.framesRate; loc5.leathRayLevels = 3; loc5.teleportCost = 300; loc5.teleportCostLevel = 100; loc5.teleportRange = 50; loc5.teleportMaxEnemies = 3; loc5.teleportExtraEnemies = 1; loc5.teleportNodes = 20; loc5.teleportExtraNodes = 5; loc5.teleportCoolDown = 10 * this.framesRate; loc5.teleportLevels = 3; loc5.teleportMaxTimes = 3; this.mages.arcane = loc5; var loc6 = new Object(); loc6.cost = 300; loc6.range = 310; loc6.minDamage = 42; loc6.maxDamage = 78; loc6.reload = 1.5 * this.framesRate; loc6.curseDamage = 10; loc6.curseArmorReduce = 50; loc6.curseDuration = 5 * this.framesRate; loc6.polymorphCost = 300; loc6.polymorphCostLevel = 150; loc6.polymorphDamage = 50; loc6.polymorphCoolDown = 22 * this.framesRate; loc6.polymorphLessCoolDown = 2 * this.framesRate; loc6.polymorphSpeedMultiplier = 1.5; loc6.polymorphLevels = 3; loc6.elementalRallyRange = 280; loc6.elementalMaxSize = §-D6§; loc6.elementalCost = 350; loc6.elementalCostLevel = 150; loc6.elementalMaxLevel = 10; loc6.elementalRange = 120; loc6.elementalHealth = 500; loc6.elementalExtraHealth = 100; loc6.elementalRegen = 20; loc6.elementalRegenReload = 1 * this.framesRate; loc6.elementalAreaAttackRangeWidth = 70; loc6.elementalAreaAttackMaxEnemies = 4; loc6.elementalMinDamage = 40; loc6.elementalMaxDamage = 80; loc6.elementalDamageExtra = 10; loc6.elementalArmor = 30; loc6.elementalArmorExtra = 10; loc6.elementalReload = 2 * this.framesRate; loc6.elementalRespawnTime = 8 * this.framesRate; loc6.elementalLevels = 3; this.mages.sorcerer = loc6; }

private void §_-9-§() { var loc1 = new Object(); this.archers.building = loc1; var loc2 = new Object(); loc2.cost = 70; loc2.range = 220; loc2.minDamage = 4; loc2.maxDamage = 6; loc2.reload = 0.8 * this.framesRate; this.archers.level1 = loc2; var loc3 = new Object(); loc3.cost = 110; loc3.range = 250; loc3.minDamage = 7; loc3.maxDamage = 11; loc3.reload = 0.6 * this.framesRate; this.archers.level2 = loc3; var loc4 = new Object(); loc4.cost = 160; loc4.range = 280; loc4.minDamage = 10; loc4.maxDamage = 16; loc4.reload = 0.5 * this.framesRate; this.archers.level3 = loc4; var loc5 = new Object(); loc5.cost = 230; loc5.range = 310; loc5.minDamage = 13; loc5.maxDamage = 19; loc5.reload = 0.4 * this.framesRate; loc5.poisonCost = 250; loc5.poisonCostLevel = 250; loc5.poisonDuration = 3 * this.framesRate; loc5.poisonDamage = 5; loc5.poisonCoolDown = 0.4 * this.framesRate; loc5.poisonLevels = 3; loc5.thornCost = 300; loc5.thornCostLevel = 150; loc5.thornMinEnemies = 2; loc5.thornMaxEnemies = 2; loc5.thornDuration = 1 * this.framesRate; loc5.thornDamageTime = 1 * this.framesRate; loc5.thornDamage = 40; loc5.thornCoolDown = 8 * this.framesRate; loc5.thornLevels = 3; loc5.thornMaxTimes = 3; this.archers.ranger = loc5; var loc6 = new Object(); loc6.cost = 230; loc6.range = 370; loc6.minDamage = 35; loc6.maxDamage = 65; loc6.reload = 1.5 * this.framesRate; loc6.sniperCost = 250; loc6.sniperCostLevel = 250; loc6.sniperRange = 1.5; loc6.sniperDamagePercent = 20; loc6.sniperCoolDown = 14 * this.framesRate; loc6.sniperLevels = 3; loc6.shrapnelCost = 300; loc6.shrapnelCostLevel = 300; loc6.shrapnelRange = 0.5; loc6.shrapnelArea = 50; loc6.shrapnelMinDamage = 50 / 5; loc6.shrapnelMaxDamage = 200 / 5; loc6.shrapnelCoolDown = 9 * this.framesRate; loc6.shrapnelLevels = 3; this.archers.musketeer = loc6; }

private void §_-2V§()
    {
        var _loc1_ = new object();
        this.engineers.building = _loc1_;
        var _loc2_ = new object();
        _loc2_.cost = 125;
        _loc2_.range = 250;
        _loc2_.area = 70;
        _loc2_.minDamage = 7;
        _loc2_.maxDamage = 14;
        _loc2_.reload = 3 * this.framesRate;
        this.engineers.level1 = _loc2_;
        var _loc3_ = new object();
        _loc3_.cost = 220;
        _loc3_.range = 250;
        _loc3_.area = 70;
        _loc3_.minDamage = 20;
        _loc3_.maxDamage = 39;
        _loc3_.reload = 3 * this.framesRate;
        this.engineers.level2 = _loc3_;
        var _loc4_ = new object();
        _loc4_.cost = 320;
        _loc4_.range = 280;
        _loc4_.area = 75;
        _loc4_.minDamage = 33;
        _loc4_.maxDamage = 66;
        _loc4_.reload = 3 * this.framesRate;
        this.engineers.level3 = _loc4_;
        var _loc5_ = new object();
        _loc5_.cost = 400;
        _loc5_.range = 280;
        _loc5_.area = 80;
        _loc5_.minDamage = 60;
        _loc5_.maxDamage = 120;
        _loc5_.reload = 3.5 * this.framesRate;
        _loc5_.missileCost = 250;
        _loc5_.missileCostLevel = 100;
        _loc5_.missileRangeIncrement = 0.2;
        _loc5_.missileArea = 50;
        _loc5_.missileMinDamage = 100;
        _loc5_.missileMaxDamage = 140;
        _loc5_.missileIncrementDamage = 40;
        _loc5_.missileCoolDown = 11 * this.framesRate;
        _loc5_.missileLevels = 3;
        _loc5_.clusterCost = 250;
        _loc5_.clusterCostLevel = 150;
        _loc5_.clusterArea = 70;
        _loc5_.clusterMinDamage = 60;
        _loc5_.clusterMaxDamage = 80;
        _loc5_.clusterMinBombs = 1;
        _loc5_.clusterIncrementBombs = 2;
        _loc5_.clusterCoolDown = 17 * this.framesRate;
        _loc5_.clusterLevels = 3;
        this.engineers.bfg = _loc5_;
        var _loc6_ = new object();
        _loc6_.cost = 375;
        _loc6_.range = 260;
        _loc6_.minDamage = 55;
        _loc6_.maxDamage = 105;
        _loc6_.reload = 2.2 * this.framesRate;
        _loc6_.chargedBoltCost = 300;
        _loc6_.chargedBoltCostLevel = 300;
        _loc6_.chargedBoltEnemies = 3;
        _loc6_.chargedBoltIncrementEnemies = 1;
        _loc6_.chargedBoltCoolDown = 6 * this.framesRate;
        _loc6_.chargedBoltLevels = 2;
        _loc6_.chargedBoltRange = 80;
        _loc6_.overchargeCost = 250;
        _loc6_.overchargeCostLevel = 125;
        _loc6_.overchargeArea = 230;
        _loc6_.overchargeMinDamage = 0;
        _loc6_.overchargeMaxDamage = 10;
        _loc6_.overchargeDamageIncrement = 5;
        _loc6_.overchargeCoolDown = 6 * this.framesRate;
        _loc6_.overchargeLevels = 3;
        _loc6_.overchargeDisplayRatio = 0.7;
        this.engineers.tesla = _loc6_;
    }
private void §throw§() { var loc1 = new Object(); this.engineers.building = loc1; var loc2 = new Object(); loc2.cost = 70; loc2.maxSize = MEDIUM; loc2.maxLevel = 5; loc2.rangeRally = 230; loc2.range = 100; loc2.health = 50 * this.ModifSoldierHealth; loc2.armor = 0; loc2.minDamage = 1; loc2.maxDamage = 3; loc2.reload = 1 * this.framesRate; loc2.respawn = 10 * this.framesRate; loc2.regen = 5; loc2.regenReload = 1 * this.framesRate; this.soldiers.level1 = loc2; var loc3 = new Object(); loc3.cost = 110; loc3.maxSize = MEDIUM; loc3.maxLevel = 5; loc3.rangeRally = 230; loc3.range = 100; loc3.health = 100 * this.ModifSoldierHealth; loc3.armor = 15; loc3.minDamage = 3; loc3.maxDamage = 4; loc3.reload = 1 * this.framesRate; loc3.respawn = 10 * this.framesRate; loc3.regen = 7; loc3.regenReload = 1 * this.framesRate; this.soldiers.level2 = loc3; var loc4 = new Object(); loc4.cost = 160; loc4.maxSize = MEDIUM; loc4.maxLevel = 5; loc4.rangeRally = 230; loc4.range = 100; loc4.health = 150 * this.ModifSoldierHealth; loc4.armor = 30; loc4.minDamage = 6; loc4.maxDamage = 10; loc4.reload = 1 * this.framesRate; loc4.respawn = 10 * this.framesRate; loc4.regen = 10; loc4.regenReload = 1 * this.framesRate; this.soldiers.level3 = loc4; var loc5 = new Object(); loc5.cost = 230; loc5.maxSize = MEDIUM; loc5.maxLevel = 5; loc5.rangeRally = 230; loc5.range = 100; loc5.health = 200 * this.ModifSoldierHealth; loc5.armor = 50; loc5.minDamage = 12; loc5.maxDamage = 18; loc5.reload = 1 * this.framesRate; loc5.respawn = 14 * this.framesRate; loc5.regen = 25; loc5.regenReload = 1 * this.framesRate; loc5.healingCost = 150; loc5.healingCostLevel = 150; loc5.healingMin = 40; loc5.healingMax = 60; loc5.healingCoolDown = 10 * this.framesRate; loc5.healingLevels = 3; loc5.holyStrikeCost = 220; loc5.holyStrikeCostLevel = 150; loc5.holyStrikeRange = 80; loc5.holyStrikeMinEnemies = 1; loc5.holyStrikeMinDamage = 25; loc5.holyStrikeMaxDamage = 45; loc5.holyStrikeChance = 10; loc5.holyStrikeLevels = 3; loc5.shieldCost = 250; loc5.shieldCostLevel = 100; loc5.shieldArmor = 15; loc5.shieldMaxSize = §_-D6§; loc5.shieldLevels = 1; this.soldiers.paladin = loc5; var loc6 = new Object(); loc6.cost = 230; loc6.maxSize = MEDIUM; loc6.maxLevel = 5; loc6.rangeRally = 230; loc6.range = 100; loc6.health = 200 * this.ModifSoldierHealth; loc6.armor = 0; loc6.minDamage = 16; loc6.maxDamage = 24; loc6.reload = 1 * this.framesRate; loc6.respawn = 10 * this.framesRate; loc6.regen = 20; loc6.regenReload = 1 * this.framesRate; loc6.dualWeaponsCost = 300; loc6.dualWeaponsCostLevel = 100; loc6.dualWeaponsIncrementDamage = 10; loc6.dualWeaponsLevels = 3; loc6.throwingCost = 200; loc6.throwingCostLevel = 100; loc6.throwingCoolDown = 3 * this.framesRate; loc6.throwingRange = 240; loc6.throwingMinRange = 40; loc6.throwingMinDamage = 24; loc6.throwingMaxDamage = 32; loc6.throwingIncrementDamage = 10; loc6.throwingIncrementRange = 20; loc6.throwingLevels = 3; loc6.huntingNetsCost = 150; loc6.huntingNetsCostLevel = 75; loc6.huntingNetsCoolDown = 3 * this.framesRate; loc6.huntingNetsRange = 150; loc6.huntingNetsDuration = 3 * this.framesRate; loc6.huntingNetsNewSpeed = 30; loc6.huntingNetsNewSpeedIncrement = 15; loc6.huntingNetsLevels = 3; this.soldiers.barbarian = loc6; }

private void §-9D§() { var loc1 = new Object(); loc1.className = "EnemyGoblin"; loc1.elite = false; loc1.size = §-8Z§; loc1.isFlying = false; loc1.health = Math.Round(20 * this.ModifEnemyHealth); loc1.armor = 0; loc1.magicArmor = 0; loc1.dodge = 0; loc1.speed = 1.2; loc1.gold = 3; loc1.cost = 1; loc1.minDamage = 1; loc1.maxDamage = 4; loc1.attackReloadTime = 1 * this.framesRate; loc1.xSoldierAdjust = 15; loc1.xAdjust = 0; loc1.yAdjust = -8; this.enemies.goblin = loc1;

var _loc2_ = new Object();
_loc2_.className = "EnemyWolfSmall";
_loc2_.elite = false;
_loc2_.size = §_-8Z§;
_loc2_.isFlying = false;
_loc2_.health = Math.Round(35 * this.ModifEnemyHealth);
_loc2_.armor = 0;
_loc2_.magicArmor = 0;
_loc2_.dodge = 30;
_loc2_.speed = 2.5;
_loc2_.gold = 5;
_loc2_.cost = 1;
_loc2_.minDamage = 1;
_loc2_.maxDamage = 3;
_loc2_.attackReloadTime = 1 * this.framesRate;
_loc2_.xSoldierAdjust = 15;
_loc2_.xAdjust = 0;
_loc2_.yAdjust = -8;
this.enemies.wolfSmall = _loc2_;

var _loc3_ = new Object();
_loc3_.className = "EnemyFatOrc";
_loc3_.elite = false;
_loc3_.size = MEDIUM;
_loc3_.isFlying = false;
_loc3_.health = Math.Round(80 * this.ModifEnemyHealth);
_loc3_.armor = 30;
_loc3_.magicArmor = 0;
_loc3_.dodge = 0;
_loc3_.speed = 0.8;
_loc3_.gold = 9;
_loc3_.cost = 1;
_loc3_.minDamage = 4;
_loc3_.maxDamage = 8;
_loc3_.attackReloadTime = 1 * this.framesRate;
_loc3_.xSoldierAdjust = 15;
_loc3_.xAdjust = 0;
_loc3_.yAdjust = -8;
this.enemies.fatOrc = _loc3_;
loc4 = new object(); loc4.className = "EnemyShaman"; loc4.elite = false; loc4.size = §-8Z§; loc4.isFlying = false; loc4.health = Math.Round(100 * this.ModifEnemyHealth); loc4.armor = 0; loc4.magicArmor = 85; loc4.dodge = 0; loc4.speed = 1; loc4.gold = 10; loc4.cost = 1; loc4.minDamage = 3; loc4.maxDamage = 5; loc4.attackReloadTime = 1 * this.framesRate; loc4.xSoldierAdjust = 15; loc4.xAdjust = 0; loc4.yAdjust = -8; loc4.healMaxEnemies = 3; loc4.healCoolDown = 8 * this.framesRate; loc4.healRange = 150; loc4.healPoints = 50; this.enemies.shaman = loc4; var loc5 = new object(); loc5.className = "EnemyOgre"; loc5.elite = false; loc5.size = §-D6§; loc5.isFlying = false; loc5.health = Math.Round(800 * this.ModifEnemyHealth); loc5.armor = 0; loc5.magicArmor = 0; loc5.dodge = 0; loc5.speed = 0.7; loc5.gold = 50; loc5.cost = 3; loc5.minDamage = 40; loc5.maxDamage = 60; loc5.attackReloadTime = 1 * this.framesRate; loc5.xSoldierAdjust = 25; loc5.xAdjust = 3; loc5.yAdjust = -18; this.enemies.ogre = loc5; var loc6 = new object(); loc6.className = "EnemyBandit"; loc6.elite = false; loc6.size = §-8Z§; loc6.isFlying = false; loc6.health = Math.Round(70 * this.ModifEnemyHealth); loc6.armor = 0; loc6.magicArmor = 0; loc6.dodge = 50; loc6.speed = 1.2; loc6.gold = 8; loc6.cost = 1; loc6.minDamage = 20; loc6.maxDamage = 30; loc6.attackReloadTime = 1 * this.framesRate; loc6.xSoldierAdjust = 15; loc6.xAdjust = 0; loc6.yAdjust = -8; this.enemies.bandit = loc6; var loc7 = new object(); loc7.className = "EnemyBrigand"; loc7.elite = false; loc7.size = §-8Z§; loc7.isFlying = false; loc7.health = Math.Round(160 * this.ModifEnemyHealth); loc7.armor = 50; loc7.magicArmor = 0; loc7.dodge = 0; loc7.speed = 0.8; loc7.gold = 15; loc7.cost = 1; loc7.minDamage = 6; loc7.maxDamage = 10; loc7.attackReloadTime = 1 * this.framesRate; loc7.xSoldierAdjust = 15; loc7.xAdjust = 0; loc7.yAdjust = -8; this.enemies.brigand = loc7; var loc8 = new object(); loc8.className = "EnemyMarauder"; loc8.elite = false; loc8.size = §-D6§; loc8.isFlying = false; loc8.health = Math.Round(600 * this.ModifEnemyHealth); loc8.armor = 60; loc8.magicArmor = 0; loc8.dodge = 0; loc8.speed = 0.8; loc8.gold = 40; loc8.cost = 3; loc8.minDamage = 16; loc8.maxDamage = 24; loc8.attackReloadTime = 1 * this.framesRate; loc8.xSoldierAdjust = 20; loc8.xAdjust = 0; loc8.yAdjust = -18; this.enemies.marauder = loc8;

var loc1 = new Object(); var loc9 = new Object(); loc9.className = "EnemyWolf"; loc9.elite = false; loc9.size = MEDIUM; loc9.isFlying = false; loc9.health = Math.Round(120 * this.ModifEnemyHealth); loc9.armor = 0; loc9.magicArmor = 50; loc9.dodge = 50; loc9.speed = 2; loc9.gold = 12; loc9.cost = 1; loc9.minDamage = 12; loc9.maxDamage = 18; loc9.attackReloadTime = 1 * this.framesRate; loc9.xSoldierAdjust = 20; loc9.xAdjust = 0; loc9.yAdjust = -8; this.enemies.wolf = loc9;

var _loc10_ = new Object();
_loc10_.className = "EnemySpider";
_loc10_.elite = false;
_loc10_.size = §_-8Z§;
_loc10_.isFlying = false;
_loc10_.health = Math.Round(250 * this.ModifEnemyHealth);
_loc10_.armor = 0;
_loc10_.magicArmor = 80;
_loc10_.dodge = 0;
_loc10_.speed = 1;
_loc10_.gold = 20;
_loc10_.cost = 2;
_loc10_.minDamage = 15;
_loc10_.maxDamage = 25;
_loc10_.attackReloadTime = 1 * this.framesRate;
_loc10_.xSoldierAdjust = 24;
_loc10_.xAdjust = 1;
_loc10_.yAdjust = -8;
_loc10_.eggsMax = 3;
_loc10_.eggsSpiders = 3;
_loc10_.eggsCooldownTimeMin = 4 * this.framesRate;
_loc10_.eggsCooldownTimeMax = 8 * this.framesRate;
this.enemies.spider = _loc10_;

var _loc11_ = new Object();
_loc11_.className = "EnemySpiderTiny";
_loc11_.elite = false;
_loc11_.size = §_-8Z§;
_loc11_.isFlying = false;
_loc11_.health = Math.Round(10 * this.ModifEnemyHealth);
_loc11_.armor = 0;
_loc11_.magicArmor = 50;
_loc11_.dodge = 0;
_loc11_.speed = 2;
_loc11_.gold = 0;
_loc11_.cost = 1;
_loc11_.minDamage = 1;
_loc11_.maxDamage = 5;
_loc11_.attackReloadTime = 1 * this.framesRate;
_loc11_.xSoldierAdjust = 14;
_loc11_.xAdjust = 1;
_loc11_.yAdjust = -4;
this.enemies.spiderTiny = _loc11_;

var _loc12_ = new Object();
_loc12_.className = "EnemySpiderSmall";
_loc12_.elite = false;
_loc12_.size = §_-8Z§;
_loc12_.isFlying = false;
_loc12_.health = Math.Round(60 * this.ModifEnemyHealth);
_loc12_.armor = 0;
_loc12_.magicArmor = 65;
_loc12_.dodge = 0;
_loc12_.speed = 1.5;
_loc12_.gold = 6;
_loc12_.cost = 1;
_loc12_.minDamage = 10;
_loc12_.maxDamage = 18;
_loc12_.attackReloadTime = 1 * this.framesRate;
_loc12_.xSoldierAdjust = 18;
_loc12_.xAdjust = 1;
_loc12_.yAdjust = -8;
this.enemies.spiderSmall = _loc12_;

var _loc13_ = new Object();
_loc13_.className = "EnemySarelgaz";
_loc13_.elite = false;
_loc13_.size = §_-8Z§;
_loc13_.isFlying = false;
_loc13_.health = Math.Round(18000 * this.ModifEnemyHealth);
_loc13_.armor = 0;
_loc13_.magicArmor = 0;
_loc13_.dodge = 0;
_loc13_.speed = 0.4;
_loc13_.gold = 0;
_loc13_.cost = 20;
_loc13_.minDamage = 300;
_loc13_.maxDamage = 500;
_loc13_.attackReloadTime = 1 * this.framesRate;
_loc13_.xSoldierAdjust = 75;
_loc13_.xAdjust = 1;
_loc13_.yAdjust = -40;
this.enemies.sarelgaz = _loc13_;

var _loc14_ = new Object();
_loc14_.className = "EnemySarelgazSmall";
_loc14_.elite = false;
_loc14_.size = §_-8Z§;
_loc14_.isFlying = false;
_loc14_.health = Math.Round(1250 * this.ModifEnemyHealth);
_loc14_.armor = 70;
_loc14_.magicArmor = 70;
_loc14_.dodge = 0;
_loc14_.speed = 0.8;
_loc14_.gold = 80;
_loc14_.cost = 1;
_loc14_.minDamage = 50;
_loc14_.maxDamage = 100;
_loc14_.attackReloadTime = 1 * this.framesRate;
_loc14_.xSoldierAdjust = 32;
_loc14_.xAdjust = 1;
_loc14_.yAdjust = -21;
this.enemies.sarelgazSmall = _loc14_;

var _loc15_ = new Object();
_loc15_.className = "EnemyShadowArcher";
_loc15_.elite = false;
_loc15_.size = §_-8Z§;
_loc15_.isFlying = false;
_loc15_.health = Math.Round(180 * this.ModifEnemyHealth);
_loc15_.armor = 0;
_loc15_.magicArmor = 30;
_loc15_.dodge = 0;
_loc15_.speed = 1.2;
_loc15_.gold = 16;
_loc15_.cost = 1;
_loc15_.minDamage = 10;
_loc15_.maxDamage = 20;
_loc15_.attackReloadTime = 1 * this.framesRate;
_loc15_.xSoldierAdjust = 15;
_loc15_.xAdjust = 1;
_loc15_.yAdjust = -8;
_loc15_.arrowCoolDown = 1 * this.framesRate;
_loc15_.arrowRange = 230;
_loc15_.arrowMinRange = 40;
_loc15_.arrowMinDamage = 20;
_loc15_.arrowMaxDamage = 30;
this.enemies.shadowArcher = _loc15_;
new object(); var loc16 = new object(); loc16.className = "EnemyDarkKnight"; loc16.elite = false; loc16.size = §-8Z§; loc16.isFlying = false; loc16.health = Math.Round(300 * this.ModifEnemyHealth); loc16.armor = 80; loc16.magicArmor = 0; loc16.dodge = 0; loc16.speed = 0.7; loc16.gold = 25; loc16.cost = 1; loc16.minDamage = 15; loc16.maxDamage = 25; loc16.attackReloadTime = 1 * this.framesRate; loc16.xSoldierAdjust = 20; loc16.xAdjust = 0; loc16.yAdjust = -10; this.enemies.darkKnight = loc16; var loc17 = new object(); loc17.className = "EnemyGargoyle"; loc17.elite = false; loc17.size = §-8Z§; loc17.isFlying = true; loc17.health = Math.Round(90 * this.ModifEnemyHealth); loc17.armor = 0; loc17.magicArmor = 0; loc17.dodge = 0; loc17.speed = 1.2; loc17.gold = 12; loc17.cost = 1; loc17.minDamage = 1; loc17.maxDamage = 2; loc17.attackReloadTime = 1 * this.framesRate; loc17.xSoldierAdjust = 15; loc17.xAdjust = 3; loc17.yAdjust = -45; this.enemies.gargoyle = loc17; var loc18 = new object(); loc18.className = "EnemyJuggernaut"; loc18.elite = false; loc18.size = §-D6§; loc18.isFlying = false; loc18.health = Math.Round(10000 * this.ModifEnemyHealth); loc18.armor = 0; loc18.magicArmor = 0; loc18.dodge = 0; loc18.speed = 0.4; loc18.gold = 0; loc18.cost = 20; loc18.attackReloadTime = 2 * this.framesRate; loc18.xSoldierAdjust = 35; loc18.xAdjust = 0; loc18.yAdjust = -30; loc18.missileCoolDown = 9 * this.framesRate; loc18.missileMinRange = 100; loc18.missileMinDamage = 150; loc18.missileMaxDamage = 250; loc18.areaAttackRangeWidth = 90; loc18.minDamage = 150; loc18.maxDamage = 250; loc18.areaAttackMaxEnemies = 10; loc18.golemHeads = 7; loc18.spawnCooldownTime = 6 * this.framesRate; this.enemies.juggernaut = loc18; var loc19 = new object(); loc19.className = "EnemyGolemHead"; loc19.elite = false; loc19.size = §-8Z§; loc19.isFlying = false; loc19.health = Math.Round(125 * this.ModifEnemyHealth); loc19.armor = 0; loc19.magicArmor = 0; loc19.dodge = 0; loc19.speed = 0.7; loc19.gold = 10; loc19.cost = 1; loc19.minDamage = 10; loc19.maxDamage = 20; loc19.attackReloadTime = 1 * this.framesRate; loc19.xSoldierAdjust = 14; loc19.xAdjust = 1; loc19.yAdjust = -8; this.enemies.golemHead = loc19; var loc20 = new object(); loc20.className = "EnemyWhiteWolf"; loc20.elite = false; loc20.size = §-8Z§; loc20.isFlying = false; loc20.health = Math.Round(350 * this.ModifEnemyHealth); loc20.armor = 0; loc20.magicArmor = 50; loc20.dodge = 50; loc20.speed = 2; loc20.gold = 35; loc20.cost = 1; loc20.minDamage = 20; loc20.maxDamage = 40; loc20.attackReloadTime = 1 * this.framesRate; loc20.xSoldierAdjust = 15; loc20.xAdjust = 0; loc20.yAdjust = -8; loc20.regenerateTime = 30; loc20.regenerateHealPoints = 0; this.enemies.whiteWolf = loc20; var loc21 = new object(); loc21.className = "EnemyTroll"; loc21.elite = false; loc21.size = §_-8Z§; loc21.isFlying = false; loc21.health = Math.Round(280 * this.ModifEnemyHealth); loc21.armor = 0; loc21.magicArmor = 0; loc21.dodge = 0; loc21.speed = 0.9; loc21.gold = 25; loc21.cost = 1; loc21.minDamage = 20; loc21.maxDamage = 40; loc21.attackReloadTime = 1 * this.framesRate; loc21.xSoldierAdjust = 15; loc21.xAdjust = 0; loc21.yAdjust = -8; loc21.regenerateTime = 5; loc21.regenerateHealPoints = 1; this.enemies.troll = loc21; . }
var _loc22_ = new object();
        _loc22_.className = "EnemyTrollChieftain";
        _loc22_.elite = false;
        _loc22_.size = §_-D6§;
        _loc22_.isFlying = false;
        _loc22_.health = Math.Round(1200 * this.ModifEnemyHealth);
        _loc22_.armor = 0;
        _loc22_.magicArmor = 0;
        _loc22_.dodge = 0;
        _loc22_.speed = 0.6;
        _loc22_.gold = 70;
        _loc22_.cost = 6;
        _loc22_.minDamage = 10;
        _loc22_.maxDamage = 30;
        _loc22_.attackReloadTime = 1 * this.framesRate;
        _loc22_.xSoldierAdjust = 25;
        _loc22_.xAdjust = 0;
        _loc22_.yAdjust = -18;
        _loc22_.rageMaxEnemies = 3;
        _loc22_.rageCoolDown = 6 * this.framesRate;
        _loc22_.rageDurationTime = 6 * this.framesRate;
        _loc22_.rageRange = 280;
        _loc22_.rageHealPoints = 50;
        _loc22_.rageAddedMinDamage = 15;
        _loc22_.rageAddedMaxDamage = 30;
        _loc22_.rageAddedSpeed = 0.8;
        _loc22_.rageAddedArmor = 50;
        _loc22_.regenerateTime = 5;
        _loc22_.regenerateHealPoints = 4;
        this.enemies.trollChieftain = _loc22_;
        var _loc23_ = new object();
        _loc23_.className = "EnemyTrollAxeThrower";
        _loc23_.elite = false;
        _loc23_.size = §_-D6§;
        _loc23_.isFlying = false;
        _loc23_.health = Math.Round(600 * this.ModifEnemyHealth);
        _loc23_.armor = 0;
        _loc23_.magicArmor = 0;
        _loc23_.dodge = 0;
        _loc23_.speed = 0.8;
        _loc23_.gold = 50;
        _loc23_.cost = 3;
        _loc23_.minDamage = 30;
        _loc23_.maxDamage = 50;
        _loc23_.attackReloadTime = 1 * this.framesRate;
        _loc23_.xSoldierAdjust = 15;
        _loc23_.xAdjust = 1;
        _loc23_.yAdjust = -8;
        _loc23_.axeCoolDown = 1 * this.framesRate;
        _loc23_.axeRange = 230;
        _loc23_.axeMinRange = 40;
        _loc23_.axeMinDamage = 40;
        _loc23_.axeMaxDamage = 80;
        _loc23_.regenerateTime = 5;
        _loc23_.regenerateHealPoints = 2;
        this.enemies.trollAxeThrower = _loc23_;
        var _loc24_ = new object();
        _loc24_.className = "EnemyYeti";
        _loc24_.elite = false;
        _loc24_.size = §_-D6§;
        _loc24_.isFlying = false;
        _loc24_.health = Math.Round(2000 * this.ModifEnemyHealth);
        _loc24_.armor = 0;
        _loc24_.magicArmor = 0;
        _loc24_.dodge = 0;
        _loc24_.speed = 0.7;
        _loc24_.gold = 120;
        _loc24_.cost = 5;
        _loc24_.attackReloadTime = 2.5 * this.framesRate;
        _loc24_.xSoldierAdjust = 27;
        _loc24_.xAdjust = 0;
        _loc24_.yAdjust = -18;
        _loc24_.minDamage = 50;
        _loc24_.maxDamage = 150;
        _loc24_.areaAttackRangeWidth = 70;
        _loc24_.areaAttackMaxEnemies = 10;
        this.enemies.yeti = _loc24_;
        var _loc25_ = new object();
        _loc25_.className = "EnemyYetiBoss";
        _loc25_.elite = false;
        _loc25_.size = §_-D6§;
        _loc25_.isFlying = false;
        _loc25_.health = Math.Round(11000 * this.ModifEnemyHealth);
        _loc25_.armor = 0;
        _loc25_.magicArmor = 0;
        _loc25_.dodge = 0;
        _loc25_.speed = 0.4;
        _loc25_.gold = 0;
        _loc25_.cost = 20;
        _loc25_.attackReloadTime = 2 * this.framesRate;
        _loc25_.xSoldierAdjust = 35;
        _loc25_.xAdjust = 0;
        _loc25_.yAdjust = -50;
        _loc25_.breathDuration = 4 * this.framesRate;
        _loc25_.minDamage = 150;
        _loc25_.maxDamage = 200;
        _loc25_.areaDamageAttackRangeWidth = 70;
        _loc25_.areaDamageAttackMaxEnemies = 10;
        _loc25_.areaAttackRangeWidth = 70;
        _loc25_.areaAttackMaxEnemies = 5;
        _loc25_.frozeMaxTowers = 4;
        _loc25_.frozeRangeWidth = 300;
        _loc25_.frozeReloadTime = 10 * this.framesRate;
        _loc25_.maxWolf = 2;
        _loc25_.wolfSpawnCooldownTime = 8 * this.framesRate;
        _loc25_.wolfSpawnInterval = 20;
        _loc25_.maxYetis = 1;
        _loc25_.yetisSpawnCooldownTime = 19 * this.framesRate;
        _loc25_.yetisSpawnInterval = 200;
        this.enemies.yetiBoss = _loc25_;
        var _loc26_ = new object();
        _loc26_.className = "EnemySlayer";
        _loc26_.elite = false;
        _loc26_.size = §_-D6§;
        _loc26_.isFlying = false;
        _loc26_.health = Math.Round(1200 * this.ModifEnemyHealth);
        _loc26_.armor = 95;
        _loc26_.magicArmor = 0;
        _loc26_.dodge = 0;
        _loc26_.speed = 0.7;
        _loc26_.gold = 100;
        _loc26_.cost = 3;
        _loc26_.minDamage = 24;
        _loc26_.maxDamage = 76;
        _loc26_.attackReloadTime = 1 * this.framesRate;
        _loc26_.xSoldierAdjust = 20;
        _loc26_.xAdjust = 0;
        _loc26_.yAdjust = -18;
        this.enemies.slayer = _loc26_;
var _loc27_:* = new Object();
         _loc27_.className = "EnemyRocketeer";
         _loc27_.elite = false;
         _loc27_.size = §_-8Z§;
         _loc27_.isFlying = true;
         _loc27_.health = Math.round(340 * this.ModifEnemyHealth);
         _loc27_.armor = 0;
         _loc27_.magicArmor = 0;
         _loc27_.dodge = 0;
         _loc27_.speed = 1.2;
         _loc27_.gold = 30;
         _loc27_.cost = 1;
         _loc27_.minDamage = 1;
         _loc27_.maxDamage = 2;
         _loc27_.attackReloadTime = 1 * this.framesRate;
         _loc27_.xSoldierAdjust = 15;
         _loc27_.xAdjust = 0;
         _loc27_.yAdjust = -50;
         _loc27_.fastSpeedDuration = 2 * this.framesRate;
         _loc27_.fastSpeed = 4;
         this.enemies.rocketeer = _loc27_;
         _loc28_ = new Object();
         _loc28_.className = "EnemySkeleton";
         _loc28_.elite = false;
         _loc28_.size = §_-8Z§;
         _loc28_.isFlying = false;
         _loc28_.health = Math.round(120 * this.ModifEnemyHealth);
         _loc28_.armor = 0;
         _loc28_.magicArmor = 0;
         _loc28_.dodge = 0;
         _loc28_.speed = 0.6;
         _loc28_.gold = 2;
         _loc28_.cost = 1;
         _loc28_.minDamage = 10;
         _loc28_.maxDamage = 20;
         _loc28_.attackReloadTime = 1 * this.framesRate;
         _loc28_.xSoldierAdjust = 15;
         _loc28_.xAdjust = 0;
         _loc28_.yAdjust = -8;
         this.enemies.skeleton = _loc28_;
         _loc29_ = new Object();
         _loc29_.className = "EnemySkeletonBig";
         _loc29_.elite = false;
         _loc29_.size = §_-D6§;
         _loc29_.isFlying = false;
         _loc29_.health = Math.round(400 * this.ModifEnemyHealth);
         _loc29_.armor = 30;
         _loc29_.magicArmor = 0;
         _loc29_.dodge = 0;
         _loc29_.speed = 0.6;
         _loc29_.gold = 10;
         _loc29_.cost = 1;
         _loc29_.minDamage = 20;
         _loc29_.maxDamage = 40;
         _loc29_.attackReloadTime = 1 * this.framesRate;
         _loc29_.xSoldierAdjust = 18;
         _loc29_.xAdjust = 0;
         _loc29_.yAdjust = -11;
         this.enemies.skeletonBig = _loc29_;
         _loc30_ = new Object();
         _loc30_.className = "EnemyDemonWolf";
         _loc30_.elite = false;
         _loc30_.size = §_-8Z§;
         _loc30_.isFlying = false;
         _loc30_.health = Math.round(350 * this.ModifEnemyHealth);
         _loc30_.armor = 0;
         _loc30_.magicArmor = 60;
         _loc30_.dodge = 50;
         _loc30_.speed = 1.5;
         _loc30_.gold = 25;
         _loc30_.cost = 1;
         _loc30_.minDamage = 20;
         _loc30_.maxDamage = 40;
         _loc30_.attackReloadTime = 1 * this.framesRate;
         _loc30_.xSoldierAdjust = 20;
         _loc30_.xAdjust = 0;
         _loc30_.yAdjust = -8;
         _loc30_.exploteRange = 100;
         _loc30_.exploteMinDamage = 70;
         _loc30_.exploteMaxDamage = 140;
         this.enemies.demonWolf = _loc30_;
         _loc31_ = new Object();
         _loc31_.className = "EnemyDemon";
         _loc31_.elite = false;
         _loc31_.size = §_-8Z§;
         _loc31_.isFlying = false;
         _loc31_.health = Math.round(250 * this.ModifEnemyHealth);
         _loc31_.armor = 0;
         _loc31_.magicArmor = 60;
         _loc31_.dodge = 0;
         _loc31_.speed = 0.8;
         _loc31_.gold = 20;
         _loc31_.cost = 1;
         _loc31_.minDamage = 10;
         _loc31_.maxDamage = 30;
         _loc31_.attackReloadTime = 1 * this.framesRate;
         _loc31_.xSoldierAdjust = 15;
         _loc31_.xAdjust = 0;
         _loc31_.yAdjust = -8;
         _loc31_.exploteRange = 100;
         _loc31_.exploteMinDamage = 50;
         _loc31_.exploteMaxDamage = 100;
         this.enemies.demon = _loc31_;
_loc32_.className = "EnemyDemonMage";
        _loc32_.elite = false;
        _loc32_.size = §_-D6§;
        _loc32_.isFlying = false;
        _loc32_.health = Math.Round(1000 * this.ModifEnemyHealth);
        _loc32_.armor = 0;
        _loc32_.magicArmor = 60;
        _loc32_.dodge = 0;
        _loc32_.speed = 0.6;
        _loc32_.gold = 60;
        _loc32_.cost = 5;
        _loc32_.minDamage = 15;
        _loc32_.maxDamage = 75;
        _loc32_.attackReloadTime = 1 * this.framesRate;
        _loc32_.xSoldierAdjust = 23;
        _loc32_.xAdjust = 0;
        _loc32_.yAdjust = -18;
        _loc32_.shieldMaxEnemies = 4;
        _loc32_.shieldCoolDown = 6 * this.framesRate;
        _loc32_.shieldIgnoreHits = 4;
        _loc32_.shieldRange = 280;
        _loc32_.exploteRange = 100;
        _loc32_.exploteMinDamage = 200;
        _loc32_.exploteMaxDamage = 400;
        this.enemies.demonMage = _loc32_;
        _loc33_.className = "EnemyNecromancer";
        _loc33_.elite = false;
        _loc33_.size = §_-8Z§;
        _loc33_.isFlying = false;
        _loc33_.health = Math.Round(700 * this.ModifEnemyHealth);
        _loc33_.armor = 0;
        _loc33_.magicArmor = 0;
        _loc33_.dodge = 0;
        _loc33_.speed = 0.6;
        _loc33_.gold = 50;
        _loc33_.cost = 3;
        _loc33_.minDamage = 20;
        _loc33_.maxDamage = 40;
        _loc33_.attackReloadTime = 1 * this.framesRate;
        _loc33_.xSoldierAdjust = 15;
        _loc33_.xAdjust = 0;
        _loc33_.yAdjust = -9;
        _loc33_.summonMaxSkeletons = 35;
        _loc33_.summonMaxEnemies = 4;
        _loc33_.summonCoolDown = 8 * this.framesRate;
        _loc33_.spellCoolDown = 1 * this.framesRate;
        _loc33_.spellRange = 230;
        _loc33_.spellMinRange = 40;
        _loc33_.spellMinDamage = 20;
        _loc33_.spellMaxDamage = 40;
        this.enemies.necromancer = _loc33_;
        _loc34_.className = "EnemyDemonImp";
        _loc34_.elite = false;
        _loc34_.size = §_-8Z§;
        _loc34_.isFlying = true;
        _loc34_.health = Math.Round(350 * this.ModifEnemyHealth);
        _loc34_.armor = 0;
        _loc34_.magicArmor = 0;
        _loc34_.dodge = 0;
        _loc34_.speed = 1;
        _loc34_.gold = 25;
        _loc34_.cost = 1;
        _loc34_.minDamage = 1;
        _loc34_.maxDamage = 2;
        _loc34_.attackReloadTime = 1 * this.framesRate;
        _loc34_.xSoldierAdjust = 15;
        _loc34_.xAdjust = 3;
        _loc34_.yAdjust = -45;
        this.enemies.demonImp = _loc34_;
        _loc35_.className = "EnemyLavaElemental";
        _loc35_.elite = false;
        _loc35_.size = §_-D6§;
        _loc35_.isFlying = false;
        _loc35_.health = Math.Round(2500 * this.ModifEnemyHealth);
        _loc35_.armor = 0;
        _loc35_.magicArmor = 0;
        _loc35_.dodge = 0;
        _loc35_.speed = 0.5;
        _loc35_.gold = 100;
        _loc35_.cost = 5;
        _loc35_.attackReloadTime = 2.5 * this.framesRate;
        _loc35_.xSoldierAdjust = 27;
        _loc35_.xAdjust = 0;
        _loc35_.yAdjust = -18;
        _loc35_.minDamage = 50;
        _loc35_.maxDamage = 150;
        _loc35_.areaAttackRangeWidth = 70;
        _loc35_.areaAttackMaxEnemies = 10;
        this.enemies.lavaElemental = _loc35_;
        _loc36_.className = "EnemyVeznan";
        _loc36_.elite = false;
        _loc36_.size = §_-D6§;
        _loc36_.isFlying = false;
        _loc36_.health = Math.Round(6666 * this.ModifEnemyHealth);
        _loc36_.armor = 0;
        _loc36_.magicArmor = 0;
        _loc36_.dodge = 0;
        _loc36_.speed = 0.4;
        _loc36_.gold = 0;
        _loc36_.cost = 20;
        _loc36_.attackReloadTime = 2 * this.framesRate;
        _loc36_.xSoldierAdjust = 20;
        _loc36_.xAdjust = 0;
        _loc36_.yAdjust = -18;
        _loc36_.demonHealth = 6666;
        _loc36_.demonSpeed = 0.6;
        _loc36_.demonAttackReloadTime = 2.5 * this.framesRate;
        _loc36_.demonXSoldierAdjust = 35;
        _loc36_.demonXAdjust = 0;
        _loc36_.demonYAdjust = -45;
        _loc36_.minDamage = 666;
        _loc36_.maxDamage = 999;
        _loc36_.areaAttackRangeWidth = 120;
        _loc36_.areaAttackMaxEnemies = 8;
        _loc36_.tsungReloadTime = 5 * this.framesRate;
        _loc36_.tsungRangeWidth = 230;
        _loc36_.tsungMinRange = 50;
        _loc36_.tsungMaxEnemies = 5;
        _loc36_.portalTimers = new int[][] {
            new int[] {0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0},
            new int[] {15, 1, 0, 0, 3},
            new int[] {10, 1, 0, 0, 2},
            new int[] {20, 0, 1, 0, 3},
            new int[] {15, 1, 0, 0, 3},
            new int[] {20, 1, 1, 0, 3},
            new int[] {15, 1, 1, 0, 3},
            new int[] {15, 1, 1, 0, 3},
            new int[] {15, 0, 0, 1, 3},
            new int[] {15, 1, 1, 1, 3},
            new int[] {15, 1, 1, 1, 3}
        };
        _loc36_.holdTimers = new int[][] {
            new int[] {0, 3},
            new int[] {0, 3},
            new int[] {0, 3},
            new int[] {0, 3},
            new int[] {0, 2},
            new int[] {0, 2},
            new int[] {0, 2},
            new int[] {0, 2},
            new int[] {13, 2},
            new int[] {13, 3},
            new int[] {14, 4},
            new int[] {14, 5},
            new int[] {16, 6},
            new int[] {16, 7},
            new int[] {18, 8}
        };
        _loc36_.towerHoldFreeTime = 4 * this.framesRate;
        _loc36_.towerHoldBlockTime = 6 * this.framesRate;
        this.enemies.veznan = _loc36_;
var loc37 = new object(); var loc38 = new object(); var loc39 = new object(); var loc40 = new object(); var loc41 = new object(); loc37.className = "EnemyGoblinZapper"; loc37.elite = false; loc37.size = §-8Z§; loc37.isFlying = false; loc37.health = Math.Round(140 * this.ModifEnemyHealth); loc37.armor = 0; loc37.magicArmor = 0; loc37.dodge = 0; loc37.speed = 1.2; loc37.gold = 10; loc37.cost = 1; loc37.minDamage = 10; loc37.maxDamage = 20; loc37.attackReloadTime = 1 * this.framesRate; loc37.xSoldierAdjust = 15; loc37.xAdjust = 1; loc37.yAdjust = -8; loc37.bombCoolDown = 1 * this.framesRate; loc37.bombRange = 260; loc37.bombMinRange = 40; loc37.bombMinDamage = 30; loc37.bombMaxDamage = 60; loc37.exploteRange = 120; loc37.exploteMinDamage = 50; loc37.exploteMaxDamage = 150; this.enemies.goblinZapper = loc37; loc38.className = "EnemyForestTroll"; loc38.elite = false; loc38.size = §-D6§; loc38.isFlying = false; loc38.health = Math.Round(4000 * this.ModifEnemyHealth); loc38.armor = 0; loc38.magicArmor = 0; loc38.dodge = 0; loc38.speed = 0.6; loc38.gold = 200; loc38.cost = 5; loc38.attackReloadTime = 2.5 * this.framesRate; loc38.xSoldierAdjust = 27; loc38.xAdjust = 0; loc38.yAdjust = -18; loc38.minDamage = 50; loc38.maxDamage = 150; loc38.areaAttackRangeWidth = 70; loc38.areaAttackMaxEnemies = 10; loc38.regenerateTime = 1; loc38.regenerateHealPoints = 2; this.enemies.forestTroll = loc38; loc39.className = "EnemyOrcWolfRider"; loc39.elite = false; loc39.size = MEDIUM; loc39.isFlying = false; loc39.health = Math.Round(400 * this.ModifEnemyHealth); loc39.armor = 0; loc39.magicArmor = 80; loc39.dodge = 0; loc39.speed = 1.4; loc39.gold = 25; loc39.cost = 2; loc39.minDamage = 20; loc39.maxDamage = 40; loc39.attackReloadTime = 1 * this.framesRate; loc39.xSoldierAdjust = 22; loc39.xAdjust = 0; loc39.yAdjust = -13; this.enemies.orcWolfRider = loc39; loc40.className = "EnemyOrcArmored"; loc40.elite = false; loc40.size = MEDIUM; loc40.isFlying = false; loc40.health = Math.Round(400 * this.ModifEnemyHealth); loc40.armor = 80; loc40.magicArmor = 0; loc40.dodge = 0; loc40.speed = 0.8; loc40.gold = 30; loc40.cost = 1; loc40.minDamage = 20; loc40.maxDamage = 40; loc40.attackReloadTime = 1 * this.framesRate; loc40.xSoldierAdjust = 18; loc40.xAdjust = 0; loc40.yAdjust = -12; this.enemies.orcArmored = loc40; loc41.className = "EnemyBossGoblinChieftain"; loc41.elite = false; loc41.size = §-D6§; loc41.isFlying = false; loc41.health = Math.Round(12000 * this.ModifEnemyHealth); loc41.armor = 0; loc41.magicArmor = 0; loc41.dodge = 0; loc41.speed = 0.4; loc41.gold = 0; loc41.cost = 20; loc41.minDamage = 200; loc41.maxDamage = 600; loc41.attackReloadTime = 1 * this.framesRate; loc41.xSoldierAdjust = 42; loc41.xAdjust = 0; loc41.yAdjust = -15; loc41.healMaxEnemies = 20; loc41.healCoolDown = 8 * this.framesRate; loc41.healRange = 500; loc41.healPoints = 200; this.enemies.goblinChieftain = loc41; }
 private void §_-L§()
    {
        var _loc1_ = new object();
        _loc1_.coolDown = 25 * framesRate;
        _loc1_.minDamage = 1;
        _loc1_.maxDamage = 500;
        powers.lightning = _loc1_;

        var _loc2_ = new object();
        _loc2_.coolDown = 80 * framesRate;
        _loc2_.minDamage = 30;
        _loc2_.maxDamage = 60;
        _loc2_.range = 100;
        _loc2_.scorchedEarthRange = 100;
        _loc2_.scorchedEarthMinDamage = 10;
        _loc2_.scorchedEarthMaxDamage = 20;
        _loc2_.scorchedEarthDamageTime = 1 * framesRate;
        _loc2_.scorchedEarthDuration = 5 * framesRate;
        _loc2_.blazingEarthRange = 100;
        _loc2_.blazingEarthMinDamage = 20;
        _loc2_.blazingEarthMaxDamage = 30;
        _loc2_.blazingEarthDamageTime = 1 * framesRate;
        _loc2_.blazingEarthDuration = 10 * framesRate;
        powers.fireball = _loc2_;

        var _loc3_ = new object();
        _loc3_.coolDown = 10 * framesRate;
        _loc3_.maxSize = §_-D6§;
        _loc3_.maxLevel = 5;
        _loc3_.range = 100;
        _loc3_.health = 30;
        _loc3_.armor = 0;
        _loc3_.minDamage = 1;
        _loc3_.maxDamage = 2;
        _loc3_.reload = 1 * framesRate;
        _loc3_.lifeTime = 20 * framesRate;
        _loc3_.regen = 3;
        _loc3_.regenReload = 1 * framesRate;
        powers.farmers = _loc3_;

        var _loc4_ = new object();
        _loc4_.range = 100;
        _loc4_.health = 50;
        _loc4_.armor = 0;
        _loc4_.minDamage = 1;
        _loc4_.maxDamage = 3;
        _loc4_.reload = 1 * framesRate;
        _loc4_.lifeTime = 20 * framesRate;
        _loc4_.regen = 6;
        _loc4_.regenReload = 1 * framesRate;
        powers.reinforcementLevel1 = _loc4_;

        var _loc5_ = new object();
        _loc5_.coolDown = 10 * framesRate;
        _loc5_.maxSize = §_-D6§;
        _loc5_.maxLevel = 5;
        _loc5_.range = 100;
        _loc5_.health = 70;
        _loc5_.armor = 10;
        _loc5_.minDamage = 2;
        _loc5_.maxDamage = 4;
        _loc5_.reload = 1 * framesRate;
        _loc5_.lifeTime = 20 * framesRate;
        _loc5_.regen = 9;
        _loc5_.regenReload = 1 * framesRate;
        powers.reinforcementLevel2 = _loc5_;

        var _loc6_ = new object();
        _loc6_.coolDown = 10 * framesRate;
        _loc6_.maxSize = §_-D6§;
        _loc6_.maxLevel = 5;
        _loc6_.range = 100;
        _loc6_.health = 90;
        _loc6_.armor = 20;
        _loc6_.minDamage = 3;
        _loc6_.maxDamage = 6;
        _loc6_.reload = 1 * framesRate;
        _loc6_.lifeTime = 20 * framesRate;
        _loc6_.regen = 12;
        _loc6_.regenReload = 1 * framesRate;
        powers.reinforcementLevel3 = _loc6_;

        var _loc7_ = new object();
        _loc7_.coolDown = 10 * framesRate;
        _loc7_.maxSize = §_-D6§;
        _loc7_.maxLevel = 5;
        _loc7_.range = 100;
        _loc7_.health = 110;
        _loc7_.armor = 30;
        _loc7_.minDamage = 6;
        _loc7_.maxDamage = 10;
        _loc7_.reload = 1 * framesRate;
        _loc7_.lifeTime = 20 * framesRate;
        _loc7_.regen = 15;
        _loc7_.regenReload = 1 * framesRate;
        _loc7_.spearCoolDown = 1 * framesRate;
        _loc7_.spearRange = 260;
        _loc7_.spearMinRange = 40;
        _loc7_.spearMinDamage = 24;
        _loc7_.spearMaxDamage = 40;
        powers.reinforcementLevel4 = _loc7_;

        var _loc8_ = new object();
        _loc8_.coolDown = 10 * framesRate;
        _loc8_.maxSize = §_-D6§;
        _loc8_.maxLevel = 5;
        _loc8_.range = 100;
        _loc8_.health = 200;
        _loc8_.armor = 0;
        _loc8_.minDamage = 25;
        _loc8_.maxDamage = 35;
        _loc8_.reload = 1 * framesRate;
        _loc8_.lifeTime = 20 * framesRate;
        _loc8_.regen = 10;
        _loc8_.regenReload = 1 * framesRate;
        powers.knights = _loc8_;
    }
private void §-Ke§() { var loc1 = new Dictionary<string, object>(); loc1["max"] = 4; loc1["repairCost"] = 100; loc1["elfCost"] = 100; loc1["maxSize"] = §-D6§; loc1["maxLevel"] = 5; loc1["range"] = 80; loc1["health"] = 200; loc1["armor"] = 0; loc1["minDamage"] = 25; loc1["maxDamage"] = 50; loc1["reload"] = 1 * framesRate; loc1["regen"] = 20; loc1["regenReload"] = 0.5 * framesRate; loc1["arrowCoolDown"] = 1 * framesRate; loc1["arrowRange"] = 320; loc1["arrowMinRange"] = 40; loc1["arrowMinDamage"] = 25; loc1["arrowMaxDamage"] = 50; specials["elves"] = loc1;

var _loc2_ = new Dictionary<string, object>();
_loc2_["maxSize"] = §_-D6§;
_loc2_["maxLevel"] = 5;
_loc2_["range"] = 120;
_loc2_["health"] = 250;
_loc2_["armor"] = 40;
_loc2_["minDamage"] = 10;
_loc2_["maxDamage"] = 30;
_loc2_["reload"] = 1 * framesRate;
_loc2_["regen"] = 25;
_loc2_["regenReload"] = 1 * framesRate;
specials["imperial"] = _loc2_;

var _loc3_ = new Dictionary<string, object>();
_loc3_["max"] = 1;
_loc3_["cost"] = 500;
_loc3_["rallyRange"] = 450;
_loc3_["coolDown"] = 10 * framesRate;
_loc3_["maxSize"] = §_-D6§;
_loc3_["maxLevel"] = 5;
_loc3_["range"] = 130;
_loc3_["health"] = 2500;
_loc3_["armor"] = 0;
_loc3_["reload"] = 2.5 * framesRate;
_loc3_["regen"] = 250;
_loc3_["regenReload"] = 1 * framesRate;
_loc3_["areaAttackRangeWidth"] = 70;
_loc3_["minDamage"] = 50;
_loc3_["maxDamage"] = 110;
_loc3_["areaAttackMaxEnemies"] = 10;
specials["sasquash"] = _loc3_;

var _loc4_ = new Dictionary<string, object>();
_loc4_["mageCost"] = 100;
_loc4_["reloadTime"] = 22 * framesRate;
_loc4_["reloadDecrease"] = 3 * framesRate;
_loc4_["damageIncrement"] = 50;
_loc4_["minDamage"] = 25;
_loc4_["maxDamage"] = 75;
specials["templeTower"] = _loc4_;

var _loc5_ = new Dictionary<string, object>();
_loc5_["limitLifeCondition"] = 299;
specials["graveyard"] = _loc5_;

var _loc6_ = new Dictionary<string, object>();
_loc6_["spawnTime"] = 400 * framesRate;
_loc6_["spawnAuxTime"] = 120 * framesRate;
specials["lavaSpawn"] = _loc6_;
}
private void §_-5E§() { double loc1; double loc2; double loc3; double loc4; double loc5; double loc6; double loc7; double loc8; double loc9; if (game.gameUpgrades.archersUpEagleEye == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 2)) { loc1 = 0.1; archers.level1.range += Math.Ceiling(archers.level1.range * loc1); archers.level2.range += Math.Ceiling(archers.level2.range * loc1); archers.level3.range += Math.Ceiling(archers.level3.range * loc1); archers.ranger.range += Math.Ceiling(archers.ranger.range * loc1); archers.musketeer.range += Math.Ceiling(archers.musketeer.range * loc1); } if (game.gameUpgrades.archersUpFarShots == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 4)) { loc1 = 0.1; archers.level1.range += Math.Ceiling(archers.level1.range * loc1); archers.level2.range += Math.Ceiling(archers.level2.range * loc1); archers.level3.range += Math.Ceiling(archers.level3.range * loc1); archers.ranger.range += Math.Ceiling(archers.ranger.range * loc1); archers.musketeer.range += Math.Ceiling(archers.musketeer.range * loc1); } if (game.gameUpgrades.magesUpSpellReach == true) { loc2 = 0.1; mages.level1.range += Math.Ceiling(mages.level1.range * loc2); mages.level2.range += Math.Ceiling(mages.level2.range * loc2); mages.level3.range += Math.Ceiling(mages.level3.range * loc2); mages.arcane.range += Math.Ceiling(mages.arcane.range * loc2); mages.sorcerer.range += Math.Ceiling(mages.sorcerer.range * loc2); }

if (game.gameUpgrades.magesUpEmpoweredMagic == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 4)) { loc3 = 0.15; mages.level1.minDamage += Math.Ceiling(mages.level1.minDamage * loc3); mages.level1.maxDamage += Math.Ceiling(mages.level1.maxDamage * loc3); mages.level2.minDamage += Math.Ceiling(mages.level2.minDamage * loc3); mages.level2.maxDamage += Math.Ceiling(mages.level2.maxDamage * loc3); mages.level3.minDamage += Math.Ceiling(mages.level3.minDamage * loc3); mages.level3.maxDamage += Math.Ceiling(mages.level3.maxDamage * loc3); mages.arcane.minDamage += Math.Ceiling(mages.arcane.minDamage * loc3); mages.arcane.maxDamage += Math.Ceiling(mages.arcane.maxDamage * loc3); mages.sorcerer.minDamage += Math.Ceiling(mages.sorcerer.minDamage * loc3); mages.sorcerer.maxDamage += Math.Ceiling(mages.sorcerer.maxDamage * loc3); } if (game.gameUpgrades.barracksUpSurvival == true) { loc6 = 0.1; if (game.gameUpgrades.barracksUpSurvival2 == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 4)) { loc6 = 0.2; } soldiers.level1.health += Math.Ceiling(soldiers.level1.health * loc6); soldiers.level2.health += Math.Ceiling(soldiers.level2.health * loc6); soldiers.level3.health += Math.Ceiling(soldiers.level3.health * loc6); soldiers.paladin.health += Math.Ceiling(soldiers.paladin.health * loc6); soldiers.barbarian.health += Math.Ceiling(soldiers.barbarian.health * loc6); } if (game.gameUpgrades.barracksUpBetterArmor == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 2)) { loc7 = 10; soldiers.level1.armor += loc7; soldiers.level2.armor += loc7; soldiers.level3.armor += loc7; soldiers.paladin.armor += loc7; soldiers.barbarian.armor += loc7; } if (game.gameUpgrades.barracksUpImprovedDeployment == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 3)) { loc8 = 0.2; loc9 = 0.2; soldiers.level1.respawn -= Math.Ceiling(soldiers.level1.respawn * loc8); soldiers.level2.respawn -= Math.Ceiling(soldiers.level2.respawn * loc8); soldiers.level3.respawn -= Math.Ceiling(soldiers.level3.respawn * loc8); soldiers.paladin.respawn -= Math.Ceiling(soldiers.paladin.respawn * loc8); soldiers.barbarian.respawn -= Math.Ceiling(soldiers.barbarian.respawn * loc8); soldiers.level1.rangeRally += Math.Ceiling(soldiers.level1.rangeRally * loc9); soldiers.level2.rangeRally += Math.Ceiling(soldiers.level2.rangeRally * loc9); soldiers.level3.rangeRally += Math.Ceiling(soldiers.level3.rangeRally * loc9); soldiers.paladin.rangeRally += Math.Ceiling(soldiers.paladin.rangeRally * loc9); soldiers.barbarian.rangeRally += Math.Ceiling(soldiers.barbarian.rangeRally * loc9); } 

private void §_-5E§() { double loc1; double loc2; double loc3; double loc4; double loc5; double loc6; double loc7; double loc8; double loc9;

if (game.gameUpgrades.engineersUpConcentratedFire == true)
{
    _loc4_ = 0.1;
    engineers.level1.minDamage += Math.Ceiling(engineers.level1.minDamage * _loc4_);
    engineers.level1.maxDamage += Math.Ceiling(engineers.level1.maxDamage * _loc4_);
    engineers.level2.minDamage += Math.Ceiling(engineers.level2.minDamage * _loc4_);
    engineers.level2.maxDamage += Math.Ceiling(engineers.level2.maxDamage * _loc4_);
    engineers.level3.minDamage += Math.Ceiling(engineers.level3.minDamage * _loc4_);
    engineers.level3.maxDamage += Math.Ceiling(engineers.level3.maxDamage * _loc4_);
    engineers.bfg.minDamage += Math.Ceiling(engineers.bfg.minDamage * _loc4_);
    engineers.bfg.maxDamage += Math.Ceiling(engineers.bfg.maxDamage * _loc4_);
    engineers.tesla.minDamage += Math.Ceiling(engineers.tesla.minDamage * _loc4_);
    engineers.tesla.maxDamage += Math.Ceiling(engineers.tesla.maxDamage * _loc4_);
}

if (game.gameUpgrades.engineersUpRangeFinder == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 2))
{
    _loc5_ = 0.1;
    engineers.level1.range += Math.Ceiling(engineers.level1.range * _loc5_);
    engineers.level2.range += Math.Ceiling(engineers.level2.range * _loc5_);
    engineers.level3.range += Math.Ceiling(engineers.level3.range * _loc5_);
    engineers.bfg.range += Math.Ceiling(engineers.bfg.range * _loc5_);
    engineers.tesla.range += Math.Ceiling(engineers.tesla.range * _loc5_);
}

if (game.gameUpgrades.rainUpBlazingSkies == true)
{
    powers.fireball.minDamage += 20;
    powers.fireball.maxDamage += 20;
}

if (game.gameUpgrades.rainsUpBiggerAndMeaner == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 3))
{
    powers.fireball.range += powers.fireball.range * 0.25;
    powers.fireball.minDamage += 40;
    powers.fireball.maxDamage += 40;
    powers.fireball.coolDown -= 10 * framesRate;
}

if (game.gameUpgrades.rainUpBlazingEarth == true && (maxUpgradeLevel == 0 || maxUpgradeLevel >= 4))
{
    powers.fireball.coolDown -= 10 * framesRate;
}

if (game.gameUpgrades.rainUpCataclysm == true && (maxUpgradeLevel == 0 || maxUpgradeLevel == 5))
{
    powers.fireball.minDamage += 60;
    powers.fireball.maxDamage += 60;
}

if (game.gameUpgrades.reinforcementLevel == 1)
{
    powers.farmers.range = powers.reinforcementLevel1.range;
    powers.farmers.health = powers.reinforcementLevel1.health;
    powers.farmers.armor = powers.reinforcementLevel1.armor;
    powers.farmers.minDamage = powers.reinforcementLevel1.minDamage;
    powers.farmers.maxDamage = powers.reinforcementLevel1.maxDamage;
    powers.farmers.reload = powers.reinforcementLevel1.reload;
    powers.farmers.lifeTime = powers.reinforcementLevel1.lifeTime;
    powers.farmers.regen = powers.reinforcementLevel1.regen;
    powers.farmers.regenReload = powers.reinforcementLevel1.regenReload;
}
}
 public string GetArmorString(double param1)
    {
        if (param1 == 0)
        {
            return Locale.loadStringEx("C_ARMOR_0", Locale.getDefaultLang());
        }
        if (param1 >= 1 && param1 <= 30)
        {
            return Locale.loadStringEx("C_ARMOR_1", Locale.getDefaultLang());
        }
        if (param1 >= 31 && param1 <= 60)
        {
            return Locale.loadStringEx("C_ARMOR_2", Locale.getDefaultLang());
        }
        if (param1 >= 61 && param1 <= 90)
        {
            return Locale.loadStringEx("C_ARMOR_3", Locale.getDefaultLang());
        }
        if (param1 >= 90)
        {
            return Locale.loadStringEx("C_ARMOR_4", Locale.getDefaultLang());
        }
        return "";
    }

    public string §in §(double param1)
    {
        if (param1 >= 0 && param1 <= 0.7)
        {
            return Locale.loadStringEx("C_SPEED_0", Locale.getDefaultLang());
        }
        if (param1 > 0.7 && param1 < 1.5)
        {
            return Locale.loadStringEx("C_SPEED_1", Locale.getDefaultLang());
        }
        if (param1 >= 1.5)
        {
            return Locale.loadStringEx("C_SPEED_2", Locale.getDefaultLang());
        }
        return "";
    }
 public string GetArmorString(double param1)
    {
        if (param1 == 0)
        {
            return Locale.loadStringEx("C_ARMOR_0", Locale.getDefaultLang());
        }
        if (param1 >= 1 && param1 <= 30)
        {
            return Locale.loadStringEx("C_ARMOR_1", Locale.getDefaultLang());
        }
        if (param1 >= 31 && param1 <= 60)
        {
            return Locale.loadStringEx("C_ARMOR_2", Locale.getDefaultLang());
        }
        if (param1 >= 61 && param1 <= 90)
        {
            return Locale.loadStringEx("C_ARMOR_3", Locale.getDefaultLang());
        }
        if (param1 >= 90)
        {
            return Locale.loadStringEx("C_ARMOR_4", Locale.getDefaultLang());
        }
        return "";
    }

    public string §in §(double param1)
    {
        if (param1 >= 0 && param1 <= 0.7)
        {
            return Locale.loadStringEx("C_SPEED_0", Locale.getDefaultLang());
        }
        if (param1 > 0.7 && param1 < 1.5)
        {
            return Locale.loadStringEx("C_SPEED_1", Locale.getDefaultLang());
        }
        if (param1 >= 1.5)
        {
            return Locale.loadStringEx("C_SPEED_2", Locale.getDefaultLang());
        }
        return "";
    }

    public string GetReloadString(double param1)
    {
        if (param1 >= 0 && param1 < 0.5)
        {
            return Locale.loadStringEx("C_RELOAD_4", Locale.getDefaultLang());
        }
        if (param1 >= 0.5 && param1 < 0.8)
        {
            return Locale.loadStringEx("C_RELOAD_3", Locale.getDefaultLang());
        }
        if (param1 >= 0.8 && param1 < 1.5)
        {
            return Locale.loadStringEx("C_RELOAD_2", Locale.getDefaultLang());
        }
        if (param1 >= 1.5 && param1 < 2)
        {
            return Locale.loadStringEx("C_RELOAD_1", Locale.getDefaultLang());
        }
        if (param1 >= 2)
        {
            return Locale.loadStringEx("C_RELOAD_0", Locale.getDefaultLang());
        }
        return "";
    }
public string GetReloadString(double param1)
    {
        if (param1 >= 0 && param1 < 0.5)
        {
            return Locale.loadStringEx("C_RELOAD_4", Locale.getDefaultLang());
        }
        if (param1 >= 0.5 && param1 < 0.8)
        {
            return Locale.loadStringEx("C_RELOAD_3", Locale.getDefaultLang());
        }
        if (param1 >= 0.8 && param1 < 1.5)
        {
            return Locale.loadStringEx("C_RELOAD_2", Locale.getDefaultLang());
        }
        if (param1 >= 1.5 && param1 < 2)
        {
            return Locale.loadStringEx("C_RELOAD_1", Locale.getDefaultLang());
        }
        if (param1 >= 2)
        {
            return Locale.loadStringEx("C_RELOAD_0", Locale.getDefaultLang());
        }
        return "";
    }

    public string §_-0b§(double param1)
    {
        if (param1 >= 0 && param1 < 250)
        {
            return Locale.loadStringEx("C_RANGE_0", Locale.getDefaultLang());
        }
        if (param1 >= 250 && param1 < 280)
        {
            return Locale.loadStringEx("C_RANGE_1", Locale.getDefaultLang());
        }
        if (param1 >= 280 && param1 < 310)
        {
            return Locale.loadStringEx("C_RANGE_2", Locale.getDefaultLang());
        }
        if (param1 >= 310 && param1 < 360)
        {
            return Locale.loadStringEx("C_RANGE_3", Locale.getDefaultLang());
        }
        if (param1 >= 360)
        {
            return Locale.loadStringEx("C_RANGE_4", Locale.getDefaultLang());
        }
        return "";
    }

    public void DestroyThis()
    {
        this.mages = null;
        this.archers = null;
        this.engineers = null;
        this.soldiers = null;
        this.powers = null;
        this.enemies = null;
        this.specials = null;
        this.game = null;
    }
}

// javascript
package
{
   import fl.lang.Locale;
   
   public class GameSettings
   {
      
      public static const §_-8Z§:int = 0;
      
      public static const MEDIUM:int = 1;
      
      public static const §_-D6§:int = 2;
      
      public static const §_-6d§:int = 0;
      
      public static const §_-Kd§:int = 1;
      
      public static const §_-GV§:int = 2;
      
      public static const §_-9O§:int = 3;
      
      public static const §_-2Q§:int = 0;
      
      public static const §_-Mv§:int = 1;
      
      public static const MODE_IRON:int = 2;
      
      public static const DIFFICULTY_NORMAL:int = 0;
      
      public static const DIFFICULTY_EASY:int = 1;
      
      public static const §_-L1§:int = 2;
      
      public static const DIFFICULTY_HARD:int = 3;
      
      public static const REINFORCEMENT_NORMAL:int = 0;
      
      public static const §_-9u§:int = 1;
      
      public static const §_-B6§:int = 2;
      
      public static const §_-Jy§:int = 3;
      
      public static const §_-MC§:String = "NotificationTowerMage";
      
      public static const §_-Kk§:String = "NotificationTowerEngineer";
      
      public static const NOTIFICATION_TOWER_LEVEL2:String = "NotificationTowerLevel2";
      
      public static const §_-Jm§:String = "NotificationPowerFireball";
      
      public static const §_-MZ§:String = "NotificationPowerReinforcement";
      
      public static const NOTIFICATION_TOWER_LEVEL3:String = "NotificationTowerLevel3";
      
      public static const §_-DE§:String = "NotificationTowerArcherRanger";
      
      public static const §_-1L§:String = "NotificationTowerSoldierPaladin";
      
      public static const §_-E7§:String = "NotificationTowerMageArcane";
      
      public static const §_-7k§:String = "NotificationTowerMageSorcerer";
      
      public static const §_-8J§:String = "NotificationTowerSoldierBarbarian";
      
      public static const §_-0s§:String = "NotificationTowerArcherMusketeer";
      
      public static const §_-N-§:String = "NotificationTowerEngineerTesla";
      
      public static const §_-1v§:String = "NotificationEnemyGoblin";
      
      public static const §_-4e§:String = "NotificationEnemyFatOrc";
      
      public static const §_-86§:String = "NotificationEnemyOgre";
      
      public static const §_-2j§:String = "NotificationEnemyWolfSmall";
      
      public static const §_-Db§:String = "NotificationEnemyShaman";
      
      public static const §_-6n§:String = "NotificationEnemyBandit";
      
      public static const §_-Bw§:String = "NotificationEnemyBrigand";
      
      public static const §_-IV§:String = "NotificationEnemyDarkKnight";
      
      public static const §_-s§:String = "NotificationEnemyGargoyle";
      
      public static const §_-1a§:String = "NotificationEnemyMarauder";
      
      public static const §_-IL§:String = "NotificationEnemyWolf";
      
      public static const §_-7H§:String = "NotificationEnemyShadowArcher";
      
      public static const §_-Dl§:String = "NotificationEnemySpider";
      
      public static const §_-4i§:String = "NotificationEnemySpiderSmall";
      
      public static const §_-K5§:String = "NotificationEnemyTroll";
      
      public static const §_-A-§:String = "NotificationEnemyTrollAxeThrower";
      
      public static const §_-6l§:String = "NotificationEnemyTrollChieftain";
      
      public static const NOTIFICATION_ENEMY_WHITE_WOLF:String = "NotificationEnemyWhiteWolf";
      
      public static const NOTIFICATION_ENEMY_YETI:String = "NotificationEnemyYeti";
      
      public static const §_-0N§:String = "NotificationEnemySlayer";
      
      public static const §_-4a§:String = "NotificationEnemyRocketeer";
      
      public static const NOTIFICATION_ENEMY_DEMON:String = "NotificationEnemyDemon";
      
      public static const §_-2m§:String = "NotificationEnemyDemonMage";
      
      public static const NOTIFICATION_ENEMY_DEMON_WOLF:String = "NotificationEnemyDemonWolf";
      
      public static const §_-G9§:String = "NotificationEnemyDemonImp";
      
      public static const §_-Mm§:String = "NotificationEnemyNecromancer";
      
      public static const §_-4R§:String = "NotificationEnemyLavaElemental";
      
      public static const §_-EI§:String = "NotificationEnemySarelgazSmall";
      
      public static const §_-4z§:String = "NotificationEnemyOrcArmored";
      
      public static const §_-MT§:String = "NotificationEnemyOrcWolfRider";
      
      public static const §_-4-§:String = "NotificationEnemyGoblinZapper";
      
      public static const §_-GT§:String = "NotificationEnemyForestTroll";
      
      public static const §if§:String = "NotificationTipRallyPoint";
      
      public static const §_-8Y§:String = "NotificationTipArmor";
      
      public static const §_-57§:String = "NotificationTipArmorMagic";
      
      public static const §_-9t§:String = "NotificationTipStrategySoldier";
      
      public static const §_-CD§:String = "NotificationTipStrategyHeavyArmor";
       
      
      private var game:Game;
      
      private var maxUpgradeLevel:int;
      
      public const §_-9b§:Number = 0.3;
      
      public const pcStars:int = 15;
      
      public const framesRate:int = 30;
      
      public const rangeRatio:Number = 0.7;
      
      public const sellPercent:Number = 0.6;
      
      public const §_-Bk§:Number = 2;
      
      public const minSpeed:Number = 2;
      
      public const enemyMaxLevel:int = 99;
      
      public const buildingTime:int = 30;
      
      private var ModifEnemyHealth:Number;
      
      private var ModifSoldierHealth:Number;
      
      public var mages:*;
      
      public var archers:*;
      
      public var engineers:*;
      
      public var soldiers:*;
      
      public var powers:*;
      
      public var enemies:*;
      
      public var specials:*;
      
      public const P_ARMOR:int = 0;
      
      public const M_ARMOR:int = 1;
      
      public const E_ARMOR:int = 2;
      
      public const I_ARMOR:int = 3;
      
      public function GameSettings(param1:Game, param2:Boolean = true, param3:int = 0)
      {
         this.mages = new Object();
         this.archers = new Object();
         this.engineers = new Object();
         this.soldiers = new Object();
         this.powers = new Object();
         this.enemies = new Object();
         this.specials = new Object();
         super();
         this.game = param1;
         if(this.game.difficulty == DIFFICULTY_EASY)
         {
            this.ModifEnemyHealth = 0.8;
            this.ModifSoldierHealth = 1.2;
         }
         else if(this.game.difficulty == DIFFICULTY_NORMAL || this.game.difficulty == §_-L1§)
         {
            this.ModifEnemyHealth = 1;
            this.ModifSoldierHealth = 1;
         }
         else if(this.game.difficulty == DIFFICULTY_HARD)
         {
            this.ModifEnemyHealth = 1.2;
            this.ModifSoldierHealth = 1;
         }
         this.maxUpgradeLevel = param3;
         this.§_-9-§();
         this.§_-Mo§();
         this.§_-2V§();
         this.§throw§();
         this.§_-L§();
         this.§_-9D§();
         this.§_-Ke§();
         if(param2)
         {
            this.§_-5E§();
         }
      }
      
      public function §_-ML§(param1:String) : Object
      {
         switch(param1)
         {
            case "EnemyGoblin":
               return Locale.loadStringEx("ENEMY_GOBLIN_NAME",Locale.getDefaultLang());
            case "EnemyFatOrc":
               return Locale.loadStringEx("ENEMY_FAT_ORC_NAME",Locale.getDefaultLang());
            case "EnemyOgre":
               return Locale.loadStringEx("ENEMY_OGRE_NAME",Locale.getDefaultLang());
            case "EnemyWolfSmall":
               return Locale.loadStringEx("ENEMY_WULF_NAME",Locale.getDefaultLang());
            case "EnemyShaman":
               return Locale.loadStringEx("ENEMY_SHAMAN_NAME",Locale.getDefaultLang());
            case "EnemyGargoyle":
               return Locale.loadStringEx("ENEMY_GARGOYLE_NAME",Locale.getDefaultLang());
            case "EnemySpider":
               return Locale.loadStringEx("ENEMY_SPIDER_NAME",Locale.getDefaultLang());
            case "EnemyBandit":
               return Locale.loadStringEx("ENEMY_BANDIT_NAME",Locale.getDefaultLang());
            case "EnemyBrigand":
               return Locale.loadStringEx("ENEMY_BRIGAND_NAME",Locale.getDefaultLang());
            case "EnemyMarauder":
               return Locale.loadStringEx("ENEMY_MARAUDER_NAME",Locale.getDefaultLang());
            case "EnemyWolf":
               return Locale.loadStringEx("ENEMY_WORG_NAME",Locale.getDefaultLang());
            case "EnemySpider":
               return Locale.loadStringEx("ENEMY_SPIDER_NAME",Locale.getDefaultLang());
            case "EnemySpiderSmall":
               return Locale.loadStringEx("ENEMY_SPIDERSMALL_NAME",Locale.getDefaultLang());
            case "EnemySpiderTiny":
               return Locale.loadStringEx("ENEMY_SPIDERTINY_NAME",Locale.getDefaultLang());
            case "EnemyShadowArcher":
               return Locale.loadStringEx("ENEMY_SHADOW_ARCHER_NAME",Locale.getDefaultLang());
            case "EnemyDarkKnight":
               return Locale.loadStringEx("ENEMY_DARK_NIGHT_NAME",Locale.getDefaultLang());
            case "EnemyJuggernaut":
               return Locale.loadStringEx("ENEMY_JUGGERNAUT_NAME",Locale.getDefaultLang());
            case "EnemyGolemHead":
               return Locale.loadStringEx("ENEMY_GOLEM_HEAD_NAME",Locale.getDefaultLang());
            case "EnemyWhiteWolf":
               return Locale.loadStringEx("ENEMY_WHITE_WOLF_NAME",Locale.getDefaultLang());
            case "EnemyTroll":
               return Locale.loadStringEx("ENEMY_TROLL_NAME",Locale.getDefaultLang());
            case "EnemyTrollChieftain":
               return Locale.loadStringEx("ENEMY_TROLL_CHIEFTAIN_NAME",Locale.getDefaultLang());
            case "EnemyTrollAxeThrower":
               return Locale.loadStringEx("ENEMY_TROLL_AXE_THROWER_NAME",Locale.getDefaultLang());
            case "EnemyYeti":
               return Locale.loadStringEx("ENEMY_YETI_NAME",Locale.getDefaultLang());
            case "EnemyBoss":
               return Locale.loadStringEx("ENEMY_YETI_BOSS_NAME",Locale.getDefaultLang());
            case "EnemyYetiBoss":
               return Locale.loadStringEx("ENEMY_YETI_BOSS_NAME",Locale.getDefaultLang());
            case "EnemySlayer":
               return Locale.loadStringEx("ENEMY_SLAYER_NAME",Locale.getDefaultLang());
            case "EnemyRocketeer":
               return Locale.loadStringEx("ENEMY_ROCKETEER_NAME",Locale.getDefaultLang());
            case "EnemyNecromancer":
               return Locale.loadStringEx("ENEMY_NECROMANCER_NAME",Locale.getDefaultLang());
            case "EnemySkeleton":
               return Locale.loadStringEx("ENEMY_SKELETON_NAME",Locale.getDefaultLang());
            case "EnemySkeletonBig":
               return Locale.loadStringEx("ENEMY_SKELETON_BIG_NAME",Locale.getDefaultLang());
            case "EnemyDemonWolf":
               return Locale.loadStringEx("ENEMY_DEMON_WOLF_NAME",Locale.getDefaultLang());
            case "EnemyDemon":
               return Locale.loadStringEx("ENEMY_DEMON_NAME",Locale.getDefaultLang());
            case "EnemyDemonMage":
               return Locale.loadStringEx("ENEMY_DEMON_MAGE_NAME",Locale.getDefaultLang());
            case "EnemyDemonWolf":
               return Locale.loadStringEx("ENEMY_DEMON_WOLF_NAME",Locale.getDefaultLang());
            case "EnemyDemonImp":
               return Locale.loadStringEx("ENEMY_DEMON_IMP_NAME",Locale.getDefaultLang());
            case "EnemyLavaElemental":
               return Locale.loadStringEx("ENEMY_LAVA_ELEMENTAL_NAME",Locale.getDefaultLang());
            case "EnemyVeznan":
               return Locale.loadStringEx("ENEMY_VEZNAN_NAME",Locale.getDefaultLang());
            case "EnemySarelgaz":
               return Locale.loadStringEx("ENEMY_SARELGAZ_NAME",Locale.getDefaultLang());
            case "EnemySarelgazSmall":
               return Locale.loadStringEx("ENEMY_SARELGAZ_SMALL_NAME",Locale.getDefaultLang());
            case "EnemyGoblinZapper":
               return Locale.loadStringEx("ENEMY_GOBLIN_ZAPPER_NAME",Locale.getDefaultLang());
            case "EnemyForestTroll":
               return Locale.loadStringEx("ENEMY_FOREST_TROLL_NAME",Locale.getDefaultLang());
            case "EnemyOrcWolfRider":
               return Locale.loadStringEx("ENEMY_ORC_WOLF_RIDER_NAME",Locale.getDefaultLang());
            case "EnemyOrcArmored":
               return Locale.loadStringEx("ENEMY_ORC_ARMORED_NAME",Locale.getDefaultLang());
            case "EnemyBossGoblinChieftain":
               return Locale.loadStringEx("ENEMY_BOSS_GOBLIN_CHIEFTAIN_NAME",Locale.getDefaultLang());
            default:
               return null;
         }
      }
      
      private function §_-Mo§() : void
      {
         var _loc1_:* = new Object();
         this.mages.building = _loc1_;
         var _loc2_:* = new Object();
         _loc2_.cost = 100;
         _loc2_.range = 220;
         _loc2_.minDamage = 9;
         _loc2_.maxDamage = 17;
         _loc2_.reload = 1.5 * this.framesRate;
         this.mages.level1 = _loc2_;
         var _loc3_:* = new Object();
         _loc3_.cost = 160;
         _loc3_.range = 250;
         _loc3_.minDamage = 23;
         _loc3_.maxDamage = 43;
         _loc3_.reload = 1.5 * this.framesRate;
         this.mages.level2 = _loc3_;
         var _loc4_:* = new Object();
         _loc4_.cost = 240;
         _loc4_.range = 280;
         _loc4_.minDamage = 40;
         _loc4_.maxDamage = 74;
         _loc4_.reload = 1.5 * this.framesRate;
         this.mages.level3 = _loc4_;
         var _loc5_:* = new Object();
         _loc5_.cost = 300;
         _loc5_.range = 310;
         _loc5_.minDamage = 76;
         _loc5_.maxDamage = 140;
         _loc5_.reload = 2 * this.framesRate;
         _loc5_.deathRayCost = 350;
         _loc5_.deathRayCostLevel = 200;
         _loc5_.deathRayCoolDown = 22 * this.framesRate;
         _loc5_.deathRayLessCoolDown = 2 * this.framesRate;
         _loc5_.deathRayLevels = 3;
         _loc5_.teleportCost = 300;
         _loc5_.teleportCostLevel = 100;
         _loc5_.teleportRange = 50;
         _loc5_.teleportMaxEnemies = 3;
         _loc5_.teleportExtraEnemies = 1;
         _loc5_.teleportNodes = 20;
         _loc5_.teleportExtraNodes = 5;
         _loc5_.teleportCoolDown = 10 * this.framesRate;
         _loc5_.teleportLevels = 3;
         _loc5_.teleportMaxTimes = 3;
         this.mages.arcane = _loc5_;
         var _loc6_:* = new Object();
         _loc6_.cost = 300;
         _loc6_.range = 310;
         _loc6_.minDamage = 42;
         _loc6_.maxDamage = 78;
         _loc6_.reload = 1.5 * this.framesRate;
         _loc6_.curseDamage = 10;
         _loc6_.curseArmorReduce = 50;
         _loc6_.curseDuration = 5 * this.framesRate;
         _loc6_.polymorphCost = 300;
         _loc6_.polymorphCostLevel = 150;
         _loc6_.polymorphDamage = 50;
         _loc6_.polymorphCoolDown = 22 * this.framesRate;
         _loc6_.polymorphLessCoolDown = 2 * this.framesRate;
         _loc6_.polymorphSpeedMultiplier = 1.5;
         _loc6_.polymorphLevels = 3;
         _loc6_.elementalRallyRange = 280;
         _loc6_.elementalMaxSize = §_-D6§;
         _loc6_.elementalCost = 350;
         _loc6_.elementalCostLevel = 150;
         _loc6_.elementalMaxLevel = 10;
         _loc6_.elementalRange = 120;
         _loc6_.elementalHealth = 500;
         _loc6_.elementalExtraHealth = 100;
         _loc6_.elementalRegen = 20;
         _loc6_.elementalRegenReload = 1 * this.framesRate;
         _loc6_.elementalAreaAttackRangeWidth = 70;
         _loc6_.elementalAreaAttackMaxEnemies = 4;
         _loc6_.elementalMinDamage = 40;
         _loc6_.elementalMaxDamage = 80;
         _loc6_.elementalDamageExtra = 10;
         _loc6_.elementalArmor = 30;
         _loc6_.elementalArmorExtra = 10;
         _loc6_.elementalReload = 2 * this.framesRate;
         _loc6_.elementalRespawnTime = 8 * this.framesRate;
         _loc6_.elementalLevels = 3;
         this.mages.sorcerer = _loc6_;
      }
      
      private function §_-9-§() : void
      {
         var _loc1_:* = new Object();
         this.archers.building = _loc1_;
         var _loc2_:* = new Object();
         _loc2_.cost = 70;
         _loc2_.range = 220;
         _loc2_.minDamage = 4;
         _loc2_.maxDamage = 6;
         _loc2_.reload = 0.8 * this.framesRate;
         this.archers.level1 = _loc2_;
         var _loc3_:* = new Object();
         _loc3_.cost = 110;
         _loc3_.range = 250;
         _loc3_.minDamage = 7;
         _loc3_.maxDamage = 11;
         _loc3_.reload = 0.6 * this.framesRate;
         this.archers.level2 = _loc3_;
         var _loc4_:* = new Object();
         _loc4_.cost = 160;
         _loc4_.range = 280;
         _loc4_.minDamage = 10;
         _loc4_.maxDamage = 16;
         _loc4_.reload = 0.5 * this.framesRate;
         this.archers.level3 = _loc4_;
         var _loc5_:* = new Object();
         _loc5_.cost = 230;
         _loc5_.range = 310;
         _loc5_.minDamage = 13;
         _loc5_.maxDamage = 19;
         _loc5_.reload = 0.4 * this.framesRate;
         _loc5_.poisonCost = 250;
         _loc5_.poisonCostLevel = 250;
         _loc5_.poisonDuration = 3 * this.framesRate;
         _loc5_.poisonDamage = 5;
         _loc5_.poisonCoolDown = 0.4 * this.framesRate;
         _loc5_.poisonLevels = 3;
         _loc5_.thornCost = 300;
         _loc5_.thornCostLevel = 150;
         _loc5_.thornMinEnemies = 2;
         _loc5_.thornMaxEnemies = 2;
         _loc5_.thornDuration = 1 * this.framesRate;
         _loc5_.thornDamageTime = 1 * this.framesRate;
         _loc5_.thornDamage = 40;
         _loc5_.thornCoolDown = 8 * this.framesRate;
         _loc5_.thornLevels = 3;
         _loc5_.thornMaxTimes = 3;
         this.archers.ranger = _loc5_;
         var _loc6_:* = new Object();
         _loc6_.cost = 230;
         _loc6_.range = 370;
         _loc6_.minDamage = 35;
         _loc6_.maxDamage = 65;
         _loc6_.reload = 1.5 * this.framesRate;
         _loc6_.sniperCost = 250;
         _loc6_.sniperCostLevel = 250;
         _loc6_.sniperRange = 1.5;
         _loc6_.sniperDamagePercent = 20;
         _loc6_.sniperCoolDown = 14 * this.framesRate;
         _loc6_.sniperLevels = 3;
         _loc6_.shrapnelCost = 300;
         _loc6_.shrapnelCostLevel = 300;
         _loc6_.shrapnelRange = 0.5;
         _loc6_.shrapnelArea = 50;
         _loc6_.shrapnelMinDamage = 50 / 5;
         _loc6_.shrapnelMaxDamage = 200 / 5;
         _loc6_.shrapnelCoolDown = 9 * this.framesRate;
         _loc6_.shrapnelLevels = 3;
         this.archers.musketeer = _loc6_;
      }
      
      private function §_-2V§() : void
      {
         var _loc1_:* = new Object();
         this.engineers.building = _loc1_;
         var _loc2_:* = new Object();
         _loc2_.cost = 125;
         _loc2_.range = 250;
         _loc2_.area = 70;
         _loc2_.minDamage = 7;
         _loc2_.maxDamage = 14;
         _loc2_.reload = 3 * this.framesRate;
         this.engineers.level1 = _loc2_;
         var _loc3_:* = new Object();
         _loc3_.cost = 220;
         _loc3_.range = 250;
         _loc3_.area = 70;
         _loc3_.minDamage = 20;
         _loc3_.maxDamage = 39;
         _loc3_.reload = 3 * this.framesRate;
         this.engineers.level2 = _loc3_;
         var _loc4_:* = new Object();
         _loc4_.cost = 320;
         _loc4_.range = 280;
         _loc4_.area = 75;
         _loc4_.minDamage = 33;
         _loc4_.maxDamage = 66;
         _loc4_.reload = 3 * this.framesRate;
         this.engineers.level3 = _loc4_;
         var _loc5_:* = new Object();
         _loc5_.cost = 400;
         _loc5_.range = 280;
         _loc5_.area = 80;
         _loc5_.minDamage = 60;
         _loc5_.maxDamage = 120;
         _loc5_.reload = 3.5 * this.framesRate;
         _loc5_.missileCost = 250;
         _loc5_.missileCostLevel = 100;
         _loc5_.missileRangeIncrement = 0.2;
         _loc5_.missileArea = 50;
         _loc5_.missileMinDamage = 100;
         _loc5_.missileMaxDamage = 140;
         _loc5_.missileIncrementDamage = 40;
         _loc5_.missileCoolDown = 11 * this.framesRate;
         _loc5_.missileLevels = 3;
         _loc5_.clusterCost = 250;
         _loc5_.clusterCostLevel = 150;
         _loc5_.clusterArea = 70;
         _loc5_.clusterMinDamage = 60;
         _loc5_.clusterMaxDamage = 80;
         _loc5_.clusterMinBombs = 1;
         _loc5_.clusterIncrementBombs = 2;
         _loc5_.clusterCoolDown = 17 * this.framesRate;
         _loc5_.clusterLevels = 3;
         this.engineers.bfg = _loc5_;
         var _loc6_:* = new Object();
         _loc6_.cost = 375;
         _loc6_.range = 260;
         _loc6_.minDamage = 55;
         _loc6_.maxDamage = 105;
         _loc6_.reload = 2.2 * this.framesRate;
         _loc6_.chargedBoltCost = 300;
         _loc6_.chargedBoltCostLevel = 300;
         _loc6_.chargedBoltEnemies = 3;
         _loc6_.chargedBoltIncrementEnemies = 1;
         _loc6_.chargedBoltCoolDown = 6 * this.framesRate;
         _loc6_.chargedBoltLevels = 2;
         _loc6_.chargedBoltRange = 80;
         _loc6_.overchargeCost = 250;
         _loc6_.overchargeCostLevel = 125;
         _loc6_.overchargeArea = 230;
         _loc6_.overchargeMinDamage = 0;
         _loc6_.overchargeMaxDamage = 10;
         _loc6_.overchargeDamageIncrement = 5;
         _loc6_.overchargeCoolDown = 6 * this.framesRate;
         _loc6_.overchargeLevels = 3;
         _loc6_.overchargeDisplayRatio = 0.7;
         this.engineers.tesla = _loc6_;
      }
      
      private function §throw§() : void
      {
         var _loc1_:* = new Object();
         this.engineers.building = _loc1_;
         var _loc2_:* = new Object();
         _loc2_.cost = 70;
         _loc2_.maxSize = MEDIUM;
         _loc2_.maxLevel = 5;
         _loc2_.rangeRally = 230;
         _loc2_.range = 100;
         _loc2_.health = 50 * this.ModifSoldierHealth;
         _loc2_.armor = 0;
         _loc2_.minDamage = 1;
         _loc2_.maxDamage = 3;
         _loc2_.reload = 1 * this.framesRate;
         _loc2_.respawn = 10 * this.framesRate;
         _loc2_.regen = 5;
         _loc2_.regenReload = 1 * this.framesRate;
         this.soldiers.level1 = _loc2_;
         var _loc3_:* = new Object();
         _loc3_.cost = 110;
         _loc3_.maxSize = MEDIUM;
         _loc3_.maxLevel = 5;
         _loc3_.rangeRally = 230;
         _loc3_.range = 100;
         _loc3_.health = 100 * this.ModifSoldierHealth;
         _loc3_.armor = 15;
         _loc3_.minDamage = 3;
         _loc3_.maxDamage = 4;
         _loc3_.reload = 1 * this.framesRate;
         _loc3_.respawn = 10 * this.framesRate;
         _loc3_.regen = 7;
         _loc3_.regenReload = 1 * this.framesRate;
         this.soldiers.level2 = _loc3_;
         var _loc4_:* = new Object();
         _loc4_.cost = 160;
         _loc4_.maxSize = MEDIUM;
         _loc4_.maxLevel = 5;
         _loc4_.rangeRally = 230;
         _loc4_.range = 100;
         _loc4_.health = 150 * this.ModifSoldierHealth;
         _loc4_.armor = 30;
         _loc4_.minDamage = 6;
         _loc4_.maxDamage = 10;
         _loc4_.reload = 1 * this.framesRate;
         _loc4_.respawn = 10 * this.framesRate;
         _loc4_.regen = 10;
         _loc4_.regenReload = 1 * this.framesRate;
         this.soldiers.level3 = _loc4_;
         var _loc5_:* = new Object();
         _loc5_.cost = 230;
         _loc5_.maxSize = MEDIUM;
         _loc5_.maxLevel = 5;
         _loc5_.rangeRally = 230;
         _loc5_.range = 100;
         _loc5_.health = 200 * this.ModifSoldierHealth;
         _loc5_.armor = 50;
         _loc5_.minDamage = 12;
         _loc5_.maxDamage = 18;
         _loc5_.reload = 1 * this.framesRate;
         _loc5_.respawn = 14 * this.framesRate;
         _loc5_.regen = 25;
         _loc5_.regenReload = 1 * this.framesRate;
         _loc5_.healingCost = 150;
         _loc5_.healingCostLevel = 150;
         _loc5_.healingMin = 40;
         _loc5_.healingMax = 60;
         _loc5_.healingCoolDown = 10 * this.framesRate;
         _loc5_.healingLevels = 3;
         _loc5_.holyStrikeCost = 220;
         _loc5_.holyStrikeCostLevel = 150;
         _loc5_.holyStrikeRange = 80;
         _loc5_.holyStrikeMinEnemies = 1;
         _loc5_.holyStrikeMinDamage = 25;
         _loc5_.holyStrikeMaxDamage = 45;
         _loc5_.holyStrikeChance = 10;
         _loc5_.holyStrikeLevels = 3;
         _loc5_.shieldCost = 250;
         _loc5_.shieldCostLevel = 100;
         _loc5_.shieldArmor = 15;
         _loc5_.shieldMaxSize = §_-D6§;
         _loc5_.shieldLevels = 1;
         this.soldiers.paladin = _loc5_;
         var _loc6_:* = new Object();
         _loc6_.cost = 230;
         _loc6_.maxSize = MEDIUM;
         _loc6_.maxLevel = 5;
         _loc6_.rangeRally = 230;
         _loc6_.range = 100;
         _loc6_.health = 200 * this.ModifSoldierHealth;
         _loc6_.armor = 0;
         _loc6_.minDamage = 16;
         _loc6_.maxDamage = 24;
         _loc6_.reload = 1 * this.framesRate;
         _loc6_.respawn = 10 * this.framesRate;
         _loc6_.regen = 20;
         _loc6_.regenReload = 1 * this.framesRate;
         _loc6_.dualWeaponsCost = 300;
         _loc6_.dualWeaponsCostLevel = 100;
         _loc6_.dualWeaponsIncrementDamage = 10;
         _loc6_.dualWeaponsLevels = 3;
         _loc6_.throwingCost = 200;
         _loc6_.throwingCostLevel = 100;
         _loc6_.throwingCoolDown = 3 * this.framesRate;
         _loc6_.throwingRange = 240;
         _loc6_.throwingMinRange = 40;
         _loc6_.throwingMinDamage = 24;
         _loc6_.throwingMaxDamage = 32;
         _loc6_.throwingIncrementDamage = 10;
         _loc6_.throwingIncrementRange = 20;
         _loc6_.throwingLevels = 3;
         _loc6_.huntingNetsCost = 150;
         _loc6_.huntingNetsCostLevel = 75;
         _loc6_.huntingNetsCoolDown = 3 * this.framesRate;
         _loc6_.huntingNetsRange = 150;
         _loc6_.huntingNetsDuration = 3 * this.framesRate;
         _loc6_.huntingNetsNewSpeed = 30;
         _loc6_.huntingNetsNewSpeedIncrement = 15;
         _loc6_.huntingNetsLevels = 3;
         this.soldiers.barbarian = _loc6_;
      }
      
      private function §_-9D§() : void
      {
         var _loc28_:* = undefined;
         var _loc29_:* = undefined;
         var _loc30_:* = undefined;
         var _loc31_:* = undefined;
         var _loc32_:* = undefined;
         var _loc33_:* = undefined;
         var _loc34_:* = undefined;
         var _loc35_:* = undefined;
         var _loc36_:* = undefined;
         var _loc37_:* = undefined;
         var _loc38_:* = undefined;
         var _loc39_:* = undefined;
         var _loc40_:* = undefined;
         var _loc41_:* = undefined;
         var _loc1_:* = new Object();
         _loc1_.className = "EnemyGoblin";
         _loc1_.elite = false;
         _loc1_.size = §_-8Z§;
         _loc1_.isFlying = false;
         _loc1_.health = Math.round(20 * this.ModifEnemyHealth);
         _loc1_.armor = 0;
         _loc1_.magicArmor = 0;
         _loc1_.dodge = 0;
         _loc1_.speed = 1.2;
         _loc1_.gold = 3;
         _loc1_.cost = 1;
         _loc1_.minDamage = 1;
         _loc1_.maxDamage = 4;
         _loc1_.attackReloadTime = 1 * this.framesRate;
         _loc1_.xSoldierAdjust = 15;
         _loc1_.xAdjust = 0;
         _loc1_.yAdjust = -8;
         this.enemies.goblin = _loc1_;
         var _loc2_:* = new Object();
         _loc2_.className = "EnemyWolfSmall";
         _loc2_.elite = false;
         _loc2_.size = §_-8Z§;
         _loc2_.isFlying = false;
         _loc2_.health = Math.round(35 * this.ModifEnemyHealth);
         _loc2_.armor = 0;
         _loc2_.magicArmor = 0;
         _loc2_.dodge = 30;
         _loc2_.speed = 2.5;
         _loc2_.gold = 5;
         _loc2_.cost = 1;
         _loc2_.minDamage = 1;
         _loc2_.maxDamage = 3;
         _loc2_.attackReloadTime = 1 * this.framesRate;
         _loc2_.xSoldierAdjust = 15;
         _loc2_.xAdjust = 0;
         _loc2_.yAdjust = -8;
         this.enemies.wolfSmall = _loc2_;
         var _loc3_:* = new Object();
         _loc3_.className = "EnemyFatOrc";
         _loc3_.elite = false;
         _loc3_.size = MEDIUM;
         _loc3_.isFlying = false;
         _loc3_.health = Math.round(80 * this.ModifEnemyHealth);
         _loc3_.armor = 30;
         _loc3_.magicArmor = 0;
         _loc3_.dodge = 0;
         _loc3_.speed = 0.8;
         _loc3_.gold = 9;
         _loc3_.cost = 1;
         _loc3_.minDamage = 4;
         _loc3_.maxDamage = 8;
         _loc3_.attackReloadTime = 1 * this.framesRate;
         _loc3_.xSoldierAdjust = 15;
         _loc3_.xAdjust = 0;
         _loc3_.yAdjust = -8;
         this.enemies.fatOrc = _loc3_;
         var _loc4_:* = new Object();
         _loc4_.className = "EnemyShaman";
         _loc4_.elite = false;
         _loc4_.size = §_-8Z§;
         _loc4_.isFlying = false;
         _loc4_.health = Math.round(100 * this.ModifEnemyHealth);
         _loc4_.armor = 0;
         _loc4_.magicArmor = 85;
         _loc4_.dodge = 0;
         _loc4_.speed = 1;
         _loc4_.gold = 10;
         _loc4_.cost = 1;
         _loc4_.minDamage = 3;
         _loc4_.maxDamage = 5;
         _loc4_.attackReloadTime = 1 * this.framesRate;
         _loc4_.xSoldierAdjust = 15;
         _loc4_.xAdjust = 0;
         _loc4_.yAdjust = -8;
         _loc4_.healMaxEnemies = 3;
         _loc4_.healCoolDown = 8 * this.framesRate;
         _loc4_.healRange = 150;
         _loc4_.healPoints = 50;
         this.enemies.shaman = _loc4_;
         var _loc5_:* = new Object();
         _loc5_.className = "EnemyOgre";
         _loc5_.elite = false;
         _loc5_.size = §_-D6§;
         _loc5_.isFlying = false;
         _loc5_.health = Math.round(800 * this.ModifEnemyHealth);
         _loc5_.armor = 0;
         _loc5_.magicArmor = 0;
         _loc5_.dodge = 0;
         _loc5_.speed = 0.7;
         _loc5_.gold = 50;
         _loc5_.cost = 3;
         _loc5_.minDamage = 40;
         _loc5_.maxDamage = 60;
         _loc5_.attackReloadTime = 1 * this.framesRate;
         _loc5_.xSoldierAdjust = 25;
         _loc5_.xAdjust = 3;
         _loc5_.yAdjust = -18;
         this.enemies.ogre = _loc5_;
         var _loc6_:* = new Object();
         _loc6_.className = "EnemyBandit";
         _loc6_.elite = false;
         _loc6_.size = §_-8Z§;
         _loc6_.isFlying = false;
         _loc6_.health = Math.round(70 * this.ModifEnemyHealth);
         _loc6_.armor = 0;
         _loc6_.magicArmor = 0;
         _loc6_.dodge = 50;
         _loc6_.speed = 1.2;
         _loc6_.gold = 8;
         _loc6_.cost = 1;
         _loc6_.minDamage = 20;
         _loc6_.maxDamage = 30;
         _loc6_.attackReloadTime = 1 * this.framesRate;
         _loc6_.xSoldierAdjust = 15;
         _loc6_.xAdjust = 0;
         _loc6_.yAdjust = -8;
         this.enemies.bandit = _loc6_;
         var _loc7_:* = new Object();
         _loc7_.className = "EnemyBrigand";
         _loc7_.elite = false;
         _loc7_.size = §_-8Z§;
         _loc7_.isFlying = false;
         _loc7_.health = Math.round(160 * this.ModifEnemyHealth);
         _loc7_.armor = 50;
         _loc7_.magicArmor = 0;
         _loc7_.dodge = 0;
         _loc7_.speed = 0.8;
         _loc7_.gold = 15;
         _loc7_.cost = 1;
         _loc7_.minDamage = 6;
         _loc7_.maxDamage = 10;
         _loc7_.attackReloadTime = 1 * this.framesRate;
         _loc7_.xSoldierAdjust = 15;
         _loc7_.xAdjust = 0;
         _loc7_.yAdjust = -8;
         this.enemies.brigand = _loc7_;
         var _loc8_:* = new Object();
         _loc8_.className = "EnemyMarauder";
         _loc8_.elite = false;
         _loc8_.size = §_-D6§;
         _loc8_.isFlying = false;
         _loc8_.health = Math.round(600 * this.ModifEnemyHealth);
         _loc8_.armor = 60;
         _loc8_.magicArmor = 0;
         _loc8_.dodge = 0;
         _loc8_.speed = 0.8;
         _loc8_.gold = 40;
         _loc8_.cost = 3;
         _loc8_.minDamage = 16;
         _loc8_.maxDamage = 24;
         _loc8_.attackReloadTime = 1 * this.framesRate;
         _loc8_.xSoldierAdjust = 20;
         _loc8_.xAdjust = 0;
         _loc8_.yAdjust = -18;
         this.enemies.marauder = _loc8_;
         var _loc9_:* = new Object();
         _loc9_.className = "EnemyWolf";
         _loc9_.elite = false;
         _loc9_.size = MEDIUM;
         _loc9_.isFlying = false;
         _loc9_.health = Math.round(120 * this.ModifEnemyHealth);
         _loc9_.armor = 0;
         _loc9_.magicArmor = 50;
         _loc9_.dodge = 50;
         _loc9_.speed = 2;
         _loc9_.gold = 12;
         _loc9_.cost = 1;
         _loc9_.minDamage = 12;
         _loc9_.maxDamage = 18;
         _loc9_.attackReloadTime = 1 * this.framesRate;
         _loc9_.xSoldierAdjust = 20;
         _loc9_.xAdjust = 0;
         _loc9_.yAdjust = -8;
         this.enemies.wolf = _loc9_;
         var _loc10_:* = new Object();
         _loc10_.className = "EnemySpider";
         _loc10_.elite = false;
         _loc10_.size = §_-8Z§;
         _loc10_.isFlying = false;
         _loc10_.health = Math.round(250 * this.ModifEnemyHealth);
         _loc10_.armor = 0;
         _loc10_.magicArmor = 80;
         _loc10_.dodge = 0;
         _loc10_.speed = 1;
         _loc10_.gold = 20;
         _loc10_.cost = 2;
         _loc10_.minDamage = 15;
         _loc10_.maxDamage = 25;
         _loc10_.attackReloadTime = 1 * this.framesRate;
         _loc10_.xSoldierAdjust = 24;
         _loc10_.xAdjust = 1;
         _loc10_.yAdjust = -8;
         _loc10_.eggsMax = 3;
         _loc10_.eggsSpiders = 3;
         _loc10_.eggsCooldownTimeMin = 4 * this.framesRate;
         _loc10_.eggsCooldownTimeMax = 8 * this.framesRate;
         this.enemies.spider = _loc10_;
         var _loc11_:* = new Object();
         _loc11_.className = "EnemySpiderTiny";
         _loc11_.elite = false;
         _loc11_.size = §_-8Z§;
         _loc11_.isFlying = false;
         _loc11_.health = Math.round(10 * this.ModifEnemyHealth);
         _loc11_.armor = 0;
         _loc11_.magicArmor = 50;
         _loc11_.dodge = 0;
         _loc11_.speed = 2;
         _loc11_.gold = 0;
         _loc11_.cost = 1;
         _loc11_.minDamage = 1;
         _loc11_.maxDamage = 5;
         _loc11_.attackReloadTime = 1 * this.framesRate;
         _loc11_.xSoldierAdjust = 14;
         _loc11_.xAdjust = 1;
         _loc11_.yAdjust = -4;
         this.enemies.spiderTiny = _loc11_;
         var _loc12_:* = new Object();
         _loc12_.className = "EnemySpiderSmall";
         _loc12_.elite = false;
         _loc12_.size = §_-8Z§;
         _loc12_.isFlying = false;
         _loc12_.health = Math.round(60 * this.ModifEnemyHealth);
         _loc12_.armor = 0;
         _loc12_.magicArmor = 65;
         _loc12_.dodge = 0;
         _loc12_.speed = 1.5;
         _loc12_.gold = 6;
         _loc12_.cost = 1;
         _loc12_.minDamage = 10;
         _loc12_.maxDamage = 18;
         _loc12_.attackReloadTime = 1 * this.framesRate;
         _loc12_.xSoldierAdjust = 18;
         _loc12_.xAdjust = 1;
         _loc12_.yAdjust = -8;
         this.enemies.spiderSmall = _loc12_;
         var _loc13_:* = new Object();
         _loc13_.className = "EnemySarelgaz";
         _loc13_.elite = false;
         _loc13_.size = §_-8Z§;
         _loc13_.isFlying = false;
         _loc13_.health = Math.round(18000 * this.ModifEnemyHealth);
         _loc13_.armor = 0;
         _loc13_.magicArmor = 0;
         _loc13_.dodge = 0;
         _loc13_.speed = 0.4;
         _loc13_.gold = 0;
         _loc13_.cost = 20;
         _loc13_.minDamage = 300;
         _loc13_.maxDamage = 500;
         _loc13_.attackReloadTime = 1 * this.framesRate;
         _loc13_.xSoldierAdjust = 75;
         _loc13_.xAdjust = 1;
         _loc13_.yAdjust = -40;
         this.enemies.sarelgaz = _loc13_;
         var _loc14_:* = new Object();
         _loc14_.className = "EnemySarelgazSmall";
         _loc14_.elite = false;
         _loc14_.size = §_-8Z§;
         _loc14_.isFlying = false;
         _loc14_.health = Math.round(1250 * this.ModifEnemyHealth);
         _loc14_.armor = 70;
         _loc14_.magicArmor = 70;
         _loc14_.dodge = 0;
         _loc14_.speed = 0.8;
         _loc14_.gold = 80;
         _loc14_.cost = 1;
         _loc14_.minDamage = 50;
         _loc14_.maxDamage = 100;
         _loc14_.attackReloadTime = 1 * this.framesRate;
         _loc14_.xSoldierAdjust = 32;
         _loc14_.xAdjust = 1;
         _loc14_.yAdjust = -21;
         this.enemies.sarelgazSmall = _loc14_;
         var _loc15_:* = new Object();
         _loc15_.className = "EnemyShadowArcher";
         _loc15_.elite = false;
         _loc15_.size = §_-8Z§;
         _loc15_.isFlying = false;
         _loc15_.health = Math.round(180 * this.ModifEnemyHealth);
         _loc15_.armor = 0;
         _loc15_.magicArmor = 30;
         _loc15_.dodge = 0;
         _loc15_.speed = 1.2;
         _loc15_.gold = 16;
         _loc15_.cost = 1;
         _loc15_.minDamage = 10;
         _loc15_.maxDamage = 20;
         _loc15_.attackReloadTime = 1 * this.framesRate;
         _loc15_.xSoldierAdjust = 15;
         _loc15_.xAdjust = 1;
         _loc15_.yAdjust = -8;
         _loc15_.arrowCoolDown = 1 * this.framesRate;
         _loc15_.arrowRange = 230;
         _loc15_.arrowMinRange = 40;
         _loc15_.arrowMinDamage = 20;
         _loc15_.arrowMaxDamage = 30;
         this.enemies.shadowArcher = _loc15_;
         var _loc16_:* = new Object();
         _loc16_.className = "EnemyDarkKnight";
         _loc16_.elite = false;
         _loc16_.size = §_-8Z§;
         _loc16_.isFlying = false;
         _loc16_.health = Math.round(300 * this.ModifEnemyHealth);
         _loc16_.armor = 80;
         _loc16_.magicArmor = 0;
         _loc16_.dodge = 0;
         _loc16_.speed = 0.7;
         _loc16_.gold = 25;
         _loc16_.cost = 1;
         _loc16_.minDamage = 15;
         _loc16_.maxDamage = 25;
         _loc16_.attackReloadTime = 1 * this.framesRate;
         _loc16_.xSoldierAdjust = 20;
         _loc16_.xAdjust = 0;
         _loc16_.yAdjust = -10;
         this.enemies.darkKnight = _loc16_;
         var _loc17_:* = new Object();
         _loc17_.className = "EnemyGargoyle";
         _loc17_.elite = false;
         _loc17_.size = §_-8Z§;
         _loc17_.isFlying = true;
         _loc17_.health = Math.round(90 * this.ModifEnemyHealth);
         _loc17_.armor = 0;
         _loc17_.magicArmor = 0;
         _loc17_.dodge = 0;
         _loc17_.speed = 1.2;
         _loc17_.gold = 12;
         _loc17_.cost = 1;
         _loc17_.minDamage = 1;
         _loc17_.maxDamage = 2;
         _loc17_.attackReloadTime = 1 * this.framesRate;
         _loc17_.xSoldierAdjust = 15;
         _loc17_.xAdjust = 3;
         _loc17_.yAdjust = -45;
         this.enemies.gargoyle = _loc17_;
         var _loc18_:* = new Object();
         _loc18_.className = "EnemyJuggernaut";
         _loc18_.elite = false;
         _loc18_.size = §_-D6§;
         _loc18_.isFlying = false;
         _loc18_.health = Math.round(10000 * this.ModifEnemyHealth);
         _loc18_.armor = 0;
         _loc18_.magicArmor = 0;
         _loc18_.dodge = 0;
         _loc18_.speed = 0.4;
         _loc18_.gold = 0;
         _loc18_.cost = 20;
         _loc18_.attackReloadTime = 2 * this.framesRate;
         _loc18_.xSoldierAdjust = 35;
         _loc18_.xAdjust = 0;
         _loc18_.yAdjust = -30;
         _loc18_.missileCoolDown = 9 * this.framesRate;
         _loc18_.missileMinRange = 100;
         _loc18_.missileMinDamage = 150;
         _loc18_.missileMaxDamage = 250;
         _loc18_.areaAttackRangeWidth = 90;
         _loc18_.minDamage = 150;
         _loc18_.maxDamage = 250;
         _loc18_.areaAttackMaxEnemies = 10;
         _loc18_.golemHeads = 7;
         _loc18_.spawnCooldownTime = 6 * this.framesRate;
         this.enemies.juggernaut = _loc18_;
         var _loc19_:* = new Object();
         _loc19_.className = "EnemyGolemHead";
         _loc19_.elite = false;
         _loc19_.size = §_-8Z§;
         _loc19_.isFlying = false;
         _loc19_.health = Math.round(125 * this.ModifEnemyHealth);
         _loc19_.armor = 0;
         _loc19_.magicArmor = 0;
         _loc19_.dodge = 0;
         _loc19_.speed = 0.7;
         _loc19_.gold = 10;
         _loc19_.cost = 1;
         _loc19_.minDamage = 10;
         _loc19_.maxDamage = 20;
         _loc19_.attackReloadTime = 1 * this.framesRate;
         _loc19_.xSoldierAdjust = 14;
         _loc19_.xAdjust = 1;
         _loc19_.yAdjust = -8;
         this.enemies.golemHead = _loc19_;
         var _loc20_:* = new Object();
         _loc20_.className = "EnemyWhiteWolf";
         _loc20_.elite = false;
         _loc20_.size = §_-8Z§;
         _loc20_.isFlying = false;
         _loc20_.health = Math.round(350 * this.ModifEnemyHealth);
         _loc20_.armor = 0;
         _loc20_.magicArmor = 50;
         _loc20_.dodge = 50;
         _loc20_.speed = 2;
         _loc20_.gold = 35;
         _loc20_.cost = 1;
         _loc20_.minDamage = 20;
         _loc20_.maxDamage = 40;
         _loc20_.attackReloadTime = 1 * this.framesRate;
         _loc20_.xSoldierAdjust = 15;
         _loc20_.xAdjust = 0;
         _loc20_.yAdjust = -8;
         _loc20_.regenerateTime = 30;
         _loc20_.regenerateHealPoints = 0;
         this.enemies.whiteWolf = _loc20_;
         var _loc21_:* = new Object();
         _loc21_.className = "EnemyTroll";
         _loc21_.elite = false;
         _loc21_.size = §_-8Z§;
         _loc21_.isFlying = false;
         _loc21_.health = Math.round(280 * this.ModifEnemyHealth);
         _loc21_.armor = 0;
         _loc21_.magicArmor = 0;
         _loc21_.dodge = 0;
         _loc21_.speed = 0.9;
         _loc21_.gold = 25;
         _loc21_.cost = 1;
         _loc21_.minDamage = 20;
         _loc21_.maxDamage = 40;
         _loc21_.attackReloadTime = 1 * this.framesRate;
         _loc21_.xSoldierAdjust = 15;
         _loc21_.xAdjust = 0;
         _loc21_.yAdjust = -8;
         _loc21_.regenerateTime = 5;
         _loc21_.regenerateHealPoints = 1;
         this.enemies.troll = _loc21_;
         var _loc22_:* = new Object();
         _loc22_.className = "EnemyTrollChieftain";
         _loc22_.elite = false;
         _loc22_.size = §_-D6§;
         _loc22_.isFlying = false;
         _loc22_.health = Math.round(1200 * this.ModifEnemyHealth);
         _loc22_.armor = 0;
         _loc22_.magicArmor = 0;
         _loc22_.dodge = 0;
         _loc22_.speed = 0.6;
         _loc22_.gold = 70;
         _loc22_.cost = 6;
         _loc22_.minDamage = 10;
         _loc22_.maxDamage = 30;
         _loc22_.attackReloadTime = 1 * this.framesRate;
         _loc22_.xSoldierAdjust = 25;
         _loc22_.xAdjust = 0;
         _loc22_.yAdjust = -18;
         _loc22_.rageMaxEnemies = 3;
         _loc22_.rageCoolDown = 6 * this.framesRate;
         _loc22_.rageDurationTime = 6 * this.framesRate;
         _loc22_.rageRange = 280;
         _loc22_.rageHealPoints = 50;
         _loc22_.rageAddedMinDamage = 15;
         _loc22_.rageAddedMaxDamage = 30;
         _loc22_.rageAddedSpeed = 0.8;
         _loc22_.rageAddedArmor = 50;
         _loc22_.regenerateTime = 5;
         _loc22_.regenerateHealPoints = 4;
         this.enemies.trollChieftain = _loc22_;
         var _loc23_:* = new Object();
         _loc23_.className = "EnemyTrollAxeThrower";
         _loc23_.elite = false;
         _loc23_.size = §_-D6§;
         _loc23_.isFlying = false;
         _loc23_.health = Math.round(600 * this.ModifEnemyHealth);
         _loc23_.armor = 0;
         _loc23_.magicArmor = 0;
         _loc23_.dodge = 0;
         _loc23_.speed = 0.8;
         _loc23_.gold = 50;
         _loc23_.cost = 3;
         _loc23_.minDamage = 30;
         _loc23_.maxDamage = 50;
         _loc23_.attackReloadTime = 1 * this.framesRate;
         _loc23_.xSoldierAdjust = 15;
         _loc23_.xAdjust = 1;
         _loc23_.yAdjust = -8;
         _loc23_.axeCoolDown = 1 * this.framesRate;
         _loc23_.axeRange = 230;
         _loc23_.axeMinRange = 40;
         _loc23_.axeMinDamage = 40;
         _loc23_.axeMaxDamage = 80;
         _loc23_.regenerateTime = 5;
         _loc23_.regenerateHealPoints = 2;
         this.enemies.trollAxeThrower = _loc23_;
         var _loc24_:* = new Object();
         _loc24_.className = "EnemyYeti";
         _loc24_.elite = false;
         _loc24_.size = §_-D6§;
         _loc24_.isFlying = false;
         _loc24_.health = Math.round(2000 * this.ModifEnemyHealth);
         _loc24_.armor = 0;
         _loc24_.magicArmor = 0;
         _loc24_.dodge = 0;
         _loc24_.speed = 0.7;
         _loc24_.gold = 120;
         _loc24_.cost = 5;
         _loc24_.attackReloadTime = 2.5 * this.framesRate;
         _loc24_.xSoldierAdjust = 27;
         _loc24_.xAdjust = 0;
         _loc24_.yAdjust = -18;
         _loc24_.minDamage = 50;
         _loc24_.maxDamage = 150;
         _loc24_.areaAttackRangeWidth = 70;
         _loc24_.areaAttackMaxEnemies = 10;
         this.enemies.yeti = _loc24_;
         var _loc25_:* = new Object();
         _loc25_.className = "EnemyYetiBoss";
         _loc25_.elite = false;
         _loc25_.size = §_-D6§;
         _loc25_.isFlying = false;
         _loc25_.health = Math.round(11000 * this.ModifEnemyHealth);
         _loc25_.armor = 0;
         _loc25_.magicArmor = 0;
         _loc25_.dodge = 0;
         _loc25_.speed = 0.4;
         _loc25_.gold = 0;
         _loc25_.cost = 20;
         _loc25_.attackReloadTime = 2 * this.framesRate;
         _loc25_.xSoldierAdjust = 35;
         _loc25_.xAdjust = 0;
         _loc25_.yAdjust = -50;
         _loc25_.breathDuration = 4 * this.framesRate;
         _loc25_.minDamage = 150;
         _loc25_.maxDamage = 200;
         _loc25_.areaDamageAttackRangeWidth = 70;
         _loc25_.areaDamageAttackMaxEnemies = 10;
         _loc25_.areaAttackRangeWidth = 70;
         _loc25_.areaAttackMaxEnemies = 5;
         _loc25_.frozeMaxTowers = 4;
         _loc25_.frozeRangeWidth = 300;
         _loc25_.frozeReloadTime = 10 * this.framesRate;
         _loc25_.maxWolf = 2;
         _loc25_.wolfSpawnCooldownTime = 8 * this.framesRate;
         _loc25_.wolfSpawnInterval = 20;
         _loc25_.maxYetis = 1;
         _loc25_.yetisSpawnCooldownTime = 19 * this.framesRate;
         _loc25_.yetisSpawnInterval = 200;
         this.enemies.yetiBoss = _loc25_;
         var _loc26_:* = new Object();
         _loc26_.className = "EnemySlayer";
         _loc26_.elite = false;
         _loc26_.size = §_-D6§;
         _loc26_.isFlying = false;
         _loc26_.health = Math.round(1200 * this.ModifEnemyHealth);
         _loc26_.armor = 95;
         _loc26_.magicArmor = 0;
         _loc26_.dodge = 0;
         _loc26_.speed = 0.7;
         _loc26_.gold = 100;
         _loc26_.cost = 3;
         _loc26_.minDamage = 24;
         _loc26_.maxDamage = 76;
         _loc26_.attackReloadTime = 1 * this.framesRate;
         _loc26_.xSoldierAdjust = 20;
         _loc26_.xAdjust = 0;
         _loc26_.yAdjust = -18;
         this.enemies.slayer = _loc26_;
         var _loc27_:* = new Object();
         _loc27_.className = "EnemyRocketeer";
         _loc27_.elite = false;
         _loc27_.size = §_-8Z§;
         _loc27_.isFlying = true;
         _loc27_.health = Math.round(340 * this.ModifEnemyHealth);
         _loc27_.armor = 0;
         _loc27_.magicArmor = 0;
         _loc27_.dodge = 0;
         _loc27_.speed = 1.2;
         _loc27_.gold = 30;
         _loc27_.cost = 1;
         _loc27_.minDamage = 1;
         _loc27_.maxDamage = 2;
         _loc27_.attackReloadTime = 1 * this.framesRate;
         _loc27_.xSoldierAdjust = 15;
         _loc27_.xAdjust = 0;
         _loc27_.yAdjust = -50;
         _loc27_.fastSpeedDuration = 2 * this.framesRate;
         _loc27_.fastSpeed = 4;
         this.enemies.rocketeer = _loc27_;
         _loc28_ = new Object();
         _loc28_.className = "EnemySkeleton";
         _loc28_.elite = false;
         _loc28_.size = §_-8Z§;
         _loc28_.isFlying = false;
         _loc28_.health = Math.round(120 * this.ModifEnemyHealth);
         _loc28_.armor = 0;
         _loc28_.magicArmor = 0;
         _loc28_.dodge = 0;
         _loc28_.speed = 0.6;
         _loc28_.gold = 2;
         _loc28_.cost = 1;
         _loc28_.minDamage = 10;
         _loc28_.maxDamage = 20;
         _loc28_.attackReloadTime = 1 * this.framesRate;
         _loc28_.xSoldierAdjust = 15;
         _loc28_.xAdjust = 0;
         _loc28_.yAdjust = -8;
         this.enemies.skeleton = _loc28_;
         _loc29_ = new Object();
         _loc29_.className = "EnemySkeletonBig";
         _loc29_.elite = false;
         _loc29_.size = §_-D6§;
         _loc29_.isFlying = false;
         _loc29_.health = Math.round(400 * this.ModifEnemyHealth);
         _loc29_.armor = 30;
         _loc29_.magicArmor = 0;
         _loc29_.dodge = 0;
         _loc29_.speed = 0.6;
         _loc29_.gold = 10;
         _loc29_.cost = 1;
         _loc29_.minDamage = 20;
         _loc29_.maxDamage = 40;
         _loc29_.attackReloadTime = 1 * this.framesRate;
         _loc29_.xSoldierAdjust = 18;
         _loc29_.xAdjust = 0;
         _loc29_.yAdjust = -11;
         this.enemies.skeletonBig = _loc29_;
         _loc30_ = new Object();
         _loc30_.className = "EnemyDemonWolf";
         _loc30_.elite = false;
         _loc30_.size = §_-8Z§;
         _loc30_.isFlying = false;
         _loc30_.health = Math.round(350 * this.ModifEnemyHealth);
         _loc30_.armor = 0;
         _loc30_.magicArmor = 60;
         _loc30_.dodge = 50;
         _loc30_.speed = 1.5;
         _loc30_.gold = 25;
         _loc30_.cost = 1;
         _loc30_.minDamage = 20;
         _loc30_.maxDamage = 40;
         _loc30_.attackReloadTime = 1 * this.framesRate;
         _loc30_.xSoldierAdjust = 20;
         _loc30_.xAdjust = 0;
         _loc30_.yAdjust = -8;
         _loc30_.exploteRange = 100;
         _loc30_.exploteMinDamage = 70;
         _loc30_.exploteMaxDamage = 140;
         this.enemies.demonWolf = _loc30_;
         _loc31_ = new Object();
         _loc31_.className = "EnemyDemon";
         _loc31_.elite = false;
         _loc31_.size = §_-8Z§;
         _loc31_.isFlying = false;
         _loc31_.health = Math.round(250 * this.ModifEnemyHealth);
         _loc31_.armor = 0;
         _loc31_.magicArmor = 60;
         _loc31_.dodge = 0;
         _loc31_.speed = 0.8;
         _loc31_.gold = 20;
         _loc31_.cost = 1;
         _loc31_.minDamage = 10;
         _loc31_.maxDamage = 30;
         _loc31_.attackReloadTime = 1 * this.framesRate;
         _loc31_.xSoldierAdjust = 15;
         _loc31_.xAdjust = 0;
         _loc31_.yAdjust = -8;
         _loc31_.exploteRange = 100;
         _loc31_.exploteMinDamage = 50;
         _loc31_.exploteMaxDamage = 100;
         this.enemies.demon = _loc31_;
         _loc32_ = new Object();
         _loc32_.className = "EnemyDemonMage";
         _loc32_.elite = false;
         _loc32_.size = §_-D6§;
         _loc32_.isFlying = false;
         _loc32_.health = Math.round(1000 * this.ModifEnemyHealth);
         _loc32_.armor = 0;
         _loc32_.magicArmor = 60;
         _loc32_.dodge = 0;
         _loc32_.speed = 0.6;
         _loc32_.gold = 60;
         _loc32_.cost = 5;
         _loc32_.minDamage = 15;
         _loc32_.maxDamage = 75;
         _loc32_.attackReloadTime = 1 * this.framesRate;
         _loc32_.xSoldierAdjust = 23;
         _loc32_.xAdjust = 0;
         _loc32_.yAdjust = -18;
         _loc32_.shieldMaxEnemies = 4;
         _loc32_.shieldCoolDown = 6 * this.framesRate;
         _loc32_.shieldIgnoreHits = 4;
         _loc32_.shieldRange = 280;
         _loc32_.exploteRange = 100;
         _loc32_.exploteMinDamage = 200;
         _loc32_.exploteMaxDamage = 400;
         this.enemies.demonMage = _loc32_;
         _loc33_ = new Object();
         _loc33_.className = "EnemyNecromancer";
         _loc33_.elite = false;
         _loc33_.size = §_-8Z§;
         _loc33_.isFlying = false;
         _loc33_.health = Math.round(700 * this.ModifEnemyHealth);
         _loc33_.armor = 0;
         _loc33_.magicArmor = 0;
         _loc33_.dodge = 0;
         _loc33_.speed = 0.6;
         _loc33_.gold = 50;
         _loc33_.cost = 3;
         _loc33_.minDamage = 20;
         _loc33_.maxDamage = 40;
         _loc33_.attackReloadTime = 1 * this.framesRate;
         _loc33_.xSoldierAdjust = 15;
         _loc33_.xAdjust = 0;
         _loc33_.yAdjust = -9;
         _loc33_.summonMaxSkeletons = 35;
         _loc33_.summonMaxEnemies = 4;
         _loc33_.summonCoolDown = 8 * this.framesRate;
         _loc33_.spellCoolDown = 1 * this.framesRate;
         _loc33_.spellRange = 230;
         _loc33_.spellMinRange = 40;
         _loc33_.spellMinDamage = 20;
         _loc33_.spellMaxDamage = 40;
         this.enemies.necromancer = _loc33_;
         _loc34_ = new Object();
         _loc34_.className = "EnemyDemonImp";
         _loc34_.elite = false;
         _loc34_.size = §_-8Z§;
         _loc34_.isFlying = true;
         _loc34_.health = Math.round(350 * this.ModifEnemyHealth);
         _loc34_.armor = 0;
         _loc34_.magicArmor = 0;
         _loc34_.dodge = 0;
         _loc34_.speed = 1;
         _loc34_.gold = 25;
         _loc34_.cost = 1;
         _loc34_.minDamage = 1;
         _loc34_.maxDamage = 2;
         _loc34_.attackReloadTime = 1 * this.framesRate;
         _loc34_.xSoldierAdjust = 15;
         _loc34_.xAdjust = 3;
         _loc34_.yAdjust = -45;
         this.enemies.demonImp = _loc34_;
         _loc35_ = new Object();
         _loc35_.className = "EnemyLavaElemental";
         _loc35_.elite = false;
         _loc35_.size = §_-D6§;
         _loc35_.isFlying = false;
         _loc35_.health = Math.round(2500 * this.ModifEnemyHealth);
         _loc35_.armor = 0;
         _loc35_.magicArmor = 0;
         _loc35_.dodge = 0;
         _loc35_.speed = 0.5;
         _loc35_.gold = 100;
         _loc35_.cost = 5;
         _loc35_.attackReloadTime = 2.5 * this.framesRate;
         _loc35_.xSoldierAdjust = 27;
         _loc35_.xAdjust = 0;
         _loc35_.yAdjust = -18;
         _loc35_.minDamage = 50;
         _loc35_.maxDamage = 150;
         _loc35_.areaAttackRangeWidth = 70;
         _loc35_.areaAttackMaxEnemies = 10;
         this.enemies.lavaElemental = _loc35_;
         _loc36_ = new Object();
         _loc36_.className = "EnemyVeznan";
         _loc36_.elite = false;
         _loc36_.size = §_-D6§;
         _loc36_.isFlying = false;
         _loc36_.health = Math.round(6666 * this.ModifEnemyHealth);
         _loc36_.armor = 0;
         _loc36_.magicArmor = 0;
         _loc36_.dodge = 0;
         _loc36_.speed = 0.4;
         _loc36_.gold = 0;
         _loc36_.cost = 20;
         _loc36_.attackReloadTime = 2 * this.framesRate;
         _loc36_.xSoldierAdjust = 20;
         _loc36_.xAdjust = 0;
         _loc36_.yAdjust = -18;
         _loc36_.demonHealth = 6666;
         _loc36_.demonSpeed = 0.6;
         _loc36_.demonAttackReloadTime = 2.5 * this.framesRate;
         _loc36_.demonXSoldierAdjust = 35;
         _loc36_.demonXAdjust = 0;
         _loc36_.demonYAdjust = -45;
         _loc36_.minDamage = 666;
         _loc36_.maxDamage = 999;
         _loc36_.areaAttackRangeWidth = 120;
         _loc36_.areaAttackMaxEnemies = 8;
         _loc36_.tsungReloadTime = 5 * this.framesRate;
         _loc36_.tsungRangeWidth = 230;
         _loc36_.tsungMinRange = 50;
         _loc36_.tsungMaxEnemies = 5;
         _loc36_.portalTimers = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[15,1,0,0,3],[10,1,0,0,2],[20,0,1,0,3],[15,1,0,0,3],[20,1,1,0,3],[15,1,1,0,3],[15,1,1,0,3],[15,0,0,1,3],[15,1,1,1,3],[15,1,1,1,3]];
         _loc36_.holdTimers = [[0,3],[0,3],[0,3],[0,3],[0,2],[0,2],[0,2],[0,2],[13,2],[13,3],[14,4],[14,5],[16,6],[16,7],[18,8]];
         _loc36_.towerHoldFreeTime = 4 * this.framesRate;
         _loc36_.towerHoldBlockTime = 6 * this.framesRate;
         this.enemies.veznan = _loc36_;
         _loc37_ = new Object();
         _loc37_.className = "EnemyGoblinZapper";
         _loc37_.elite = false;
         _loc37_.size = §_-8Z§;
         _loc37_.isFlying = false;
         _loc37_.health = Math.round(140 * this.ModifEnemyHealth);
         _loc37_.armor = 0;
         _loc37_.magicArmor = 0;
         _loc37_.dodge = 0;
         _loc37_.speed = 1.2;
         _loc37_.gold = 10;
         _loc37_.cost = 1;
         _loc37_.minDamage = 10;
         _loc37_.maxDamage = 20;
         _loc37_.attackReloadTime = 1 * this.framesRate;
         _loc37_.xSoldierAdjust = 15;
         _loc37_.xAdjust = 1;
         _loc37_.yAdjust = -8;
         _loc37_.bombCoolDown = 1 * this.framesRate;
         _loc37_.bombRange = 260;
         _loc37_.bombMinRange = 40;
         _loc37_.bombMinDamage = 30;
         _loc37_.bombMaxDamage = 60;
         _loc37_.exploteRange = 120;
         _loc37_.exploteMinDamage = 50;
         _loc37_.exploteMaxDamage = 150;
         this.enemies.goblinZapper = _loc37_;
         _loc38_ = new Object();
         _loc38_.className = "EnemyForestTroll";
         _loc38_.elite = false;
         _loc38_.size = §_-D6§;
         _loc38_.isFlying = false;
         _loc38_.health = Math.round(4000 * this.ModifEnemyHealth);
         _loc38_.armor = 0;
         _loc38_.magicArmor = 0;
         _loc38_.dodge = 0;
         _loc38_.speed = 0.6;
         _loc38_.gold = 200;
         _loc38_.cost = 5;
         _loc38_.attackReloadTime = 2.5 * this.framesRate;
         _loc38_.xSoldierAdjust = 27;
         _loc38_.xAdjust = 0;
         _loc38_.yAdjust = -18;
         _loc38_.minDamage = 50;
         _loc38_.maxDamage = 150;
         _loc38_.areaAttackRangeWidth = 70;
         _loc38_.areaAttackMaxEnemies = 10;
         _loc38_.regenerateTime = 1;
         _loc38_.regenerateHealPoints = 2;
         this.enemies.forestTroll = _loc38_;
         _loc39_ = new Object();
         _loc39_.className = "EnemyOrcWolfRider";
         _loc39_.elite = false;
         _loc39_.size = MEDIUM;
         _loc39_.isFlying = false;
         _loc39_.health = Math.round(400 * this.ModifEnemyHealth);
         _loc39_.armor = 0;
         _loc39_.magicArmor = 80;
         _loc39_.dodge = 0;
         _loc39_.speed = 1.4;
         _loc39_.gold = 25;
         _loc39_.cost = 2;
         _loc39_.minDamage = 20;
         _loc39_.maxDamage = 40;
         _loc39_.attackReloadTime = 1 * this.framesRate;
         _loc39_.xSoldierAdjust = 22;
         _loc39_.xAdjust = 0;
         _loc39_.yAdjust = -13;
         this.enemies.orcWolfRider = _loc39_;
         _loc40_ = new Object();
         _loc40_.className = "EnemyOrcArmored";
         _loc40_.elite = false;
         _loc40_.size = MEDIUM;
         _loc40_.isFlying = false;
         _loc40_.health = Math.round(400 * this.ModifEnemyHealth);
         _loc40_.armor = 80;
         _loc40_.magicArmor = 0;
         _loc40_.dodge = 0;
         _loc40_.speed = 0.8;
         _loc40_.gold = 30;
         _loc40_.cost = 1;
         _loc40_.minDamage = 20;
         _loc40_.maxDamage = 40;
         _loc40_.attackReloadTime = 1 * this.framesRate;
         _loc40_.xSoldierAdjust = 18;
         _loc40_.xAdjust = 0;
         _loc40_.yAdjust = -12;
         this.enemies.orcArmored = _loc40_;
         _loc41_ = new Object();
         _loc41_.className = "EnemyBossGoblinChieftain";
         _loc41_.elite = false;
         _loc41_.size = §_-D6§;
         _loc41_.isFlying = false;
         _loc41_.health = Math.round(12000 * this.ModifEnemyHealth);
         _loc41_.armor = 0;
         _loc41_.magicArmor = 0;
         _loc41_.dodge = 0;
         _loc41_.speed = 0.4;
         _loc41_.gold = 0;
         _loc41_.cost = 20;
         _loc41_.minDamage = 200;
         _loc41_.maxDamage = 600;
         _loc41_.attackReloadTime = 1 * this.framesRate;
         _loc41_.xSoldierAdjust = 42;
         _loc41_.xAdjust = 0;
         _loc41_.yAdjust = -15;
         _loc41_.healMaxEnemies = 20;
         _loc41_.healCoolDown = 8 * this.framesRate;
         _loc41_.healRange = 500;
         _loc41_.healPoints = 200;
         this.enemies.goblinChieftain = _loc41_;
      }
      
      private function §_-L§() : void
      {
         var _loc1_:* = undefined;
         var _loc2_:* = undefined;
         var _loc3_:* = undefined;
         var _loc4_:* = undefined;
         var _loc5_:* = undefined;
         var _loc6_:* = undefined;
         var _loc7_:* = undefined;
         var _loc8_:* = undefined;
         _loc1_ = new Object();
         _loc1_.coolDown = 25 * this.framesRate;
         _loc1_.minDamage = 1;
         _loc1_.maxDamage = 500;
         this.powers.lightning = _loc1_;
         _loc2_ = new Object();
         _loc2_.coolDown = 80 * this.framesRate;
         _loc2_.minDamage = 30;
         _loc2_.maxDamage = 60;
         _loc2_.range = 100;
         _loc2_.scorchedEarthRange = 100;
         _loc2_.scorchedEarthMinDamage = 10;
         _loc2_.scorchedEarthMaxDamage = 20;
         _loc2_.scorchedEarthDamageTime = 1 * this.framesRate;
         _loc2_.scorchedEarthDuration = 5 * this.framesRate;
         _loc2_.blazingEarthRange = 100;
         _loc2_.blazingEarthMinDamage = 20;
         _loc2_.blazingEarthMaxDamage = 30;
         _loc2_.blazingEarthDamageTime = 1 * this.framesRate;
         _loc2_.blazingEarthDuration = 10 * this.framesRate;
         this.powers.fireball = _loc2_;
         _loc3_ = new Object();
         _loc3_.coolDown = 10 * this.framesRate;
         _loc3_.maxSize = §_-D6§;
         _loc3_.maxLevel = 5;
         _loc3_.range = 100;
         _loc3_.health = 30;
         _loc3_.armor = 0;
         _loc3_.minDamage = 1;
         _loc3_.maxDamage = 2;
         _loc3_.reload = 1 * this.framesRate;
         _loc3_.lifeTime = 20 * this.framesRate;
         _loc3_.regen = 3;
         _loc3_.regenReload = 1 * this.framesRate;
         this.powers.farmers = _loc3_;
         _loc4_ = new Object();
         _loc4_.range = 100;
         _loc4_.health = 50;
         _loc4_.armor = 0;
         _loc4_.minDamage = 1;
         _loc4_.maxDamage = 3;
         _loc4_.reload = 1 * this.framesRate;
         _loc4_.lifeTime = 20 * this.framesRate;
         _loc4_.regen = 6;
         _loc4_.regenReload = 1 * this.framesRate;
         this.powers.reinforcementLevel1 = _loc4_;
         _loc5_ = new Object();
         _loc5_.coolDown = 10 * this.framesRate;
         _loc5_.maxSize = §_-D6§;
         _loc5_.maxLevel = 5;
         _loc5_.range = 100;
         _loc5_.health = 70;
         _loc5_.armor = 10;
         _loc5_.minDamage = 2;
         _loc5_.maxDamage = 4;
         _loc5_.reload = 1 * this.framesRate;
         _loc5_.lifeTime = 20 * this.framesRate;
         _loc5_.regen = 9;
         _loc5_.regenReload = 1 * this.framesRate;
         this.powers.reinforcementLevel2 = _loc5_;
         _loc6_ = new Object();
         _loc6_.coolDown = 10 * this.framesRate;
         _loc6_.maxSize = §_-D6§;
         _loc6_.maxLevel = 5;
         _loc6_.range = 100;
         _loc6_.health = 90;
         _loc6_.armor = 20;
         _loc6_.minDamage = 3;
         _loc6_.maxDamage = 6;
         _loc6_.reload = 1 * this.framesRate;
         _loc6_.lifeTime = 20 * this.framesRate;
         _loc6_.regen = 12;
         _loc6_.regenReload = 1 * this.framesRate;
         this.powers.reinforcementLevel3 = _loc6_;
         _loc7_ = new Object();
         _loc7_.coolDown = 10 * this.framesRate;
         _loc7_.maxSize = §_-D6§;
         _loc7_.maxLevel = 5;
         _loc7_.range = 100;
         _loc7_.health = 110;
         _loc7_.armor = 30;
         _loc7_.minDamage = 6;
         _loc7_.maxDamage = 10;
         _loc7_.reload = 1 * this.framesRate;
         _loc7_.lifeTime = 20 * this.framesRate;
         _loc7_.regen = 15;
         _loc7_.regenReload = 1 * this.framesRate;
         _loc7_.spearCoolDown = 1 * this.framesRate;
         _loc7_.spearRange = 260;
         _loc7_.spearMinRange = 40;
         _loc7_.spearMinDamage = 24;
         _loc7_.spearMaxDamage = 40;
         this.powers.reinforcementLevel4 = _loc7_;
         _loc8_ = new Object();
         _loc8_.coolDown = 10 * this.framesRate;
         _loc8_.maxSize = §_-D6§;
         _loc8_.maxLevel = 5;
         _loc8_.range = 100;
         _loc8_.health = 200;
         _loc8_.armor = 0;
         _loc8_.minDamage = 25;
         _loc8_.maxDamage = 35;
         _loc8_.reload = 1 * this.framesRate;
         _loc8_.lifeTime = 20 * this.framesRate;
         _loc8_.regen = 10;
         _loc8_.regenReload = 1 * this.framesRate;
         this.powers.knights = _loc8_;
      }
      
      private function §_-Ke§() : void
      {
         var _loc1_:* = undefined;
         var _loc2_:* = undefined;
         var _loc3_:* = undefined;
         var _loc4_:* = undefined;
         var _loc5_:* = undefined;
         var _loc6_:* = undefined;
         _loc1_ = new Object();
         _loc1_.max = 4;
         _loc1_.repairCost = 100;
         _loc1_.elfCost = 100;
         _loc1_.maxSize = §_-D6§;
         _loc1_.maxLevel = 5;
         _loc1_.range = 80;
         _loc1_.health = 200;
         _loc1_.armor = 0;
         _loc1_.minDamage = 25;
         _loc1_.maxDamage = 50;
         _loc1_.reload = 1 * this.framesRate;
         _loc1_.regen = 20;
         _loc1_.regenReload = 0.5 * this.framesRate;
         _loc1_.arrowCoolDown = 1 * this.framesRate;
         _loc1_.arrowRange = 320;
         _loc1_.arrowMinRange = 40;
         _loc1_.arrowMinDamage = 25;
         _loc1_.arrowMaxDamage = 50;
         this.specials.elves = _loc1_;
         _loc2_ = new Object();
         _loc2_.maxSize = §_-D6§;
         _loc2_.maxLevel = 5;
         _loc2_.range = 120;
         _loc2_.health = 250;
         _loc2_.armor = 40;
         _loc2_.minDamage = 10;
         _loc2_.maxDamage = 30;
         _loc2_.reload = 1 * this.framesRate;
         _loc2_.regen = 25;
         _loc2_.regenReload = 1 * this.framesRate;
         this.specials.imperial = _loc2_;
         _loc3_ = new Object();
         _loc3_.max = 1;
         _loc3_.cost = 500;
         _loc3_.rallyRange = 450;
         _loc3_.coolDown = 10 * this.framesRate;
         _loc3_.maxSize = §_-D6§;
         _loc3_.maxLevel = 5;
         _loc3_.range = 130;
         _loc3_.health = 2500;
         _loc3_.armor = 0;
         _loc3_.reload = 2.5 * this.framesRate;
         _loc3_.regen = 250;
         _loc3_.regenReload = 1 * this.framesRate;
         _loc3_.areaAttackRangeWidth = 70;
         _loc3_.minDamage = 50;
         _loc3_.maxDamage = 110;
         _loc3_.areaAttackMaxEnemies = 10;
         this.specials.sasquash = _loc3_;
         _loc4_ = new Object();
         _loc4_.mageCost = 100;
         _loc4_.reloadTime = 22 * this.framesRate;
         _loc4_.reloadDecrease = 3 * this.framesRate;
         _loc4_.damageIncrement = 50;
         _loc4_.minDamage = 25;
         _loc4_.maxDamage = 75;
         this.specials.templeTower = _loc4_;
         _loc5_ = new Object();
         _loc5_.limitLifeCondition = 299;
         this.specials.graveyard = _loc5_;
         _loc6_ = new Object();
         _loc6_.spawnTime = 400 * this.framesRate;
         _loc6_.spawnAuxTime = 120 * this.framesRate;
         this.specials.lavaSpawn = _loc6_;
      }
      
      private function §_-5E§() : void
      {
         var _loc1_:Number = NaN;
         var _loc2_:Number = NaN;
         var _loc3_:Number = NaN;
         var _loc4_:Number = NaN;
         var _loc5_:Number = NaN;
         var _loc6_:Number = NaN;
         var _loc7_:Number = NaN;
         var _loc8_:Number = NaN;
         var _loc9_:Number = NaN;
         if(this.game.gameUpgrades.archersUpEagleEye == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 2))
         {
            _loc1_ = 0.1;
            this.archers.level1.range += Math.ceil(this.archers.level1.range * _loc1_);
            this.archers.level2.range += Math.ceil(this.archers.level2.range * _loc1_);
            this.archers.level3.range += Math.ceil(this.archers.level3.range * _loc1_);
            this.archers.ranger.range += Math.ceil(this.archers.ranger.range * _loc1_);
            this.archers.musketeer.range += Math.ceil(this.archers.musketeer.range * _loc1_);
         }
         if(this.game.gameUpgrades.archersUpFarShots == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 4))
         {
            _loc1_ = 0.1;
            this.archers.level1.range += Math.ceil(this.archers.level1.range * _loc1_);
            this.archers.level2.range += Math.ceil(this.archers.level2.range * _loc1_);
            this.archers.level3.range += Math.ceil(this.archers.level3.range * _loc1_);
            this.archers.ranger.range += Math.ceil(this.archers.ranger.range * _loc1_);
            this.archers.musketeer.range += Math.ceil(this.archers.musketeer.range * _loc1_);
         }
         if(this.game.gameUpgrades.magesUpSpellReach == true)
         {
            _loc2_ = 0.1;
            this.mages.level1.range += Math.ceil(this.mages.level1.range * _loc2_);
            this.mages.level2.range += Math.ceil(this.mages.level2.range * _loc2_);
            this.mages.level3.range += Math.ceil(this.mages.level3.range * _loc2_);
            this.mages.arcane.range += Math.ceil(this.mages.arcane.range * _loc2_);
            this.mages.sorcerer.range += Math.ceil(this.mages.sorcerer.range * _loc2_);
         }
         if(this.game.gameUpgrades.magesUpEmpoweredMagic == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 4))
         {
            _loc3_ = 0.15;
            this.mages.level1.minDamage += Math.ceil(this.mages.level1.minDamage * _loc3_);
            this.mages.level1.maxDamage += Math.ceil(this.mages.level1.maxDamage * _loc3_);
            this.mages.level2.minDamage += Math.ceil(this.mages.level2.minDamage * _loc3_);
            this.mages.level2.maxDamage += Math.ceil(this.mages.level2.maxDamage * _loc3_);
            this.mages.level3.minDamage += Math.ceil(this.mages.level3.minDamage * _loc3_);
            this.mages.level3.maxDamage += Math.ceil(this.mages.level3.maxDamage * _loc3_);
            this.mages.arcane.minDamage += Math.ceil(this.mages.arcane.minDamage * _loc3_);
            this.mages.arcane.maxDamage += Math.ceil(this.mages.arcane.maxDamage * _loc3_);
            this.mages.sorcerer.minDamage += Math.ceil(this.mages.sorcerer.minDamage * _loc3_);
            this.mages.sorcerer.maxDamage += Math.ceil(this.mages.sorcerer.maxDamage * _loc3_);
         }
         if(this.game.gameUpgrades.barracksUpSurvival == true)
         {
            _loc6_ = 0.1;
            if(this.game.gameUpgrades.barracksUpSurvival2 == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 4))
            {
               _loc6_ = 0.2;
            }
            this.soldiers.level1.health += Math.ceil(this.soldiers.level1.health * _loc6_);
            this.soldiers.level2.health += Math.ceil(this.soldiers.level2.health * _loc6_);
            this.soldiers.level3.health += Math.ceil(this.soldiers.level3.health * _loc6_);
            this.soldiers.paladin.health += Math.ceil(this.soldiers.paladin.health * _loc6_);
            this.soldiers.barbarian.health += Math.ceil(this.soldiers.barbarian.health * _loc6_);
         }
         if(this.game.gameUpgrades.barracksUpBetterArmor == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 2))
         {
            _loc7_ = 10;
            this.soldiers.level1.armor += _loc7_;
            this.soldiers.level2.armor += _loc7_;
            this.soldiers.level3.armor += _loc7_;
            this.soldiers.paladin.armor += _loc7_;
            this.soldiers.barbarian.armor += _loc7_;
         }
         if(this.game.gameUpgrades.barracksUpImprovedDeployment == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 3))
         {
            _loc8_ = 0.2;
            _loc9_ = 0.2;
            this.soldiers.level1.respawn -= Math.ceil(this.soldiers.level1.respawn * _loc8_);
            this.soldiers.level2.respawn -= Math.ceil(this.soldiers.level2.respawn * _loc8_);
            this.soldiers.level3.respawn -= Math.ceil(this.soldiers.level3.respawn * _loc8_);
            this.soldiers.paladin.respawn -= Math.ceil(this.soldiers.paladin.respawn * _loc8_);
            this.soldiers.barbarian.respawn -= Math.ceil(this.soldiers.barbarian.respawn * _loc8_);
            this.soldiers.level1.rangeRally += Math.ceil(this.soldiers.level1.rangeRally * _loc9_);
            this.soldiers.level2.rangeRally += Math.ceil(this.soldiers.level2.rangeRally * _loc9_);
            this.soldiers.level3.rangeRally += Math.ceil(this.soldiers.level3.rangeRally * _loc9_);
            this.soldiers.paladin.rangeRally += Math.ceil(this.soldiers.paladin.rangeRally * _loc9_);
            this.soldiers.barbarian.rangeRally += Math.ceil(this.soldiers.barbarian.rangeRally * _loc9_);
         }
         if(this.game.gameUpgrades.engineersUpConcentratedFire == true)
         {
            _loc4_ = 0.1;
            this.engineers.level1.minDamage += Math.ceil(this.engineers.level1.minDamage * _loc4_);
            this.engineers.level1.maxDamage += Math.ceil(this.engineers.level1.maxDamage * _loc4_);
            this.engineers.level2.minDamage += Math.ceil(this.engineers.level2.minDamage * _loc4_);
            this.engineers.level2.maxDamage += Math.ceil(this.engineers.level2.maxDamage * _loc4_);
            this.engineers.level3.minDamage += Math.ceil(this.engineers.level3.minDamage * _loc4_);
            this.engineers.level3.maxDamage += Math.ceil(this.engineers.level3.maxDamage * _loc4_);
            this.engineers.bfg.minDamage += Math.ceil(this.engineers.bfg.minDamage * _loc4_);
            this.engineers.bfg.maxDamage += Math.ceil(this.engineers.bfg.maxDamage * _loc4_);
            this.engineers.tesla.minDamage += Math.ceil(this.engineers.tesla.minDamage * _loc4_);
            this.engineers.tesla.maxDamage += Math.ceil(this.engineers.tesla.maxDamage * _loc4_);
         }
         if(this.game.gameUpgrades.engineersUpRangeFinder == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 2))
         {
            _loc5_ = 0.1;
            this.engineers.level1.range += Math.ceil(this.engineers.level1.range * _loc5_);
            this.engineers.level2.range += Math.ceil(this.engineers.level2.range * _loc5_);
            this.engineers.level3.range += Math.ceil(this.engineers.level3.range * _loc5_);
            this.engineers.bfg.range += Math.ceil(this.engineers.bfg.range * _loc5_);
            this.engineers.tesla.range += Math.ceil(this.engineers.tesla.range * _loc5_);
         }
         if(this.game.gameUpgrades.rainUpBlazingSkies == true)
         {
            this.powers.fireball.minDamage += 20;
            this.powers.fireball.maxDamage += 20;
         }
         if(this.game.gameUpgrades.rainsUpBiggerAndMeaner == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 3))
         {
            this.powers.fireball.range += this.powers.fireball.range * 0.25;
            this.powers.fireball.minDamage += 40;
            this.powers.fireball.maxDamage += 40;
            this.powers.fireball.coolDown -= 10 * this.framesRate;
         }
         if(this.game.gameUpgrades.rainUpBlazingEarth == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel >= 4))
         {
            this.powers.fireball.coolDown -= 10 * this.framesRate;
         }
         if(this.game.gameUpgrades.rainUpCataclysm == true && (this.maxUpgradeLevel == 0 || this.maxUpgradeLevel == 5))
         {
            this.powers.fireball.minDamage += 60;
            this.powers.fireball.maxDamage += 60;
         }
         if(this.game.gameUpgrades.reinforcementLevel == 1)
         {
            this.powers.farmers.range = this.powers.reinforcementLevel1.range;
            this.powers.farmers.health = this.powers.reinforcementLevel1.health;
            this.powers.farmers.armor = this.powers.reinforcementLevel1.armor;
            this.powers.farmers.minDamage = this.powers.reinforcementLevel1.minDamage;
            this.powers.farmers.maxDamage = this.powers.reinforcementLevel1.maxDamage;
            this.powers.farmers.reload = this.powers.reinforcementLevel1.reload;
            this.powers.farmers.lifeTime = this.powers.reinforcementLevel1.lifeTime;
            this.powers.farmers.regen = this.powers.reinforcementLevel1.regen;
            this.powers.farmers.regenReload = this.powers.reinforcementLevel1.regenReload;
         }
      }
      
      public function getArmorString(param1:Number) : String
      {
         if(param1 == 0)
         {
            return Locale.loadStringEx("C_ARMOR_0",Locale.getDefaultLang());
         }
         if(param1 >= 1 && param1 <= 30)
         {
            return Locale.loadStringEx("C_ARMOR_1",Locale.getDefaultLang());
         }
         if(param1 >= 31 && param1 <= 60)
         {
            return Locale.loadStringEx("C_ARMOR_2",Locale.getDefaultLang());
         }
         if(param1 >= 61 && param1 <= 90)
         {
            return Locale.loadStringEx("C_ARMOR_3",Locale.getDefaultLang());
         }
         if(param1 >= 90)
         {
            return Locale.loadStringEx("C_ARMOR_4",Locale.getDefaultLang());
         }
         return "";
      }
      
      public function §in §(param1:Number) : String
      {
         if(param1 >= 0 && param1 <= 0.7)
         {
            return Locale.loadStringEx("C_SPEED_0",Locale.getDefaultLang());
         }
         if(param1 > 0.7 && param1 < 1.5)
         {
            return Locale.loadStringEx("C_SPEED_1",Locale.getDefaultLang());
         }
         if(param1 >= 1.5)
         {
            return Locale.loadStringEx("C_SPEED_2",Locale.getDefaultLang());
         }
         return "";
      }
      
      public function getReloadString(param1:Number) : String
      {
         if(param1 >= 0 && param1 < 0.5)
         {
            return Locale.loadStringEx("C_RELOAD_4",Locale.getDefaultLang());
         }
         if(param1 >= 0.5 && param1 < 0.8)
         {
            return Locale.loadStringEx("C_RELOAD_3",Locale.getDefaultLang());
         }
         if(param1 >= 0.8 && param1 < 1.5)
         {
            return Locale.loadStringEx("C_RELOAD_2",Locale.getDefaultLang());
         }
         if(param1 >= 1.5 && param1 < 2)
         {
            return Locale.loadStringEx("C_RELOAD_1",Locale.getDefaultLang());
         }
         if(param1 >= 2)
         {
            return Locale.loadStringEx("C_RELOAD_0",Locale.getDefaultLang());
         }
         return "";
      }
      
      public function §_-0b§(param1:Number) : String
      {
         if(param1 >= 0 && param1 < 250)
         {
            return Locale.loadStringEx("C_RANGE_0",Locale.getDefaultLang());
         }
         if(param1 >= 250 && param1 < 280)
         {
            return Locale.loadStringEx("C_RANGE_1",Locale.getDefaultLang());
         }
         if(param1 >= 280 && param1 < 310)
         {
            return Locale.loadStringEx("C_RANGE_2",Locale.getDefaultLang());
         }
         if(param1 >= 310 && param1 < 360)
         {
            return Locale.loadStringEx("C_RANGE_3",Locale.getDefaultLang());
         }
         if(param1 >= 360)
         {
            return Locale.loadStringEx("C_RANGE_4",Locale.getDefaultLang());
         }
         return "";
      }
      
      public function destroyThis() : void
      {
         this.mages = null;
         this.archers = null;
         this.engineers = null;
         this.soldiers = null;
         this.powers = null;
         this.enemies = null;
         this.specials = null;
         this.game = null;
      }
   }
}