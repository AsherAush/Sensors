using System;
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

            bool sensorCreated = false;

            while (!sensorCreated)
            {
                Console.WriteLine("Please enter the type of sensor you would like to pair (Termi / Basic):");

                try
                {
                    string sensorType = Console.ReadLine();

                    switch (sensorType.ToLower())
                    {
                        case "termi":
                            thisSensor = new Termi(sensorType);
                            sensorCreated = true;
                            break;

                        case "basic":
                            thisSensor = new Basic(sensorType);
                            sensorCreated = true;
                            break;

                        default:
                            Console.WriteLine("Invalid sensor type. Try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            sochan.AddSensor(thisSensor);
        }

        //public ASensor ThisSensor()
        //{
        //    return thisSensor;
        //}
    }
}
