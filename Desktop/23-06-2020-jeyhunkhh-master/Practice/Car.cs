using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Car
    {
        public double CurrentFuel { get; private set; }
        public double FuelUsage { get; private set; }
        public double FuelCapacity { get; private set; }
        public double LocalKm { get; private set; }
        public double GlobalKm { get; private set; }

        public Car(double fuelUsage,double fuelCapacity)
        {
            this.FuelUsage = fuelUsage;
            this.FuelCapacity = fuelCapacity;

            this.CurrentFuel = this.FuelCapacity * 0.05;
        }

        public bool Drive(double km)
        {
            double usageLitr = this.FuelUsage * km / 100;

            if (usageLitr > this.CurrentFuel) return false;

            this.CurrentFuel -= usageLitr;
            this.GlobalKm += km;
            this.LocalKm += km;
            return true;
        }

        public bool AddFuel(double litr)
        {
            if (this.CurrentFuel + litr > this.FuelCapacity) return false;

            this.CurrentFuel += litr;
            return true;
        }

        public void ResetLocalKm()
        {
            this.LocalKm = 0;
        }
    }
}
