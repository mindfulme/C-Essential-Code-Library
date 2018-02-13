class MyFriend {
    public:
    MyFriend() {
        Var = 0;
    }
    private:
    int Var;
    
    friend void FUNC(MyFriend &obj);
};