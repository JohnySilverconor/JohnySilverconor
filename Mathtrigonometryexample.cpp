#include <iostream>
#include <cmath>
#include <stdexcept>
#include <string>
#include <tuple>

double radianOf(double deg) {
    return deg / 180 * M_PI;
}

double degreeOf(double rad) {
    return rad / M_PI * 180;
}

double Pythagoras(double xDist, double yDist) {
    return sqrt(xDist * xDist + yDist * yDist);
}

double cosineRule(double a, double b, double c) {
    double angle = (b * b + c * c - a * a) / (2 * b * c);
    return cos(angle);
}

double implementBound(double lowerBound, double upperBound, double input) {
    return std::min(std::max(lowerBound, input), upperBound);
}

int main() {
    // Example usage of the functions
    std::cout << radianOf(90) << std::endl;
    std::cout << degreeOf(M_PI) << std::endl;
    std::cout << Pythagoras(3, 4) << std::endl;
    std::cout << cosineRule(5, 3, 4) << std::endl;
    std::cout << implementBound(0, 10, 15) << std::endl;

    return 0;
}