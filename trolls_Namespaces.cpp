// inst.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string> 
#include <conio.h>
using namespace std;

namespace Hogwarts {
	int Troll = 1;
}

namespace Mordor {
	int Troll = 2;
}
//do feed a troll
int main(void) {
	cout << Hogwarts::Troll << " " << Mordor::Troll << endl;
	getch();
	return 0;
}
