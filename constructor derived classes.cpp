/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>
class F{
    public:
    int x;
    int y;
    int z;
    
};

class BaseA {
    public:
        int valueA;
        BaseA(int val) : valueA(val) {
            // Constructor for BaseA
        }
    };

    class BaseB {
    public:
        double valueB;
        BaseB(double val) : valueB(val) {
            // Constructor for BaseB
        }
    };

class Derived : public BaseA, public BaseB {
    public:
        std::string name;
        Derived(int a_val, double b_val, std::string n)
            : BaseA(a_val), BaseB(b_val), name(n) {
            // Constructor for Derived
        }
    };

 class M {
    public:
    int q;
    M(int s) : q(s){
        
    }
    
};

int main()
{
     Derived obj(10, 20.5, "MyObject");
    
    F f = {40,20,21};
    M ta(11);
    
    std::cout<<f.y<<std::endl;
    std::cout<<ta.q<<std::endl;
    std::cout<<obj.valueA<<std::endl;
    
    return 0;
}