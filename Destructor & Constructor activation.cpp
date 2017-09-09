// Rostislav Gogolauri /C++/2017
//eng version
// static initializes only once!!!!!!!!!
#include "stdafx.h"
#include <iostream>
#include <conio.h>                 //include the debug library
using namespace std;
        // Let`s move out!
// static variable example
// static initializes only once!!!!!!!!!
class Class {
public:
	Class(void) {
		cout << "Object constructed!" << endl;
	}
	~Class(void) {
		cout << "Object destructed!" << endl;
	}
	int value;
};
int main(void) {
	Class *ptr;

	ptr = new Class;
	ptr->value = 0;
	cout << ++(ptr->value) << endl;
	delete ptr;
	getch();    //debug point
	return 0;
}
