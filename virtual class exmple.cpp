/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
class body{
    public:
   virtual void talk() = 0;
   /*{
        std::cout<<"Aaaaairrrr...";
    }*/
};
class head : public body{
    public:
    void talk(){
        std::cout<<"Hi!";
    }
};

class mouth : public body{
    public:
    void talk(){
        std::cout<<"Aaaaaaaah!";
    }
};
int main()
{
    body* l1 = new head();
    body* l2 = new mouth();
    //p->talk();
    l1->talk();
    l2->talk();
    
    
    body* bodies[2] = {l1, l2};
    
    for(int i = 0; i<2; i++)
    {
        bodies[i]->talk();
    }
    std::cout<<"Hello World";

    return 0;
}