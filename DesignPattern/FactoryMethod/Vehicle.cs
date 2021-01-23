using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public abstract class Vehicle
    {
        public abstract string CC { get; set; }
        public abstract int Gears { get; set; }
        public abstract int MaxSpeed { get; set; }
    }
}
