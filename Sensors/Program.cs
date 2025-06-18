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
            int totalMatches = 0;
            const int max = 2;
            while (totalMatches < max)
            {
                GameManeger game = new GameManeger(agent);
                //    var sensor = game.ThisSensor();
                //    agent.AddSensor(sensor);

                //    AgentInvestigation investigation = new AgentInvestigation(agent.Name, agent.WeaknessesCount, agent.SensorsAgent);
                //    totalMatches = investigation.countmatching;

                //    Console.WriteLine("\nPress any key to continue...");
                //    Console.ReadKey();
                //    Console.Clear();
                //}

                //Console.WriteLine("Game Over. Agent exposed.");
            }
        }
    }
}
