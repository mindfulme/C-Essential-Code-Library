// ReverseArray.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

void main()
{
	int temp, arrayLength;
	int array[100];
	cout << "Enter Array Length: ";
	cin >> arrayLength;
	//input elements into Array
	cout << "Enter Array Elements" << endl;
	for (int i = 0; i < arrayLength; i++)
	{
		cout << "Array[" << i << "] = ";
		cin >> array[i];
	}
	//Swap the array elements
	for (int i = 0; i < arrayLength / 2; i++)
	{
		temp = array[i];
		array[i] = array[(arrayLength - 1) - i];
		array[(arrayLength - 1) - i] = temp;
	}
	cout << "Cout Array After Reversing" << endl;
	for (int i = 0; i < arrayLength; i++)
	{
		cout << "Array[" << i << "] = " << array[i] << endl;

	}
	getch();
}

