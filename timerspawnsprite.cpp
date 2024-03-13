#include <iostream>
#include <chrono>
#include <thread>

int main()
{
    const int CountObjectToShow = 10;
    const unsigned int TIME_TO_SHOW = 3; // Time interval in seconds

    for (int i = 0; i < CountObjectToShow; i++)
    {
        // Your code to spawn the sprite goes here
        // For example:
        // mole1.visible = true;
        // mole1.paint_sprite(myscreen);

        std::this_thread::sleep_for(std::chrono::seconds(TIME_TO_SHOW));
        // Set object invisible here (if needed)
        // For example:
        // mole1.visible = false;
        // mole1.paint_sprite(myscreen);
    }

    return 0;
}