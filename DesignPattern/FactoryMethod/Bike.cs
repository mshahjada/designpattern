using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class Bike : Vehicle
    {
        private string _cc;
        private int _gears;
        private int _maxSpeed;
        public Bike(string cc, int gears, int maxSpeed)
        {
            _cc = cc;
            _gears = gears;
            _maxSpeed = maxSpeed;

        }


        public override string CC
        {
            get { return _cc; }
            set { _cc = value; }
        }

        public override int Gears
        {
            get { return _gears; }
            set { _gears = value; }
        }

        public override int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }
    }
}
