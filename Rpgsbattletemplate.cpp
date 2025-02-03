#include <iostream>
#include <bits/stdc++.h>
#include <random>
using namespace std;
class npc 
{
    public:
    virtual void talk()
    {
        cout<<"Hi, i like sunrays!";
    }
};

class player : public npc{
    public:
    short attack;
    short def;
    short inte;
    short spirit;
    short speed;
    short maxhp;
    short hp;
    short maxmana;
    short mana;
    short level;
    short xp;
    void talk()
    {
    cout<< "Hi let's fight";
    }
    
int growrate()
    {
       attack += 2;
       def += 2;
       inte += 1;
        spirit+=2;
        maxhp +=100;
        hp += 100;
        maxmana +=50;
        mana += 50;
        return 0;
    }
    int levelup()
    {
        if(level<100){
            growrate();
            level++;
            xp =0;
        }
        else{
            level = 100;
        }
        return 0;
    }
    int buffattack()
{
    this->attack*2;
    return 0;
}
int buffdefense()
{
    this->def*2;
    return 0;
}
int buffinte()
{
    this->inte*2;
    return 0;
}
int buffspirit()
{
    this->spirit*2;
    return 0;
}
int critical()
{
    this->attack*3;
    return 0;
}

int inn()
{
    this->hp = this->maxhp;
    this->mana = this->maxmana;
    return 0;
}
//debuffs
int poison(){
    this->hp -= int(this->hp / 5);
    return 0;
}
int burn(){
    this->hp -= int(this->hp / 2);
    return 0;
}
int froze()
{
    this->speed = 0;
    return 0;
}
 int debuffattack()
{
    this->attack/2;
    return 0;
}
int debuffdefense()
{
    this->def/2;
    return 0;
}
int debuffinte()
{
    this->inte/2;
    return 0;
}
int debuffspirit()
{
    this->spirit/2;
    return 0;
}
int debuffagility(){
    this->speed/2;
    return 0;
}
int hpdrain(){
    this->hp -= this->hp + this->inte;
    return this->hp;
}
int manadrain()
{
    this->mana -= this->mana + this->inte;
    return this->mana;
}
int swap()
{
    this->attack = this->def;
    this->def = this->attack;
    return 0;
}
int magictrick(){
    this->inte = this->spirit;
    this->spirit = this->inte;
    return 0;
}
int swaphp()
{
    this->hp = this->mana;
    this->mana = this->hp;
    return 0;
}
int ko()
{
   this->hp -= this->maxhp;
   return 0;
}
int confuse(){
random_device rd;

    // Initialize Mersenne Twister pseudo-random number generator
    mt19937 gen(rd());
    // Generate pseudo-random numbers
    // uniformly distributed in range (1, 100)
    uniform_int_distribution<> dis(0, 1);
    int randomX = dis(gen);
    if(randomX == 0){
        cout<<"attacked itself";
        this->hp -= this->attack;
     }
    cout<<randomX;
    return 0;
}
};

class enemy : public npc
{
    public:
    short attack;
    short def;
    short inte;
    short spirit;
    short speed;
    short maxhp;
    short hp;
    short maxmana;
    short mana;
    short level;
    short xp;
    void talk(){
        cout<<"Fight!";
    }
        int buffattack()
{
    this->attack*2;
    return 0;
}
int buffdefense()
{
    this->def*2;
    return 0;
}
int buffinte()
{
    this->inte*2;
    return 0;
}
int buffspirit()
{
    this->spirit*2;
    return 0;
}
int buffagility(){
    this->speed*2;
    return 0;
}
int critical()
{
    this->attack*3;
    return 0;
}
//debuffs
int poison(){
    this->hp -= int(this->hp / 5);
    return 0;
}
int burn(){
    this->hp -= int(this->hp / 2);
    return 0;
}
int froze()
{
    this->speed = 0;
    return 0;
}
 int debuffattack()
{
    this->attack/2;
    return 0;
}
int debuffdefense()
{
    this->def/2;
    return 0;
}
int debuffinte()
{
    this->inte/2;
    return 0;
}
int debuffspirit()
{
    this->spirit/2;
    return 0;
}
int debuffagility(){
    this->speed/2;
    return 0;
}
int hpdrain(){
    this->hp -= this->hp + this->inte;
    return this->hp;
}
int manadrain()
{
    this->mana -= this->mana + this->inte;
    return this->mana;
}
int swap()
{
    this->attack = this->def;
    this->def = this->attack;
    return 0;
}
int magictrick(){
    this->inte = this->spirit;
    this->spirit = this->inte;
    return 0;
}
int swaphp()
{
    this->hp = this->mana;
    this->mana = this->hp;
    return 0;
}
int ko()
{
   this->hp -= this->maxhp;
   return 0;
}
int confuse(){
    random_device rd;

    // Initialize Mersenne Twister pseudo-random number generator
    mt19937 gen(rd());
    // Generate pseudo-random numbers
    // uniformly distributed in range (1, 100)
    uniform_int_distribution<> dis(0, 1);
    int randomX = dis(gen);
    if(randomX == 0){
        cout<<"attacked itself";
        this->hp -= this->attack;
     }
    cout<<randomX;
    return 0;
}
};

int battle(player &l1, enemy &l2)
{
    l2.hp -= l1.attack - l2.def;
    l1.hp -= l2.attack -l1.def;
    return 0;
}

int magicbattle(player &l1, enemy &l2)
{
    l2.hp -= l1.inte - l2.spirit;
    l1.hp -= l2.inte -l1.spirit;
    return 0;
}

int teleport()
{
    
    
    return 0;
}
int inn(){
    
    return 0;
}

int main()
{
player r1;
r1.confuse();
    return 0;
}