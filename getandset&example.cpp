
#include <iostream>
class monster{
    
    int hp;
    int mp;
    int attack;
    int magic;
    public:
    
    void sethp(int valhp){
        hp = valhp;
    }
     void setmp(int valmp){
        mp = valmp;
    }
     void setattack(int valattack){
        attack = valattack;
    }
     void setmagic(int valmagic){
        magic = valmagic;
    }
    int gethp() const{
        return hp;
    }
    int getmp() const{
        return mp;
    }
    int getattack() const{
        return attack;
    }
    int getmagic() const{
        return magic;
    }
};

class human : virtual public monster{
    
};
int main()
{
    human player;
    player.sethp(370);
    std::cout<<player.gethp();

    return 0;
}