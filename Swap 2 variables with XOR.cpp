#include <iostream>

int main()
{
    int a = 70;
    int b = 19;
    
    std::cout<<a<<b<<std::endl;
    
    a = a ^ b;
    std::cout<<a<<b<<std::endl;
    b = a ^ b;
    std::cout<<a<<b<<std::endl;
    a = a ^ b;
    
    
    std::cout<<a<<b<<std::endl;
    return 0;
}
