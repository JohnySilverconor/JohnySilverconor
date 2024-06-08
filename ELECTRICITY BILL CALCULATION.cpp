#include<iostream>
#include<conio.h>

using namespace std;
class electricity
{
  protected:
  float unit;
  float cost;
  public:
  void bill()
  {
    cout<<"\n enter the no. of units"<<endl;
    cin>>unit;
    if(unit<=100)
    {
      cost=0.50*unit;
      cout<<"cost up to 100 unit is Rs."<<cost<<endl;
    }
    else
    {
      if(unit>300)
      {
        cost=0.60*unit;
        cout<<"Beyond 300 units is Rs"<<cost;
      }
    }
  }
};
class more_electricity:public electricity
{
  float surcharge,diff,total_cost;
  public:
  void bill()
  {
    electricity::bill();
    if(cost>250.00)
    {
      diff=cost-250;
      surcharge=diff*0.15;
      total_cost=cost+surcharge;
      cout<<" Bill amount with surcharge is Rs"<<total_cost;
    }
    else
    {
      cout<<"Bill amout is Rs."<<cost;
    }
  }
};
int main()
{
 
  more_electricity me;
  me.bill();
  getch();
  return 0;
}