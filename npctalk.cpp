#include <iostream>
void npctalk();
void npctalk2();
void npctalk3();
void npctalk4();
void npctalk5();
void victoryscreen();
void npcdetection(int a);
short hunt = 0;

class Npc
{
public:
  int x = 0;
  int y = 0;

};

class Player:public Npc
{


};

int main()
{
  Npc npc;
  Player player;
  char hello[13] = { "Hello World!" };
  //player.x = 30;
  std::cin >> hunt;
  //std::cout<<hello;
  
  //player approach a npc
  if(player.x-npc.x<=0 && player.y-npc.y<=0)
  {
  npcdetection(hunt);
  }
  else{
      std::cout<<hello<<std::endl;
  }
  return 0;
}

void npcdetection(int a)
{
  switch(a)
	{
	case 1:
	  npctalk();
	  break;
	case 2:
	  npctalk2();
	  break;
	case 3:
	  npctalk3();
	  break;
	case 4:
	  npctalk4();
	  break;
	case 5:
	  npctalk5();
	  break;
	default:
	  std::cout << "Please choose 1 to 5 to proceed:" << std::endl;
	  main();
	  break;
	}
}


void
npctalk()
{
  char newbie[] = { "You like disguting creatures!" };
  std::cout << newbie << std::endl;
  main();
}

void
npctalk2()
{
  char lady[] = { "My boyfriend buys elegant perfumes." };
  std::cout << lady << std::endl;
  main();
}

void
npctalk3()
{
  char worker[] = { "Monsters keep stealing my tools." };
  std::cout << worker << std::endl;
  main();
}

void
npctalk4()
{
  char workera[] = { "My honyx is strong enough to break giant stones." };
  std::cout << workera << std::endl;
  main();
}

void
npctalk5()
{
  char workert[] = { "Chase me if you can." };
  std::cout << workert << std::endl;
  victoryscreen();
}

void
victoryscreen()
{
  std::cout << "You won the game!" << std::endl;
}
