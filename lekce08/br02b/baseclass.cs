using System;
namespace br02;

public abstract class BaseClass
{
    private Guid _id;

    public BaseClass()
    {
        _id = Guid.NewGuid();
    }

    public Guid id 
    {
        get {return _id;}
        private set {value = _id;}
    }
}