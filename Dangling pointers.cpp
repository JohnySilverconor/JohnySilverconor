// C++ Program to implement
// the Memory Management

#include <cstring>
#include <iostream>
using namespace std;

// Driver Code
int main()
{
    short num = 5;
    float* ptr;
    float* ptri;
    short inventory = 4;
    // Memory allocation of
    // num number of floats
    ptr = new float[num];
    ptri = new float[inventory];
    for (short i = 0; i < num; ++i) {
        *(i + ptr) = i;
    }

    cout << "Display the GPA of students:" << endl;
    for (short i = 0; i < num; ++i) {

        cout << "Student" << i + 1 << ": " << *(ptr + i)
             << endl;
    }
    for(short j= 0; j<inventory; j++){
        *(ptri + j) = j;
        
    }
for (short j= 0; j<inventory; j++) {

        cout << "inventory" << j + 1 << ": " << *(ptri + j)
             << endl;
    }
    // Ptr memory is released
    delete[] ptr;
    delete[] ptri;
    return 0;
}