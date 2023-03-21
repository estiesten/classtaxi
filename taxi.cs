using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtaxi
{
    public class taxi
    {
        // properties
        public string DriverName { get; set; }
        public Boolean Onduty { get; set; }
        public int NumPassenger { get; set; }

        // method

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (Onduty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else if (Onduty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Num Passenger : {0}", NumPassenger);
        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
