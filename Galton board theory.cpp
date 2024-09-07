#include <iostream>
#include <ctime>
#include <vector>
using namespace std;

//Decide a L or R direction at random
bool dropMarble()
{
  if(rand() % 2)
    {
      return false;
    }
  else
    {
      return true;
    }
}

void dropMarble(vector<int> &columns, int cols)
{
  short i = 0, j = 0;
  bool GoneRight=true;

  while((i + j) != cols)
    {
      GoneRight = dropMarble();

      if(GoneRight)
        {
      //Marble goes right
      ++j;
        }

      else
        {
      //Marble goes left
      // i is height small i is high, large i is low
      ++i;
        }
    }

  //Increment the count of marbles in the columns
  ++columns[j];
}

void printColumns(vector<int> &columns, int cols)
{
  for(short i = 0; i< cols; ++i)
    {
      cout << columns[i] << "";
    }
  cout << endl;
}

int main()
{
  srand(time(NULL));
  short numberOfMarbles;
  short numberOfColumns = 8;
  vector<int> slots;
  slots.resize(8);

  //    int columns[numberOfColumns];

  //Initialize the count of marbles in the columns to zero
  for(short i = 1; i <= numberOfColumns; ++i)
    {
      slots[i] = 0;
    }
  cout << "Enter the number of marbles to drop: " << endl;
  cin >> numberOfMarbles;

  for(short i = 1; i <= numberOfMarbles; ++i)
  {    
      dropMarble(slots, numberOfColumns);
  }

  for(short j = 0; j<numberOfColumns;++j){
    cout << "The number of marbles in slot " << j << " is " << slots[j] << endl;
  }

  printColumns(slots, numberOfColumns);
  return 0;
}