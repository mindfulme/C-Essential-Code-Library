// Written by Rostisval Gogolauri /2017/
// Telegram @Map_Inc

#include "stdafx.h"
#include <iostream>
#include <conio.h> // debug library
#include <string>
#include <math.h>
#define PI 3.14159265
using namespace std;

int main()
{

	int ink = 1;
	float x0, x, y0, y, z0, z, c, k;			    //coordinates * координаты
	system("Color 2");	// f0 - white and black		// change text and background color of console * цвета для фона, текста
	while (ink == 1) {                          // loop for inputing without exiting command line * Ввод след. без закрытия консоли 
		cout << "Choise one statement which you need to solve (1-7)" << endl;
		cout << " " << endl;
		cout << "1: General equation of line Ax+By+C=0" << endl;												   // Загальне рівняня прямої
		cout << "2: Equation of line using line segments x/a+y/b=1 " << endl;								       // Векторне рівняня прямої  у відрізках
		cout << "3: Equation of line with angle coefficient y=kx+b" << endl;							           //  Рівняня прямої з кутовим коефіціентом k
		cout << "4: Equation of line going through 2 points (x-x1)/(x2-x1)=(y-y1)/(y2-y1)" << endl;			       // Відстань від точки до прямої
		cout << "5: Normal equation of line x*cos(a)+y*sin(a)-p=0" << endl;										   // Нормальне рівнянян прямої
		cout << "6: Equation of line with parameters x=x1+a*(lambda)" << "  y=y1+b*(lambda)" << endl;			   // Параметричне рівняня прямої
		cout << "7: Equation of line in the open space" << endl;                                                   // Рівняня прямої в просторі, що проходить через 2 точки
		cout << "8: Angle between plane and line (alpha)" << endl;
		int caser;
		cin >> caser;
		switch (caser) {
		case 1:cout << "(A,B,C are coefficients) A,B - vector coordinates. Give me A : ";
			cin >> x; // x = A
			cout << "Give me B: ";
			cin >> y; // y = B
			cout << "Give me C:";
			cin >> c; // c = C
			system("cls"); // clears the screen * Оч. скрин
			if (y == 0) { cout << "Division by zero!!!!!!!!!!!!!"; }
			else if (x == 0) {
				if ((c / y) > 0) {
					cout << "Equation of line :   y=" << "+" << c / y;
				}
				else if ((c / y) < 0) {
					cout << "Equation of line :   y=" << c / y;
				}
			}
			else {
				if ((c / y) > 0) {
					cout << "Equation of line :   y=" << -x / y << "x" << "+" << c / y;
				}
				else if ((c / y) < 0) {
					cout << "Equation of line :   y=" << -x / y << "x" << c / y;
				}
				else {
					cout << "Equation of line :   y=" << 0;
				}
			}
			break;
		case 2:cout << "Input please 2 line segments a,b:";
			cin >> x >> y;    //x=a, y=b
			system("cls"); // clears the screen * Оч. скрин
			if (x == 0 || y == 0) {
				cout << "division by zero!!!!!!!!!!!";
			}
			else {
				if (y / x > 0) {
					cout << "y=" << "-" << y / x << "x";
				}
				else if (y / x < 0) {
					cout << "y=" << y / x << "x";
				}
				else {
					cout << "y=" << 0;
				}
			}
			break;
		case 3:cout << "Give me tg(alpha) :";
			cin >> k;
			cout << "Give me b :";
			cin >> c; // c = b;
			system("cls"); // clears the screen * Оч. скрин
			if (k == 0) { cout << "y=" << c; }
			else if (k == 1) {
				if (c >= 0) {
					cout << "y=" << "x+" << c;
				}
				else if (c < 0) {
					cout << "y=" << "x" << c;
				}

			}
			else {
				if (c >= 0) {
					cout << "y=" << k << "x+" << c;
				}
				else if (c < 0) {
					cout << "y=" << k << "x" << c;
				}
			}

			break;
		case 4:cout << "Give me coordinates of first point x1,y1 : ";
			cin >> x0 >> y0;
			cout << "Give me coordinates of second point x2,y2 : ";
			cin >> x >> y;
			system("cls"); // clears the screen * Оч. скрин
			if ((x - x0) == 0 || (y - y0) == 0) {
				cout << "Division by zero!!!";
			}
			else if ((x - x0)*(y - y0) == 1) {
				if ((x0 / (x - x0)*(y - y0) + y0) >= 0) {
					cout << "y=" << 1 / (x - x0)*(y - y0) << "x+" << (x0 / (x - x0)*(y - y0) + y0);
				}
				else {
					cout << "y=" << 1 / (x - x0)*(y - y0) << "x" << (x0 / (x - x0)*(y - y0) + y0);
				}
			}
			else {
				if ((x0 / (x - x0)*(y - y0) + y0) >= 0) {
					cout << "y=" << 1 / (x - x0)*(y - y0) << "x+" << (x0 / (x - x0)*(y - y0) + y0);
				}
				else {
					cout << "y=" << 1 / (x - x0)*(y - y0) << "x" << (x0 / (x - x0)*(y - y0) + y0);
				}
				//cout << "y=" << 1 / (x - x0)*(y - y0) << "x-" << (x0 / (x - x0)*(y - y0) + y0);
			}
			break;
		case 5:cout << "Give me alpha:";
			cin >> k;// k=alpha
			cout << "Give me p - distance from (0;0) to line";
			cin >> c;// c=p
			if (cos(k / 180.0 / PI) / sin(k / 180.0 / PI) > 0) { cout << "y=" << c / sin(k / 180.0 / PI) << "-" << cos(k / 180.0 / PI) / sin(k / 180.0 / PI) << "x"; }
			else if (cos(k / 180.0 / PI) / sin(k / 180.0 / PI) < 0) { cout << "y=" << c / sin(k / 180.0 / PI) << cos(k / 180.0 / PI) / sin(k / 180.0 / PI) << "x"; }
			else if (sin(k / 180.0 / PI) == 0) { cout << "division by zero!!! Tracepaser"; }
			else { cout << "y=" << c / sin(k / 180.0 / PI); }
			break;
		case 6:cout << "Give me direction vector coordinates a,b:";
			cin >> x0 >> y0; //x0,y0=a,b
			cout << "Give me point(dot) coordinates x1,y1:";
			cin >> x >> y;// x=x1, y=y1
			system("cls"); // clears the screen * Оч. скрин
			if (x0 >= 0 && y >= 0) {
				cout << "x=" << x << "+" << x0 << "*lambda(any number)" << endl;
				cout << "y=" << y << "+" << y0 << "*lambda(any number)" << endl;
			}
			else if (x0 >= 0 && y < 0) {
				cout << "x=" << x << "+" << x0 << "*lambda(any number)" << endl;
				cout << "y=" << y << y0 << "*lambda(any number)" << endl;
			}
			else if (x0 < 0 && y >= 0) {
				cout << "x=" << x << x0 << "*lambda(any number)" << endl;
				cout << "y=" << y << "+" << y0 << "*lambda(any number)" << endl;
			}
			else if (x0 < 0 && y < 0) {
				cout << "x=" << x << x0 << "*lambda(any number)" << endl;
				cout << "y=" << y << y0 << "*lambda(any number)" << endl;
			}
			break;
		case 7:cout << "Give me coordinates of the first point x,y,z:"; //  <- must be handled
			cin >> x0 >> y0 >> z0;
			cout << "Give me coordinates of the second point x,y,z:";
			cin >> x >> y >> z;
			system("cls"); // clears the screen * Оч. скрин
			if ((x - x0) == 0 || (y - y0) == 0 || (z - z0) == 0) {
				cout << "Division by zero!!!";
			}
			else if ((x0 / (x - x0)) >= 0 && (y0 / (y - y0)) >= 0 && (z0 / (z - z0)) >= 0) {
				cout << 1 / (x - x0) << "x-" << x0 / (x - x0) << "=" << 1 / (y - y0) << "y-" << y0 / (y - y0) << "=" << 1 / (z - z0) << "z-" << z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) < 0 && (y0 / (y - y0)) < 0 && (z0 / (z - z0)) < 0) {
				cout << 1 / (x - x0) << "x+" << -x0 / (x - x0) << "=" << 1 / (y - y0) << "y+" << -y0 / (y - y0) << "=" << 1 / (z - z0) << "z+" << -z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) >= 0 && (y0 / (y - y0)) < 0 && (z0 / (z - z0)) < 0) {
				cout << 1 / (x - x0) << "x-" << x0 / (x - x0) << "=" << 1 / (y - y0) << "y+" << -y0 / (y - y0) << "=" << 1 / (z - z0) << "z+" << -z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) >= 0 && (y0 / (y - y0)) >= 0 && (z0 / (z - z0)) < 0) {
				cout << 1 / (x - x0) << "x-" << x0 / (x - x0) << "=" << 1 / (y - y0) << "y-" << y0 / (y - y0) << "=" << 1 / (z - z0) << "z+" << -z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) < 0 && (y0 / (y - y0)) < 0 && (z0 / (z - z0)) >= 0) {
				cout << 1 / (x - x0) << "x+" << -x0 / (x - x0) << "=" << 1 / (y - y0) << "y+" << -y0 / (y - y0) << "=" << 1 / (z - z0) << "z-" << z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) < 0 && (y0 / (y - y0)) >= 0 && (z0 / (z - z0)) >= 0) {
				cout << 1 / (x - x0) << "x+" << -x0 / (x - x0) << "=" << 1 / (y - y0) << "y-" << y0 / (y - y0) << "=" << 1 / (z - z0) << "z-" << z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) < 0 && (y0 / (y - y0)) >= 0 && (z0 / (z - z0)) < 0) {
				cout << 1 / (x - x0) << "x+" << -x0 / (x - x0) << "=" << 1 / (y - y0) << "y-" << y0 / (y - y0) << "=" << 1 / (z - z0) << "z+" << -z0 / (z - z0);
			}
			else if ((x0 / (x - x0)) >= 0 && (y0 / (y - y0)) < 0 && (z0 / (z - z0)) >= 0) {
				cout << 1 / (x - x0) << "x-" << x0 / (x - x0) << "=" << 1 / (y - y0) << "y+" << -y0 / (y - y0) << "=" << 1 / (z - z0) << "z-" << z0 / (z - z0);
			}

			break;
		case 8:cout << "Coordinates of directional vector (x,y,z):" << endl;
			cin >> x0 >> y0 >> z0;
			cout << "Normal vector of the plane coordinates (x,y,z):" << endl;
			cin >> x >> y >> z;
			system("cls");
			double hangle;
			hangle = asin(sqrt((x*x0 + y*y0 + z*z0)*(x*x0 + y*y0 + z*z0)) / sqrt(x*x + y*y + z*z)*sqrt(x0*x0 + y0*y0 + z0*z0))*180.0 / PI;
			if (hangle == 90) {

				cout << "Parallel";
			}
			else if (hangle == 0) {
				cout << "Perpendicular";
			}
			else {
				cout << "alpha = " << hangle;
			}
			break;
		default:cout << "Select the existing number from the table, thank's!" << endl;
			cout << "Try once more.";
		}
		ink = 0;
		cout << "				continue? press 1" << endl;;
		cin >> ink;
		system("cls"); // clears the screen * Оч. скрин
	}

	// debug point
	return 0;
}
