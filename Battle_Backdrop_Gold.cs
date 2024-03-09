using System.Collections.Generic;

public class Spriteset_Battle
{
    private Viewport _viewport1;
    private Viewport _viewport2;
    private Viewport _viewport3;
    private Sprite _battleback_sprite;
    private Sprite _battlefloor_sprite;
    private List<Sprite_Battler> _enemy_sprites;
    private List<Sprite_Battler> _actor_sprites;
    private List<Sprite_Picture> _picture_sprites;
    private Sprite_Timer _timer_sprite;

    public Spriteset_Battle()
    {
        CreateViewports();
        CreateBattleback();
        CreateBattlefloor();
        CreateEnemies();
        CreateActors();
        CreatePictures();
        CreateTimer();
        Update();
    }

    private void CreateViewports()
    {
        _viewport1 = new Viewport(0, 0, 544, 416);
        _viewport2 = new Viewport(0, 0, 544, 416);
        _viewport3 = new Viewport(0, 0, 544, 416);
        _viewport2.Z = 50;
        _viewport3.Z = 100;
    }

    private void CreateBattleback()
    {
        var source = Game_Temp.BackgroundBitmap;
        var bitmap = new Bitmap(640, 480);
        bitmap.StretchBlt(bitmap.Rect, source, source.Rect);
        bitmap.RadialBlur(90, 12);
        _battleback_sprite = new Sprite(_viewport1);
        _battleback_sprite.Bitmap = bitmap;
        _battleback_sprite.Ox = 320;
        _battleback_sprite.Oy = 240;
        _battleback_sprite.X = 272;
        _battleback_sprite.Y = 176;
        _battleback_sprite.WaveAmp = 8;
        _battleback_sprite.WaveLength = 5;
        _battleback_sprite.WaveSpeed = 5;
    }

    private void CreateBattlefloor()
    {
        _battlefloor_sprite = new Sprite(_viewport1);
        _battlefloor_sprite.Bitmap = Cache.System("Grid");
        _battlefloor_sprite.X = 0;
        _battlefloor_sprite.Y = 0;
        _battlefloor_sprite.Z = 1;
        _battlefloor_sprite.Opacity = 300;
    }

    private void CreateEnemies()
    {
        _enemy_sprites = new List<Sprite_Battler>();
        foreach (var enemy in Game_Troop.Members.Reverse())
        {
            _enemy_sprites.Add(new Sprite_Battler(_viewport1, enemy));
        }
    }

    private void CreateActors()
    {
        _actor_sprites = new List<Sprite_Battler>();
        _actor_sprites.Add(new Sprite_Battler(_viewport1));
        _actor_sprites.Add(new Sprite_Battler(_viewport1));
        _actor_sprites.Add(new Sprite_Battler(_viewport1));
        _actor_sprites.Add(new Sprite_Battler(_viewport1));
    }

    private void CreatePictures()
    {
        _picture_sprites = new List<Sprite_Picture>();
        for (int i = 1; i <= 20; i++)
        {
            _picture_sprites.Add(new Sprite_Picture(_viewport2, Game_Troop.Screen.Pictures));
        }
    }

    private void CreateTimer()
    {
        _timer_sprite = new Sprite_Timer(_viewport2);
    }

    public void Dispose()
    {
        DisposeBattlebackBitmap();
        DisposeBattleback();
        DisposeBattlefloor();
        DisposeEnemies();
        DisposeActors();
        DisposePictures();
        DisposeTimer();
        DisposeViewports();
    }

    private void DisposeBattlebackBitmap()
    {
        _battleback_sprite.Bitmap.Dispose();
    }

    private void DisposeBattleback()
    {
        _battleback_sprite.Dispose();
    }

    private void DisposeBattlefloor()
    {
        _battlefloor_sprite.Dispose();
    }

    private void DisposeEnemies()
    {
        foreach (var sprite in _enemy_sprites)
        {
            sprite.Dispose();
        }
    }

    private void DisposeActors()
    {
        foreach (var sprite in _actor_sprites)
        {
            sprite.Dispose();
        }
    }

    private void DisposePictures()
    {
        foreach (var sprite in _picture_sprites)
        {
            sprite.Dispose();
        }
    }

    private void DisposeTimer()
    {
        _timer_sprite.Dispose();
    }

    private void DisposeViewports()
    {
        _viewport1.Dispose();
        _viewport2.Dispose();
        _viewport3.Dispose();
    }

    public void Update()
    {
        UpdateBattleback();
        UpdateBattlefloor();
        UpdateEnemies();
        UpdateActors();
        UpdatePictures();
        UpdateTimer();
        UpdateViewports();
    }

    private void UpdateBattleback()
    {
        _battleback_sprite.Update();
    }

    private void UpdateBattlefloor()
    {
        _battlefloor_sprite.Update();
    }

    private void UpdateEnemies()
    {
        foreach (var sprite in _enemy_sprites)
        {
            sprite.Update();
        }
    }

    private void UpdateActors()
    {
        _actor_sprites.Battler = Game_Party.Members;
        _actor_sprites.Battler = Game_Party.Members;
        _actor_sprites.Battler = Game_Party.Members;
        _actor_sprites.Battler = Game_Party.Members;
        foreach (var sprite in _actor_sprites)
        {
            sprite.Update();
        }
    }

    private void UpdatePictures()
    {
        foreach (var sprite in _picture_sprites)
        {
            sprite.Update();
        }
    }

    private void UpdateTimer()
    {
        _timer_sprite.Update();
    }

    private void UpdateViewports()
    {
        _viewport1.Tone = Game_Troop.Screen.Tone;
        _viewport1.Ox = Game_Troop.Screen.Shake;
        _viewport2.Color = Game_Troop.Screen.FlashColor;
        _viewport3.Color.Set(0, 0, 0, 255 - Game_Troop.Screen.Brightness);
        _viewport1.Update();
        _viewport2.Update();
        _viewport3.Update();
    }

    public bool Animation()
    {
        foreach (var sprite in _enemy_sprites.Concat(_actor_sprites))
        {
            if (sprite.Animation())
            {
                return true;
            }
        }
        return false;
    }
}
//ruby

# This class brings together battle screen sprites. It's used within the
# Scene_Battle class.
#==============================================================================

class Spriteset_Battle
#--------------------------------------------------------------------------
# * Object Initialization
#--------------------------------------------------------------------------
def initialize
create_viewports
create_battleback
create_battlefloor
create_enemies
create_actors
create_pictures
create_timer
update
end
#--------------------------------------------------------------------------
# * Create Viewport
#--------------------------------------------------------------------------
def create_viewports
@viewport1 = Viewport.new(0, 0, 544, 416)
@viewport2 = Viewport.new(0, 0, 544, 416)
@viewport3 = Viewport.new(0, 0, 544, 416)
@viewport2.z = 50
@viewport3.z = 100
end
#--------------------------------------------------------------------------
# * Create Battleback Sprite
#--------------------------------------------------------------------------
def create_battleback
source = $game_temp.background_bitmap
bitmap = Bitmap.new(640, 480)
bitmap.stretch_blt(bitmap.rect, source, source.rect)
bitmap.radial_blur(90, 12)
@battleback_sprite = Sprite.new(@viewport1)
@battleback_sprite.bitmap = bitmap
@battleback_sprite.ox = 320
@battleback_sprite.oy = 240
@battleback_sprite.x = 272
@battleback_sprite.y = 176
@battleback_sprite.wave_amp = 8
@battleback_sprite.wave_length = 5
@battleback_sprite.wave_speed = 5
end
#--------------------------------------------------------------------------
# * Create Battlefloor Sprite
#--------------------------------------------------------------------------
def create_battlefloor
@battlefloor_sprite = Sprite.new(@viewport1)
@battlefloor_sprite.bitmap = Cache.system("Grid")
@battlefloor_sprite.x = 0
@battlefloor_sprite.y = 0
@battlefloor_sprite.z = 1
@battlefloor_sprite.opacity = 300
end
#--------------------------------------------------------------------------
# * Create Enemy Sprite
#--------------------------------------------------------------------------
def create_enemies
@enemy_sprites =
for enemy in $game_troop.members.reverse
@enemy_sprites.push(Sprite_Battler.new(@viewport1, enemy))
end
end
#--------------------------------------------------------------------------
# * Create Actor Sprite
# By default, the actor image is not displayed, but a dummy sprite is
# created for treating enemies and allies the same, if required.
#--------------------------------------------------------------------------
def create_actors
@actor_sprites =
@actor_sprites.push(Sprite_Battler.new(@viewport1))
@actor_sprites.push(Sprite_Battler.new(@viewport1))
@actor_sprites.push(Sprite_Battler.new(@viewport1))
@actor_sprites.push(Sprite_Battler.new(@viewport1))
end
#--------------------------------------------------------------------------
# * Create Picture Sprite
#--------------------------------------------------------------------------
def create_pictures
@picture_sprites =
for i in 1..20
@picture_sprites.push(Sprite_Picture.new(@viewport2,
$game_troop.screen.pictures))
end
end
#--------------------------------------------------------------------------
# * Create Timer Sprite
#--------------------------------------------------------------------------
def create_timer
@timer_sprite = Sprite_Timer.new(@viewport2)
end
#--------------------------------------------------------------------------
# * Dispose
#--------------------------------------------------------------------------
def dispose
dispose_battleback_bitmap
dispose_battleback
dispose_battlefloor
dispose_enemies
dispose_actors
dispose_pictures
dispose_timer
dispose_viewports
end
#--------------------------------------------------------------------------
# * Dispose of Battleback Bitmap
#--------------------------------------------------------------------------
def dispose_battleback_bitmap
@battleback_sprite.bitmap.dispose
end
#--------------------------------------------------------------------------
# * Dispose of Battleback Sprite
#--------------------------------------------------------------------------
def dispose_battleback
@battleback_sprite.dispose
end
#--------------------------------------------------------------------------
# * Dispose of Battlefloor Sprite
#--------------------------------------------------------------------------
def dispose_battlefloor
@battlefloor_sprite.dispose
end
#--------------------------------------------------------------------------
# * Dispose of Enemy Sprite
#--------------------------------------------------------------------------
def dispose_enemies
for sprite in @enemy_sprites
sprite.dispose
end
end
#--------------------------------------------------------------------------
# * Dispose of Actor Sprite
#--------------------------------------------------------------------------
def dispose_actors
for sprite in @actor_sprites
sprite.dispose
end
end
#--------------------------------------------------------------------------
# * Dispose of Picture Sprite
#--------------------------------------------------------------------------
def dispose_pictures
for sprite in @picture_sprites
sprite.dispose
end
end
#--------------------------------------------------------------------------
# * Dispose of Timer Sprite
#--------------------------------------------------------------------------
def dispose_timer
@timer_sprite.dispose
end
#--------------------------------------------------------------------------
# * Dispose of Viewport
#--------------------------------------------------------------------------
def dispose_viewports
@viewport1.dispose
@viewport2.dispose
@viewport3.dispose
end
#--------------------------------------------------------------------------
# * Frame Update
#--------------------------------------------------------------------------
def update
update_battleback
update_battlefloor
update_enemies
update_actors
update_pictures
update_timer
update_viewports
end
#--------------------------------------------------------------------------
# * Update Battleback
#--------------------------------------------------------------------------
def update_battleback
@battleback_sprite.update
end
#--------------------------------------------------------------------------
# * Update Battlefloor
#--------------------------------------------------------------------------
def update_battlefloor
@battlefloor_sprite.update
end
#--------------------------------------------------------------------------
# * Update Enemy Sprite
#--------------------------------------------------------------------------
def update_enemies
for sprite in @enemy_sprites
sprite.update
end
end
#--------------------------------------------------------------------------
# * Update Actor Sprite
#--------------------------------------------------------------------------
def update_actors
@actor_sprites.battler = $game_party.members
@actor_sprites.battler = $game_party.members
@actor_sprites.battler = $game_party.members
@actor_sprites.battler = $game_party.members
for sprite in @actor_sprites
sprite.update
end
end
#--------------------------------------------------------------------------
# *Update Picture Sprite
#--------------------------------------------------------------------------
def update_pictures
for sprite in @picture_sprites
sprite.update
end
end
#--------------------------------------------------------------------------
# * Update Timer Sprite
#--------------------------------------------------------------------------
def update_timer
@timer_sprite.update
end
#--------------------------------------------------------------------------
# * Update Viewport
#--------------------------------------------------------------------------
def update_viewports
@viewport1.tone = $game_troop.screen.tone
@viewport1.ox = $game_troop.screen.shake
@viewport2.color = $game_troop.screen.flash_color
@viewport3.color.set(0, 0, 0, 255 - $game_troop.screen.brightness)
@viewport1.update
@viewport2.update
@viewport3.update
end
#--------------------------------------------------------------------------
# * Determine if animation is being displayed
#--------------------------------------------------------------------------
def animation?
for sprite in @enemy_sprites + @actor_sprites
return true if sprite.animation?
end
return false
end
end