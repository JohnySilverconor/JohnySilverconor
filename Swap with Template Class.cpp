//Swap with Template Class 
#include<iostream>
using namespace std;
template <class T>
//swap Function
void sap(T &a,T &b)
{
    T temp=a;
    a=b;
    b=temp;
}
void func(int x,int y,char w,char z)
{
    cout<<"x and y before swap: "<<x<<y<<"\n";
    sap(x,y);
    cout<<"x and y after swap: "<<x<<y<<"\n";
    cout<<"w and z before swap: "<<w<<z<<"\n";
    sap(w,z);
    cout<<"w and z after swap: "<<w<<z<<"\n";
}
int main()
{
    func(10,20,'s','S');
    return 0;
}