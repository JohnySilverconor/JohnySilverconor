#include<iostream>
#include<string>
//prototyping
void titlescreen();
void StartTown();
void WebCave();
void Emeraldcity();
void LimeForest();
void Waterfallcity();
void WhiteMaze();
void MookCity();
void DeepFall();
void CliffEdge();
void CloudRoute();
void Haltmoto();
void MasinoCasino();
void SpyHideout();
void PsyStar();
void MeteorFalls();
void Flamberge();
void Radbase();
void SilverArc();
void Goldenoutskirts();
void GoldenPalace();
void Credits();

int attack(int force);
int inn();
bool startgame;
bool firstTyrant;
bool firstobstacle;
bool secondTyrant;
bool secondobstacle;
bool thirdTyrant;
bool thirdobstacle;
bool fourthTyrant;
bool fifthTyrant;
bool sixthTyrant;
bool seventhTyrant;
bool eightTyrant;
bool Kingdefeated;
short npcs = 0;

char StartTownnpc1[30]={"I love my computer!"};
char StartTownnpc2[20] = {"This town is small."};
char StartTownnpc3[19] = {"I'm your opponent!"};

char WebCavenpc1[22] = {"I'm hiking this cave."};
char WebCavenpc2[44] = {"Nice Place.To hide bodies, don't you think?"};
char WebCavenpc3[30] = {"I'm sleeping leave me alone! "};
char WebCavenpc4[21] = {"Don't steal my food!"};
char WebCavenpc5[13] = {"End of line!"};

char Emeraldcitynpc1[31] = {"The shopping here is massive."};
char Emeraldcitynpc2[27] = {"Buy more guns and armors."};
char Emeraldcitynpc3[62] = {"The roads outside here. are more treacherous and dangerous. "};
char Emeraldcitynpc4[48] = {"You should be careful around the unknown caves."};

char LimeForestnpc1[15] = {"Don't go Left."};
char LimeForestnpc2[33] = {"This place used to be a cemetery"};
char LimeForestnpc3[23] = {"This place is haunted."};

char MookCitynpc1[]={"This is a really loooooong tree."};
char MookCitynpc2[]={"The fresh air from the tree."};
char MookCitynpc3[]={"Go to top for a surprise."};
char MookCitynpc4[]={"Catching air?"};
char MookCitynpc5[]={"The tree never ends."};
char MookCitynpc6[]={"People are gathering at top. They look like touble."};
char MookCitynpc7[]={"I knew someone would try explore tree stairs."};

char WhiteMazenpc1[28]={"These walls drive me crazy!"};
char WhiteMazenpc2[51]={"Pick one direction and keep going or you get lost!"};
char WhiteMazenpc3[41]={"I'm starving and i been here for hours."};
char WhiteMazenpc4[5]={"Hel-"};

char CliffEdgenpc1[]={"Thunders fall pretty close and loud here."};
char CliffEdgenpc2[]={"The air is so heavy here."};
char CliffEdgenpc3[]={"Catch of day!"};
char CliffEdgenpc4[]={"Did you fish on mountain lake? it's a fantastic experience."};
char CliffEdgenpc5[]={"People are crazy for hiking here."};

char Haltmotonpc1[]={"Shuriken, katana, charge."};
char Haltmotonpc2[]={"Patience makes complicated things easy."};
char Haltmotonpc3[]={"I put souls inside swords."};
char Haltmotonpc4[]={"Always strike the heart of your enemy."};

char PsyStarnpc1[]={"Psychic power is everything."};
char PsyStarnpc2[]={"Meteors here have mysterious power."};
char PsyStarnpc3[]={"METEOR GIVE ME POWER!"};
char PsyStarnpc4[]={"I'll be rich selling meteors."};
char PsyStarnpc5[]={"Poke the holes for a surprise."};
char PsyStarnpc6[]={"Would like to play a game?"};

char Flambergenpc1[]={"You're hot."};
char Flambergenpc2[]={"The volcano ritual battles are exciting!"};
char Flambergenpc3[]={"Come on! there are gold and diamonds here somewhere."};
char Flambergenpc4[]={"Play with fire. it burns."};
char Flambergenpc5[]={"Very high level monsters protect treasures around here. If one catches you..."};

char SilverArcnpc1[]={"I'm the air master."};
char SilverArcnpc2[]={"I'm burning with energy. "};
char SilverArcnpc3[]={"I'm the water gardian."};

char GoldenPalacenpc1[]={"King will never see you."};
char GoldenPalacenpc2[]={"I'll fight to death."};
char GoldenPalacenpc3[]={"I'm the true ruler of legaia."};
//mini-areas dialogue;
char CloudRoutenpc1[]={"Head in clouds, hmmm.... "};
char CloudRoutenpc2[]={"My monsters will smash you."};
char CloudRoutenpc3[]={"Get a litle ahead of yourself"};

char MasinoCasinonpc1[]={"Welcome to my casino."};
char MasinoCasinonpc2[]={"Try get 777 as much possible."};

char SpyHideoutnpc1[]={"Don't meddle in our operations!"};
char SpyHideoutnpc2[]={"Hey! Intruder alert!"};
char SpyHideoutnpc3[]={"There's no escape!"};
char SpyHideoutnpc4[]={"Heheh. Feeling lucky, today?"};
char SpyHideoutnpc5[]={"You came to the wrong place."};
char SpyHideoutnpc6[]={"You won't get out here alive."};
char SpyHideoutnpc7[]={"I'm the one in charge here."};
char SpyHideoutnpc8[]={"They will never find your corpse."};

char MeteorFallsnpc1[]={"All meteors here are mine."};
char MeteorFallsnpc2[]={"Does meteors give diseases?"};
char MeteorFallsnpc3[]={"AAAAAAAAAAUUUUUMMM... You broke my concentration."};
char MeteorFallsnpc4[]={"I'm studing meteors here."};
char MeteorFallsnpc5[]={"Sometimes monsters evolved touching meteors."};
char MeteorFallsnpc6[]={"Press onwards! Very carefully, or you'll never reach the end."};
char MeteorFallsnpc7[]={"First!"};
char MeteorFallsnpc8[]={"There is not enought for both us."};
char MeteorFallsnpc9[]={"Please respect nature."};

char Radbasenpc1[]={"Tresspasser!"};
char Radbasenpc2[]={"Not on my watch!"};
char Radbasenpc3[]={"Move it! Soldier"};
char Radbasenpc4[]={"Wait! Who are you!?"};
char Radbasenpc5[]={"We have a spy here!"};
char Radbasenpc6[]={"You don't have fear?"};
char Radbasenpc7[]={"I will torture you like no tomorrow."};
char Radbasenpc8[]={"Someone is raiding the base."};
char Radbasenpc9[]={"We don't defy our superiors."};
char Radbasenpc10[]={"You lack discipline and respect!"};
char Radbasenpc11[]={"At least, amuse me."};
char Radbasenpc12[]={"How they let you pass?"};
char Radbasenpc13[]={"No time to give up now."};
char Radbasenpc14[]={"I'm impressed you made this far. But all ends here."};

char Goldenoutskirtnpc1[]={"This is the most important place on legaia."};
char Goldenoutskirtnpc2[]={"You are worth so much."};
char Goldenoutskirtnpc3[]={"I have come for your head."};
char Goldenoutskirtnpc4[]={"Only a true hero can pass through "};

class player
{
    public:
    int MAXHP = 1000;
    int hp = 0;
int attack = 0;
int maxXp = 200;
int xp = 0;
int level = 1;
    
        player()
            {
            
            }
    
    int levelup(){
        
        MAXHP += 1000;
        attack += 100;
        level++;
        std::cout<<"You level up!"<<std::endl;
        return 0;
        
    }
};

class enemy
{
    public:
    int hp = 0;
int attack = 0;

    
        enemy(){
        
    }
};
player p1;
    enemy trainer;
int attack(int force){
    return 10 + force;
}
int inn()
{
   p1.hp+=1000;
   return 0;
}
int experience(player& local3, int loot){
    local3.maxXp;
         local3.xp = local3.xp + loot;
         if(local3.xp >= local3.maxXp){
             local3.maxXp =  local3.maxXp + 200 * local3.level;
             std::cout<< local3.maxXp<<std::endl;
             local3.levelup();
            
         }
         return 0;
}
int combat(player& local1, enemy& local2)
{
   
    
    local2.hp = local2.hp - local1.attack;
    local1.hp = local1.hp - local2.attack;
     std::cout<<local2.hp<<std::endl;
     std::cout<<local1.hp<<std::endl;
     if(local2.hp <= 0){
         return 0;
     }
    return 0;
}
void titlescreen(){
    std::cout<<"Skycraft"<<std::endl;
}

void StartTown(){

    std::cout<<"You are starting here."<<std::endl;
    std::cout<<"Please choose a number(1 to 3) to progress."<<std::endl;
    std::cout<<p1.xp<<std::endl;
    std::cout<<p1.level<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<StartTownnpc1<<std::endl;
    trainer.hp = 10;
    trainer.attack = 10;
    //p1.levelup();
    experience(p1,20);
    combat(p1, trainer);
    StartTown();
    break;
    
    case 2:
    std::cout<<StartTownnpc2<<std::endl;
    trainer.hp = 40;
    trainer.attack = 60;
    experience(p1,60);
    combat(p1, trainer);
    StartTown();
    break;
    
    case 3:
    std::cout<<StartTownnpc3<<std::endl;
    trainer.hp = 140;
    trainer.attack = 60;
    experience(p1,100);
    combat(p1, trainer);
    //p1.attack += 100;
    std::cout<<"You level up!"<<std::endl;
    WebCave();
    break;
    
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    StartTown();
    break;
    }
}
void WebCave(){
    std::cout<<"You are in the WebCave."<<std::endl;
    std::cout<<"Here is very humid."<<std::endl;
    std::cout<<"Please choose a number(1 to 5) to progress."<<std::endl;
    std::cout<<p1.xp<<std::endl;
    std::cout<<p1.level<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<WebCavenpc1<<std::endl;
    trainer.hp = 50;
    trainer.attack = 70;
    combat(p1, trainer);
    WebCave();
    break;
    case 2:
    std::cout<<WebCavenpc2<<std::endl;
    trainer.hp = 50;
    trainer.attack = 70;
    combat(p1, trainer);
    WebCave();
    break;
    case 3:
    std::cout<<WebCavenpc3<<std::endl;
    Emeraldcity();
    break;
    case 4:
    std::cout<<WebCavenpc4<<std::endl;
    WebCave();
    break;
    case 5:
    std::cout<<WebCavenpc5<<std::endl;
    inn();
    WebCave();
    break;
    
    default:
    std::cout<<"Please choose a valid number(1 to 5) to progress.";
    WebCave();
    break;
    }
}
void Emeraldcity(){
    std::cout<<"Welcome to Emerald city."<<std::endl;
    std::cout<<"This city shines likes no tomorrow."<<std::endl;
    std::cout<<"Please choose a number(1 to 4) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<Emeraldcitynpc1<<std::endl;
    Emeraldcity();
    break;
    case 2:
    std::cout<<Emeraldcitynpc2<<std::endl;
    LimeForest();
    break;
    case 3:
    std::cout<<Emeraldcitynpc3<<std::endl;
    Emeraldcity();
    break;
    case 4:
    std::cout<<Emeraldcitynpc4<<std::endl;
    LimeForest();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 4) to progress.";
    Emeraldcity();
    break;
    }
}

void LimeForest(){
    std::cout<<"Sleeping Lime forest."<<std::endl;
    std::cout<<"This place give you chills."<<std::endl;
    std::cout<<"Please choose a number(1 to 3) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<LimeForestnpc1<<std::endl;
    LimeForest();
    break;
    case 2:
    std::cout<<LimeForestnpc2<<std::endl;
    MookCity();
    break;
    case 3:
    std::cout<<LimeForestnpc3<<std::endl;
    LimeForest();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    LimeForest();
    break;
    }
}
void MookCity(){
    std::cout<<"The jungle city."<<std::endl;
    std::cout<<"This place is very high."<<std::endl;
    std::cout<<"Please choose a number(1 to 7) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<MookCitynpc1<<std::endl;
    MookCity();
    break;
    case 2:
    std::cout<<MookCitynpc2<<std::endl;
    MookCity();
    break;
    case 3:
    std::cout<<MookCitynpc3<<std::endl;
    WhiteMaze();
    break;
    case 4:
    std::cout<<MookCitynpc4<<std::endl;
    MookCity();
    break;
    case 5:
    std::cout<<MookCitynpc5<<std::endl;
    MookCity();
    break;
    case 6:
    std::cout<<MookCitynpc6<<std::endl;
    MookCity();
    case 7:
    std::cout<<MookCitynpc7<<std::endl;
    CloudRoute();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 7) to progress.";
    MookCity();
    break;
    }
}
void CloudRoute(){
    std::cout<<"The Cloud Routes."<<std::endl;
    std::cout<<"This place is above earth."<<std::endl;
    std::cout<<"Please choose a number(1 to 3) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<CloudRoutenpc1<<std::endl;
    CloudRoute();
    break;
    case 2:
    std::cout<<CloudRoutenpc2<<std::endl;
    WhiteMaze();
    break;
    case 3:
    std::cout<<CloudRoutenpc3<<std::endl;
    MookCity();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    CloudRoute();
    break;
    }
}
void WhiteMaze(){
    std::cout<<"WhiteMaze"<<std::endl;
    std::cout<<"This place is very high."<<std::endl;
    std::cout<<"Please choose a number(1 to 4) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<WhiteMazenpc1<<std::endl;
    WhiteMaze();
    break;
    case 2:
    std::cout<<WhiteMazenpc2<<std::endl;
    CliffEdge();
    break;
    case 3:
    std::cout<<WhiteMazenpc3<<std::endl;
    WhiteMaze();
    break;
    case 4:
    std::cout<<WhiteMazenpc4<<std::endl;
    WhiteMaze();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 4) to progress.";
    WhiteMaze();
    break;
    }
}
void CliffEdge(){
    std::cout<<"You are in the CliffEdge."<<std::endl;
    std::cout<<"Here is very humid."<<std::endl;
    std::cout<<"Please choose a number(1 to 5) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<CliffEdgenpc1<<std::endl;
    CliffEdge();
    break;
    case 2:
    std::cout<<CliffEdgenpc2<<std::endl;
    CliffEdge();
    break;
    case 3:
    std::cout<<CliffEdgenpc3<<std::endl;
    CliffEdge();
    break;
    case 4:
    std::cout<<CliffEdgenpc4<<std::endl;
    CliffEdge();
    break;
    case 5:
    std::cout<<CliffEdgenpc5<<std::endl;
    Haltmoto();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 5) to progress.";
    CliffEdge();
    break;
    }
}

void Haltmoto(){
     std::cout<<"Welcome to Haltmoto city."<<std::endl;
    std::cout<<"This city honours tigers and dragons."<<std::endl;
    std::cout<<"Please choose a number(1 to 4) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<Haltmotonpc1<<std::endl;
    PsyStar();
    break;
    case 2: 
    std::cout<<Haltmotonpc2<<std::endl;
    Haltmoto();
    break;
    case 3:
    std::cout<<Haltmotonpc3<<std::endl;
    Haltmoto();
    break;
    case 4:
    std::cout<<Haltmotonpc4<<std::endl;
    SpyHideout();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 4) to progress.";
    Haltmoto();
    break;
    }
    
}
void SpyHideout(){
    std::cout<<"Watch and pray."<<std::endl;
    std::cout<<"This looking like a odd place."<<std::endl;
    std::cout<<"Please choose a number(1 to 4) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<SpyHideoutnpc1<<std::endl;
    SpyHideout();
    break;
    case 2:
    std::cout<<SpyHideoutnpc2<<std::endl;
    SpyHideout();
    break;
    case 3:
    std::cout<<SpyHideoutnpc3<<std::endl;
    SpyHideout();
    break;
    case 4:
    std::cout<<SpyHideoutnpc4<<std::endl;
    SpyHideout();
    break;
    case 5:
    std::cout<<SpyHideoutnpc5<<std::endl;
    SpyHideout();
    break;
    case 6:
    std::cout<<SpyHideoutnpc6<<std::endl;
    SpyHideout();
    break;
    case 7:
    std::cout<<SpyHideoutnpc7<<std::endl;
    SpyHideout();
    break;
    case 8:
    std::cout<<SpyHideoutnpc8<<std::endl;
    Haltmoto();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 8) to progress.";
    SpyHideout();
    break;
    }
}
void PsyStar(){
     std::cout<<"Welcome to PsyStar city."<<std::endl;
    std::cout<<"The stone city ."<<std::endl;
    std::cout<<"Please choose a number(1 to 6) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<PsyStarnpc1<<std::endl;
    PsyStar();
    break;
    case 2:
    std::cout<<PsyStarnpc2<<std::endl;
    PsyStar();
    break;
    case 3:
    std::cout<<PsyStarnpc3<<std::endl;
    PsyStar();
    break;
    case 4:
    std::cout<<PsyStarnpc4<<std::endl;
    Flamberge();
    break;
    case 5:
    std::cout<<PsyStarnpc5<<std::endl;
    PsyStar();
    break;
    case 6:
    std::cout<<PsyStarnpc6<<std::endl;
    MeteorFalls();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 6) to progress.";
    PsyStar();
    break;
    }
    
}
void MeteorFalls(){
    std::cout<<"Welcome to MeteorFalls."<<std::endl;
    std::cout<<"Watch out the meteors ."<<std::endl;
    std::cout<<"Please choose a number(1 to 9) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<MeteorFallsnpc1<<std::endl;
    MeteorFalls();
    break;
    case 2:
    std::cout<<MeteorFallsnpc2<<std::endl;
    MeteorFalls();
    break;
    case 3:
    std::cout<<MeteorFallsnpc3<<std::endl;
    MeteorFalls();
    break;
    case 4:
    std::cout<<MeteorFallsnpc4<<std::endl;
    MeteorFalls();
    break;
    case 5:
    std::cout<<MeteorFallsnpc5<<std::endl;
    MeteorFalls();
    break;
    case 6:
    std::cout<<MeteorFallsnpc6<<std::endl;
    MeteorFalls();
    break;
    case 7:
    std::cout<<MeteorFallsnpc7<<std::endl;
    MeteorFalls();
    break;
    case 8:
    std::cout<<MeteorFallsnpc8<<std::endl;
    MeteorFalls();
    break;
    case 9:
    std::cout<<MeteorFallsnpc9<<std::endl;
    PsyStar();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 9) to progress.";
    MeteorFalls();
    break;
    }
    
}
void Flamberge(){
     std::cout<<"Welcome to Flamberge island."<<std::endl;
    std::cout<<"Island hot volcano."<<std::endl;
    std::cout<<"Please choose a number(1 to 5) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<Flambergenpc1<<std::endl;
    Flamberge();
    break;
    case 2:
    std::cout<<Flambergenpc2<<std::endl;
    Flamberge();
    break;
    case 3:
    std::cout<<Flambergenpc3<<std::endl;
    Flamberge();
    break;
    case 4:
    std::cout<<Flambergenpc4<<std::endl;
    SilverArc();
    case 5:
    std::cout<<Flambergenpc5<<std::endl;
    Radbase();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 5) to progress.";
    Flamberge();
    break;
    }
}
void Radbase(){
    std::cout<<"Welcome to Radbase."<<std::endl;
    std::cout<<"Soldiers only."<<std::endl;
    std::cout<<"Please choose a number(1 to 14) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<Radbasenpc1<<std::endl;
    Radbase();
    break;
    case 2:
    std::cout<<Radbasenpc2<<std::endl;
    Radbase();
    break;
    case 3:
    std::cout<<Radbasenpc3<<std::endl;
    Radbase();
    break;
    case 4:
    std::cout<<Radbasenpc4<<std::endl;
    Radbase();
    break;
    case 5:
    std::cout<<Radbasenpc5<<std::endl;
    Radbase();
    break;
    case 6:
    std::cout<<Radbasenpc6<<std::endl;
    Radbase();
    break;
    case 7:
    std::cout<<Radbasenpc7<<std::endl;
    Radbase();
    break;
    case 8:
    std::cout<<Radbasenpc8<<std::endl;
    Radbase();
    break;
    case 9:
    std::cout<<Radbasenpc9<<std::endl;
    Radbase();
    break;
    case 10:
    std::cout<<Radbasenpc10<<std::endl;
    Radbase();
    break;
    case 11:
    std::cout<<Radbasenpc11<<std::endl;
    Radbase();
    break;
    case 12:
    std::cout<<Radbasenpc12<<std::endl;
    Radbase();
    break;
    case 13:
    std::cout<<Radbasenpc13<<std::endl;
    Radbase();
    break;
    case 14:
    std::cout<<Radbasenpc14<<std::endl;
    SilverArc();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 14) to progress.";
    Radbase();
    break;
    }
}
void SilverArc(){
     std::cout<<"Welcome to SilverArc city."<<std::endl;
    std::cout<<"Winds of time."<<std::endl;
    std::cout<<"Please choose a number(1 to 3) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<SilverArcnpc1<<std::endl;
    SilverArc();
    break;
    case 2:
    std::cout<<SilverArcnpc2<<std::endl;
    SilverArc();
    break;
    case 3:
    std::cout<<SilverArcnpc3<<std::endl;
    Goldenoutskirts();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    SilverArc();
    break;
    }
    
}
void Goldenoutskirts(){
    
    std::cout<<"Welcome to Goldenoutskirts."<<std::endl;
    std::cout<<"The golden gardens."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<Goldenoutskirtnpc1<<std::endl;
    Goldenoutskirts();
    break;
    case 2:
    std::cout<<Goldenoutskirtnpc2<<std::endl;
    Goldenoutskirts();
    break;
    case 3:
    std::cout<<Goldenoutskirtnpc3<<std::endl;
    GoldenPalace();
    break;
    case 4:
    std::cout<<Goldenoutskirtnpc4<<std::endl;
    SilverArc();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    Goldenoutskirts();
    break;
    }
    
}
void GoldenPalace(){
    std::cout<<"Welcome to GoldenPalace."<<std::endl;
    std::cout<<"Shiniest Palace."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<GoldenPalacenpc1<<std::endl;
    GoldenPalace();
    break;
    case 2:
    std::cout<<GoldenPalacenpc2<<std::endl;
    GoldenPalace();
    break;
    case 3:
    std::cout<<GoldenPalacenpc3<<std::endl;
    Credits();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    GoldenPalace();
    break;
    }
    
}


int main()
{
    p1.hp = 1000;
    p1.attack = 30;
    p1.xp = 20;
    p1.level = 1;
    trainer.hp = 20;
    trainer.attack = 10;
    
    titlescreen();
    StartTown();
    return 0;
}

void Credits(){
    std::cout<<"You saved the world!"<<std::endl;
    std::cout<<"Thanks for playing!!!"<<std::endl;
    std::cout<<"Would like to play again? (1 yes/2 no"<<std::endl;
    std::cin>>npcs;
    if(npcs==1){
     main();
    }
    else {
        std::cout<<"Bye."<<std::endl;
    }
}