using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sensors.Sensor;

namespace Sensors.Game
{
    internal class Game
    {
        public Game() 
        {
            Console.WriteLine("Welcome to the interrogation room:");
            Console.WriteLine("You are now interrogating investigator Ahmed in room 9.");
            Console.WriteLine("Please enter the type of sensor you would like to pair.");
            string sensorType = Console.ReadLine();

            if (sensorType == "Termi")
            {
                var termiSensor =  new Sensor.Termi(sensorType);
            }
            else
            {
                var basic = new Sensor.Basic(sensorType);
            }
        }
    }
}
