class Destructor {
    public:
    Destructor();
    ~Destructor();
    
     void DisposeObject()
        {
           delete this;
        }
};