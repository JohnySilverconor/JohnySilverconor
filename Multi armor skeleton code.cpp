
#include <iostream>
int defmain();
int add_armor(int h, int a);
int print_health(int new_health);
int sword_damage = 10;
int start_health = 100;
int end_health = start_health - sword_damage;
int a = 40, f = 20, pb = 10;
// Don't touch below this line
enum roger{
    river = 3,
    water = 4,
    sky = 7
    
};

int defmain(){
    int health = 10;
    int armor = 5;
    add_armor(health, armor);
    
return 0;
}
int add_armor(int h, int a){
   int new_health = h + a;
    print_health(new_health);
    return 0;
}
int print_health(int new_health){
    std::cout<<"The player now has "<<new_health<< " health"<<std::endl;
    return 0;
}


int main()
{
    std::cout<<"Hello World";
// Don't touch below this line
std::cout<<"Sam's health is: " <<start_health<<std::endl;
std::cout<<"Sam takes "<< sword_damage <<" damage..."<<std::endl;
std::cout<<"Sam's health is: " << end_health <<std::endl;
start_health = end_health;
std::cout<<"Sam's health is: " <<start_health<<std::endl;
std::cout<<a<<std::endl;
std::cout<<f<<std::endl;
std::cout<<pb<<std::endl;
std::cout<<roger::river<<std::endl;
// call entrypoint function last
defmain();
    return 0;
}