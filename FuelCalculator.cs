#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Assignment3
{
    class FuelCalculator
    {
        private double currentReading;
        private double previousReading;
        private double fuelAmount;
        private double unitPrice;
        private double consumption;
        private double distanceTraveled;

        public FuelCalculator()
        {

        }

        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        public double GetCurrentReading()
        {
            return currentReading;
        }

        public double GetPreviousReading()
        {
            return previousReading;
        }

        public double GetUnitPrice()
        {
            return unitPrice;
        }

        public void SetCurrentReading(double reading)
        {
            currentReading = reading;
        }

        public void SetFuelAmount(double fuel)
        {
            fuelAmount = fuel;
        }

        public void SetPreviousReading(double reading)
        {
            previousReading = reading;
        }

        public void SetUnitPrice(double price)
        {
            unitPrice = price;
        }

        public bool ValidateOdomoterValues()
        {
            return true;
        }

        public double CalculateConsumptionLiterPerKM()
        {
            CalculateDistanceTraveled();
            consumption = fuelAmount / distanceTraveled;

            return consumption;
        }

        public double CalculateConsumptionKMPerLiter()
        {
            CalculateDistanceTraveled();
            consumption = distanceTraveled / fuelAmount;

            return consumption;
        }

        public double CalculateDistanceTraveled()
        {
            distanceTraveled = (currentReading - previousReading);

            return distanceTraveled;
        }

        public double CalculateConsumptionLiterPerImperialMile()
        {
            const double kmToMileFactor = 0.621371192;
            consumption = CalculateDistanceTraveled() / kmToMileFactor;

            return consumption;
        }

        public double CalculateConsumptionLiterPerMetricMile()
        {
            consumption = CalculateConsumptionKMPerLiter() * 10;

            return consumption;
        }

        public double CalculateCostPerKmDriven()
        {
            consumption = CalculateConsumptionKMPerLiter() * unitPrice;

            return consumption;
        }
    }
}
