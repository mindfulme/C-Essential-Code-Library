// Rostislav Gogolauri /C++/2017
//eng version

#include "stdafx.h"
#include <iostream>
#include <conio.h>                 //include the debug library
using namespace std;
        // Let`s move out!
int main(void) {
	  // OOP a class example for future problems
	 //+Encapsulating
    //+function call...etc...
   //Start of the class definition
	class Class {
	public:
		Class(void) { this->value = -1; }
		Class(int val) { this->value = val; }
		void setVal(long value) { this->value = value; }
		int getVal(void) { return value; }
	private:
		int value;
		
	}; 
	//end of the class definition
	long value =-1;
	Class obj1, obj2(200);		//identify objects
	cout << "Give me any number, that has a length < 10 (Example: 999999999 )"<<endl;
	cin >> value;;			 //get an input from the user	
	obj2.setVal(value);		//setting the value to obj2
	 cout <<"Give me a number: "<< obj2.getVal() << endl;
	cout <<"Default number in the class is "<<obj1.getVal() << endl;
	getch();    //debug point
	return 0;
}
