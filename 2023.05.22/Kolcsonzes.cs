using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2023._05._22
{
    internal class Kolcsonzes
    {
        string name;
        char vehicleId;
        int takeoutHour;
        int takeoutMinute;
        int takebackHour;
        int takebackMinute;

        public Kolcsonzes(string name, char vehicleId, int takeoutHour, int takeoutMinute, int takebackHour, int takebackMinute) {
            this.name = name;
            this.vehicleId  = vehicleId;
            this.takeoutHour = takeoutHour;
            this.takeoutMinute = takeoutMinute;
            this.takebackHour = takebackHour;
            this.takebackMinute = takebackMinute;
        }

        public Kolcsonzes(string csvRow)
        {
            var fields = csvRow.Split(';');
            this.name = fields[0];
            this.vehicleId = fields[1][0];
            this.takeoutHour = int.Parse(fields[2]);
            this.takeoutMinute = int.Parse(fields[3]);
            this.takebackHour = int.Parse(fields[4]);
            this.takebackMinute = int.Parse(fields[5]);
        }

        public string Name { get { return name; } }
        public char VehicleId { get {  return vehicleId; } }
        public int TakeoutHour { get { return takeoutHour; } }
        public int TakeoutMinute { get {  return takeoutMinute; } }
        public int TakebackHour { get { return takebackHour; } }
        public int TakebackMinute { get { return takebackMinute;  } }
        

        public int TimeDistance()
        {
            return takebackHour * 60 + takebackMinute-takeoutHour*60+takeoutMinute;
        }

    }
}
