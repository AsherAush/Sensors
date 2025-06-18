using Sensors.Iranian_agent;
using Sensors.Sensor;
using System;

namespace Sensors.Game
{
    internal class GameManeger
    {
        public GameManeger(IranAgent agent)
        {
            Console.WriteLine("\nWelcome to the interrogation room:");
            Console.WriteLine("You are now interrogating investigator Ahmed in room 9.");

            ASensor selectedSensor = null;

            while (true)
            {
                Console.WriteLine("Please enter the type of sensor you would like to pair (Termi / Basic):");
                string sensorType = Console.ReadLine();

                switch (sensorType)
                {
                    case "Termi":
                        selectedSensor = new Termi(sensorType);
                        break;
                    case "Basic":
                        selectedSensor = new Basic(sensorType);
                        break;
                    default:
                        Console.WriteLine("Invalid sensor type. Please try again.\n");
                        continue; // חוזר לתחילת הלולאה
                }

                break; // יציאה מהלולאה אם הכל תקין
            }

            agent.AddSensor(selectedSensor);
        }
    }
}
