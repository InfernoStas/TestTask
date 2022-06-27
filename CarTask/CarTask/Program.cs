using System;

namespace CarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = 100;
            
            var vehicle = new Vehicle { AverageFuelConsumption = 6, FullTankValue = 52 , TankValue = 40.3, Speed = 140};
            Console.WriteLine(vehicle.Type);
            Console.WriteLine($"Average fuel consumption : {vehicle.AverageFuelConsumption} liters/100km");
            Console.WriteLine($"Distance with full tank ({vehicle.FullTankValue} liters) : {vehicle.GetDistanceWithFullTank().ToString("#.##")}km");
            Console.WriteLine($"Distance with current tank ({vehicle.TankValue} liters) : {vehicle.GetDistanceWithCurrentTank().ToString("#.##")}km");
            Console.WriteLine($"Time with current speed({vehicle.Speed}kmph) and tank({vehicle.TankValue} liters) : {TimeSpan.FromHours(vehicle.GetCurrentDistanceTime())}");
            Console.WriteLine($"Time with {distance}km and current speed({vehicle.Speed}kmph) : {TimeSpan.FromHours(vehicle.GetDistanceTime(distance))}");
            Console.WriteLine();

            var car = new Car { AverageFuelConsumption = 7, FullTankValue = 60, TankValue = 33.5, MaxSpeed = 180, Speed = 90, PassengersNumber = 2 };
            Console.WriteLine(car.Type);
            Console.WriteLine($"Average fuel consumption : {car.AverageFuelConsumption} liters/100km");
            Console.WriteLine($"Passengers nubmer : {car.PassengersNumber}");
            Console.WriteLine($"Distance with full tank ({car.FullTankValue} liters) : {car.GetDistanceWithFullTank().ToString("#.##")}km");
            Console.WriteLine($"Distance with current tank ({car.TankValue} liters) : {car.GetDistanceWithCurrentTank().ToString("#.##")}km");
            Console.WriteLine($"Time with current speed({car.Speed}kmph) and tank({car.TankValue} liters) : {TimeSpan.FromHours(car.GetCurrentDistanceTime())}");
            Console.WriteLine($"Time with {distance}km and current speed({car.Speed}kmph) : {TimeSpan.FromHours(car.GetDistanceTime(distance))}");
            Console.WriteLine();

            var lorry = new Lorry { AverageFuelConsumption = 12, FullTankValue = 70, TankValue = 40.3, MaxSpeed = 150, Speed = 80, LoadValue = 1000 };
            Console.WriteLine(lorry.Type);
            Console.WriteLine($"Load weight : {lorry.LoadValue} kg");
            Console.WriteLine($"Average fuel consumption : {lorry.AverageFuelConsumption} liters/100km");
            Console.WriteLine($"Distance with full tank ({lorry.FullTankValue} liters) : {lorry.GetDistanceWithFullTank().ToString("#.##")}km");
            Console.WriteLine($"Distance with current tank ({lorry.TankValue} liters) : {lorry.GetDistanceWithCurrentTank().ToString("#.##")}km");
            Console.WriteLine($"Time with current speed({lorry.Speed}kmph) and tank({lorry.TankValue} liters) : {TimeSpan.FromHours(lorry.GetCurrentDistanceTime())}");
            Console.WriteLine($"Time with {distance}km and current speed({lorry.Speed}kmph) : {TimeSpan.FromHours(lorry.GetDistanceTime(distance))}");
            Console.WriteLine();

            var sportCar = new SportCar { AverageFuelConsumption = 15, FullTankValue = 40, TankValue = 40, MaxSpeed = 400, Speed = 300};
            Console.WriteLine(sportCar.Type);
            Console.WriteLine($"Average fuel consumption : {sportCar.AverageFuelConsumption} liters/100km");
            Console.WriteLine($"Distance with full tank ({sportCar.FullTankValue} liters) : {sportCar.GetDistanceWithFullTank().ToString("#.##")}km");
            Console.WriteLine($"Distance with current tank ({sportCar.TankValue} liters) : {sportCar.GetDistanceWithCurrentTank().ToString("#.##")}km");
            Console.WriteLine($"Time with current speed({sportCar.Speed}kmph) and tank({sportCar.TankValue} liters) : {TimeSpan.FromHours(sportCar.GetCurrentDistanceTime())}");
            Console.WriteLine($"Time with {distance}km and current speed({sportCar.Speed}kmph) : {TimeSpan.FromHours(sportCar.GetDistanceTime(distance))}");
            Console.WriteLine();

        }
    }
}
