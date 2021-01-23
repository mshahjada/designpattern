using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    public class PrototypeFactory<T> : IPrototype<T> where T: class
    {
        public IPrototype<T> Clone()
        {
            return (IPrototype<T>)this.MemberwiseClone();
        }
    }
}
