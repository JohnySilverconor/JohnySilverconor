#include <iostream>
#include <ctime>
#include <cstdlib>
#include <vector>
using namespace std;

int main(){
	
	int ballnum;
	int slots;
	int count = 1;
	string direction[2] = {"L", "R"};
	srand(time(0));
	
	
	cout << "Enter number of balls to drop: ";
	cin >> ballnum;
	cout << "Enter number of slots in the bean machine: ";
	cin >> slots;
	
    std::vector<int> histogram(slots, 0);
    
	for (int j = 0; j<ballnum; j++){
		cout << "Ball number " << j + 1 <<" : " ;
		
		int position = 0;
		for (int i = 0; i<slots-1; i++){
			int r = rand()%2;
			cout<<direction[r];
			if (r == 1) {
				 position += 1;
			}
		}	
		histogram[position] += 1;
			
		cout<<endl;
	}
	
	for (int i = 0; i < slots; i++)
	{
	    for (int j = 0; j < histogram[i]; j++)
	    {
	        std::cout << '*';
	    }
	    std::cout << '\n'; 
	}
	
}