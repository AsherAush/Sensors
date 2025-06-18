using Sensors.Sensor;
using System;
using System.Collections.Generic;

namespace Sensors.Iranian_agent
{
    public class IranAgent
    {
        public string Name { get; }
        public List<string> Weaknesses { get; }
        public Dictionary<string, int> WeaknessesCount { get; }
        public List<ASensor> SensorsAgent { get; }
        public int MatchedSensorsCount { get; private set; }

        public IranAgent()
        {
            Random rand = new Random();
            List<string> Sensors = new List<string> { "Termi", "Basic" };
            string sensor1 = Sensors[rand.Next(Sensors.Count)];
            string sensor2 = Sensors[rand.Next(Sensors.Count)];

            Name = "achmed";
            Weaknesses = new List<string> { sensor1, sensor2 };
            WeaknessesCount = new Dictionary<string, int>();
            SensorsAgent = new List<ASensor>();
            MatchedSensorsCount = 0;

            foreach (var weakness in Weaknesses)
            {
                if (WeaknessesCount.ContainsKey(weakness))
                    WeaknessesCount[weakness]++;
                else
                    WeaknessesCount[weakness] = 1;
            }
        }

        public void AddSensor(ASensor sensor)
        {
            if (WeaknessesCount.ContainsKey(sensor.Name) && WeaknessesCount[sensor.Name] > 0)
            {
                WeaknessesCount[sensor.Name]--;
                MatchedSensorsCount++;
                SensorsAgent.Add(sensor);

                Console.WriteLine($"{MatchedSensorsCount}/2 sensors matching Agent {Name} weaknesses were found.");

                if (MatchedSensorsCount == 2)
                {
                    Console.WriteLine($"Agent {Name} exposed!");
                }
            }
            else
            {
                Console.WriteLine($"Sensor {sensor.Name} is not effective against Agent {Name}.");
            }
        }
    }
}
