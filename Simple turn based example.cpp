#include <iostream>
class Npc{
    public:
    short speed = 0;
    short attack = 0;
    short hp = 0;
    short x = 0;
    short y = 0;
    int experience =  0;
};

class player  : public Npc{
    
};
class enemy  : public Npc{
    
};

int battle(Npc& battle1, Npc& battle2)
{
    battle1.hp = battle1.hp - battle2.attack;
    battle2.hp = battle2.hp - battle1.attack;
    return 0;
}
int main()
{
    player p1;
    p1.attack = 20;
    p1.speed = 40;
    p1.hp = 1000;
   enemy l1;
    l1.attack = 20;
    l1.speed = 10;
    l1.hp = 400;
    std::cout<<"Hello World";

    return 0;
}