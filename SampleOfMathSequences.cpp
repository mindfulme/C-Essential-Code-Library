// Written by Rostisval Gogolauri /2017//
// Telegram @Map_Inc//

#include "stdafx.h"
#include <iostream>
#include <conio.h> // debug library//
#include <string>
#include <math.h>
#define PI 3.14159265
using namespace std;

int main()
{

	int ink = 1;
	float x0, x, y0, y, z0, z, c, k, x1, y1, z1;			    //coordinates * координаты//
	system("Color 2");	// f0 - white and black		 change text and background color of console * цвета для фона, текста //
	while (ink == 1) {                          // loop for inputing without exiting command line * Ввод след. без закрытия консоли //
		cout << "Choise one statement which you need to solve (1-7)" << endl;
		cout << " " << endl;
		cout << "1: General equation of line Ax+By+C=0" << endl;												  
		cout << "2: Equation of line using line segments x/a+y/b=1 " << endl;								      
		cout << "3: Equation of line with angle coefficient y=kx+b" << endl;							          
		cout << "4: Equation of line going through 2 points (x-x1)/(x2-x1)=(y-y1)/(y2-y1)" << endl;			      
		cout << "5: Normal equation of line x*cos(a)+y*sin(a)-p=0" << endl;										   
		cout << "6: Equation of line with parameters x=x1+a*(lambda)" << "  y=y1+b*(lambda)" << endl;			   
		cout << "7: Equation of line in the open space" << endl;                                                  
		cout << "8: Angle between plane and line (alpha)" << endl;                                                
		cout << "9: Scalar equation of the plane ax+by+cz=d" << endl;											   

		int caser;
		cin >> caser;
		switch (caser) {
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		case 8:
			break;
		case 9: 
			break;
		default:cout << "Select the existing number from the table, thank's!" << endl;
			cout << "Try once more.";
		}
		ink = 0;
		cout << "				continue? press 1" << endl;;
		cin >> ink;
		system("cls"); // clears the screen * Оч. скрин
	}

	// debug point//
	system("pause");
}
