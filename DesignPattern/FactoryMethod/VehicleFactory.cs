using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle GetVehicle();
    }
}
