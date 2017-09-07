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

void fun(void) {
	static int var = 99;
	cout << "var = " << ++var << endl;
}
int main(void) {
	for (int i = 0; i < 5; i++)
		fun();
	getch();    //debug point
	return 0;
}
