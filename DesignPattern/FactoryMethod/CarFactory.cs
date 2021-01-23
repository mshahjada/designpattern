using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class CarFactory : VehicleFactory
    {
        private readonly string _cc;
        private readonly int _gears;
        private readonly int _maxSpeed;
        public CarFactory(string cc, int gears, int maxSpeed)
        {
            _cc = cc;
            _gears = gears;
            _maxSpeed = maxSpeed;
        }
        public override Vehicle GetVehicle()
        {
            return new Car(_cc, _gears, _maxSpeed);
        }
    }
}
