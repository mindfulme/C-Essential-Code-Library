// Rostislav Gogolauri /C++/2017
//eng version

#include "stdafx.h"
#include <iostream>
#include <conio.h>                 //include the debug library
using namespace std;
                                // Let`s move out!
int main(void) {
	float a, b, c;           // koeficients of the -->

	cout << "Enter me a,b,c (Example: ax2-bx+c=0)"<<endl;
	cin >> a >> b >> c;
	                     // Starting condition section
	if (a != 0)
	{
		float D = b*b - 4 * a*c;
		if (D > 0) {
			float x1=(-b+sqrt(D))/2*a;
			float x2 = (-b -sqrt(D)) / 2 * a;
			cout << "Roots are " << x1 << ", " << x2 << endl;
		}
		else if (D = 0) {
			  cout << "Root is " << -b / 2 * a << endl;
		}
		else  { cout << "No Roots , sorry...";
	    }
	}
	    else { 
		cout << "for this you must be sure that first koef not equal 1" << endl;
	         }
		          //Ending condition section

	getch();    //debug point
	return 0;
}
