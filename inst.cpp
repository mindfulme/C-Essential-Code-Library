// inst.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string> 
#include <conio.h>

using namespace std;

int main(void) {
	string sky;
	sky.assign(800000, 'X');
	cout << sky << endl;
	getch();
	return 0;
}