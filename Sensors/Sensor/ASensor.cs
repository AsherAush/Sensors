using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.Sensor
{
    public class ASensor
    {
        public string Name { get; }
        public bool Activat { get; private set; }

        public ASensor(string name)
        {
            Name = name;
            Activat = false;
            ActivatSensor();
        }

        public void ActivatSensor()
        {
            Activat = true;
        }
    }
}
