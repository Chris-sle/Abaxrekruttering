using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Car : VehicleWithMaxSpeed
    {
        
        public Car(string registrationNumber, int effectInKw, int topSpeed, string paintColor, string typeOfVehicle) 
            : base(registrationNumber, effectInKw, topSpeed, paintColor, typeOfVehicle)
        {
        }

        public void Drive()
        {
            Action<string> printWithDelay = (message) =>
            {
                Console.WriteLine(message);
                Thread.Sleep(1000); // 1 second delay
            };

            bool isDriving = true;

            while (isDriving)
            {
                printWithDelay("Leaving parking lot.");
                printWithDelay("Driving off.");
                printWithDelay("Driving to destination.");
                printWithDelay("Starting to near destination.");
                printWithDelay("Arrived and parked.");

                isDriving = false;
            }
        }
    }
}
