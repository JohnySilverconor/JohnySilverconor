#include <iostream>
using namespace std;
class npc {
public:
	short attack = 20;
	short def = 10;
	short magic = 5;
	short spirit = 10;
	short agility = 20;
	short maxhp = 100;
	short hp = 100;
	short maxmana = 100;
	short mana = 100;
	short level = 1;
	uint experience = 100;
	virtual void talk() {
		cout<<"I like sun rays!";
	}

};

class player : public npc
{
public:
	void talk()
	{
		cout<<"Hi, let's fight!";

	}
	/*short attack = 20;
	short  def = 10;
	short  magic = 5;
	short spirit = 10;
	short maxhp = 100;
	short  hp = 100;
	short maxmana = 100;
	short  mana = 100;
	short level = 1;
	uint experience = 100;
*/
	int growrate() {
		attack + 2;
		def + 2;
		magic + 1;
		spirit + 2;
		maxhp + 100;
		hp + 100;
		maxmana + 100;
		mana + 50;
		return 0;

	}
	int levelup() {
		if(level <=100) {
			growrate();
			level++;
			experience = 0;
			return 0;
		}
	}
};

class enemy : public npc
{
public:

	void talk() {

	}
};

Class item{



};
int battle(player &li, enemy&l2)
{
	l2.hp -= li.attack - l2.def;
	return 0;
}

int enemybattle(player &li, enemy&l2)
{
	li.hp -= l2.attack - li.def;
	return 0;
}

int magicbattle(player &li, enemy&l2){
    
    l2.hp -= li.magic - l2.spirit;
    
    return 0;
}
int emagic(player &li, enemy&l2){
    li.hp -= l2.magic - li.spirit;
    return 0;
}
// skills buffs
int buffattack(npc &l0){
    l0.attack * 2;
    return l0.attack;
}

int buffdefense(npc &l0){
    l0.def * 2;
    return l0.def;
}

int buffintelligence(npc &l0){
    l0.magic * 2;
    return l0.magic;
}

int buffspirit(npc &l0){
    l0.spirit * 2;
    return l0.spirit;
}

int buffagility(npc &l0){
    l0.agility * 2;
    return l0.agility;
}


int critical(npc &l0){
    l0.attack * 3;
    return l0.attack;
}

int buffhp(npc &l0){
    l0.hp * 2;
    return l0.hp;
}
// debuffs
int poison(npc &l0)
{
    l0.hp -= l0.hp/5;
    return l0.hp;
}

int burn(npc &l0){
    l0.attack -= l0.attack / 2;
    l0.hp -= 50;
    return 0;
}

int froze(npc &l0){
    l0.agility = 0;
    return l0.agility;
}

int debuffattack(npc &l0)
{
    l0.attack = l0.attack / 2;
    return 0;
}

int debuffdefense(npc &l0)
{
    l0.def = l0.def / 2;
    return 0;
}

int debuffintelligence(npc &l0)
{
    l0.magic = l0.magic / 2;
    return 0;
}

int debuffspirit(npc &l0)
{
    l0.spirit = l0.spirit / 2;
    return 0;
}

int debuffagility(npc &l0)
{
    l0.agility = l0.agility / 2;
    return 0;
}

int hpdrain(npc &l0){
    l0.hp += l0.attack;
    return 0;
}

int manadrain(npc &l0)
{
    l0.mana += l0.attack;
    return 0;
}

int swaphpmana(npc &l0)
{
    int swappedmana;
    int swappedhp;
    
    swappedhp= l0.hp;
    swappedmana=l0.mana;
    
    l0.hp = swappedmana;
    l0.mana = swappedhp;
    
    return 0;
}

int swapattackdef(npc &l0)
{
    int swappedattack;
    int swappeddef;
    
    swappeddef= l0.def;
    swappedattack=l0.attack;
    
    l0.attack = swappeddef;
    l0.def = swappedattack;
    
    return 0;
}

int swapmagicspirit(npc &l0)
{
    int swappedspirit;
    int swappedmagic;
    
    swappedmagic= l0.magic;
    swappedspirit=l0.spirit;
    
    l0.spirit = swappedmagic;
    l0.magic = swappedspirit;
    
    return 0;
}
int ko(npc &l0)
{
	l0.hp-= l0.maxhp;
	return l0.hp;
}
/*int teleport(npc &l0)
{
npc.x = location.x;
npc.y = location.y;
return 0;
}

int inn(npc l0)
{
l0.hp = l0.maxhp;
l0.mana = l0.maxmana;
return´0;
}
*/
npc lom;
npc profllm;
npc assistant;
npc neighbor1;
npc neighbor2;
npc neighbor3;
npc blockexit;
npc aide;
npc fisherman;

bool startgame = false;
bool adjuststarting =false;
bool chooseday = false;
bool 1st monster = false;
bool deliveryasked = false;

int main()
{
	return 0;
}