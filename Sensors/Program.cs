using Sensors.Game;
using Sensors.Iranian_agent;
using System;

namespace Sensors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IranAgent agent = new IranAgent();

            while (agent.MatchedSensorsCount < 2)
            {
                new GameManeger(agent);
            }

            Console.WriteLine("Interrogation complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
