#include <algorithm>
#include <cctype>
#include <iomanip>
#include <iostream>
#include <string>
#include <utility>
#include <vector>

int main()
{
    std::vector<int> a = {1,2,3,4,5};
std::vector<int> b = {1,2,3,4,5};
std::vector<int>c;
std::transform(a.begin(),a.end(), b.begin(),std::back_inserter(c),
               [](const auto& aa, const auto& bb)

               
               {
                   return aa*bb;
               });
               
               
for(auto cc:c)
    std::cout<<cc<<std::endl;
    
    std::cout<<"Hello World";

    return 0;
}