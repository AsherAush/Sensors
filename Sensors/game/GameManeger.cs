using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Sensors.Iranian_agent;
using Sensors.Sensor;

namespace Sensors.Game
{
    internal class GameManeger
    {
        ASensor thisSensor;
        public GameManeger(IranAgent sochan) 
        {
            Console.WriteLine("Welcome to the interrogation room:");
            Console.WriteLine("You are now interrogating investigator Ahmed in room 9.");
            Console.WriteLine("Please enter the type of sensor you would like to pair.");
            string sensorType = Console.ReadLine();
            if (sensorType == "Termi")
            {
                thisSensor =  new Sensor.Termi(sensorType);
            }
            else if (sensorType == "basic")
            {
                thisSensor = new Sensor.Basic(sensorType);
            }
            sochan.AddSensor(thisSensor);
        }
        public   ASensor ThisSensor()
        {
            return thisSensor;
        }


    }
}
