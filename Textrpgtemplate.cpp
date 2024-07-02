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
short npcs;

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

void titlescreen(){
    std::cout<<"Skycraft"<<std::endl;
}

void StartTown(){

    std::cout<<"You are starting here."<<std::endl;
    std::cout<<"Please choose a number(1 to 3) to progress."<<std::endl;
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<StartTownnpc1<<std::endl;
    StartTown();
    break;
    case 2:
    std::cout<<StartTownnpc2<<std::endl;
    StartTown();
    break;
    case 3:
    std::cout<<StartTownnpc3<<std::endl;
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
    std::cin>>npcs;
    switch(npcs)
    {
    case 1:
    std::cout<<WebCavenpc1<<std::endl;
    WebCave();
    break;
    case 2:
    std::cout<<WebCavenpc2<<std::endl;
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
    MookCity();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 7) to progress.";
    MookCity();
    break;
    }
}
void WhiteMaze(){
    std::cout<<"WhiteMaze"<<std::endl;
    std::cout<<"This place is very high."<<std::endl;
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
    Haltmoto();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 4) to progress.";
    Haltmoto();
    break;
    }
    
}

void PsyStar(){
     std::cout<<"Welcome to PsyStar city."<<std::endl;
    std::cout<<"The stone city ."<<std::endl;
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
    PsyStar();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 6) to progress.";
    PsyStar();
    break;
    }
    
}

void Flamberge(){
     std::cout<<"Welcome to Flamberge island."<<std::endl;
    std::cout<<"Island hot volcano."<<std::endl;
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
    Flamberge();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 5) to progress.";
    Flamberge();
    break;
    }
    
}

void SilverArc(){
     std::cout<<"Welcome to SilverArc city."<<std::endl;
    std::cout<<"Winds of time."<<std::endl;
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
    GoldenPalace();
    break;
    default:
    std::cout<<"Please choose a valid number(1 to 3) to progress.";
    SilverArc();
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
    std::cout<<Haltmotonpc1<<std::endl;
    GoldenPalace();
    break;
    case 2:
    std::cout<<Haltmotonpc2<<std::endl;
    GoldenPalace();
    break;
    case 3:
    std::cout<<Haltmotonpc3<<std::endl;
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
