public class Level
{
    public const int LEVEL_NORMAL = 0;
    public const int LEVEL_PAUSED = 1;
    public const int LEVEL_WIN = 2;
    public const int LEVEL_OVER = 3;
    public const int LEVEL_STARTING = 4;
    public const int LEVEL_PRE_WIN = 5;
    
    public int mode;
    public int ifCondition;
    public string i = "forest";
    public int k;
    public Game game;
    public SaveDataLevel data;
    public GU gu;
    public int iy = 0;
    public PauseLayer pauseLayer;
    public GameSettings gameSettings;
    public int maxUpgradeLevel;
    public int maxWaves;
    public int currentWave;
    public int initLives;
    public int lives;
    public int cash;
    public int j = 0;
    public double damage = 0;
    public List<B4> b4;
    public List<Path> paths;
    public bool hasTunnels;
    public List<Tunnel> tunnels;
    public List<B4> b4List;
    public int inactiveNodeDistance = 13;
    public int indexWaves = 0;
    public int intervalWaveCounter = 0;
    public Tooltip tooltip;
    public MenuBottom menu;
    public Hud hud;
    public CP cp;
    public use use;
    public ButtonEncyclopedia buttonEncyclopedia;
    public TowerMenu towerMenu;
    public NotificationSecondLevelHolder notificationHolder;
    public TowerRange towerRange;
    public TowerCircleNew towerRangeNew;
    public TowerRangeRallyPoint towerRangeRallyPoint;
    public List<Wave> waves;
    public Dictionary<int, Wave> activeWaves;
    public bool x;
    public FirstWaveSign firstWaveSign;
    public Sprite terrain;
    public Sprite ellipses;
    public Sprite background;
    public Sprite decals;
    public Sprite entities;
    public Sprite frontEntities;
    public Sprite bulletsDecals;
    public Sprite bullets;
    public Sprite gui;
    public Dictionary<int, Tower> towers;
    public Dictionary<int, Enemy> enemies;
    public Dictionary<int, Soldier> soldiers;
    public Dictionary<int, Is> isDict;
    public MenuPause menuPause;
    public Dictionary<int, StaticEnemy> staticEnemies;
    public List<StaticArea> staticAreas;
    public TowerRallyPoint rallyPoint;
    public PowerPointer powerPointer;
    public bool enableElements = true;
    public EnemySelection enemySelection;
    public SoldierSelection soldierSelection;
    public int cc = 0;
    public AchievementItem et;
    public MovieClip gTerrain;
    public int initTime = 30;
    public int initTimeCounter = 0;
    public int bj = 30;
    public int f = 0;
    public bool power1;
    public bool power2;
    public int unlockMaxArchers;
    public int unlockMaxMages;
    public int unlockMaxEngineers;
    public int unlockMaxBarracks;
    public int unlockMaxArchersLevel;
    public int unlockMaxMagesLevel;
    public int unlockMaxEngineersLevel;
    public int unlockMaxBarracksLevel;
    public bool isReadyToWin;
    public int readyToWinTime = 30;
    public int readyToWinTimeCounter = 0;
    public bool fearless = true;
    private int fireballCounter;
    private int sellTowersCounter;
    private int elementals = 0;
    private int teslas = 0;
    public Graveyard graveyard;
    public int currentSkeletons = 0;

 public Level(List<§_-B4§> param1, List<Path> param2, int param3 = 0)
    {
        this.§_-94§ = new §_-GU§();
        this.§_-19§ = new PauseLayer();
        this.paths = new List<Path>();
        this.towerRange = new §_-0K§();
        this.towerRangeNew = new TowerCircleNew();
        this.towerRangeRallyPoint = new §_-6p§();
        this.activeWaves = new Dictionary<int, Wave>();
        this.terrain = new Sprite();
        this.ellipses = new Sprite();
        this.background = new Sprite();
        this.decals = new Sprite();
        this.entities = new Sprite();
        this.frontEntities = new Sprite();
        this.bulletsDecals = new Sprite();
        this.bullets = new Sprite();
        this.gui = new Sprite();
        this.towers = new Dictionary<int, Tower>();
        this.enemies = new Dictionary<int, Enemy>();
        this.soldiers = new Dictionary<int, Soldier>();
        this.§_-Is§ = new Dictionary<int, §_-Is§>();
        this.staticEnemies = new Dictionary<int, StaticEnemy>();
        this.staticAreas = new List<StaticArea>();
        this.enemySelection = new EnemySelection();
        this.soldierSelection = new SoldierSelection();
        this.mode = param3;
        this.§_-2K§ = this.cash;
        this.isReadyToWin = false;
        this.game.gameSounds.setLevel(this);
        this.addChild(this.terrain);
        this.addChild(this.decals);
        this.addChild(this.ellipses);
        this.addChild(this.background);
        this.addChild(this.entities);
        this.addChild(this.frontEntities);
        this.addChild(this.bulletsDecals);
        this.addChild(this.bullets);
        this.addChild(this.gui);
        this.getNumberOfWaves();
        this.menuPause = new §_-BM§(this);
        this.lives = this.initLives;
        this.§ if§ = LEVEL_STARTING;
        this.initTowers(param1);
        this.paths = param2;
        this.gameSettings = new GameSettings(this.game, true, this.maxUpgradeLevel);
        this.ellipses.addChild(this.towerRange);
        this.ellipses.addChild(this.towerRangeNew);
        this.ellipses.addChild(this.towerRangeRallyPoint);
        this.towerRange.visible = false;
        this.towerRangeNew.visible = false;
        this.towerRangeRallyPoint.visible = false;
        this.towerRange.addEventListener(MouseEvent.MOUSE_DOWN, this.towerRangeClick, false, 0, true);
        this.towerRangeNew.addEventListener(MouseEvent.MOUSE_DOWN, this.towerRangeNewClick, false, 0, true);
        this.gui.addChild(this.§_-19§);
        this.§_-19§.start();
        this.§_-C6§();
        this.game.gameSounds.stopAllMusics();
        this.game.gameSounds.playMusicPreBattle();
        this.menu = new MenuBottom(new Point(0, 543), this);
        this.§_-F§ = new FirstWaveSign(new Point(652, 543));
        this.decals.addChild(this.§_-F§);
        this.addEventListener(Event.DEACTIVATE, this.onDeactivate, false, 0, true);
        this.§try§();
    }
 public void LoadCampaign()
    {
    }
    
    public void LoadHeroic()
    {
    }
    
    public void LoadIron()
    {
    }
private void onDeactivate(Event param1)
    {
        if (this.game.AT && this.ifCondition == LEVEL_NORMAL)
        {
            this.Ib(true);
        }
    }
    
    public void P()
    {
    }
 public void KeyPress(KeyboardEvent param1)
    {
        switch (param1.keyCode)
        {
            case Keyboard.SPACE:
                CancelAllOnKeyPress();
                break;
            case Keyboard.ESCAPE:
                CancelAllOnKeyPress();
                break;
            case 112:
                if (if == LEVEL_NORMAL)
                {
                    Ib();
                }
                else
                {
                    Gl();
                }
                break;
            case 80:
                if (if == LEVEL_NORMAL)
                {
                    Ib();
                }
                else
                {
                    Gl();
                }
                break;
            case Keyboard.NUMPAD_1:
                if (if == LEVEL_NORMAL && menu != null && menu.powersHolder.numChildren != 0)
                {
                    CancelExtraPowers();
                    if (powerPointer == null)
                    {
                        ((PowerFireball)menu.powersHolder.getChildAt(0)).Hy();
                    }
                    else if (GetQualifiedClassName(powerPointer) == "PowerPointerFireball")
                    {
                        powerPointer.CancelPower();
                    }
                    else
                    {
                        powerPointer.CancelPower();
                        ((PowerFireball)menu.powersHolder.getChildAt(0)).Hy();
                    }
                }
                break;
            case 49:
                if (if == LEVEL_NORMAL && menu != null && menu.powersHolder.numChildren != 0)
                {
                    CancelExtraPowers();
                    if (powerPointer == null)
                    {
                        ((PowerFireball)menu.powersHolder.getChildAt(0)).Hy();
                    }
                    else if (GetQualifiedClassName(powerPointer) == "PowerPointerFireball")
                    {
                        powerPointer.CancelPower();
                    }
                    else
                    {
                        powerPointer.CancelPower();
                        ((PowerFireball)menu.powersHolder.getChildAt(0)).Hy();
                    }
                }
                break;
            case Keyboard.NUMPAD_2:
                if (if == LEVEL_NORMAL && menu != null && menu.powersHolder.numChildren != 0)
                {
                    CancelExtraPowers();
                    if (powerPointer == null)
                    {
                        ((PowerReinforcement)menu.powersHolder.getChildAt(1)).Hy();
                    }
                    else if (StringUtil.BeginsWith(GetQualifiedClassName(powerPointer), "PowerPointerReinforcement") || StringUtil.BeginsWith(GetQualifiedClassName(powerPointer), "PowerPointerFarmer"))
                    {
                        powerPointer.CancelPower();
                    }
                    else
                    {
                        powerPointer.CancelPower();
                        ((PowerReinforcement)menu.powersHolder.getChildAt(1)).Hy();
                    }
                }
                break;
            case 50:
                if (if == LEVEL_NORMAL && menu != null && menu.powersHolder.numChildren != 0)
                {
                    CancelExtraPowers();
                    if (powerPointer == null)
                    {
                        ((PowerReinforcement)menu.powersHolder.getChildAt(1)).Hy();
                    }
                    else if (StringUtil.BeginsWith(GetQualifiedClassName(powerPointer), "PowerPointerReinforcement") || StringUtil.BeginsWith(GetQualifiedClassName(powerPointer), "PowerPointerFarmer"))
                    {
                        powerPointer.CancelPower();
                    }
                    else
                    {
                        powerPointer.CancelPower();
                        ((PowerReinforcement)menu.powersHolder.getChildAt(1)).Hy();
                    }
                }
                break;
            case Keyboard.NUMPAD_3:
                if (game.pc && game.pcLightning && if == LEVEL_NORMAL && menu != null && menu.powersHolder.numChildren != 0)
                {
                    CancelExtraPowers();
                    if (powerPointer == null)
                    {
                        ((PowerLightning)menu.powersHolder.getChildAt(2)).Hy();
                    }
                    else if (GetQualifiedClassName(powerPointer) == "PowerPointerLightning")
                    {
                        powerPointer.CancelPower();
                    }
                    else
                    {
                        powerPointer.CancelPower();
                        ((PowerLightning)menu.powersHolder.getChildAt(2)).Hy();
                    }
                }
                break;
            case 51:
                if (game.pc && game.pcLightning && if == LEVEL_NORMAL && menu != null && menu.powersHolder.numChildren != 0)
                {
                    CancelExtraPowers();
                    if (powerPointer == null)
                    {
                        ((PowerLightning)menu.powersHolder.getChildAt(2)).Hy();
                    }
                    else if (GetQualifiedClassName(powerPointer) == "PowerPointerLightning")
                    {
                        powerPointer.CancelPower();
                    }
                    else
                    {
                        powerPointer.CancelPower();
                        ((PowerLightning)menu.powersHolder.getChildAt(2)).Hy();
                    }
                }
                break;
        }
        ExtraKeyPress(param1.keyCode);
    }
 public void Ib(bool param1 = false)
    {
        if (menuPause != null && !gui.Contains(menuPause))
        {
            pause();
            if (param1)
            {
                menuPause.enableAutoPause();
            }
            else
            {
                menuPause.34();
            }
            gui.AddChild(menuPause);
        }
    }
 public void Gl()
    {
        if (menuPause != null && gui.Contains(menuPause))
        {
            pause();
            gui.RemoveChild(menuPause);
        }
    }
    
    public void extraKeyPress(uint param1)
    {
    }
    
    public void cancelExtraPowers()
    {
    }
public void CancelAllOnKeyPress()
    {
        if (powerPointer != null)
        {
            powerPointer.CancelPower();
            menu.ForceHideInfo();
        }
        if (rallyPoint != null)
        {
            rallyPoint.CancelRallyPoint();
        }
        KeyPressCheckExtra();
    }

    public void KeyPressCheckExtra()
    {
    }
 public void Initialize()
    {
        game.main.Lz();
        GU.x = 370;
        GU.y = 5;
        Hud = new Hud(10, 10, cash, initLives, maxWaves, this);
        notificationHolder = new NotificationSecondLevelHolder(this);
        gui.addChild(notificationHolder);
        CP = new CP(this);
        gui.addChild(CP);
        use = new use(this);
        gui.addChild(use);
        butEncyclopedia = new ButtonEncyclopedia(this);
        gui.addChild(butEncyclopedia);
        gui.addChild(Hud);
        quickMenu = new TowerMenu(this);
        gui.addChild(menu);
        decals.addChild(enemySelection);
        decals.addChild(soldierSelection);
    }

    public bool IsPaused()
    {
        if (ifCondition == LEVEL_PAUSED)
        {
            return true;
        }
        return false;
    }
 public void Pause(bool param1 = false, bool param2 = true)
    {
        if (!OnPause())
        {
            if (param1)
            {
                Block();
            }
            if (if != LEVEL_PRE_WIN)
            {
                if = LEVEL_PAUSED;
            }
            if (param2)
            {
                SoundManager.GetInstance().StopAllFxSounds();
            }
            AD();
            PauseEntities();
            PauseBackground();
            Hh();
            Ca();
        }
        else
        {
            if (param1)
            {
                t();
            }
            if = LEVEL_NORMAL;
            Da();
            UnPauseEntities();
            BK();
            UnPauseBackground();
            _64();
        }
    }
    
    public void Block()
    {
        gui.AddChild(_19);
        _19.Show();
    }
    
    public void t()
    {
        _19.Hide();
    }
    
    public void UnPause()
    {
        if = LEVEL_NORMAL;
    }
public void SetPowerPointer(_27 param1)
    {
        this.powerPointer = param1;
        this.DisableLevelElements();
    }
    
    public void §_-E6§()
    {
        this.powerPointer = null;
        this.EnableLevelElements();
    }
    
    public void EnableLevelElements()
    {
        this.enableElements = true;
    }
    
    public void DisableLevelElements()
    {
        this.enableElements = false;
    }
    
    public void FreeMenues()
    {
        if (this.quickMenu != null && this.quickMenu.cTower != null && this.gui.Contains(this.quickMenu))
        {
            this.quickMenu.Hide();
        }
    }
    
    public void Intro(MouseEvent param1)
    {
        if (!this.enableElements)
        {
            return;
        }
        this.menu.ForceHideInfo();
        this.FreeMenues();
        this.RemoveToolTip();
    }
    
    public void TowerRangeClick(MouseEvent param1)
    {
        this.ForceFreeQuickMenu();
    }
    
    public void TowerRangeNewClick(MouseEvent param1)
    {
        this.ForceFreeQuickMenu();
    }
    
    public void ForceFreeQuickMenu()
    {
        if (this.quickMenu.cTower == null)
        {
            return;
        }
        if (this.gui.Contains(this.quickMenu))
        {
            this.quickMenu.Hide();
        }
    }
public void init(Event param1)
    {
    }
    
    public void eFrameEvents(Event param1)
    {
        if (if == LEVEL_STARTING)
        {
            if (initTimeCounter < initTime)
            {
                initTimeCounter++;
                if (initTimeCounter + 3 == initTime)
                {
                    _3g();
                }
                return;
            }
            if = LEVEL_NORMAL;
            if (data.levelIndex == 0 && mode == GameSettings._2Q)
            {
                pause(true);
                gui.addChild(new TutorialIntro(new Point(0, 0), this));
            }
        }
        if (if == LEVEL_NORMAL || if == LEVEL_PRE_WIN)
        {
            Cc = 0;
            if (if == LEVEL_NORMAL)
            {
                EQ();
            }
            if (if == LEVEL_NORMAL || if == LEVEL_PRE_WIN)
            {
                if (stage.focus != stage)
                {
                    stage.focus = stage;
                }
                game.gameSounds.onFrameUpdate();
                updateEntities();
                updateBullets();
                updateBulletsDecals();
                updateDecals();
                updateBackground();
                true();
                menu.updateMenu();
                notificationHolder.update();
                updatePointers();
            }
            if (if == LEVEL_PRE_WIN)
            {
                if (_6F < Bj)
                {
                    _6F++;
                    return;
                }
                if (data.levelIndex < 11 || data.levelIndex == 11 && mode != GameSettings._2Q)
                {
                    pause(true);
                }
                if = LEVEL_WIN;
                addMenuVictory();
            }
        }

    }
public void onPreWin()
    {
    }

    public void addMenuVictory()
    {
        switch (mode)
        {
            case GameSettings._2Q:
                this.addChild(new MenuVictory(this));
                break;
            case GameSettings._Mv:
                this.addChild(new MenuVictoryHeroic(this));
                break;
            case GameSettings.MODE_IRON:
                this.addChild(new MenuVictoryIron(this));
                break;
        }
    }

    public void updatePointers()
    {
        if (powerPointer != null)
        {
            powerPointer.onFrameUpdate();
        }
    }

    public void updateEntities()
    {
        Dictionary<DisplayObject, DisplayObject> entityDict = new Dictionary<DisplayObject, DisplayObject>();
        for (int i = 0; i < entities.numChildren; i++)
        {
            entityDict[entities.getChildAt(i)] = entities.getChildAt(i);
            Cc++;
        }
        foreach (DisplayObject entity in entityDict.Keys)
        {
            entity.onFrameUpdate();
        }
    }

    public void updateDecals()
    {
        for (int i = 0; i < decals.numChildren; i++)
        {
            ((MovieClip)decals.getChildAt(i)).onFrameUpdate();
            Cc++;
        }
    }

    public void updateBackground()
    {
        for (int i = 0; i < background.numChildren; i++)
        {
            ((MovieClip)background.getChildAt(i)).onFrameUpdate();
            Cc++;
        }
    }

    public void updateBullets()
    {
        Dictionary<DisplayObject, DisplayObject> bulletDict = new Dictionary<DisplayObject, DisplayObject>();
        for (int i = 0; i < bullets.numChildren; i++)
        {
            bulletDict[bullets.getChildAt(i)] = bullets.getChildAt(i);
        }
        foreach (DisplayObject bullet in bulletDict.Keys)
        {
            bullet.onFrameUpdate();
        }
    }

    public void updateBulletsDecals()
    {
        for (int i = 0; i < bulletsDecals.numChildren; i++)
        {
            ((MovieClip)bulletsDecals.getChildAt(i)).onFrameUpdate();
            Cc++;
        }
    }

    public void pauseEntities()
    {
        Dictionary<DisplayObject, DisplayObject> entityDict = new Dictionary<DisplayObject, DisplayObject>();
        for (int i = 0; i < entities.numChildren; i++)
        {
            entityDict[entities.getChildAt(i)] = entities.getChildAt(i);
            Cc++;
        }
        foreach (DisplayObject entity in entityDict.Keys)
        {
            entity.pause();
        }
    }

    public void unPauseEntities()
    {
        for (int i = 0; i < entities.numChildren; i++)
        {
            ((MovieClip)entities.getChildAt(i)).unPause();
            Cc++;
        }
    }

    public void pauseEnemies()
    {
        foreach (Enemy enemy in enemies.Values)
        {
            enemy.pause();
        }
    }

    public void unPauseEnemies()
    {
        foreach (Enemy enemy in enemies.Values)
        {
            enemy.unPause();
        }
    }

    public void pauseBackground()
    {
        for (int i = 0; i < background.numChildren; i++)
        {
            ((MovieClip)background.getChildAt(i)).pause();
        }
    }

public bool OnRangeStaticArea(List<int> param1, Vector2 param2)
    {
        if (Mathf.Sqrt(Mathf.Pow(param1[0] - param2.y, 2) + Mathf.Pow(param1[1] - param2.x, 2)) < param1[2])
        {
            return true;
        }
        return false;
    }

    public void LooseLive(int param1)
    {
        game.gameSounds.PlayGUILooseLife();
        lives -= param1;
        if (lives <= 0)
        {
            lives = 0;
        }
        Hud.UpdateLives(lives);
        if (lives == 0)
        {
            GameOver();
        }
    }

    public string GetGameName()
    {
        return game.GetGameName();
    }

    public void GameOver()
    {
        Pause(true);
        if = LEVEL_OVER;
        AddChild(new Gj(this));
    }

    protected void GetNumberOfWaves()
    {
        int _loc1_ = 0;
        int _loc2_ = 0;
        while (_loc2_ < waves.Count)
        {
            _loc1_++;
            while (_loc2_ + 1 < waves.Count && waves[_loc2_ + 1].interval == 0)
            {
                _loc2_++;
            }
            _loc2_++;
        }
        maxWaves = _loc1_;
        currentWave = 0;
    }

    private void Update()
    {
        WaveEQ();
    }

    private void WaveEQ()
    {
        Wave _loc2_;
        Wave _loc3_;
        int _loc4_;
        int _loc1_ = 0;
        if (currentWave == 0 && x)
        {
            return;
        }
        foreach (KeyValuePair<Wave, Wave> kvp in activeWaves)
        {
            _loc1_++;
        }
        if (_loc1_ == 0)
        {
            if (indexWaves < waves.Count)
            {
                if (waves[indexWaves].interval == intervalWaveCounter)
                {
                    if (indexWaves != 0 && waves[indexWaves].notification != "")
                    {
                        ForceFreeQuickMenu();
                        SendPauseNotification(waves[indexWaves].notification);
                    }
                    ++currentWave;
                    activeWaves[waves[indexWaves]] = waves[indexWaves];
                    intervalWaveCounter = 0;
                    ++indexWaves;
                    Hud.UpdateWaves(currentWave, maxWaves);
                    AfterNextWaveStart();
                    while (indexWaves < waves.Count && waves[indexWaves].interval == 0)
                    {
                        activeWaves[waves[indexWaves]] = waves[indexWaves];
                        ++indexWaves;
                    }
                    menu.Gx();
                }
                else
                {
                    if (indexWaves == 0 && waves[indexWaves].notification != "")
                    {
                        ForceFreeQuickMenu();
                        SendPauseNotification(waves[indexWaves].notification);
                    }
                    if ((intervalWaveCounter == 50 && waves[indexWaves].interval != 0) || indexWaves == 0)
                    {
                        waves[indexWaves].ShowWaveFlag(this, waves[indexWaves].interval - 50, indexWaves);
                        if (F != null)
                        {
                            game.gameSounds.PlayGUINextWaveReady();
                        }
                        _loc4_ = indexWaves + 1;
                        while (_loc4_ < waves.Count && waves[_loc4_].interval == 0)
                        {
                            waves[_loc4_].ShowWaveFlag(this, waves[indexWaves].interval - 50, indexWaves);
                            _loc4_++;
                        }
                        AfterNextWaveFlagShow();
                    }
                    if (indexWaves == 0)
                    {
                        x = true;
                    }
                    else
                    {
                        ++intervalWaveCounter;
                    }
                }
            }
            else if (!HasEnemies())
            {
                if = LEVEL_PRE_WIN;
                OnPreWin();
                CheckLevelAchievements();
            }
        }
        foreach (KeyValuePair<Wave, Wave> kvp in activeWaves)
        {
            kvp.Value.SpawnEnemies(this);
        }
    }
public void UnPauseBackground()
    {
        for (int i = 0; i < background.numChildren; i++)
        {
            ((0P)background.getChildAt(i)).UnPause();
        }
    }

    public void PauseTowers()
    {
        foreach (Tower tower in towers.Values)
        {
            tower.Pause();
        }
    }

    public void UnPauseTowers()
    {
        foreach (Tower tower in towers.Values)
        {
            tower.UnPause();
        }
    }

    public void PauseBulletsDecals()
    {
        for (int i = 0; i < bulletsDecals.numChildren; i++)
        {
            ((MovieClip)bulletsDecals.getChildAt(i)).Pause();
        }
    }

    public void UnPauseBulletsDecals()
    {
        for (int i = 0; i < bulletsDecals.numChildren; i++)
        {
            ((MovieClip)bulletsDecals.getChildAt(i)).UnPause();
        }
    }

    public void PauseBullets()
    {
        for (int i = 0; i < bullets.numChildren; i++)
        {
            ((MovieClip)bullets.getChildAt(i)).Pause();
        }
    }

    public void UnPauseBullets()
    {
        for (int i = 0; i < bullets.numChildren; i++)
        {
            ((MovieClip)bullets.getChildAt(i)).UnPause();
        }
    }

    public void PauseDecals()
    {
        for (int i = 0; i < decals.numChildren; i++)
        {
            ((MovieClip)decals.getChildAt(i)).Pause();
        }
    }

    public void UnPauseDecals()
    {
        for (int i = 0; i < decals.numChildren; i++)
        {
            ((MovieClip)decals.getChildAt(i)).UnPause();
        }
    }

    public void InitTowers(List<Tower> towers)
    {
        foreach (Tower tower in towers)
        {
            entities.addChild(tower);
        }
    }

    public void RemoveTower(Tower tower)
    {
        towers.Remove(tower);
    }

    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
    }

    public void RemoveStaticEnemy(Enemy enemy)
    {
        staticEnemies.Remove(enemy);
    }

    public void AddSoldier(Soldier soldier)
    {
        soldiers.Add(soldier);
    }

    public void RemoveSoldier(Soldier soldier)
    {
        soldiers.Remove(soldier);
    }

    public void AddBackground(0P background)
    {
        this.background.addChild(background);
    }

    public void RemoveBackground(0P background)
    {
        this.background.removeChild(background);
    }

    public void Static(MovieClip movieClip)
    {
        bullets.removeChild(movieClip);
        AddToDecal(movieClip);
    }

    public void AddToDecal(MovieClip movieClip)
    {
        decals.addChild(movieClip);
    }

    public void UpdateCash(int amount)
    {
        if (amount > 0)
        {
            J += amount;
        }
        cash += amount;
        _J9.UpdateCash(cash);
    }
public void CheckLevelSpecialAchievements()
    {
    }

    public void SendPauseNotification(string param1)
    {
        Type type = Type.GetType(param1);
        this.Pause(true);
        this.gui.addChild(Activator.CreateInstance(type, this, true));
    }

    public void SendSecondLevelNotification(string param1)
    {
        this.notificationHolder.AddNotification(param1);
    }

    public void C8(Point param1)
    {
        int _loc2_ = 0;
        if (this.x)
        {
            if (this.power2)
            {
                this.UnlockPowerFireball();
            }
            if (this.power1)
            {
                this.UnlockPowerReinforcement();
            }
            this.UnlockPowerLightning();
            this.x = false;
            if (this.F != null && this.decals.Contains(this.F))
            {
                this.decals.RemoveChild(this.F);
            }
            this.PlayLevelMusic();
        }
        else
        {
            if (this.intervalWaveCounter / 30 <= 3)
            {
                this.game.gameAchievement.CheckImpatient(this);
            }
            this.game.gameAchievement.CheckDaring(this);
        }
        if (this.indexWaves != 0)
        {
            this.menu.MD(this.waves[this.indexWaves].interval - this.intervalWaveCounter);
            _loc2_ = Math.Round((this.waves[this.indexWaves].interval - this.intervalWaveCounter) / this.gameSettings.framesRate);
            if (_loc2_ >= 1)
            {
                this.bullets.AddChild(new WaveFlagReward(param1, Math.Round(_loc2_ * 1)));
                this.game.gameSounds.PlayGUINextWaveReward();
                this.UpdateCash(Math.Round(_loc2_ * 1));
            }
        }
        this.intervalWaveCounter = this.waves[this.indexWaves].interval;
        this.5t();
    }
public void PlayLevelMusic()
    {
        game.gameSounds.StopAllMusics();
        game.gameSounds.PlayMusicBattle();
    }
    
    public void AddWaveFlag(WaveFlag waveFlag)
    {
        int count = 0;
        foreach (WaveFlag flag in isDict.Values)
        {
            count++;
        }
        if (count == 0)
        {
            menu.EnableNextWave();
        }
        isDict[waveFlag] = waveFlag;
    }
    
    public void RemoveWaveFlag(WaveFlag waveFlag, bool param2 = false)
    {
        waveFlag.Remove();
        isDict.Remove(waveFlag);
        if (!param2)
        {
            int count = 0;
            foreach (WaveFlag flag in isDict.Values)
            {
                count++;
            }
            if (count == 0)
            {
                menu.DisableNextWave();
            }
        }
    }
    
    public void RemoveWaveFlag(WaveFlag waveFlag)
    {
        isDict.Remove(waveFlag);
        int count = 0;
        foreach (WaveFlag flag in isDict.Values)
        {
            count++;
        }
        if (count == 0)
        {
            menu.DisableNextWave();
        }
    }
    
    public void RemoveAllWaveFlags()
    {
        foreach (WaveFlag flag in isDict.Values)
        {
            RemoveWaveFlag(flag, true);
        }
        menu.DisableNextWave();
    }
    
    public void UnlockPowerFireball()
    {
        menu.UnlockPower(0);
    }
    
    public void UnlockPowerReinforcement()
    {
        menu.UnlockPower(1);
    }
    
    public void UnlockPowerLightning()
    {
        if (game.pc && game.pcLightning)
        {
            menu.UnlockPower(2);
        }
    }
public void Gq()
    {
        fireballCounter++;
        if (fireballCounter == 5)
        {
            game.gameAchievement.checkArmaggedon(this);
        }
    }
    
    public void addElementalAchievement()
    {
        elementals++;
        if (elementals == 5)
        {
            game.gameAchievement.J8(this);
        }
    }
    
    public void addTeslaAchievement()
    {
        teslas++;
        if (teslas == 4)
        {
            game.gameAchievement.Na(this);
        }
    }
    
    public void addSellTowerAchievement()
    {
        sellTowersCounter++;
        if (sellTowersCounter == 5)
        {
            game.gameAchievement.doIndecisive(this);
        }
        game.gameAchievement.sellTower(this);
    }
    
    protected bool hasEnemies()
    {
        bool hasEnemies = false;
        foreach (Enemy enemy in enemies.Values)
        {
            if (!enemy.isBoss || (enemy.isBoss && !enemy.isDead))
            {
                hasEnemies = true;
                break;
            }
        }
        
        if (isReadyToWin)
        {
            if (readyToWinTimeCounter < readyToWinTime)
            {
                readyToWinTimeCounter++;
                if (readyToWinTimeCounter % 10 == 0)
                {
                    foreach (Enemy enemy in enemies.Values)
                    {
                        if (!enemy.isBoss || (enemy.isBoss && !enemy.isDead))
                        {
                            isReadyToWin = false;
                            break;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        
        if (!hasEnemies)
        {
            isReadyToWin = true;
            readyToWinTimeCounter = 0;
        }
        
        return hasEnemies;
    }
    
    private void traceEnemies()
    {
        int count = 0;
        foreach (Enemy enemy in enemies.Values)
        {
            count++;
            if (enemy.onTunnel)
            {
                // Do something
            }
        }
    }
private void trueMethod()
    {
        int loc2 = 0;
        int loc1 = entities.numChildren - 1;
        while (loc1 > 0)
        {
            loc2 = 0;
            while (loc2 < loc1)
            {
                if (entities.getChildAt(loc2).y > entities.getChildAt(loc2 + 1).y)
                {
                    entities.swapChildrenAt(loc2, loc2 + 1);
                }
                loc2++;
            }
            loc1--;
        }
    }

    protected Point Method50(Ellipse param1, int param2)
    {
        return param1.GetPointOfDegreeAux(param2);
    }

    public List<int> MethodMB(int param1)
    {
        int loc2 = Math.Ceiling(Math.Random() * paths[param1].Count) - 1;
        return paths[param1][loc2];
    }

    public double RandomRange(double param1, double param2)
    {
        return Math.Ceiling(Math.Random() * (param2 - param1) + param1) - 1;
    }

    public void AddToolTip(Tooltip param1)
    {
        RemoveToolTip();
        toolTip = param1;
        gui.addChild(toolTip);
        param1 = null;
    }

    public void RemoveToolTip()
    {
        if (toolTip != null)
        {
            toolTip.DestroyThis();
            toolTip = null;
        }
    }

    public void MethodC6()
    {
        int loc1 = 0;
        while (loc1 < _B4.Count)
        {
            decals.addChild(new DefenseIndicator(_B4[loc1]));
            loc1++;
        }
    }

    public int GetStars()
    {
        if (mode != GameSettings._2Q)
        {
            return 3;
        }
        if (lives >= 18)
        {
            return 3;
        }
        if (lives > 5 && lives < 18)
        {
            return 2;
        }
        return 1;
    }

    public void ChangeTunneStatus(int param1, bool param2)
    {
    }
 public bool isTowerLocked(string param1, int param2)
    {
        switch (param1)
        {
            case GameSettings.ARCHER_TOWER:
                if (unlockMaxArchers >= param2 || unlockMaxArchers == 0 && param2 != 1 && unlockMaxArchersLevel >= param2)
                {
                    return false;
                }
                break;
            case GameSettings.MAGE_TOWER:
                if (unlockMaxMages >= param2 || unlockMaxMages == 0 && param2 != 1 && unlockMaxMagesLevel >= param2)
                {
                    return false;
                }
                break;
            case GameSettings.ENGINEER_TOWER:
                if (unlockMaxEngineers >= param2 || unlockMaxEngineers == 0 && param2 != 1 && unlockMaxEngineersLevel >= param2)
                {
                    return false;
                }
                break;
            case GameSettings.BARRACK_TOWER:
                if (unlockMaxBarracks >= param2 || unlockMaxBarracks == 0 && param2 != 1 && unlockMaxBarracksLevel >= param2)
                {
                    return false;
                }
                break;
        }
        return true;
    }

    internal void loadXML(Event param1)
    {
        List<Wave> _loc3_ = new List<Wave>();
        string _loc4_ = "this.waves = [ \n";
        cash = int.Parse(param1.target.data);
        int _loc6_ = 0;
        while (_loc6_ < param1.target.data.wave.length())
        {
            List<WaveSpawn> _loc2_ = new List<WaveSpawn>();
            _loc4_ += "new Wave(\t [ \n";
            int _loc8_ = 0;
            while (_loc8_ < param1.target.data.wave[_loc6_].spawns.spawn.length())
            {
                _loc2_.Add(new WaveSpawn(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].creep, param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].creep_aux, int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].max_same), int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].max), int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].interval), int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].interval_next), bool.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].fixed_sub_path), int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].path)));
                _loc4_ += "new WaveSpawn(\"" + param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].creep + "\", \"" + param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].creep_aux + "\"," + int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].max_same) + ", " + int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].max) + ", " + int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].interval) + ", " + int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].interval_next) + ", " + bool.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].fixed_sub_path).ToString() + ", " + int.Parse(param1.target.data.wave[_loc6_].spawns.spawn[_loc8_].path) + ")";
                if (_loc8_ + 1 < param1.target.data.wave[_loc6_].spawns.spawn.length())
                {
                    _loc4_ += ",\n";
                }
                else
                {
                    _loc4_ += "]";
                }
                _loc8_++;
            }
            _loc3_.Add(new Wave(_loc2_, int.Parse(param1.target.data.wave[_loc6_].interval), int.Parse(param1.target.data.wave[_loc6_].path_index), param1.target.data.wave[_loc6_].notification, param1.target.data.wave[_loc6_].notification_second_level));
            _loc4_ += ", " + int.Parse(param1.target.data.wave[_loc6_].interval) + "," + int.Parse(param1.target.data.wave[_loc6_].path_index) + ",\"" + param1.target.data.wave[_loc6_].notification + "\",\"" + param1.target.data.wave[_loc6_].notification_second_level + "\" ),\n\n";
            _loc6_++;
        }
        waves = _loc3_;
        int _loc7_ = 0;
        while (_loc7_ < waves.Count)
        {
            int _loc9_ = 0;
            while (_loc9_ < waves[_loc7_].spawns.Count)
            {
                _loc9_++;
            }
            _loc7_++;
        }
        _loc4_ += "];";
        getNumberOfWaves();
    }

    public void destroyLevelSpecific()
    {
    }

    public void destroyThis()
    {
        WaveFlag _loc1_ = null;
        Wave _loc2_ = null;
        §_-Gl§();
        menuPause = null;
        destroyLevelSpecific();
        if (graveyard != null)
        {
            graveyard.destroyThis();
        }
        removeEventListener(Event.DEACTIVATE, onDeactivate);
        towerRange.removeEventListener(MouseEvent.MOUSE_DOWN, towerRangeClick);
        towerRangeNew.removeEventListener(MouseEvent.MOUSE_DOWN, towerRangeNewClick);
        gTerrain.removeEventListener(MouseEvent.MOUSE_DOWN, intro);
        stage.removeEventListener(KeyboardEvent.KEY_DOWN, §_-1D§);
        removeEventListener(Event.ENTER_FRAME, eFrameEvents);
        game.gameSounds.unSetLevel();
        foreach (_loc1_ in §_-Is§)
        {
            _loc1_.destroyThis(false);
        }
        quickMenu.destroyThis();
        quickMenu = null;
        foreach (_loc2_ in activeWaves.Values)
        {
            _loc2_.destroyThis();
        }
        if (§_-F§ != null)
        {
            §_-F§.destroyThis();
        }
        §_-F§ = null;
        data = null;
        _94 = null;
        _19 = null;
        gameSettings.destroyThis();
        gameSettings = null;
        _B4 = null;
        paths = null;
        tunnels = null;
        _4B = null;
        if (toolTip != null)
        {
            gui.removeChild(toolTip);
            toolTip = null;
        }
        menu = null;
        J9 = null;
        notificationHolder = null;
        §_-5C§.destroyThis();
        §_-5C§ = null;
        EB.destroyThis();
        EB = null;
        butEncyclopedia.destroyThis();
        butEncyclopedia = null;
        ellipses.removeChild(towerRange);
        ellipses.removeChild(towerRangeNew);
        ellipses.removeChild(towerRangeRallyPoint);
        towerRange = null;
        towerRangeNew = null;
        towerRangeRallyPoint = null;
        waves = null;
        activeWaves = null;
        terrain.removeChild(gTerrain);
        gTerrain = null;
        removeChild(terrain);
        terrain = null;
        removeChild(ellipses);
        ellipses = null;
        removeChild(background);
        background = null;
        removeChild(decals);
        decals = null;
        removeChild(entities);
        entities = null;
        removeChild(frontEntities);
        frontEntities = null;
        removeChild(bulletsDecals);
        bulletsDecals = null;
        removeChild(bullets);
        bullets = null;
        removeChild(gui);
        gui = null;
        towers = null;
        enemies = null;
        soldiers = null;
        §_-Is§ = null;
        staticEnemies = null;
        staticAreas = null;
        rallyPoint = null;
        powerPointer = null;
        enemySelection = null;
        soldierSelection = null;
        §_-Et§ = null;
        game = null;
        parent.removeChild(this);
    }
}





//javascript 
import com.adobe.utils.StringUtil;
   import com.reintroducing.sound.SoundManager;
   import flash.display.MovieClip;
   import flash.display.Sprite;
   import flash.events.*;
   import flash.geom.Point;
   import flash.ui.Keyboard;
   import flash.utils.Dictionary;
   import flash.utils.getDefinitionByName;
   import flash.utils.getQualifiedClassName;
   import ironhide.utils.tooltip.*;
   import org.casalib.math.geom.Ellipse;
   
   public class Level extends MovieClip
   {
      
      public static const LEVEL_NORMAL:int = 0;
      
      public static const LEVEL_PAUSED:int = 1;
      
      public static const LEVEL_WIN:int = 2;
      
      public static const LEVEL_OVER:int = 3;
      
      public static const LEVEL_STARTING:int = 4;
      
      public static const LEVEL_PRE_WIN:int = 5;
       
      
      public var mode:int;
      
      public var § if§:int;
      
      public var §_-i§:String = "forest";
      
      public var §_-2K§:int;
      
      public var game:Game;
      
      public var data:SaveDataLevel;
      
      public var §_-94§:§_-GU§;
      
      public var §_-Iy§:int = 0;
      
      public var §_-19§:PauseLayer;
      
      public var gameSettings:GameSettings;
      
      public var maxUpgradeLevel:int;
      
      public var maxWaves:int;
      
      public var currentWave:int;
      
      public var initLives:int;
      
      public var lives:int;
      
      public var cash:int;
      
      public var §_-2J§:int = 0;
      
      public var tDamage:Number = 0;
      
      public var §_-B4§:Array;
      
      public var paths:Array;
      
      public var hasTunnels:Boolean;
      
      public var tunnels:Array;
      
      public var §_-4B§:Array;
      
      public var inactiveNodeDistance:int = 13;
      
      public var indexWaves:int = 0;
      
      public var intervalWaveCounter:int = 0;
      
      public var toolTip:Tooltip;
      
      public var menu:MenuBottom;
      
      public var §_-J9§:Hud;
      
      public var §_-5C§:§_-CP§;
      
      public var §_-EB§:§use§;
      
      public var butEncyclopedia:ButtonEncyclopedia;
      
      public var quickMenu:TowerMenu;
      
      public var notificationHolder:NotificationSecondLevelHolder;
      
      public var towerRange:§_-0K§;
      
      public var towerRangeNew:TowerCircleNew;
      
      public var towerRangeRallyPoint:§_-6p§;
      
      public var waves:Array;
      
      public var activeWaves:Dictionary;
      
      public var §_-6x§:Boolean;
      
      public var §_-F§:FirstWaveSign;
      
      public var terrain:Sprite;
      
      public var ellipses:Sprite;
      
      public var background:Sprite;
      
      public var decals:Sprite;
      
      public var entities:Sprite;
      
      public var frontEntities:Sprite;
      
      public var bulletsDecals:Sprite;
      
      public var bullets:Sprite;
      
      public var gui:Sprite;
      
      public var towers:Dictionary;
      
      public var enemies:Dictionary;
      
      public var soldiers:Dictionary;
      
      public var §_-Is§:Dictionary;
      
      public var menuPause:§_-BM§;
      
      public var staticEnemies:Dictionary;
      
      public var staticAreas:Array;
      
      public var rallyPoint:TowerRallyPoint;
      
      public var powerPointer:§_-27§;
      
      public var enableElements:Boolean = true;
      
      public var enemySelection:EnemySelection;
      
      public var soldierSelection:SoldierSelection;
      
      public var §_-Cc§:int = 0;
      
      public var §_-Et§:AchievementItem;
      
      public var gTerrain:MovieClip;
      
      public var initTime:int = 30;
      
      public var initTimeCounter:int = 0;
      
      public var §_-Bj§:int = 30;
      
      public var §_-6F§:int = 0;
      
      public var power1:Boolean;
      
      public var power2:Boolean;
      
      public var unlockMaxArchers:int;
      
      public var unlockMaxMages:int;
      
      public var unlockMaxEngineers:int;
      
      public var unlockMaxBarracks:int;
      
      public var unlockMaxArchersLevel:int;
      
      public var unlockMaxMagesLevel:int;
      
      public var unlockMaxEngineersLevel:int;
      
      public var unlockMaxBarracksLevel:int;
      
      public var isReadyToWin:Boolean;
      
      public var readyToWinTime:int = 30;
      
      public var readyToWinTimeCounter:int = 0;
      
      public var fearless:Boolean = true;
      
      private var fireballCounter:int;
      
      private var sellTowersCounter:int;
      
      private var elementals:int = 0;
      
      private var teslas:int = 0;
      
      public var graveyard:Graveyard;
      
      public var currentSkeletons:int = 0;
      
      public function Level(param1:Array, param2:Array, param3:int = 0)
      {
         this.§_-94§ = new §_-GU§();
         this.§_-19§ = new PauseLayer();
         this.paths = [];
         this.towerRange = new §_-0K§();
         this.towerRangeNew = new TowerCircleNew();
         this.towerRangeRallyPoint = new §_-6p§();
         this.activeWaves = new Dictionary(true);
         this.terrain = new Sprite();
         this.ellipses = new Sprite();
         this.background = new Sprite();
         this.decals = new Sprite();
         this.entities = new Sprite();
         this.frontEntities = new Sprite();
         this.bulletsDecals = new Sprite();
         this.bullets = new Sprite();
         this.gui = new Sprite();
         this.towers = new Dictionary(true);
         this.enemies = new Dictionary(true);
         this.soldiers = new Dictionary(true);
         this.§_-Is§ = new Dictionary(true);
         this.staticEnemies = new Dictionary(true);
         this.staticAreas = [];
         this.enemySelection = new EnemySelection();
         this.soldierSelection = new SoldierSelection();
         super();
         this.mode = param3;
         this.§_-2K§ = this.cash;
         this.isReadyToWin = false;
         this.game.gameSounds.setLevel(this);
         this.addChild(this.terrain);
         this.addChild(this.decals);
         this.addChild(this.ellipses);
         this.addChild(this.background);
         this.addChild(this.entities);
         this.addChild(this.frontEntities);
         this.addChild(this.bulletsDecals);
         this.addChild(this.bullets);
         this.addChild(this.gui);
         this.getNumberOfWaves();
         this.menuPause = new §_-BM§(this);
         this.lives = this.initLives;
         this.§ if§ = LEVEL_STARTING;
         this.initTowers(param1);
         this.paths = param2;
         this.gameSettings = new GameSettings(this.game,true,this.maxUpgradeLevel);
         this.ellipses.addChild(this.towerRange);
         this.ellipses.addChild(this.towerRangeNew);
         this.ellipses.addChild(this.towerRangeRallyPoint);
         this.towerRange.visible = false;
         this.towerRangeNew.visible = false;
         this.towerRangeRallyPoint.visible = false;
         this.towerRange.addEventListener(MouseEvent.MOUSE_DOWN,this.towerRangeClick,false,0,true);
         this.towerRangeNew.addEventListener(MouseEvent.MOUSE_DOWN,this.towerRangeNewClick,false,0,true);
         this.gui.addChild(this.§_-19§);
         this.§_-19§.start();
         this.§_-C6§();
         this.game.gameSounds.stopAllMusics();
         this.game.gameSounds.playMusicPreBattle();
         this.menu = new MenuBottom(new Point(0,543),this);
         this.§_-F§ = new FirstWaveSign(new Point(652,543));
         this.decals.addChild(this.§_-F§);
         this.addEventListener(Event.DEACTIVATE,this.onDeactivate,false,0,true);
         this.§try§();
      }
      
      public function loadCampaign() : void
      {
      }
      
      public function loadHeroic() : void
      {
      }
      
      public function loadIron() : void
      {
      }
      
      private function onDeactivate(param1:Event) : void
      {
         if(this.game.§_-AT§ && this.§ if§ == LEVEL_NORMAL)
         {
            this.§_-Ib§(true);
         }
      }
      
      public function §_-1P§() : void
      {
      }
      
      public function §_-1D§(param1:KeyboardEvent) : void
      {
         switch(param1.keyCode)
         {
            case Keyboard.SPACE:
               this.cancelAllOnKeyPress();
               break;
            case Keyboard.ESCAPE:
               this.cancelAllOnKeyPress();
               break;
            case 112:
               if(this.§ if§ == LEVEL_NORMAL)
               {
                  this.§_-Ib§();
               }
               else
               {
                  this.§_-Gl§();
               }
               break;
            case 80:
               if(this.§ if§ == LEVEL_NORMAL)
               {
                  this.§_-Ib§();
               }
               else
               {
                  this.§_-Gl§();
               }
               break;
            case Keyboard.NUMPAD_1:
               if(this.§ if§ == LEVEL_NORMAL && this.menu != null && this.menu.powersHolder.numChildren != 0)
               {
                  this.cancelExtraPowers();
                  if(this.powerPointer == null)
                  {
                     PowerFireball(this.menu.powersHolder.getChildAt(0)).§_-Hy§();
                  }
                  else if(getQualifiedClassName(this.powerPointer) == "PowerPointerFireball")
                  {
                     this.powerPointer.cancelPower();
                  }
                  else
                  {
                     this.powerPointer.cancelPower();
                     PowerFireball(this.menu.powersHolder.getChildAt(0)).§_-Hy§();
                  }
               }
               break;
            case 49:
               if(this.§ if§ == LEVEL_NORMAL && this.menu != null && this.menu.powersHolder.numChildren != 0)
               {
                  this.cancelExtraPowers();
                  if(this.powerPointer == null)
                  {
                     PowerFireball(this.menu.powersHolder.getChildAt(0)).§_-Hy§();
                  }
                  else if(getQualifiedClassName(this.powerPointer) == "PowerPointerFireball")
                  {
                     this.powerPointer.cancelPower();
                  }
                  else
                  {
                     this.powerPointer.cancelPower();
                     PowerFireball(this.menu.powersHolder.getChildAt(0)).§_-Hy§();
                  }
               }
               break;
            case Keyboard.NUMPAD_2:
               if(this.§ if§ == LEVEL_NORMAL && this.menu != null && this.menu.powersHolder.numChildren != 0)
               {
                  this.cancelExtraPowers();
                  if(this.powerPointer == null)
                  {
                     PowerReinforcement(this.menu.powersHolder.getChildAt(1)).§_-Hy§();
                  }
                  else if(StringUtil.beginsWith(getQualifiedClassName(this.powerPointer),"PowerPointerReinforcement") || StringUtil.beginsWith(getQualifiedClassName(this.powerPointer),"PowerPointerFarmer"))
                  {
                     this.powerPointer.cancelPower();
                  }
                  else
                  {
                     this.powerPointer.cancelPower();
                     PowerReinforcement(this.menu.powersHolder.getChildAt(1)).§_-Hy§();
                  }
               }
               break;
            case 50:
               if(this.§ if§ == LEVEL_NORMAL && this.menu != null && this.menu.powersHolder.numChildren != 0)
               {
                  this.cancelExtraPowers();
                  if(this.powerPointer == null)
                  {
                     PowerReinforcement(this.menu.powersHolder.getChildAt(1)).§_-Hy§();
                  }
                  else if(StringUtil.beginsWith(getQualifiedClassName(this.powerPointer),"PowerPointerReinforcement") || StringUtil.beginsWith(getQualifiedClassName(this.powerPointer),"PowerPointerFarmer"))
                  {
                     this.powerPointer.cancelPower();
                  }
                  else
                  {
                     this.powerPointer.cancelPower();
                     PowerReinforcement(this.menu.powersHolder.getChildAt(1)).§_-Hy§();
                  }
               }
               break;
            case Keyboard.NUMPAD_3:
               if(this.game.pc && this.game.pcLightning && this.§ if§ == LEVEL_NORMAL && this.menu != null && this.menu.powersHolder.numChildren != 0)
               {
                  this.cancelExtraPowers();
                  if(this.powerPointer == null)
                  {
                     PowerLightning(this.menu.powersHolder.getChildAt(2)).§_-Hy§();
                  }
                  else if(getQualifiedClassName(this.powerPointer) == "PowerPointerLightning")
                  {
                     this.powerPointer.cancelPower();
                  }
                  else
                  {
                     this.powerPointer.cancelPower();
                     PowerLightning(this.menu.powersHolder.getChildAt(2)).§_-Hy§();
                  }
               }
               break;
            case 51:
               if(this.game.pc && this.game.pcLightning && this.§ if§ == LEVEL_NORMAL && this.menu != null && this.menu.powersHolder.numChildren != 0)
               {
                  this.cancelExtraPowers();
                  if(this.powerPointer == null)
                  {
                     PowerLightning(this.menu.powersHolder.getChildAt(2)).§_-Hy§();
                  }
                  else if(getQualifiedClassName(this.powerPointer) == "PowerPointerLightning")
                  {
                     this.powerPointer.cancelPower();
                  }
                  else
                  {
                     this.powerPointer.cancelPower();
                     PowerLightning(this.menu.powersHolder.getChildAt(2)).§_-Hy§();
                  }
               }
         }
         this.extraKeyPress(param1.keyCode);
      }
      
      public function §_-Ib§(param1:Boolean = false) : void
      {
         if(this.menuPause != null && !this.gui.contains(this.menuPause))
         {
            this.pause();
            if(param1)
            {
               this.menuPause.enableAutoPause();
            }
            else
            {
               this.menuPause.§_-34§();
            }
            this.gui.addChild(this.menuPause);
         }
      }
      
      public function §_-Gl§() : void
      {
         if(this.menuPause != null && this.gui.contains(this.menuPause))
         {
            this.pause();
            this.gui.removeChild(this.menuPause);
         }
      }
      
      public function extraKeyPress(param1:uint) : void
      {
      }
      
      public function cancelExtraPowers() : void
      {
      }
      
      public function cancelAllOnKeyPress() : void
      {
         if(this.powerPointer != null)
         {
            this.powerPointer.cancelPower();
            this.menu.forceHideInfo();
         }
         if(this.rallyPoint != null)
         {
            this.rallyPoint.§_-Cv§();
         }
         this.keyPressCheckExtra();
      }
      
      public function keyPressCheckExtra() : void
      {
      }
      
      public function §_-3g§() : void
      {
         this.game.main.§_-Lz§();
         this.§_-94§.x = 370;
         this.§_-94§.y = 5;
         this.§_-J9§ = new Hud(10,10,this.cash,this.initLives,this.maxWaves,this);
         this.notificationHolder = new NotificationSecondLevelHolder(this);
         this.gui.addChild(this.notificationHolder);
         this.§_-5C§ = new §_-CP§(this);
         this.gui.addChild(this.§_-5C§);
         this.§_-EB§ = new §use§(this);
         this.gui.addChild(this.§_-EB§);
         this.butEncyclopedia = new ButtonEncyclopedia(this);
         this.gui.addChild(this.butEncyclopedia);
         this.gui.addChild(this.§_-J9§);
         this.quickMenu = new TowerMenu(this);
         this.gui.addChild(this.menu);
         this.decals.addChild(this.enemySelection);
         this.decals.addChild(this.soldierSelection);
      }
      
      public function onPause() : Boolean
      {
         if(this.§ if§ == LEVEL_PAUSED)
         {
            return true;
         }
         return false;
      }
      
      public function pause(param1:Boolean = false, param2:Boolean = true) : void
      {
         if(!this.onPause())
         {
            if(param1)
            {
               this.block();
            }
            if(this.§ if§ != LEVEL_PRE_WIN)
            {
               this.§ if§ = LEVEL_PAUSED;
            }
            if(param2)
            {
               SoundManager.getInstance().stopAllFxSounds();
            }
            this.§_-AD§();
            this.pauseEntities();
            this.pauseBackground();
            this.§_-Hh§();
            this.§_-Ca§();
         }
         else
         {
            if(param1)
            {
               this.§_-t§();
            }
            this.§ if§ = LEVEL_NORMAL;
            this.§_-Da§();
            this.unPauseEntities();
            this.§_-BK§();
            this.unPauseBackground();
            this.§_-64§();
         }
      }
      
      public function block() : void
      {
         this.gui.addChild(this.§_-19§);
         this.§_-19§.show();
      }
      
      public function §_-t§() : void
      {
         this.§_-19§.hide();
      }
      
      public function unPause() : void
      {
         this.§ if§ = LEVEL_NORMAL;
      }
      
      public function setPowerPointer(param1:§_-27§) : void
      {
         this.powerPointer = param1;
         this.disableLevelElements();
      }
      
      public function §_-E6§() : void
      {
         this.powerPointer = null;
         this.enableLevelElements();
      }
      
      public function enableLevelElements() : void
      {
         this.enableElements = true;
      }
      
      public function disableLevelElements() : void
      {
         this.enableElements = false;
      }
      
      public function freeMenues() : void
      {
         if(this.quickMenu != null && this.quickMenu.cTower != null && this.gui.contains(this.quickMenu))
         {
            this.quickMenu.hide();
         }
      }
      
      public function intro(param1:MouseEvent) : void
      {
         if(!this.enableElements)
         {
            return;
         }
         this.menu.forceHideInfo();
         this.freeMenues();
         this.removeToopTip();
      }
      
      public function towerRangeClick(param1:MouseEvent) : void
      {
         this.forceFreeQuickMenu();
      }
      
      public function towerRangeNewClick(param1:MouseEvent) : void
      {
         this.forceFreeQuickMenu();
      }
      
      public function forceFreeQuickMenu() : void
      {
         if(this.quickMenu.cTower == null)
         {
            return;
         }
         if(this.gui.contains(this.quickMenu))
         {
            this.quickMenu.hide();
         }
      }
      
      public function init(param1:Event) : void
      {
      }
      
      public function eFrameEvents(param1:Event) : void
      {
         if(this.§ if§ == LEVEL_STARTING)
         {
            if(this.initTimeCounter < this.initTime)
            {
               ++this.initTimeCounter;
               if(this.initTimeCounter + 3 == this.initTime)
               {
                  this.§_-3g§();
               }
               return;
            }
            this.§ if§ = LEVEL_NORMAL;
            if(this.data.levelIndex == 0 && this.mode == GameSettings.§_-2Q§)
            {
               this.pause(true);
               this.gui.addChild(new TutorialIntro(new Point(0,0),this));
            }
         }
         if(this.§ if§ == LEVEL_NORMAL || this.§ if§ == LEVEL_PRE_WIN)
         {
            this.§_-Cc§ = 0;
            if(this.§ if§ == LEVEL_NORMAL)
            {
               this.§_-EQ§();
            }
            if(this.§ if§ == LEVEL_NORMAL || this.§ if§ == LEVEL_PRE_WIN)
            {
               if(this.stage.focus != this.stage)
               {
                  this.stage.focus = this.stage;
               }
               this.game.gameSounds.onFrameUpdate();
               this.updateEntities();
               this.updateBullets();
               this.updateBulletsDecals();
               this.updateDecals();
               this.updateBackground();
               this.§ true§();
               this.menu.updateMenu();
               this.notificationHolder.update();
               this.updatePointers();
            }
            if(this.§ if§ == LEVEL_PRE_WIN)
            {
               if(this.§_-6F§ < this.§_-Bj§)
               {
                  ++this.§_-6F§;
                  return;
               }
               if(this.data.levelIndex < 11 || this.data.levelIndex == 11 && this.mode != GameSettings.§_-2Q§)
               {
                  this.pause(true);
               }
               this.§ if§ = LEVEL_WIN;
               this.addMenuVictory();
            }
         }
      }
      
      public function onPreWin() : void
      {
      }
      
      public function addMenuVictory() : void
      {
         switch(this.mode)
         {
            case GameSettings.§_-2Q§:
               this.addChild(new MenuVictory(this));
               break;
            case GameSettings.§_-Mv§:
               this.addChild(new MenuVictoryHeroic(this));
               break;
            case GameSettings.MODE_IRON:
               this.addChild(new MenuVictoryIron(this));
         }
      }
      
      public function updatePointers() : void
      {
         if(this.powerPointer)
         {
            this.powerPointer.onFrameUpdate();
         }
      }
      
      public function updateEntities() : void
      {
         var _loc3_:MovieClip = null;
         var _loc1_:Dictionary = new Dictionary(true);
         var _loc2_:int = 0;
         while(_loc2_ < this.entities.numChildren)
         {
            _loc1_[this.entities.getChildAt(_loc2_)] = this.entities.getChildAt(_loc2_);
            ++this.§_-Cc§;
            _loc2_++;
         }
         for each(_loc3_ in _loc1_)
         {
            _loc3_.onFrameUpdate();
         }
         _loc1_ = null;
      }
      
      public function updateDecals() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.decals.numChildren)
         {
            MovieClip(this.decals.getChildAt(_loc1_)).onFrameUpdate();
            ++this.§_-Cc§;
            _loc1_++;
         }
      }
      
      public function updateBackground() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.background.numChildren)
         {
            §_-0P§(this.background.getChildAt(_loc1_)).onFrameUpdate();
            ++this.§_-Cc§;
            _loc1_++;
         }
      }
      
      public function updateBullets() : void
      {
         var _loc3_:MovieClip = null;
         var _loc1_:Dictionary = new Dictionary(true);
         var _loc2_:int = 0;
         while(_loc2_ < this.bullets.numChildren)
         {
            _loc1_[this.bullets.getChildAt(_loc2_)] = this.bullets.getChildAt(_loc2_);
            _loc2_++;
         }
         for each(_loc3_ in _loc1_)
         {
            _loc3_.onFrameUpdate();
         }
         _loc1_ = null;
      }
      
      public function updateBulletsDecals() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.bulletsDecals.numChildren)
         {
            MovieClip(this.bulletsDecals.getChildAt(_loc1_)).onFrameUpdate();
            ++this.§_-Cc§;
            _loc1_++;
         }
      }
      
      public function pauseEntities() : void
      {
         var _loc3_:MovieClip = null;
         var _loc1_:Dictionary = new Dictionary(true);
         var _loc2_:int = 0;
         while(_loc2_ < this.entities.numChildren)
         {
            _loc1_[this.entities.getChildAt(_loc2_)] = this.entities.getChildAt(_loc2_);
            ++this.§_-Cc§;
            _loc2_++;
         }
         for each(_loc3_ in _loc1_)
         {
            _loc3_.pause();
         }
         _loc1_ = null;
      }
      
      public function unPauseEntities() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.entities.numChildren)
         {
            MovieClip(this.entities.getChildAt(_loc1_)).unPause();
            ++this.§_-Cc§;
            _loc1_++;
         }
      }
      
      public function pauseEnemies() : void
      {
         var _loc1_:Enemy = null;
         for each(_loc1_ in this.enemies)
         {
            _loc1_.pause();
         }
      }
      
      public function unPauseEnemies() : void
      {
         var _loc1_:Enemy = null;
         for each(_loc1_ in this.enemies)
         {
            _loc1_.unPause();
         }
      }
      
      public function §_-05§() : void
      {
         var _loc1_:Soldier = null;
         for each(_loc1_ in this.soldiers)
         {
            _loc1_.pause();
         }
      }
      
      public function §_-2i§() : void
      {
         var _loc1_:Soldier = null;
         for each(_loc1_ in this.soldiers)
         {
            _loc1_.unPause();
         }
      }
      
      public function pauseBackground() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.background.numChildren)
         {
            §_-0P§(this.background.getChildAt(_loc1_)).pause();
            _loc1_++;
         }
      }
      
      public function unPauseBackground() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.background.numChildren)
         {
            §_-0P§(this.background.getChildAt(_loc1_)).unPause();
            _loc1_++;
         }
      }
      
      public function pauseTowers() : void
      {
         var _loc1_:Tower = null;
         for each(_loc1_ in this.towers)
         {
            _loc1_.pause();
         }
      }
      
      public function unPauseTowers() : void
      {
         var _loc1_:Tower = null;
         for each(_loc1_ in this.towers)
         {
            _loc1_.unPause();
         }
      }
      
      public function §_-Ca§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.bulletsDecals.numChildren)
         {
            MovieClip(this.bulletsDecals.getChildAt(_loc1_)).pause();
            _loc1_++;
         }
      }
      
      public function §_-64§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.bulletsDecals.numChildren)
         {
            MovieClip(this.bulletsDecals.getChildAt(_loc1_)).unPause();
            _loc1_++;
         }
      }
      
      public function §_-Hh§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.bullets.numChildren)
         {
            MovieClip(this.bullets.getChildAt(_loc1_)).pause();
            _loc1_++;
         }
      }
      
      public function §_-BK§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.bullets.numChildren)
         {
            MovieClip(this.bullets.getChildAt(_loc1_)).unPause();
            _loc1_++;
         }
      }
      
      public function §_-AD§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.decals.numChildren)
         {
            MovieClip(this.decals.getChildAt(_loc1_)).pause();
            _loc1_++;
         }
      }
      
      public function §_-Da§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.decals.numChildren)
         {
            MovieClip(this.decals.getChildAt(_loc1_)).unPause();
            _loc1_++;
         }
      }
      
      public function initTowers(param1:Array) : void
      {
         var _loc2_:int = 0;
         while(_loc2_ < param1.length)
         {
            this.entities.addChild(param1[_loc2_]);
            _loc2_++;
         }
      }
      
      public function removeTower(param1:Tower) : void
      {
         delete this.towers[param1];
      }
      
      public function removeEnemy(param1:Enemy) : void
      {
         delete this.enemies[param1];
      }
      
      public function removeEnemyStatic(param1:Enemy) : void
      {
         delete this.staticEnemies[param1];
      }
      
      public function addSoldier(param1:Soldier) : void
      {
         this.soldiers[param1] = param1;
      }
      
      public function removeSoldier(param1:Soldier) : void
      {
         delete this.soldiers[param1];
      }
      
      public function addBackground(param1:§_-0P§) : void
      {
         this.background.addChild(param1);
      }
      
      public function removeBackground(param1:§_-0P§) : void
      {
         this.background.removeChild(param1);
      }
      
      public function static(param1:MovieClip) : void
      {
         this.bullets.removeChild(param1);
         this.addToDecal(param1);
      }
      
      public function addToDecal(param1:MovieClip) : void
      {
         this.decals.addChild(param1);
      }
      
      public function updateCash(param1:int) : void
      {
         if(param1 > 0)
         {
            this.§_-2J§ += param1;
         }
         this.cash += param1;
         this.§_-J9§.updateCash(this.cash);
      }
      
      public function onRangeStaticArea(param1:Array, param2:Point) : Boolean
      {
         if(Math.sqrt(Math.pow(param1[0] - param2.y,2) + Math.pow(param1[1] - param2.x,2)) < param1[2])
         {
            return true;
         }
         return false;
      }
      
      public function looseLive(param1:int) : void
      {
         this.game.gameSounds.playGUILooseLife();
         this.lives -= param1;
         if(this.lives <= 0)
         {
            this.lives = 0;
         }
         this.§_-J9§.updateLives(this.lives);
         if(this.lives == 0)
         {
            this.§_-FY§();
         }
      }
      
      public function §_-5§() : String
      {
         return this.game.§_-5§();
      }
      
      public function §_-FY§() : void
      {
         this.pause(true);
         this.§ if§ = LEVEL_OVER;
         this.addChild(new §_-Gj§(this));
      }
      
      protected function getNumberOfWaves() : void
      {
         var _loc1_:int = 0;
         var _loc2_:int = 0;
         while(_loc2_ < this.waves.length)
         {
            _loc1_++;
            while(_loc2_ + 1 < this.waves.length && this.waves[_loc2_ + 1].interval == 0)
            {
               _loc2_++;
            }
            _loc2_++;
         }
         this.maxWaves = _loc1_;
         this.currentWave = 0;
      }
      
      private function §_-EQ§() : void
      {
         var _loc2_:Wave = null;
         var _loc3_:Wave = null;
         var _loc4_:int = 0;
         var _loc1_:int = 0;
         if(this.currentWave == 0 && this.§_-6x§)
         {
            return;
         }
         for each(_loc2_ in this.activeWaves)
         {
            _loc1_++;
         }
         if(_loc1_ == 0)
         {
            if(this.indexWaves < this.waves.length)
            {
               if(this.waves[this.indexWaves].interval == this.intervalWaveCounter)
               {
                  if(this.indexWaves != 0 && this.waves[this.indexWaves].notification != "")
                  {
                     this.forceFreeQuickMenu();
                     this.sendPauseNotification(this.waves[this.indexWaves].notification);
                  }
                  ++this.currentWave;
                  this.activeWaves[this.waves[this.indexWaves]] = this.waves[this.indexWaves];
                  this.intervalWaveCounter = 0;
                  ++this.indexWaves;
                  this.§_-J9§.updateWaves(this.currentWave,this.maxWaves);
                  this.afterNextWaveStart();
                  while(this.indexWaves < this.waves.length && this.waves[this.indexWaves].interval == 0)
                  {
                     this.activeWaves[this.waves[this.indexWaves]] = this.waves[this.indexWaves];
                     ++this.indexWaves;
                  }
                  this.menu.§_-Gx§();
               }
               else
               {
                  if(this.indexWaves == 0 && this.waves[this.indexWaves].notification != "")
                  {
                     this.forceFreeQuickMenu();
                     this.sendPauseNotification(this.waves[this.indexWaves].notification);
                  }
                  if(this.intervalWaveCounter == 50 && this.waves[this.indexWaves].interval != 0 || this.indexWaves == 0)
                  {
                     this.waves[this.indexWaves].showWaveFlag(this,this.waves[this.indexWaves].interval - 50,this.indexWaves);
                     if(this.§_-F§ != null)
                     {
                        this.game.gameSounds.playGUINextWaveReady();
                     }
                     _loc4_ = this.indexWaves + 1;
                     while(_loc4_ < this.waves.length && this.waves[_loc4_].interval == 0)
                     {
                        this.waves[_loc4_].showWaveFlag(this,this.waves[this.indexWaves].interval - 50,this.indexWaves);
                        _loc4_++;
                     }
                     this.afterNextWaveFlagShow();
                  }
                  if(this.indexWaves == 0)
                  {
                     this.§_-6x§ = true;
                  }
                  else
                  {
                     ++this.intervalWaveCounter;
                  }
               }
            }
            else if(!this.hasEnemies())
            {
               this.§ if§ = LEVEL_PRE_WIN;
               this.onPreWin();
               this.checkLevelAchievements();
            }
         }
         for each(_loc3_ in this.activeWaves)
         {
            _loc3_.spawnEnemies(this);
         }
      }
      
      public function afterNextWaveFlagShow() : void
      {
      }
      
      public function afterNextWaveStart() : void
      {
      }
      
      public function checkLevelAchievements() : void
      {
         if(this.fearless && this.maxWaves > 1)
         {
            this.game.gameAchievement.doFearless(this);
         }
         this.§try§();
         this.checkLevelSpecialAchievements();
      }
      
      public function §try§() : void
      {
         var _loc2_:int = 0;
         var _loc3_:int = 0;
         var _loc4_:int = 0;
         if(this.mode == GameSettings.§_-2Q§ && this.game.gameAchievement.greatDefender)
         {
            return;
         }
         if(this.mode == GameSettings.§_-Mv§ && this.game.gameAchievement.greatDefenderHeroic)
         {
            return;
         }
         if(this.mode == GameSettings.MODE_IRON && this.game.gameAchievement.greatDefenderIron)
         {
            return;
         }
         var _loc1_:Boolean = true;
         if(this.mode == GameSettings.§_-2Q§)
         {
            _loc2_ = 0;
            while(_loc2_ < 12)
            {
               if(SaveDataLevel(this.game.§_-98§[_loc2_]).campaignDifficulty != GameSettings.DIFFICULTY_NORMAL)
               {
                  if(this.data.levelIndex != _loc2_ || this.data.levelIndex == _loc2_ && this.game.difficulty != GameSettings.DIFFICULTY_NORMAL)
                  {
                     _loc1_ = false;
                     break;
                  }
               }
               _loc2_++;
            }
            if(_loc1_)
            {
               this.game.gameAchievement.§_-3U§(this);
            }
            return;
         }
         if(this.mode == GameSettings.§_-Mv§)
         {
            _loc3_ = 0;
            while(_loc3_ < 12)
            {
               if(!SaveDataLevel(this.game.§_-98§[_loc3_]).heroicModeWin || SaveDataLevel(this.game.§_-98§[_loc3_]).heroicDifficulty != GameSettings.DIFFICULTY_NORMAL)
               {
                  if(this.data.levelIndex != _loc3_ || this.data.levelIndex == _loc3_ && this.game.difficulty != GameSettings.DIFFICULTY_NORMAL)
                  {
                     _loc1_ = false;
                     break;
                  }
               }
               _loc3_++;
            }
            if(_loc1_)
            {
               this.game.gameAchievement.chkGreatDefenderHeroic(this);
            }
            return;
         }
         if(this.mode == GameSettings.MODE_IRON)
         {
            _loc4_ = 0;
            while(_loc4_ < 12)
            {
               if(!SaveDataLevel(this.game.§_-98§[_loc4_]).ironModeWin || SaveDataLevel(this.game.§_-98§[_loc4_]).ironDifficulty != GameSettings.DIFFICULTY_NORMAL)
               {
                  if(this.data.levelIndex != _loc4_ || this.data.levelIndex == _loc4_ && this.game.difficulty != GameSettings.DIFFICULTY_NORMAL)
                  {
                     _loc1_ = false;
                     break;
                  }
               }
               _loc4_++;
            }
            if(_loc1_)
            {
               this.game.gameAchievement.chkGreatDefenderIron(this);
            }
            return;
         }
      }
      
      public function checkLevelSpecialAchievements() : void
      {
      }
      
      public function sendPauseNotification(param1:String) : void
      {
         var _loc2_:Class = getDefinitionByName(param1) as Class;
         this.pause(true);
         this.gui.addChild(new _loc2_(this,true));
      }
      
      public function sendSecondLevelNotification(param1:String) : void
      {
         this.notificationHolder.addNotification(param1);
      }
      
      public function §_-C8§(param1:Point) : void
      {
         var _loc2_:int = 0;
         if(this.§_-6x§)
         {
            if(this.power2)
            {
               this.unlockPowerFireball();
            }
            if(this.power1)
            {
               this.unlockPowerReinforcement();
            }
            this.unlockPowerLightning();
            this.§_-6x§ = false;
            if(this.§_-F§ != null && this.decals.contains(this.§_-F§))
            {
               this.decals.removeChild(this.§_-F§);
            }
            this.playLevelMusic();
         }
         else
         {
            if(this.intervalWaveCounter / 30 <= 3)
            {
               this.game.gameAchievement.checkImpatient(this);
            }
            this.game.gameAchievement.checkDaring(this);
         }
         if(this.indexWaves != 0)
         {
            this.menu.§_-MD§(this.waves[this.indexWaves].interval - this.intervalWaveCounter);
            _loc2_ = Math.round((this.waves[this.indexWaves].interval - this.intervalWaveCounter) / this.gameSettings.framesRate);
            if(_loc2_ >= 1)
            {
               this.bullets.addChild(new WaveFlagReward(param1,Math.round(_loc2_ * 1)));
               this.game.gameSounds.playGUINextWaveReward();
               this.updateCash(Math.round(_loc2_ * 1));
            }
         }
         this.intervalWaveCounter = this.waves[this.indexWaves].interval;
         this.§_-5t§();
      }
      
      public function playLevelMusic() : void
      {
         this.game.gameSounds.stopAllMusics();
         this.game.gameSounds.playMusicBattle();
      }
      
      public function §_-54§(param1:WaveFlag) : void
      {
         var _loc3_:WaveFlag = null;
         var _loc2_:int = 0;
         for each(_loc3_ in this.§_-Is§)
         {
            _loc2_++;
         }
         if(_loc2_ == 0)
         {
            this.menu.enableNextWave();
         }
         this.§_-Is§[param1] = param1;
      }
      
      public function §_-2w§(param1:WaveFlag, param2:Boolean = false) : void
      {
         var _loc3_:int = 0;
         var _loc4_:WaveFlag = null;
         param1.§_-3v§();
         delete this.§_-Is§[param1];
         if(!param2)
         {
            _loc3_ = 0;
            for each(_loc4_ in this.§_-Is§)
            {
               _loc3_++;
            }
            if(_loc3_ == 0)
            {
               this.menu.§_-Gx§();
            }
         }
      }
      
      public function §_-1C§(param1:WaveFlag) : void
      {
         var _loc3_:WaveFlag = null;
         delete this.§_-Is§[param1];
         var _loc2_:int = 0;
         for each(_loc3_ in this.§_-Is§)
         {
            _loc2_++;
         }
         if(_loc2_ == 0)
         {
            this.menu.§_-Gx§();
         }
      }
      
      public function §_-5t§() : void
      {
         var _loc1_:WaveFlag = null;
         for each(_loc1_ in this.§_-Is§)
         {
            this.§_-2w§(_loc1_,true);
         }
         this.menu.§_-Gx§();
      }
      
      public function unlockPowerFireball() : void
      {
         this.menu.unlockPower(0);
      }
      
      public function unlockPowerReinforcement() : void
      {
         this.menu.unlockPower(1);
      }
      
      public function unlockPowerLightning() : void
      {
         if(this.game.pc && this.game.pcLightning)
         {
            this.menu.unlockPower(2);
         }
      }
      
      public function §_-Gq§() : void
      {
         ++this.fireballCounter;
         if(this.fireballCounter == 5)
         {
            this.game.gameAchievement.checkArmaggedon(this);
         }
      }
      
      public function addElementalAchievement() : void
      {
         ++this.elementals;
         if(this.elementals == 5)
         {
            this.game.gameAchievement.§_-J8§(this);
         }
      }
      
      public function addTeslaAchievement() : void
      {
         ++this.teslas;
         if(this.teslas == 4)
         {
            this.game.gameAchievement.§_-Na§(this);
         }
      }
      
      public function addSellTowerAchievement() : void
      {
         ++this.sellTowersCounter;
         if(this.sellTowersCounter == 5)
         {
            this.game.gameAchievement.doIndecisive(this);
         }
         this.game.gameAchievement.sellTower(this);
      }
      
      protected function hasEnemies() : Boolean
      {
         var _loc1_:Enemy = null;
         var _loc2_:Enemy = null;
         if(this.isReadyToWin)
         {
            if(this.readyToWinTimeCounter < this.readyToWinTime)
            {
               ++this.readyToWinTimeCounter;
               if(this.readyToWinTimeCounter % 10 == 0)
               {
                  for each(_loc2_ in this.enemies)
                  {
                     if(!_loc2_.isBoss || _loc2_.isBoss && !_loc2_.isDead)
                     {
                        this.isReadyToWin = false;
                     }
                  }
               }
               return true;
            }
            return false;
         }
         for each(_loc1_ in this.enemies)
         {
            if(!_loc1_.isBoss || _loc1_.isBoss && !_loc1_.isDead)
            {
               return true;
            }
         }
         this.isReadyToWin = true;
         this.readyToWinTimeCounter = 0;
         return true;
      }
      
      private function traceEnemies() : void
      {
         var _loc2_:Enemy = null;
         var _loc1_:int = 0;
         for each(_loc2_ in this.enemies)
         {
            _loc1_++;
            if(_loc2_.onTunnel)
            {
            }
         }
      }
      
      private function § true§() : void
      {
         var _loc2_:int = 0;
         var _loc1_:int = this.entities.numChildren - 1;
         while(_loc1_ > 0)
         {
            _loc2_ = 0;
            while(_loc2_ < _loc1_)
            {
               if(this.entities.getChildAt(_loc2_).y > this.entities.getChildAt(_loc2_ + 1).y)
               {
                  this.entities.swapChildrenAt(_loc2_,_loc2_ + 1);
               }
               _loc2_++;
            }
            _loc1_--;
         }
      }
      
      protected function §_-50§(param1:Ellipse, param2:int) : Point
      {
         return param1.getPointOfDegreeAux(param2);
      }
      
      public function §_-MB§(param1:int) : Array
      {
         var _loc2_:int = Math.ceil(Math.random() * this.paths[param1].length) - 1;
         return this.paths[param1][_loc2_];
      }
      
      public function randomRange(param1:Number, param2:Number) : Number
      {
         return Math.ceil(Math.random() * (param2 - param1) + param1) - 1;
      }
      
      public function addToopTip(param1:Tooltip) : void
      {
         this.removeToopTip();
         this.toolTip = param1;
         this.gui.addChild(this.toolTip);
         param1 = null;
      }
      
      public function removeToopTip() : void
      {
         if(this.toolTip != null)
         {
            this.toolTip.destroyThis();
            this.toolTip = null;
         }
      }
      
      public function §_-C6§() : void
      {
         var _loc1_:int = 0;
         while(_loc1_ < this.§_-B4§.length)
         {
            this.decals.addChild(new DefenseIndicator(this.§_-B4§[_loc1_]));
            _loc1_++;
         }
      }
      
      public function getStars() : int
      {
         if(this.mode != GameSettings.§_-2Q§)
         {
            return 3;
         }
         if(this.lives >= 18)
         {
            return 3;
         }
         if(this.lives > 5 && this.lives < 18)
         {
            return 2;
         }
         return 1;
      }
      
      public function changeTunneStatus(param1:int, param2:Boolean) : void
      {
      }
      
      public function isTowerLocked(param1:*, param2:*) : Boolean
      {
         switch(param1)
         {
            case GameSettings.§_-6d§:
               if(this.unlockMaxArchers >= param2 || this.unlockMaxArchers == 0 && param2 != 1 && this.unlockMaxArchersLevel >= param2)
               {
                  return false;
               }
               break;
            case GameSettings.§_-Kd§:
               if(this.unlockMaxMages >= param2 || this.unlockMaxMages == 0 && param2 != 1 && this.unlockMaxMagesLevel >= param2)
               {
                  return false;
               }
               break;
            case GameSettings.§_-GV§:
               if(this.unlockMaxEngineers >= param2 || this.unlockMaxEngineers == 0 && param2 != 1 && this.unlockMaxEngineersLevel >= param2)
               {
                  return false;
               }
               break;
            case GameSettings.§_-9O§:
               if(this.unlockMaxBarracks >= param2 || this.unlockMaxBarracks == 0 && param2 != 1 && this.unlockMaxBarracksLevel >= param2)
               {
                  return false;
               }
               break;
         }
         return true;
      }
      
      internal function loadXML(param1:Event) : void
      {
         var _loc5_:* = null;
         var _loc8_:int = 0;
         var _loc9_:int = 0;
         var _loc2_:Array = [];
         var _loc3_:Array = [];
         var _loc4_:XML = new XML(param1.target.data);
         _loc5_ = "this.waves = [ \n ";
         this.cash = int(_loc4_.cash);
         var _loc6_:int = 0;
         while(_loc6_ < _loc4_.wave.length())
         {
            _loc2_ = new Array();
            _loc5_ += "new Wave(\t [ \n";
            _loc8_ = 0;
            while(_loc8_ < _loc4_.wave[_loc6_].spawns.spawn.length())
            {
               _loc2_.push(new WaveSpawn(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].creep,_loc4_.wave[_loc6_].spawns.spawn[_loc8_].creep_aux,int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].max_same),int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].max),int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].interval),int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].interval_next),Boolean(int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].fixed_sub_path)),int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].path)));
               _loc5_ += "new WaveSpawn(\"" + _loc4_.wave[_loc6_].spawns.spawn[_loc8_].creep + "\", \"" + _loc4_.wave[_loc6_].spawns.spawn[_loc8_].creep_aux + "\"," + int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].max_same) + ", " + int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].max) + ", " + int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].interval) + ", " + int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].interval_next) + ", " + Boolean(int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].fixed_sub_path)).toString() + ", " + int(_loc4_.wave[_loc6_].spawns.spawn[_loc8_].path) + ")";
               if(_loc8_ + 1 < _loc4_.wave[_loc6_].spawns.spawn.length())
               {
                  _loc5_ += ",\n";
               }
               else
               {
                  _loc5_ += "]";
               }
               _loc8_++;
            }
            _loc3_.push(new Wave(_loc2_,int(_loc4_.wave[_loc6_].interval),int(_loc4_.wave[_loc6_].path_index),_loc4_.wave[_loc6_].notification,_loc4_.wave[_loc6_].notification_second_level));
            _loc5_ += ", " + int(_loc4_.wave[_loc6_].interval) + "," + int(_loc4_.wave[_loc6_].path_index) + ",\"" + _loc4_.wave[_loc6_].notification + "\",\"" + _loc4_.wave[_loc6_].notification_second_level + "\" ),\n\n\n";
            _loc6_++;
         }
         this.waves = _loc3_;
         var _loc7_:int = 0;
         while(_loc7_ < this.waves.length)
         {
            _loc9_ = 0;
            while(_loc9_ < Wave(this.waves[_loc7_]).spawns.length)
            {
               _loc9_++;
            }
            _loc7_++;
         }
         _loc5_ += "];";
         this.getNumberOfWaves();
      }
      
      public function destroyLevelSpecific() : void
      {
      }
      
      public function destroyThis() : void
      {
         var _loc1_:WaveFlag = null;
         var _loc2_:Wave = null;
         this.§_-Gl§();
         this.menuPause = null;
         this.destroyLevelSpecific();
         if(this.graveyard != null)
         {
            this.graveyard.destroyThis();
         }
         this.removeEventListener(Event.DEACTIVATE,this.onDeactivate);
         this.towerRange.removeEventListener(MouseEvent.MOUSE_DOWN,this.towerRangeClick);
         this.towerRangeNew.removeEventListener(MouseEvent.MOUSE_DOWN,this.towerRangeNewClick);
         this.gTerrain.removeEventListener(MouseEvent.MOUSE_DOWN,this.intro);
         stage.removeEventListener(KeyboardEvent.KEY_DOWN,this.§_-1D§);
         this.removeEventListener(Event.ENTER_FRAME,this.eFrameEvents);
         this.game.gameSounds.unSetLevel();
         for each(_loc1_ in this.§_-Is§)
         {
            _loc1_.destroyThis(false);
         }
         this.quickMenu.destroyThis();
         this.quickMenu = null;
         for each(_loc2_ in this.activeWaves)
         {
            _loc2_.destroyThis();
         }
         if(this.§_-F§ != null)
         {
            this.§_-F§.destroyThis();
         }
         this.§_-F§ = null;
         this.data = null;
         this.§_-94§ = null;
         this.§_-19§ = null;
         this.gameSettings.destroyThis();
         this.gameSettings = null;
         this.§_-B4§ = null;
         this.paths = null;
         this.tunnels = null;
         this.§_-4B§ = null;
         if(this.toolTip != null)
         {
            this.gui.removeChild(this.toolTip);
            this.toolTip = null;
         }
         this.menu = null;
         this.§_-J9§ = null;
         this.notificationHolder = null;
         this.§_-5C§.destroyThis();
         this.§_-5C§ = null;
         this.§_-EB§.destroyThis();
         this.§_-EB§ = null;
         this.butEncyclopedia.destroyThis();
         this.butEncyclopedia = null;
         this.ellipses.removeChild(this.towerRange);
         this.ellipses.removeChild(this.towerRangeNew);
         this.ellipses.removeChild(this.towerRangeRallyPoint);
         this.towerRange = null;
         this.towerRangeNew = null;
         this.towerRangeRallyPoint = null;
         this.waves = null;
         this.activeWaves = null;
         this.terrain.removeChild(this.gTerrain);
         this.gTerrain = null;
         this.removeChild(this.terrain);
         this.terrain = null;
         this.removeChild(this.ellipses);
         this.ellipses = null;
         this.removeChild(this.background);
         this.background = null;
         this.removeChild(this.decals);
         this.decals = null;
         this.removeChild(this.entities);
         this.entities = null;
         this.removeChild(this.frontEntities);
         this.frontEntities = null;
         this.removeChild(this.bulletsDecals);
         this.bulletsDecals = null;
         this.removeChild(this.bullets);
         this.bullets = null;
         this.removeChild(this.gui);
         this.gui = null;
         this.towers = null;
         this.enemies = null;
         this.soldiers = null;
         this.§_-Is§ = null;
         this.staticEnemies = null;
         this.staticAreas = null;
         this.rallyPoint = null;
         this.powerPointer = null;
         this.enemySelection = null;
         this.soldierSelection = null;
         this.§_-Et§ = null;
         this.game = null;
         this.parent.removeChild(this);
      }
   }