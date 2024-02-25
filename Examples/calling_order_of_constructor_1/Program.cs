
var derived = new DerivedClass();


class BaseClass 
{
    public BaseClass()
    {
        System.Console.WriteLine("Hello from BaseClass constructor");
    }
}

class DerivedClass : BaseClass
{
    public DerivedClass()
    {
        System.Console.WriteLine("Hello from DerivedClass constructor");
    } 
}


