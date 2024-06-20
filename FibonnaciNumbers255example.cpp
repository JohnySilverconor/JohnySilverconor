#include <iostream>
short FibonnaciNumbers();
short a, b,c;

int main()
{
    
    a=0;
    b=0;
    c=0;
    FibonnaciNumbers();
    return 0;
}

short FibonnaciNumbers(){
    while(c<255){
a=0;
b=1;
do{
    std::cout<<a<<std::endl;
    
    c = a+b;
    a=b;
    b = c;
    
    
    }while(a<255);
}
    return 0;
}