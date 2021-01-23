using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class BikeFactory:VehicleFactory
    {
        private readonly string _cc;
        private readonly int _gears;
        private readonly int _maxSpeed;
        public BikeFactory(string cc, int gears, int maxSpeed)
        {
            _cc = cc;
            _gears = gears;
            _maxSpeed = maxSpeed;
        }
        public override Vehicle GetVehicle()
        {
            return new Bike(_cc, _gears, _maxSpeed);
        }
    }
}
