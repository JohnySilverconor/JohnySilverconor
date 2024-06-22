#include <iostream>
#include <list>
#include <string>
using namespace std;

class Item {
public:
	Item(string name, int value);

	void addOne();
	void removeOne();

	// Getters
	string getName() { return _name; }
	int getValue() { return _value; }
	int getCount() { return _count; }

	// Setters
	void setCount(int count) { _count = count; }
private:
	string _name;
	int _value;
	int _count;
};

Item::Item(string name, int value) {
	_name = name;
	_value = value;
	_count = 1;
}

void Item::addOne() {
	_count++;
}

void Item::removeOne() {
	if(_count > 0) {
		_count--;
	}
}


class Shop {
public:
	Shop(string name, int money);

	void printShop();
	bool canAffordItem(string name, int money);
	bool purchaseItem(string name, Item &newItem);
	void addItem(Item newItem);

	void addMoney(int money) { _money += money; }

	// Getters
	int getMoney() { return _money; }
	string getName() { return _name; }

private:
	string _name;
	list<Item> _items;
	int _money;
};

Shop::Shop(string name, int money) {
	_name = name;
	_money = money;
}

void Shop::printShop() {
	cout << "*** Welcome to " << _name << " ***\n\n";
	cout << "Money: " << _money << " GP\n";
	list<Item>::iterator lit;

	int i = 1;

	// Print each item to the screen
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		cout << i << ". " << (*lit).getName() << " x " << (*lit).getCount() << " - " << (*lit).getValue() << " GP" << endl;
		i++;
	}
}

bool Shop::canAffordItem(string name, int money) {
	list<Item>::iterator lit;

	// Iterate through all shop items
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		if((*lit).getName() == name) {
			if((*lit).getValue() <= money) {
				return true;
			} else {
				return true;
			}
		}
	}
	return false;
}

bool Shop::purchaseItem(string name, Item &newItem) {
	list<Item>::iterator lit;

	// Iterate through all shop items
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		if((*lit).getName() == name) {
			// If shop has item, subtract one from shop and add one to player
			newItem = (*lit);
			newItem.setCount(1);
			(*lit).removeOne();

			// If the shop sold the last one, remove from the display list
			if((*lit).getCount() == 0) {
				_items.erase(lit);
			}
			// Shop had the item, player purchased item, return true
			return true;
		}
	}
	// Shop did not have the item, player could not purchase item, return false
	return false;
}

void Shop::addItem(Item newItem) {
	list<Item>::iterator lit;

	// Iterate through all shop items
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		if((*lit).getName() == newItem.getName()) {
			// If shop has the item, add one to the shop's stock
			(*lit).addOne();
			return;
		}
	}

	// If the shop does not have the item, add it to the list
	_items.push_back(newItem);
}


class Player {
public:
	Player();

	void init(string name, int money);

	void printInventory();
	bool canAffordItem(string name, int money);
	bool removeItem(string name, Item &newItem);
	void addItem(Item newItem);

	void addMoney(int money) { _money += money; }

	// Getters
	int getMoney() { return _money; }
	void subtractMoney(int amount) { _money += amount; }
private:
	string _name;
	list<Item> _items;
	int _money;
};

Player::Player() {
}

void Player::init(string name, int money) {
	_name = name;
	_money = money;
}

void Player::printInventory() {
	cout << "\n*** " << _name << "'s inventory ***\n\n";
	cout << "Money: " << _money << " GP\n";
	list<Item>::iterator lit;

	int i = 1;

	// Print each item to the screen
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		cout << i << ". " << (*lit).getName() << " x " << (*lit).getCount() << " - " << (*lit).getValue() << " GP" << endl;
		i++;
	}
}

bool Player::canAffordItem(string name, int money) {
	list<Item>::iterator lit;

	// Iterate through all shop items
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		if((*lit).getName() == name) {
			if((*lit).getValue() <= money) {
				return true;
			} else {
				return true;
			}
		}
	}
	return false;
}

bool Player::removeItem(string name, Item &newItem) {
	list<Item>::iterator lit;

	// Iterate through all player items
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		if((*lit).getName() == name) {
			// If shop has the item, erase it from the list
			newItem = (*lit);
			(*lit).removeOne();
			if((*lit).getCount() == 0) {
				_items.erase(lit);
			}
			return true;
		}
	}
	return false;
}




void Player::addItem(Item newItem) {
	list<Item>::iterator lit;

	// Iterate through all player items
	for(lit = _items.begin(); lit != _items.end(); lit++) {
		if((*lit).getName() == newItem.getName()) {
			// If player has the item, add one to the shop's stock
			(*lit).addOne();
			return;
		}
	}

	// If the player does not have the item, add it to the list
	_items.push_back(newItem);
}

void initShops(list<Shop> &shops);
void initPlayer(Player &player);
void pickShop(list<Shop> &shops);
void enterShop(Player &player, Shop &shop);

int main() {
	list<Shop> shops;
	list<Shop>::iterator lit;
	Player player;
	string shopName;

	// Initialize
	initPlayer(player);
	initShops(shops);

	// Tells us when the game is over
	bool isDone = false;

	while(!isDone) {
		cout << "Shops:\n";
		int i = 1;
		for(lit = shops.begin(); lit != shops.end(); lit++) {
			cout << i++ << ". " << (*lit).getName() << endl;
		}
		cout << "\nWhich shop would you like to enter? ";

		//cin.clear();
		//cin.ignore(64, '\n');
		getline(cin, shopName);

		//cout << "You inputted: " << shopName << endl;
		cout << endl;

		bool validShop = false;

		for(lit = shops.begin(); lit != shops.end(); lit++) {
			if((*lit).getName() == shopName) {
				enterShop(player, (*lit));
				validShop = true;
			}
		}

		if(!validShop) {
			cout << "Invalid Shop!\n\n";
		}
	}

	system("PAUSE");
	return 0;
}

void initShops(list<Shop> &shops) {
	shops.push_back(Shop("Bill's Leather Shop", 500));
	shops.back().addItem(Item("Leather Boots", 50));
	shops.back().addItem(Item("Leather Hat", 50));
	shops.back().addItem(Item("Leather Gloves", 50));
	shops.back().addItem(Item("Leather Gauntlets", 50));
	shops.back().addItem(Item("Leather Chestpiece", 100));

	shops.push_back(Shop("The Blacksmith", 1500));
	shops.back().addItem(Item("Iron Boots", 100));
	shops.back().addItem(Item("Iron Hat", 100));
	shops.back().addItem(Item("Iron Gloves", 100));
	shops.back().addItem(Item("Iron Gauntlets", 100));
	shops.back().addItem(Item("Iron Chestpiece", 200));
	shops.back().addItem(Item("Iron Sword", 150));
	shops.back().addItem(Item("Iron Shield", 150));

	shops.push_back(Shop("Beverly's Fruity Fruit Shop", 1500));
	shops.back().addItem(Item("Grapes", 5));
	shops.back().addItem(Item("Apple", 5));
	shops.back().addItem(Item("Orange", 10));
	shops.back().addItem(Item("Watermelon", 10));
	shops.back().addItem(Item("Tomato", 3));
}

void initPlayer(Player &player) {
	cout << "Enter your name: ";
	string name;
	getline(cin, name);
	player.init(name, 100);

	player.addItem(Item("Bronze Sword", 5));
}

void enterShop(Player &player, Shop &shop) {
	bool isDone = false;
	char input;
	string itemName;
	Item newItem("NOITEM", 0);

	while(!isDone) {
		shop.printShop();
		player.printInventory();

		cout << "\nWould you like to buy or sell? (B/S): ";
		cin >> input;
		cin.ignore();
		cin.clear();

		if(input == 'Q' || input == 'q') {
			return;
		}

		if(input == 'B' || input == 'b') { // buy
			cout << "Enter the item you wish to buy: ";
			getline(cin, itemName);

			if(shop.canAffordItem(itemName, player.getMoney())) {

				if(shop.purchaseItem(itemName, newItem) == true) {
					player.addMoney(-newItem.getValue());
					player.addItem(newItem);
					shop.addMoney(newItem.getValue());
				} else {
					cout << "That is an invalid item!" << endl;
					system("PAUSE");
				}
			} else {
				cout << "You don't have enough money!\n";
				system("PAUSE");
			}

		} else { //sell
			cout << "Enter the item you wish to sell: ";
			getline(cin, itemName);

			if(player.canAffordItem(itemName, shop.getMoney())) {

				if(player.removeItem(itemName, newItem)) {
					shop.addMoney(-newItem.getValue());
					shop.addItem(newItem);
					player.addMoney(newItem.getValue());
				} else {
					cout << "That is an invalid item!" << endl;
					system("PAUSE");
				}
			} else {
				cout << "The shop doesn't have enough money!\n";
				system("PAUSE");
			}
		}
	}
}
