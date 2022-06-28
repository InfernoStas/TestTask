using System;

namespace CarTask
{
    class Car : Vehicle
    {
        public new readonly string Type = "Car";
        private const int maxPassengersNumber = 4;
        private int passengersNumber;
        public int PassengersNumber
        {
            get => passengersNumber;

            set
            {
                if(value > maxPassengersNumber)
                {
                    throw new ArgumentException("Only 4 passengers are allowed.");
                }
                else
                {
                    passengersNumber = value;
                }
            }
        }

        public new double GetDistanceWithFullTank()
        {
            return (FullTankValue * 100 / AverageFuelConsumption) * (1 - PassengersNumber * 6 / 100.0) ;
        }

        public new double GetDistanceWithCurrentTank()
        {
            return (TankValue * 100 / AverageFuelConsumption) * (1 - PassengersNumber * 6 / 100.0);
        }

        public new double GetCurrentDistanceTime()
        {

            return GetDistanceWithCurrentTank() / Speed;
        }
    }
}
