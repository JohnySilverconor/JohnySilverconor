#include <iostream>
#include <cstdlib>
#include <ctime>
 
using namespace std;
 
int main () {
 
 
	// initial
	short ballCount = 100;
	short box[6] = { 0, 0, 0, 0, 0 };
	short leftorright = 0;
	string line = " +-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-->";
	string numbers = " 0     5     10     15     20     25     30     35     40     45     50";
 
	// Need for Random Numbers
	srand ( time(NULL) );
 
	// Rund ballCount (100) zahl = rand() % 2;
	for (short i=0; i<ballCount; i++) {
			short counter = 0;
 
		for (short j=0; j<5; j++) {
			// left or right
			leftorright = rand() % 2;
			counter = counter + leftorright;
		}
		box[counter] = box[counter]++;
 
	}	
 
	// Output
	cout << numbers << endl << line << endl;
	for (short t=0; t<6; t++) {
		cout << t << " |";
		for (int u=0; u < box[t]; u++) {
			cout << "#";
		}
		cout << " " << box[t] << endl << line << endl;
	}
	return 0;
}