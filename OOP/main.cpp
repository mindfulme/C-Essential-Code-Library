#include "iostream"
#include "string"
#include "destructClass.h"
#include "friend.h"
#include "overloading.h"

using namespace std;

Destructor::Destructor()
{
    cout<<"Constructor"<<endl;
}
Destructor::~Destructor()
{
    cout<<"Destructor"<<endl;
}

class BankAccount {
    public:
    void sayHi (string word ) {
        cout<<word;
    }
};

class Money {
public:
float doubler(int value) {
    return (float)value*2.532;
    }
};

class Name {
    public:
    void setName(string ecs) {
        name = ecs;
    }
    string getName ()
    {
        return name;
    }
    private:
    string name;
};

class Member {
    public:
    Member(int a, int b)
    :first(a),secondConst(b)
    {
        cout<<first<<"\n"<<secondConst<<endl;
    }
    private:
    int first;
    const int secondConst;
};



void FUNC(MyFriend &obj)
{
    obj.Var=5544;
    cout<<obj.Var<<endl;
}

class That {
    public:
    That(int a):decim(a)
    {}
    void printer (){
        cout<<decim<<endl;
        cout<<this->decim<<endl;
        cout<<(*this).decim<<endl;
    }
    private:
    int decim;
};

int main ()
{   Destructor obj1;
    BankAccount call;
    Money dollar;
    Name first;
    Member numObjs(54,3);
    MyFriend obj;
    FUNC(obj);
    That newObj(33);
    newObj.printer();
    Default object1(114), object2(54);
    Default resource = object1+object2;
    cout<<resource.numb<<endl;
    call.sayHi("Yay!\n");
    int valv=0;
    cin>>valv;
    cout<<dollar.doubler(valv)<<endl;
    first.setName("Jack");
    cout<<first.getName()<<endl;
    return 0;
}