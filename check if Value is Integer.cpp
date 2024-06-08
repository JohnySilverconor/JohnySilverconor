#include <iostream>
using namespace std;

bool isNumber(string s)
{
    for (int i = 0; i < s.length(); i++)
        if (isdigit(s[i]) == false)
            return false;
 
    return true;
}

int main() {
    // Saving the input in a string
    string str = "";
    
    cout << "Enter Value.\n";
    cin >> str;
 
    // Function returns 1 if all elements
    // are in range '0-9'
    if (isNumber(str))
        cout << "Entered Value is Integer";
 
    // Function returns 0 if the input is
    // not an integer
    else
        cout << "Entered Value is String";
        
    return 0;
}