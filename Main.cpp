// Written by Rostisval Gogolauri /2017/ C++
// *** GNU License ***

#include "stdafx.h"
#include <iostream>
#include <conio.h>

using namespace std;

int main()
{
	int ink = 1;
	float x0, x, y0, y, z0, z, c, k;																				   //coordinates
	system("Color f0");																						   // change color and background of console
	while (ink == 1) {
		cout << "Choise one statement which you need to solve (1-7)" << endl;
	cout << "1: General equation of line Ax+By+C=0" << endl;												   // Загальне рівняня прямої
	cout << "2: Equation of line using line segments x/a+y/b=1 " << endl;								       	   //-Векторне рівняня прямої  у відрізках
	cout << "3: Equation of line with angle coefficient y=kx+b" << endl;							           //  Рівняня прямої з кутовим коефіціентом k
	cout << "4: Equation of line going through 2 points (x-x1)/(x2-x1)=(y-y1)/(y2-y1)" << endl;			       //+Відстань від точки до прямої
	cout << "5: Normal equation of line x*cos(a)+y*sin(a)-p=0" << endl;										   // Нормальне рівнянян прямої
	cout << "6: Equation of line with parameters x=x1+a*(lambda)" <<
		"  y=y1+b*(lambda)" << endl;																				   // Параметричне рівняня прямої
	cout << "7: Equation of line in the open space, which is going through 3 points (the same as 4)" << endl;  // Рівняня прямої в просторі, що проходить через 3 точки

	int caser;
	cin >> caser;
	switch (caser) {
	case 1:cout << "(A,B,C are coefficients) Give me A : ";
		cin >> x;  // x = A
		cout << "Give me B: ";
		cin >> y; // y = B
		cout << "Give me C:";
		cin >> c; // c = C
		if (y == 0) { cout << "Division by zero!!!!!!!!!!!!!"; }
		else if (x == 0) {
			cout << "Equation of line :   y=" << "-" << c / y;
		}
		else {
			cout << "Equation of line :   y=" << -x / y << "x" << "-" << c / y;
		}
		break;
	case 2:cout << "Input please 2 line segments a,b:";
		cin >> x >> y;//x=a, y=b
		if (x == 0 || y == 0) {
			cout << "division by zero!!!!!!!!!!!";
		}
		else { cout << "y=" << "-" << y / x << "x"; }
		break;
	case 3:cout << "Give me tg(alpha) :";
		cin >> k;
		cout << "Give me b :";
		cin >> c; // c = b;
		if (k == 0) { cout << "y=" << c; }
		else if (k == 1) {
			cout << "y=" << "x+" << c;
		}
		else {
			cout << "y=" << k << "x+" << c;
		}

		break;
	case 4:cout << "Give me coordinates of first point x1,y1 : ";
		cin >> x0 >> y0;
		cout << "Give me coordinates of second point x2,y2 : ";
		cin >> x >> y;
		if ((x - x0) == 0 || (y - y0) == 0) {
			cout << " x2-x1 =0 Division by zero";
		}
		else if ((x - x0)*(y - y0) == 1) { cout << "y=" << "x-" << (x0 / (x - x0)*(y - y0) + y0); }
		else {
			cout << "y=" << 1 / (x - x0)*(y - y0) << "x-" << (x0 / (x - x0)*(y - y0) + y0);
		}
		break;
	case 5:cout << "Give me alpha:";
		cin >> k;// k=alpha
		cout << "Give me p - distance from to line from (0;0)";
		cin >> c;// c=p
		cout << "y=" << c / sin(k / 57.3) << "-" << cos(k / 57.3) / sin(k / 57.3) << "x";
		break;
	case 6:cout << "Give me direction vector coordinates a,b:";
		cin >> x0 >> y0; //x0,y0=a,b
		cout << "Give me point(dot) coordinates x1,y1:";
		cin >> x >> y;// x=x1, y=y1
		cout << "x=" << x << "+" << x0 << "*lambda(any number)" << endl;
		cout << "y=" << y << "+" << y0 << "*lambda(any number)" << endl;

		break;
	case 7:cout << "Give me coordinates of the first point x,y,z:";
		cin >> x0 >> y0 >> z0;
		cout << "Give me coordinates of the second point x,y,z:";
		cin >> x >> y >> z;

		cout << 1 / (x - x0) << "x-" << x0 / (x - x0) << "=" << 1 / (y - y0) << "y-" << y0 / (y - y0) << "=" << 1 / (z - z0) << "z-" << z0 / (z - z0);
		break;
	default:cout << "Select existing number from table, thank's!" << endl;
		cout << "Now reopen please.";
	}
	ink = 0;
	cout << "				continue? Give an Input equal to 1" << endl;;
	cin >> ink;
}
	getch();
    return 0;
}

