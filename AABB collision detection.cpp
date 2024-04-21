//swept AABB collision detection
#include <iostream>
#include <cmath>
#include <stdexcept>
#include <string>
#include <tuple>
struct Rectangle {
    int x, y, w, h;
};

std::tuple<double, int, int> sweep(Rectangle a, int dx, int dy, Rectangle b) {
    double entryTimeX, exitTimeX, entryTimeY, exitTimeY;

    if (dx == 0) {
        if (a.x < b.x + b.w && b.x < a.x + a.w) {
            entryTimeX = -INFINITY;
            exitTimeX = INFINITY;
        } else {
            return std::make_tuple(false, 0, 0);
        }
    } else {
        double entryDistanceX = (dx > 0) ? b.x - (a.x + a.w) : a.x - (b.x + b.w);
        entryTimeX = entryDistanceX / std::abs(dx);

        double exitDistanceX = (dx > 0) ? b.x + b.w - a.x : a.x + a.w - b.x;
        exitTimeX = exitDistanceX / std::abs(dx);
    }

    if (dy == 0) {
        if (a.y < b.y + b.h && b.y < a.y + a.h) {
            entryTimeY = -INFINITY;
            exitTimeY = INFINITY;
        } else {
            return std::make_tuple(false, 0, 0);
        }
    } else {
        double entryDistanceY = (dy > 0) ? b.y - (a.y + a.h) : a.y - (b.y + b.h);
        entryTimeY = entryDistanceY / std::abs(dy);

        double exitDistanceY = (dy > 0) ? b.y + b.h - a.y : a.y + a.h - b.y;
        exitTimeY = exitDistanceY / std::abs(dy);
    }

    if (entryTimeX > exitTimeY || entryTimeY > exitTimeX) {
        return std::make_tuple(false, 0, 0);
    }

    double entryTime = std::max(entryTimeX, entryTimeY);

    if (entryTime < 0 || entryTime > 1) {
        return std::make_tuple(false, 0, 0);
    }

    int normalX = 0, normalY = 0;
    if (entryTimeX > entryTimeY) {
        normalX = (dx > 0) ? -1 : 1;
    } else {
        normalY = (dy > 0) ? -1 : 1;
    }

    return std::make_tuple(entryTime, normalX, normalY);
}
int main()
{
    std::cout<<"Hello World";

    return 0;
}
