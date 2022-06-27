using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class Lorry: Vehicle
    {
        public new readonly string Type = "Lorry";
        private const int limitLoadValue = 5000;
        //kg
        private int maxLoadValue = limitLoadValue;
        public int MaxLoadValue
        {
            get => maxLoadValue;

            set
            {
                if (value >= limitLoadValue)
                {
                    throw new ArgumentException($"Max Load value can't be more then {limitLoadValue}.");
                }
                else
                {
                    maxLoadValue = value;
                }
            }
        }

        //200 kg make distance decrease by 10% -> 1 kg - 0.02%
        private const double loadFactor = 0.02;
        //Value of current load (kg)
        private int loadValue;
        public int LoadValue
        {
            get => loadValue;

            set
            {
                if (value >= maxLoadValue)
                {
                    throw new ArgumentException($"Load value must be less then {maxLoadValue}.");
                }
                else
                {
                    loadValue = value;
                }
            }
        }

        public new double GetDistanceWithFullTank()
        {
            return (this.FullTankValue * 100 / this.AverageFuelConsumption) * (1 - LoadValue * loadFactor / 100.0);
        }

        public new double GetDistanceWithCurrentTank()
        {
            return (this.TankValue * 100 / this.AverageFuelConsumption) * (1 - LoadValue * loadFactor / 100.0);
        }
    }
}
