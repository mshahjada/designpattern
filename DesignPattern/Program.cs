using DesignPattern.FactoryMethod;
using DesignPattern.PrototypePattern;
using System;

namespace DesignPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            //SingletoneImp();

            //FactoryMethod();


            // PrototypePattern();
            Console.WriteLine(DateTime.Now.ToString("yy"));

            Console.ReadKey();
        }

        private static void SingletoneImp()
        {
            Console.WriteLine("------Singletone-------");

            Singletone singletone = Singletone.GetObject();

            singletone.Length = 10; singletone.Width = 5;
            Console.WriteLine($"Area: { singletone.GetArea() }");

        }

        private static void FactoryMethod()
        {
            Console.WriteLine("---------Factory Method Design Pattern--------\n");

            Console.WriteLine("Choose: \n1. Car\n2. Bike");

            string data = Console.ReadLine();

            VehicleFactory vehicleFactory = null;

            switch (data)
            {
                case "Car":
                    vehicleFactory = new BikeFactory("1500", 6, 200);
                    break;
                case "Bike":
                    vehicleFactory = new BikeFactory("150", 5, 130);
                    break;
                default:
                    break;
            }

            if (vehicleFactory != null)
            {
                var obj = vehicleFactory.GetVehicle();
                Console.WriteLine($"{data} has CC-{obj.CC}, Gears-{obj.Gears}, Max Speed-{obj.MaxSpeed}");
            }
            else
            {
                Console.WriteLine($"No info found for {data}");
            }


        }

        private static void PrototypePattern()
        {
            Console.WriteLine("Prototype Pattern");

            var obj = new StudentInfoFactory()
            {
                Name = "Mark",
                StudentId = "S001",
                Department = "CSE",
                Semester = "2nd",
                CourseInfo = new CourseInfo() { Name = "Data Structure", Code = "DS-001" }
            };

            var cloneobj = (StudentInfoFactory)obj.Clone();
            cloneobj.Name = "Jon";
            cloneobj.StudentId = "S002";



            Console.WriteLine($"Info " +
                $"{cloneobj.Name}, " +
                $"{cloneobj.StudentId}, " +
                $"{cloneobj.Department}, " +
                $"{cloneobj.Semester} ");


        }
    }
}
