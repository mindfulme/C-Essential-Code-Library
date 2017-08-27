// Search.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
using namespace std;

int main()
{
	int a[100], n, i, beg, end, mid, item;
	cout << "Enter Number of Elements. = ";
	cin >> n;
	cout << "\nEnter Elements in Sorted Order=\n";
	for (i = 0; i <= n; i++) 
	{
		cin >> a[i];
	}
	cout << "\nEnter Item you want to Search= ";
	cin >> item;
	beg = 1;
	end = n;
	mid = (beg + end) / 2;//finds middle location of an array
	while (beg <= end && a[mid] != item)
		//compare item and value of Mid
	{
		if (a[mid] < item)
			beg = mid + 1;
		else
			end = mid - 1;
		mid = (beg + end) / 2;

	}





		if (a[mid] == item) {
			cout << "\nData is Found at Location : " << mid+1;
		}
		else {
			cout << "Data is Not Found";
		}
		
	
	getch();
    return 0;
}

