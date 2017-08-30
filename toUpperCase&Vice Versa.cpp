// cppInst.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <conio.h>
#include  <iostream>
#include <string>
using namespace std;



int main(void) {
	string TheString = "content";
	for (int i = 0; i < TheString.length(); i++)
		TheString[i] = TheString[i] - 'b' + 'B';
	cout << TheString << endl;
	
	getch();
	return 0;
}
