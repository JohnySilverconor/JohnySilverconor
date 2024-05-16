#include <iostream>
int attack = 10;
int hp = 1000;
short choice = 0;
void junglefight();
void cityfight();
void cavefight();
int main()
{
	if(hp <=0)
{
    std::cout<<"Game over!";
    return 0;
}
else
{
    std::cout<<"Hi little warrior pick you path: 1 jungle, 2 city, 3 cave \n";
	std::cin>>choice;
}
	
if(choice == 1)
{
junglefight();

}

else if(choice ==2)
{
cityfight();
}

else if(choice == 3)
{
cavefight();
}

else
{
std::cout<<"Invalid choice try again: 1, 2 , 3 \n";
std::cin>>choice;
}

    return 0;
}

 void junglefight()
{
    std::cout<<"Orcs attack you: \n"<<"-200";
    hp -= 200;
    std::cout<<"\n hp: "<<hp<<"\n";
    main();
}

  void cityfight()
{
    std::cout<<"Bandits attack you: \n"<<"-100";
    hp -= 100;
    std::cout<<"\n hp: "<<hp<<"\n";
    main();
    
}

 void cavefight()
{
    std::cout<<"Bandits attack you: \n"<<"-300";
    hp -= 300;
    std::cout<<"\n hp: "<<hp<<"\n";
    main();
}

