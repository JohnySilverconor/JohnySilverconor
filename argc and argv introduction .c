#include <stdio.h>
#include <stdlib.h>
int main(int argc, char* argv[])
{
    int i, sum = 0;
    printf("Hello World");
    printf("argc = %d\n", argc);
    printf("Let's see what is in argv[]\n");
    if(argc>1)
    {
        for(i = 0; i<argc; i++)
        {
            printf("argv[%d] = %s\n", i, argv[i]);
            sum = sum + atoi(argv[i]);
        }
        printf("Total = %d\n", sum);
    }

    return 0;
} 