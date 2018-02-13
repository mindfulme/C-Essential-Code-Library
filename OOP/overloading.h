class Default {
    public:
    int numb;
    Default(){}
    Default(int a):numb(a)
    {

    }
    Default operator + (Default &object)
    {
        Default resource;
        resource.numb=this->numb+object.numb;
        return resource;
    }
    
};