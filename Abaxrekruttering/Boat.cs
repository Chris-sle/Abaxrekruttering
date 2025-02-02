﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Boat : VehicleWithMaxSpeed
    {
        public int GrossTonnage { get; }

        public Boat(string regNo, int effect, int maxSpeed, int grossTonnage)
            : base(maxSpeed, regNo, effect, "knop")
        {
            GrossTonnage = grossTonnage;
        }

        public override void Run()
        {
            Console.WriteLine("Kjører båten");
        }

        public override void PrintInformation()
        {
            Console.WriteLine($" ** Båt ** ");
            base.PrintInformation();
            Console.WriteLine($" - Bruttotonnasje = {GrossTonnage}kg");
        }
    }
}
