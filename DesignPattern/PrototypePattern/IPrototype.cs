using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    public interface IPrototype<T> where T: class
    {
        IPrototype<T> Clone();
    }
}
