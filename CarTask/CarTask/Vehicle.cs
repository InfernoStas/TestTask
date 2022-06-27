
namespace CarTask
{
    class Vehicle
    {
        public readonly string Type = "Vehicle";
        //liter/100km
        public double AverageFuelConsumption { get; set; }
        //Value of full tank (liters)
        public double FullTankValue { get; set; }
        //Current value of tank (liters)
        private double tankValue;
        public double TankValue
        {
            get => tankValue;
            set
            {
                if (value > FullTankValue)
                {
                    tankValue = FullTankValue;
                }
                else
                {
                    tankValue = value;
                }
            }
        }

        //Max speed value (kmph)
        public double MaxSpeed { get; set; } = 500;

        //Current speed(kmph)
        protected double speed;
        public double Speed 
        {
            get => speed;
            set
            {
                if (value > MaxSpeed)
                {
                    speed = MaxSpeed;
                }
                else
                {
                    speed = value;
                }
            } 
        }


        public double GetDistanceWithFullTank()
        {
            return FullTankValue * 100 / AverageFuelConsumption;
        }

        public double GetDistanceWithCurrentTank()
        {
            return TankValue * 100 / AverageFuelConsumption;
        }

        public double GetCurrentDistanceTime()
        {

            return GetDistanceWithCurrentTank() / Speed;
        }

        public double GetDistanceTime(double distance)
        {
            if (distance < 0)
            {
                return 0;
            }
            else
            {
                return distance / Speed;
            }
        }
    }
}
