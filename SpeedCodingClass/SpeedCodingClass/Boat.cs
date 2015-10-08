using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClass
{
    public class Boat : Vehicle
    {
       
        public int NumberOfWheels
        {
            get { return 0; }   
        }        

        public string Honk()
        {
            return "I'm a boat!";
        }
    }
}
