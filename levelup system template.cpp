#include <cstdlib>
#include <iostream>
#include <time.h>
class player
{
  int attack=0;
  int defense=0;
  int magic=0;
  int spirit=0;

  int hp=0;
  int mp=0;

public:
  int lv =0;

    player ()
  {

  }

  int levelup ()
  {
      if (lv >= 100){
	 std::cout << "Max level!" << std::endl;
         lv = 100;
         attack = attack;
         defense = defense;
         magic = magic;
         spirit = spirit;
         hp = hp;
         mp = mp;
      }
      else{
         attack = attack + (rand () % (5 - 3 + 1)) + 3;
	defense = defense + (rand () % (5 - 3 + 1)) + 3;
	magic = magic + (rand () % (5 - 3 + 1)) + 3;
	spirit = spirit + (rand () % (5 - 3 + 1)) + 3;
	hp = hp + (rand () % (400 - 100 + 1)) + 100;
	mp = mp + (rand () % (400 - 100 + 1)) + 100;
	setattack (attack);
	setdefense (defense);
	setmagic (magic);
	setspirit (spirit);
	sethp (hp);
	setmp (mp);
	lv++;
      }
	return 0;
  }

public:
  void setattack (int s)
  {
	attack = s;
  }
  int getattack ()
  {
	return attack;
  }

  void setdefense (int s)
  {
	defense = s;
  }
  int getdefense ()
  {
	return defense;
  }

  void setmagic (int s)
  {
	magic = s;
  }
  int getmagic ()
  {
	return magic;
  }
  void setspirit (int s)
  {
	spirit = s;
  }
  int getspirit ()
  {
	return spirit;
  }

  void sethp (int s)
  {
	hp = s;
  }
  int gethp ()
  {
	return hp;
  }

  void setmp (int s)
  {
	mp = s;
  }
  int getmp ()
  {
	return mp;
  }

};

int
main ()
{
  srand (time (0));
  player p1;
  std::cout << "level: " << p1.lv << std::endl;
  std::cout << "attack: " << p1.getattack () << std::endl;

  //if (p1.lv <= 100)
	//{
	  for (short i = 0; i <= 101; i++)
		{
		  p1.levelup ();
		  std::cout << "level: " << p1.lv << std::endl;
		  std::cout << "attack: " << p1.getattack () << std::endl;
		}
	//}

 // else
	//{
	  //std::cout << "Max level!" << std::endl;
	  //p1.lv = 100;
	//}
  p1.levelup ();
  p1.levelup ();

  return 0;
}
