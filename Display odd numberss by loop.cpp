#include <iostream>

using namespace std;

int main()
{
    int n;
    cout<<"Enter the Limit\n";
    cin>>n;
    cout<<"Odd numbers between 1 and "<<n<<" are\n";
    for(int i=1;i<=n;i++)
    {
        if(i%2 !=0)
            cout<<i<<"\n";
    }
    return 0;
}