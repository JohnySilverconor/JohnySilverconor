#include <iostream>
#include<cmath>
int main()
{
    float n1, n2, n3, total, area;
    std::cout<<"Enter side A of triangle = "<<std::endl;
    std::cin>>n1;
std::cout<<"Enter side B of triangle = "<<std::endl;
std::cin>>n2;
std::cout<<"Enter side C of triangle =  "<<std::endl;
std::cin>>n3;
total = (n1+n2+n3) / 2;
area = sqrt( total  * (total  - n1 ) * (total  - n2 ) * (total - n3 ) ) ;

std::cout<<"Area of Triangle = "<<area<<std::endl;
    return 0;
}