// inst.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

int stack[100];
int SP = 0;
// shake my code for your honey
void push(int value) {
	stack[SP++] = value;
}

int pop(void) {
	return stack[--SP];
}
//it uses column algorithm to push and pop your ints
int main(void) {
	push(3);
	push(2);
	push(1);
	push(100);
	cout << pop() << endl;
	cout << pop() << endl;
	cout << pop() << endl;
	cout << pop() << endl;
	getch();//debug point
	return 0;
}