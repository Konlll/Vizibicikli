using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._05._22
{
    internal class Kolcsonzes
    {
        string name;
        string vehicleId;
        int takeoutHour;
        int takeoutMinute;
        int takebackHour;
        int takebackMinute;

        public Kolcsonzes(string name, string vehicleId, int takeoutHour, int takeoutMinute, int takebackHour, int takebackMinute) {
            this.name = name;
            this.vehicleId  = vehicleId;
            this.takeoutHour = takeoutHour;
            this.takeoutMinute = takeoutMinute;
            this.takebackHour = takebackHour;
            this.takebackMinute = takebackMinute;
        }

        public string Name { get { return name; } }
        public string VehicleId { get {  return vehicleId; } }
        public int TakeoutHour { get { return takeoutHour; } }
        public int TakeoutMinute { get {  return takeoutMinute; } }
        public int TakebackHour { get { return takebackHour; } }
        public int TakebackMinute { get { return takebackMinute;  } }
        
    }
}
