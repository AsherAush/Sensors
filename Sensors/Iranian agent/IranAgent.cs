using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sensors.Sensor;

namespace Sensors.Iranian_agent
{
    internal class IranAgent
    {

        public string Name { get; }
        public List<string> Weaknesses{get; }
        public List<ASensor> SensorsAgent { get; }

        public IranAgent()
        {
        // משתנה לרנדום 
        Random rands = new Random();
        // סוגי החולשות
        List <string> Sensors = new List<string> { "Termi", "Basic"};
        string sensor1 = Sensors[rands.Next(Sensors.Count)];
        string sensor2 = Sensors[rands.Next(Sensors.Count)];
            Name = "achmed";
            Weaknesses = new List<string>{sensor1,sensor2}; 
            SensorsAgent = new List<ASensor> ();
        }

    }
}
