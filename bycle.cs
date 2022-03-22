using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    internal class Bycle: IVehicle, IDrivable
    {
        public void Drive(double km);
        public double Millage { get; set; }
        public string Brand { get; set; }
       
        public string Military { get; set; }


    }
}
