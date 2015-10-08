using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClass
{
    public class Truck : Vehicle
    {

        public int NumberOfWheels
        {
            get { return 4; }
        }

        public string Honk()
        {   
            return "I'm a truck!";
        }
    }
}
