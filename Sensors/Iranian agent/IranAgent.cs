using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sensors.Sensor;
using Sensors.Game;

namespace Sensors.Iranian_agent
{
    public class IranAgent
    {
        public string Name { get; }
        public List<string> Weaknesses { get; }
        public Dictionary<string, int> WeaknessesCount { get; }
        public List<ASensor> SensorsAgent { get; }

        public IranAgent()
        {
            // משתנה לרנדום 
            Random rands = new Random();

            // חולשות של הסוכן
            List<string> Sensors = new List<string> { "Termi", "Basic" };

            // בחירת חולשות רנדומליות
            string sensor1 = Sensors[rands.Next(Sensors.Count)];
            string sensor2 = Sensors[rands.Next(Sensors.Count)];

            Name = "achmed";
            Weaknesses = new List<string> { sensor1, sensor2 };
            SensorsAgent = new List<ASensor>();

            // יצירת המילון להחזקת החולשות שקיימות לו בפועל ולסכום אותם
            WeaknessesCount = new Dictionary<string, int>();
            foreach (var weakness in Weaknesses)
            {
                if (WeaknessesCount.ContainsKey(weakness))
                {
                    WeaknessesCount[weakness]++;
                }
                else
                {
                    WeaknessesCount[weakness] = 1;
                }
            }
        }

        // דחיפת הסנסור לרשימה
        public void AddSensor(ASensor sensor)
        {
            SensorsAgent.Add(sensor);
            //foreach (var c in SensorsAgent)
            //{

            //    Console.WriteLine($"Sensor {c.Name} was added to agent {Name}.");
            //}

        }
        // שליחה לחקירות 
        public void SendInvestigatiog()
        {

        }
    }


}

    // פונקציה להדפסת תוצאות לסקרנות
    //public void PrintWeaknessesCount()
    //{
    //    Console.WriteLine($"Agent: {Name}");
    //    foreach (var kvp in WeaknessesCount)
    //    {
    //        Console.WriteLine($"Weakness: {kvp.Key}, Count: {kvp.Value}");
    //    }
    //}


