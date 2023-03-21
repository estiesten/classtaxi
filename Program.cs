using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace classtaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek taxi
            taxi taxi = new taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.Onduty = true;
            taxi.NumPassenger = 10;

            // pangggilan method
            taxi.TaxiInfo();

            Console.WriteLine();

            taxi.PickUpPassanger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
