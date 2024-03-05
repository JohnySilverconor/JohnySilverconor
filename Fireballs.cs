using System;
using System.Drawing;

public class Fireball : MovieClip
{
    protected Bv _8p;
    protected bool isActive = true;
    protected Ellipse _D4;
    private int durationTime = 75;
    private int durationTimeCounter = 0;
    protected int _6_ = 30;
    protected int _65 = 0;
    private int initDamage = 5;
    private int _0y = 5;
    private int _1y = 0;
    protected double xSpeed;
    protected double ySpeed;
    protected double maxAceleration = 15;
    protected double aceleration = 10;
    protected Point _Jw;
    protected string sName;
    protected string _Gn;
    private int damage;
    public Level _IY;

    public Fireball(Point param1, Point param2)
    {
        base();
        addFrameScript(5, frame6, 24, frame25);
        this.x = param1.x;
        this.y = param1.y;
        this._Jw = param2;
        this.addEventListener(Event.ADDED_TO_STAGE, init, false, 0, true);
    }

    private void init(Event param1)
    {
        this._IY = Level(this.parent.parent);
        this.sName = "fireball" + Math.random().ToString();
        SoundManager.getInstance().addLibrarySound(Ch, this.sName);
        SoundManager.getInstance().playSound(this.sName, 0.15, 0, 0);
        this.FE();
        this._8p = new Bv(this._Jw);
        this._IY.decals.addChild(this._8p);
    }

    public void onFrameUpdate()
    {
        if (!this.isActive)
        {
            this.fadeThis();
            return;
        }
        this._2g();
    }

    public void pause()
    {
        this.stop();
    }

    public void unPause()
    {
        switch (this.currentFrameLabel)
        {
            case "travelEnd":
                this.gotoAndPlay("travel");
                break;
            case "hitEnd":
                break;
            default:
                this.play();
        }
    }

    protected void fadeThis()
    {
        if (this._65 == this._6_)
        {
            this.destroyThis();
        }
        ++this._65;
    }

    private void _2g()
    {
        double _loc1_ = 0;
        double _loc2_ = 0;
        double _loc3_ = 0;
        _loc1_ = this._Jw.y - this.y;
        _loc2_ = this._Jw.x - this.x;
        _loc3_ = Math.atan2(_loc1_, _loc2_);
        if (this.aceleration < this.maxAceleration)
        {
            this.aceleration += Math.Ceiling(this.aceleration * 0.05);
            if (this.aceleration >= this.maxAceleration)
            {
                this.aceleration = this.maxAceleration;
            }
        }
        this.ySpeed = Math.Sin(_loc3_) * this.aceleration;
        this.xSpeed = Math.Cos(_loc3_) * this.aceleration;
        this.rotation = 360 - Math.Atan2(-this.ySpeed, this.xSpeed) * 180 / Math.PI;
        this.x += this.xSpeed;
        this.y += this.ySpeed;
        this.freeParticles();
        if (Math.Sqrt(Math.Pow(this._Jw.y - this.y, 2) + Math.Pow(this._Jw.x - this.x, 2)) < this.aceleration)
        {
            this.hit();
        }
    }

    protected void hit()
    {
        SoundManager.getInstance().stopSound(this.sName);
        SoundManager.getInstance().removeSound(this.sName);
        this._Gn = "fireball_hit_" + Math.random().ToString();
        SoundManager.getInstance().addLibrarySound(Bg, this._Gn);
        SoundManager.getInstance().playSound(this._Gn, 0.15, 0, 0);
        this.isActive = false;
        this.aceleration = 0;
        this.rotation = 0;
        this._8p.destroyThis();
        this._8p = null;
        this._IY.addToDecal(new Decal(this.x, this.y, "crater", 180, Math.random() / 2 + 1));
        this.gotoAndPlay("hit");
        this.damageEnemies();
        this.damageStaticEnemies();
        this.freeScorchedEarth();
    }

    private void freeScorchedEarth()
    {
        if (this._IY.game.gameUpgrades.rainUpScorchedEarth && (this._IY.maxUpgradeLevel == 0 || this._IY.maxUpgradeLevel >= 2))
        {
            this._IY.decals.addChild(new ScorchedEarth(new Point(this.x, this.y), this._IY));
        }
    }

    private void freeParticles()
    {
        this.EM(new Point(this.x, this.y - 10));
        this.EM(new Point(this.x + this.xSpeed / 2, this.y + this.ySpeed / 2 - 10));
    }

    protected void EM(Point param1)
    {
        FireballParticle _loc3_ = null;
        FireballParticle _loc2_ = null;
        foreach (_loc3_ in this._IY.game.main.fireballParticlesPool)
        {
            if (!_loc3_.isActive)
            {
                _loc3_.15(param1, this._IY.bulletsDecals);
                return;
            }
            if (_loc2_ == null || _loc2_.GR < _loc3_.GR)
            {
                _loc2_ = _loc3_;
            }
        }
        _loc2_.15(param1, this._IY.bulletsDecals);
    }

    public void damageEnemies()
    {
        Enemy _loc1_ = null;
        foreach (_loc1_ in this._IY.enemies)
        {
            if (_loc1_.isActive && this.onRange(_loc1_))
            {
                _loc1_.setDamage(this.damage);
                if (_loc1_ != null && _loc1_.isDead)
                {
                    this._IY.game.gameAchievement.finally(this._IY);
                }
            }
        }
    }

    public void damageStaticEnemies()
    {
        Enemy _loc1_ = null;
        foreach (_loc1_ in this._IY.staticEnemies)
        {
            if (_loc1_.isActive && this.onRange(_loc1_))
            {
                _loc1_.setDamage(this.damage);
                if (_loc1_ != null && _loc1_.isDead)
                {
                    this._IY.game.gameAchievement.finally(this._IY);
                }
            }
        }
    }

    public bool onRange(Enemy param1)
    {
        return this._D4.containsPoint(new Point(param1.x + param1.xAdjust, param1.y + param1.yAdjust));
    }

    private void FE()
    {
        this._D4 = new Ellipse(this._Jw.x - this._IY.gameSettings.powers.fireball.range / 2, this._Jw.y - this._IY.gameSettings.powers.fireball.range * this._IY.gameSettings.rangeRatio / 2, this._IY.gameSettings.powers.fireball.range, this._IY.gameSettings.powers.fireball.range * this._IY.gameSettings.rangeRatio);
        this.damage = this._IY.gameSettings.powers.fireball.minDamage + Math.Ceiling(Math.random() * (this._IY.gameSettings.powers.fireball.maxDamage - this._IY.gameSettings.powers.fireball.minDamage));
    }

    public void destroyThis()
    {
        this._D4 = null;
        this._IY = null;
        this._8p = null;
        SoundManager.getInstance().removeSound(this._Gn);
        this.removeEventListener(Event.ADDED_TO_STAGE, init);
        this.parent.removeChild(this);
    }

    internal void frame6()
    {
        gotoAndPlay("travel");
    }

    internal void frame25()
    {
        stop();
    }
}