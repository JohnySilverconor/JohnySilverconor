//Print a triangle using a star.
#include<iostream>
#include<conio.h>
using namespace std;
int main()
{
  int j,i,k,l;
  char c;
  do
  {
     cout<<"Enter the number of stars in the base: ";
     cin>>k;
     for (i=1;i<=k;i++)
     {    
         for (j=1;j<=i;j++)
            cout<<"* ";
         cout<<endl;
     }
     cout<<"\nWant to try more..(y/n)\n";
     cin>>c;
  }
  while(c=='y');
  getch();
  return 0;
}