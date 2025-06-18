using Sensors.Sensor;
using System;
using System.Collections.Generic;

public class IranAgent
{
    public string Name { get; }
    public List<string> Weaknesses { get; }
    public Dictionary<string, int> WeaknessesCount { get; }
    public List<ASensor> SensorsAgent { get; }

    public IranAgent()
    {
        Random rands = new Random();
        List<string> Sensors = new List<string> { "Termi", "Basic" };

        string sensor1 = Sensors[rands.Next(Sensors.Count)];
        string sensor2 = Sensors[rands.Next(Sensors.Count)];

        Name = "achmed";
        Weaknesses = new List<string> { sensor1, sensor2 };
        SensorsAgent = new List<ASensor>();
        WeaknessesCount = new Dictionary<string, int>();

        foreach (var weakness in Weaknesses)
        {
            if (!WeaknessesCount.ContainsKey(weakness))
                WeaknessesCount[weakness] = 1;
            else
                WeaknessesCount[weakness]++;
        }

    }

    public void AddSensor(ASensor sensor)
    {
        SensorsAgent.Add(sensor);
    }
}
