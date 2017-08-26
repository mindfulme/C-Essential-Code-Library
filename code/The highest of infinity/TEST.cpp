// TEST.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;


int main(void)
{
	cout << "Enter as many numbers as you want and get the highest one. (if you gonna end giving numbers to the program just enter -1" << endl;
	int number;
	cin >> number;
	int max = number;
	while (number != -1) {
		if (number > max)
			max = number;
		cin >> number;
	}
	cout << "The largest number is " << max << endl;

    return 0;
}

