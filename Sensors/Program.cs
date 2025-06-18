using Sensors.Game;
using Sensors.Iranian_agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IranAgent agent = new IranAgent();
            GameManeger game = new GameManeger(agent);
            var sensor = game.ThisSensor();

            //agent.PrintWeaknessesCount();



        }
    }
}
