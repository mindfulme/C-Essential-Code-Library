#include "iostream"

using namespace std;

int factorial(int number) {
    if(number<=1)
        return 1;
    else 
        return number*factorial(number-1);
}

int main () {
    cout<<"Number:"<<endl;
    int number1=0;
    cin>>number1;
    cout<<"Factorial of the entered number is\n"<<factorial(number1)<<endl;
    return 0;
}