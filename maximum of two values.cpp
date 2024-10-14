#include <iostream>
 template<typename T>
 
 //returns the maximum of two values:
 T max (T a, T b)
 {
 // if b < a then yield a else yield b
 return b < a ? a : b;
 }
int main()
{
     int i = 42;
 std::cout << "max(7,i): " << ::max(7,i) << \n ;
 double f1 = 3.4;
 double f2 =-6.7;
 std::cout << "max(f1,f2): " << ::max(f1,f2) << \n ;
 std::string s1 = "mathematics";
 std::string s2 = "math";
 std::cout << "max(s1,s2): " << ::max(s1,s2) << \n ;
 
    std::cout<<"Hello World"<<std::endl;
    std::cout<<max<short>(13, 7)<<std::endl;
    std::cout<<max<int>(3, 7)<<std::endl;
    std::cout<<max<float>(3.0f, 7.5f)<<std::endl;
std::cout<<max<double>(3.0, 7.0)<<std::endl;
std::cout<<max<char>('g', 'e')<<std::endl;

    return 0;
}