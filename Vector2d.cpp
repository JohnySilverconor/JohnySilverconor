#include <iostream>
#include <cmath>
#include <stdexcept>
#include <string>
#include <tuple>

class Vector2d {
private:
    double _x, _y;

public:
    double get_x() {
        return _x;
    }

    void set_x(double value) {
        _x = value;
    }

    double get_y() {
        return _y;
    }

    void set_y(double value) {
        _y = value;
    }

    double get_magnitude() {
        return sqrt(_x * _x + _y * _y);
    }

    void set_magnitude(double value) {
        double current_angle = get_angle();
        _x = value * cos(current_angle);
        _y = value * sin(current_angle);
    }

    double get_angle() {
        return atan2(_y, _x);
    }

    void set_angle(double value) {
        double current_magnitude = get_magnitude();
        _x = current_magnitude * cos(value);
        _y = current_magnitude * sin(value);
    }

    Vector2d get_normR() {
        return Vector2d(-1 * _y, _x);
    }

    Vector2d get_normL() {
        return Vector2d(_y, -1 * _x);
    }

    Vector2d get_unitVector() {
        double mag = get_magnitude();
        return Vector2d(_x / mag, _y / mag);
    }

    static Vector2d add(Vector2d A, Vector2d B) {
        return Vector2d(A.get_x() + B.get_x(), A.get_y() + B.get_y());
    }

    static Vector2d minus(Vector2d A, Vector2d B) {
        return Vector2d(A.get_x() - B.get_x(), A.get_y() - B.get_y());
    }

    static Vector2d rotate(Vector2d A, double angle) {
        Vector2d B = A;
        B.set_angle(angle);
        return B;
    }

    static double angleBetween(Vector2d A, Vector2d B) {
        Vector2d A_unitVector = A.get_unitVector();
        Vector2d B_unitVector = B.get_unitVector();
        return acos(A.dotProduct(B));
    }

    static Vector2d interpolate(Vector2d A, double value) {
        return Vector2d(A.get_x() * value, A.get_y() * value);
    }

    Vector2d(double x, double y) : _x(x), _y(y) {}

    Vector2d clone() {
        return Vector2d(_x, _y);
    }

    void trace(std::string type) {
        if (type == "xy") {
            std::cout << "[" << _x << ", " << _y << "]" << std::endl;
        } else if (type == "ma") {
            std::cout << "[" << get_magnitude() << ", " << get_angle() << "]" << std::endl;
        }
    }

    void scale(double factor) {
        _x *= factor;
        _y *= factor;
    }

    void invert(std::string type) {
        if (type == "x") {
            _x *= -1;
        }
        if (type == "y" || type == "xy") {
            _y *= -1;
        }
    }

    void add(Vector2d B) {
        _x += B.get_x();
        _y += B.get_y();
    }

    void minus(Vector2d B) {
        _x -= B.get_x();
        _y -= B.get_y();
    }

    void rotate(double value) {
        double new_x = _x * cos(value) - _y * sin(value);
        double new_y = _x * sin(value) + _y * cos(value);
        _x = new_x;
        _y = new_y;
    }

    double dotProduct(Vector2d B) {
        return _x * B.get_x() + _y * B.get_y();
    }

    double perpProduct(Vector2d B) {
        return _y * B.get_x() + _x * -B.get_y();
    }

    double crossProduct(Vector2d B) {
        return _x * B.get_y() - _y * B.get_x();
    }

    bool equivalent(Vector2d B) {
        double diff = pow(4, -10);
        return (_x - B.get_x() < diff && _y - B.get_y() < diff);
    }
};

int main()
{
    std::cout<<"Hello World";

    return 0;
}
