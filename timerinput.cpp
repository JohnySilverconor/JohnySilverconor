#include <iostream>
#include <iomanip>
#include <chrono>
#include <thread>
#include <cstdlib>
using namespace std;

#define FMT << setw( 2 ) << setfill( '0' ) <<

int main()
{
   int totalTime;
   cout << "Input number of half-minute intervals: ";   cin >> totalTime;
   totalTime *= 30;
   for (int t = totalTime; t >= 0; t--)
   {
      int second = t;
      int hour   = second / 3600;   second %= 3600;
      int minute = second / 60  ;   second %= 60;
      system( "cls" );                                           // Comment out for testing
      cout FMT hour << " : " FMT minute << " : " FMT second << '\n';
      this_thread::sleep_for( chrono::seconds( 1 ) );            // Comment out for testing
   }
}