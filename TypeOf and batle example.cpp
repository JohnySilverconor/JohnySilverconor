/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>

class player
{
    public:
    int a = 133;
};

struct money{
    int pizza;
};
int battle(player& c, money& b);
int battle(player& c, money& b){
    int hp;
    hp = c.a - b.pizza ;
    c.a = hp;
    
    return hp;
}
int main()
{
    
    auto p = 2.7f;
    int y ;
    player h1;
    money customer;
    std::cout << typeid(p).name() << '\n';
    
    std::cout << typeid(h1.a).name() << '\n';
    std::cout << typeid(h1).name() << '\n';
    std::cout << typeid(customer.pizza).name() << '\n';
    h1.a = 2250;
    customer.pizza = 300;
    battle(h1, customer);
     std::cout << h1.a<< '\n';
      battle(h1, customer);
     std::cout << h1.a<< '\n';
      battle(h1, customer);
     std::cout << h1.a<< '\n';
      battle(h1, customer);
     std::cout << h1.a<< '\n';
      battle(h1, customer);
     std::cout << h1.a<< '\n';
      battle(h1, customer);
     std::cout << h1.a<< '\n';
      battle(h1, customer);
     std::cout << h1.a<< '\n';
    return 0;
}