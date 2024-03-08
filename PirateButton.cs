public class PirateButton : FlxButton
{
    public PirateButton(int X = 0, int Y = 0, string Label = "", Action OnClick = null)
        : base(X, Y, "", OnClick)
    {
        this.setSounds(null, 1, null, 1, AssetHolder._sndBtn, Pirate.SoundVolume);

        switch (Label)
        {
            case "Upgrade":
                loadGraphic(AssetHolder._btnUpgrade, true, false, 85, 25);
                break;
            case "back":
                loadGraphic(AssetHolder._btnBack, true, false, 142, 42);
                break;
            case "Buy Ammo":
                loadGraphic(AssetHolder._btnAmmo, true, false, 85, 25);
                break;
            case "Repair":
                loadGraphic(AssetHolder._btnRepair, true, false, 85, 25);
                break;
            case "Play Game":
                loadGraphic(AssetHolder._btnPlay, true, false, 142, 42);
                break;
            case "Highscore":
                loadGraphic(AssetHolder._btnHighScore, true, false, 142, 42);
                break;
            case "Credits":
                loadGraphic(AssetHolder._btnCredits, true, false, 142, 42);
                break;
            case "More Games":
                loadGraphic(AssetHolder._btnMoreGames, true, false, 142, 42);
                break;
            case "Continue":
                loadGraphic(AssetHolder._btnContinue, true, false, 142, 42);
                break;
            case "Shipyard":
                loadGraphic(AssetHolder._btnShipyard, true, false, 111, 100);
                break;
            case "Weaponshop":
                loadGraphic(AssetHolder._btnWeaponsmith, true, false, 111, 100);
                break;
            case "Market":
                loadGraphic(AssetHolder._btnMarket, true, false, 111, 100);
                break;
            case "Status":
                loadGraphic(AssetHolder._btnStatus, true, false, 111, 100);
                break;
            case "Sail":
                loadGraphic(AssetHolder._btnSail, true, false, 156, 100);
                break;
            case "Trash":
                loadGraphic(AssetHolder._btnTrash, true, false, 25, 25);
                break;
            case "MoveDown":
                loadGraphic(AssetHolder._btnArrowDn, true, false, 25, 25);
                break;
            case "MoveUp":
                loadGraphic(AssetHolder._btnArrowUp, true, false, 25, 25);
                break;
            case "Sell":
                loadGraphic(AssetHolder._btnSell, true, false, 85, 25);
                this.setSounds(null, 1, null, 1, AssetHolder._sndKaching, 0.6 * Pirate.SoundVolume);
                break;
            case "Take":
                loadGraphic(AssetHolder._btnTake, true, false, 85, 25);
                break;
            // Add more cases as needed
            default:
                // Handle any other Label values
                break;
  
//switch (Label)
    case "Sell All":
        loadGraphic(AssetHolder._btnSellAll, true, false, 85, 25);
        this.setSounds(null, 1, null, 1, AssetHolder._sndKaching, 0.6 * Pirate.SoundVolume);
        break;
    case "Take All":
        loadGraphic(AssetHolder._btnTakeAll, true, false, 85, 25);
        break;
    case "Skip":
        loadGraphic(AssetHolder._btnSkip, true, false, 85, 25);
        break;
    case "Next":
        loadGraphic(AssetHolder._btnNext, true, false, 85, 25);
        break;
    case "OK":
        loadGraphic(AssetHolder._btnOK, true, false, 85, 25);
        break;
    case "Cancel":
        loadGraphic(AssetHolder._btnCancel, true, false, 85, 25);
        break;
    case "ScrollDown":
        loadGraphic(AssetHolder._btnScroll, true, false, 21, 21);
        scale.y = -1;
        break;
    case "ScrollUp":
        loadGraphic(AssetHolder._btnScroll, true, false, 21, 21);
        break;
    case "Return":
        loadGraphic(AssetHolder._btnReturn, true, false, 85, 25);
        break;
    case "MainMenu":
        loadGraphic(AssetHolder._btnMainMenu, true, false, 85, 25);
        break;
    case "Sound":
        loadGraphic(AssetHolder._btnSound, true, false, 85, 25);
        break;
    case "Music":
        loadGraphic(AssetHolder._btnMusic, true, false, 85, 25);
        break;
    case "EndDay":
        loadGraphic(AssetHolder._btnEnd, true, false, 85, 25);
        break;
    case "Pause":
        loadGraphic(AssetHolder._btnPause, true, false, 25, 25);
        break;
    case "SoundSmall":
        loadGraphic(AssetHolder._btnSoundSmall, true, false, 25, 25);
        break;
    case "MusicSmall":
        loadGraphic(AssetHolder._btnMusicSmall, true, false, 25, 25);
        break;
    case "Logo":
        loadGraphic(AssetHolder._btnLabu, true, false, 33, 60);
        break;
    case "SponsorLogo":
        loadGraphic(AssetHolder._sponsorlogo, true, false, 191, 56);
        break;
    case "SponsorFB":
        loadGraphic(AssetHolder._sponsorfb, true, false, 50, 47);
        break;
    case "LikeUs":
        loadGraphic(AssetHolder._btnLikeUs, true, false, 108, 94);
        break;
    case "LikeSponsor":
        loadGraphic(AssetHolder._btnLikeSponsor, true, false, 142, 142);
        break;
    case "FollowSponsor":
        loadGraphic(AssetHolder._btnFollowSponsor, true, false, 142, 142);
        break;
    // Add more cases as needed
 case "Likep":
 loadGraphic(AssetHolder._btnLikeLabu,true,false,142,142);
 break;
 case "Followp":
 loadGraphic(AssetHolder._btnFollowLabu,true,false,142,142);
   break;
       default:
        // Handle any other Label values
        break;
         }
      }
   }
// javascript

public class PirateButton extends FlxButton
   {
       
      
      public function PirateButton(X:int = 0, Y:int = 0, Label:String = "", OnClick:Function = null)
      {
         super(X,Y,"",OnClick);
         this.setSounds(null,1,null,1,AssetHolder._sndBtn,Pirate.SoundVolume);
         switch(Label)
         {
            case "Upgrade":
               loadGraphic(AssetHolder._btnUpgrade,true,false,85,25);
               break;
            case "back":
               loadGraphic(AssetHolder._btnBack,true,false,142,42);
               break;
            case "Buy Ammo":
               loadGraphic(AssetHolder._btnAmmo,true,false,85,25);
               break;
            case "Repair":
               loadGraphic(AssetHolder._btnRepair,true,false,85,25);
               break;
            case "Play Game":
               loadGraphic(AssetHolder._btnPlay,true,false,142,42);
               break;
            case "Highscore":
               loadGraphic(AssetHolder._btnHighScore,true,false,142,42);
               break;
            case "Credits":
               loadGraphic(AssetHolder._btnCredits,true,false,142,42);
               break;
            case "More Games":
               loadGraphic(AssetHolder._btnMoreGames,true,false,142,42);
               break;
            case "Continue":
               loadGraphic(AssetHolder._btnContinue,true,false,142,42);
               break;
            case "Shipyard":
               loadGraphic(AssetHolder._btnShipyard,true,false,111,100);
               break;
            case "Weaponshop":
               loadGraphic(AssetHolder._btnWeaponsmith,true,false,111,100);
               break;
            case "Market":
               loadGraphic(AssetHolder._btnMarket,true,false,111,100);
               break;
            case "Status":
               loadGraphic(AssetHolder._btnStatus,true,false,111,100);
               break;
            case "Sail":
               loadGraphic(AssetHolder._btnSail,true,false,156,100);
               break;
            case "Trash":
               loadGraphic(AssetHolder._btnTrash,true,false,25,25);
               break;
            case "MoveDown":
               loadGraphic(AssetHolder._btnArrowDn,true,false,25,25);
               break;
            case "MoveUp":
               loadGraphic(AssetHolder._btnArrowUp,true,false,25,25);
               break;
            case "Sell":
               loadGraphic(AssetHolder._btnSell,true,false,85,25);
               this.setSounds(null,1,null,1,AssetHolder._sndKaching,0.6 * Pirate.SoundVolume);
               break;
            case "Take":
               loadGraphic(AssetHolder._btnTake,true,false,85,25);
               break;
            case "Sell All":
               loadGraphic(AssetHolder._btnSellAll,true,false,85,25);
               this.setSounds(null,1,null,1,AssetHolder._sndKaching,0.6 * Pirate.SoundVolume);
               break;
            case "Take All":
               loadGraphic(AssetHolder._btnTakeAll,true,false,85,25);
               break;
            case "Skip":
               loadGraphic(AssetHolder._btnSkip,true,false,85,25);
               break;
            case "Next":
               loadGraphic(AssetHolder._btnNext,true,false,85,25);
               break;
            case "OK":
               loadGraphic(AssetHolder._btnOK,true,false,85,25);
               break;
            case "Cancel":
               loadGraphic(AssetHolder._btnCancel,true,false,85,25);
               break;
            case "ScrollDown":
               loadGraphic(AssetHolder._btnScroll,true,false,21,21);
               scale.y = -1;
               break;
            case "ScrollUp":
               loadGraphic(AssetHolder._btnScroll,true,false,21,21);
               break;
            case "Return":
               loadGraphic(AssetHolder._btnReturn,true,false,85,25);
               break;
            case "MainMenu":
               loadGraphic(AssetHolder._btnMainMenu,true,false,85,25);
               break;
            case "Sound":
               loadGraphic(AssetHolder._btnSound,true,false,85,25);
               break;
            case "Music":
               loadGraphic(AssetHolder._btnMusic,true,false,85,25);
               break;
            case "EndDay":
               loadGraphic(AssetHolder._btnEnd,true,false,85,25);
               break;
            case "Pause":
               loadGraphic(AssetHolder._btnPause,true,false,25,25);
               break;
            case "SoundSmall":
               loadGraphic(AssetHolder._btnSoundSmall,true,false,25,25);
               break;
            case "MusicSmall":
               loadGraphic(AssetHolder._btnMusicSmall,true,false,25,25);
               break;
            case "Logo":
               loadGraphic(AssetHolder._btnLabu,true,false,33,60);
               break;
            case "SponsorLogo":
               loadGraphic(AssetHolder._sponsorlogo,true,false,191,56);
               break;
            case "SponsorFB":
               loadGraphic(AssetHolder._sponsorfb,true,false,50,47);
               break;
            case "LikeUs":
               loadGraphic(AssetHolder._btnLikeUs,true,false,108,94);
               break;
            case "LikeSponsor":
               loadGraphic(AssetHolder._btnLikeSponsor,true,false,142,142);
               break;
            case "FollowSponsor":
               loadGraphic(AssetHolder._btnFollowSponsor,true,false,142,142);
               break;
            case "Likep":
               loadGraphic(AssetHolder._btnLikeLabu,true,false,142,142);
               break;
            case "Followp":
               loadGraphic(AssetHolder._btnFollowLabu,true,false,142,142);
         }
      }
   }