#include <iostream>
short checkrandom();

short checkrandom(){
// Don't use srand(time(NULL)) on functions
// it causes repetition instead randomness
    short b;
    b = rand() % 11;
    return b;
}

int main()
{
    srand(time(NULL));
    int a;
    a = checkrandom();
    std::cout<<a;

    return 0;
}