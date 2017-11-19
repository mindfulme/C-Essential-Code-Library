// Rostislav Gogolauri / 2017
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>                 //include the debug library
using namespace std;
        // Let`s move out!
class Class1 {
public:
	Class1(int val) { this->value = val; }
	Class1(Class1 const &source) { value = source.value + 100; }
	int value;
};
class Class2 {
public:
	Class2(int val) { this->value = val; }
	int value;
};
int main(void) {
	Class1 object11(100), object12 = object11;
	Class2 object21(200), object22 = object21;
	cout << object12.value << endl;
	cout << object22.value << endl;
	getch();    //debug point
	return 0;
}
