// C++ program To handle large numbers using string and
// arrays
#include <algorithm>
#include <iostream>
#include <string>

using namespace std;

// Class to handle large numbers
class LargeNumber {
private:
    // The large number represented as a string
    string number;

public:
    LargeNumber(): number("0"){}
    LargeNumber(const string& num): number(num){}

    // Overloaded operator+ to add two LargeNumber objects
    LargeNumber operator+(const LargeNumber& other) const
    {
        string result;
        int carry = 0;
        int maxLength = max(number.length(), other.number.length());

        for (int i = 0; i < maxLength || carry; ++i) {
            int digit1
                = i < number.length()
                      ? number[number.length() - 1 - i]
                            - '0'
                      : 0;
            int digit2
                = i < other.number.length()
                      ? other.number[other.number.length()
                                     - 1 - i]
                            - '0'
                      : 0;

            int sum = digit1 + digit2 + carry;
            result.push_back(sum % 10 + '0');
            carry = sum / 10;
        }

        // Since the result is reversed, reverse it back to
        // get the correct number
        reverse(result.begin(), result.end());
        return LargeNumber(result);
    }

    // Overloaded operator<< to print a LargeNumber object
    friend ostream& operator<<(ostream& out, const LargeNumber& num)
    {
        out << num.number;
        return out;
    }
};

int main()
{
    // Create two LargeNumber objects
    LargeNumber num1("123456789012345678901234567890");
    LargeNumber num2("0387654321098765432109876543210");

    // Add the two LargeNumber objects
    LargeNumber sum = num1 + num2;

    // Print the sum
    cout << "Sum: " << sum << endl;

    return 0;
}