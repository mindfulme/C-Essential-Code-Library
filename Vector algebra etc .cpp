// Written by Rostisval Gogolauri /2017/ C++
// *** GNU License ***

#include "stdafx.h"
#include <iostream>
#include <conio.h>

using namespace std;

int main()
{
	float x0, x, y0,y,z0,z,cVector1,cVector2; // cVector1,cVector2 are vector coordinates
	system("Color f0"); // change color and background of console

	cout << "Choise one statement wich you need to solve" << endl;
	cout << "1: Vector equation of line  "<<endl;			   //-Векторне рівняня прямої
	cout << "2: Normal equation of line" << endl;			   // Нормальне рівняня прямої
	cout << "3: General equation of line" << endl;			   // Загальне рівняня прямої
	cout << "4: Distance from dot to line" << endl;			   //+Відстань від точки до прямої
	cout << "5: Projection of Vector on other Vector" << endl; // Проекція вектора на вектор
	cout << "6: Distance from dot to area" << endl;			   // Відстань від точки до площини
	cout << "7: Cosine of angle beetween vectors" << endl;	   // Косинус кута між двома векторами (точне значенння)

	int caser;
	cin >> caser;
	
		switch (caser) {
		case 1:cout << "First point (x0,y0): ";
			cin >> x0 >> y0;
			cout << "Second point (x,y): ";
			cin >> x >> y;
			cout << "Vector coordinates (c1,c2): ";
			cin >> cVector1 >> cVector2;
			cout << (x - x0) / cVector1 << " = " << (y - y0) / cVector2;
			break;
		case 2:;
			break;
		case 3:;
			break;
		case 4:cout << "(A,B,C are coefficients) Give me A : ";
			cin >> x;  // x = A
			cout << "Give me B: ";
			cin >> y; // y = B
			cout << "Give me C:";
			cin >> cVector1; // cVector=C
			cout << "Give me x0: ";
			cin >> x0;
			cout << "Give me y0: ";
			cin >> y0;
			cout << "Distance is " << (x*x0 + y0*y + cVector1) / sqrt(x*x + y*y);
			break;
		case 5:cout<<"Give me coordinates of first vector x0, y0,z0: ";
			cin >> x0 >> y0>>z0;
			cout << "Give me coordinates of second vector x, y, z: ";
			cin >> x >> y>>z;
			cout << "Projection of Second vector on First is "<<(x0*x+y*y0+z*z0)/sqrt(x*x+y*y+z*z);
			break;
		case 6:;
			break;
		case 7:;
			break;
		default:cout << "Select existing number from table, thank's!" << endl;
			cout << "Now reopen please.";
		}
	
	getch();
    return 0;
}

