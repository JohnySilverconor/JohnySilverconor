#include <iostream>

int main()
{
    float n1, n2, n3, total, average;
    std::cout<<"Enter n1: "<<std::endl;
    std::cin>>n1;
std::cout<<"Enter n2: "<<std::endl;
std::cin>>n2;
std::cout<<"Enter n3: "<<std::endl;
std::cin>>n3;
total = n1+n2+n3;
average = total / 3;
std::cout<<"average= "<<average<<std::endl;
    return 0;
}