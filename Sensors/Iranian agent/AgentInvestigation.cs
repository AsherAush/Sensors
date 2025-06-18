//using Sensors.Sensor;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sensors.Iranian_agent
//{
//    internal  class AgentInvestigation
//    {
//        public int countmatching;
//        public AgentInvestigation(string name, Dictionary<string, int> weaknessesCount, List<ASensor> sensorsAgent)
//        {
//            countmatching = 0;
//            foreach (var sensor in sensorsAgent)
//            {
//                if (weaknessesCount.ContainsKey(sensor.Name) && weaknessesCount[sensor.Name] > 0)
//                {
//                    weaknessesCount[sensor.Name]--;
//                    countmatching++;
//                    if (countmatching == 1)
//                    {
//                        Console.WriteLine($"1/2 sensors matching Agent {name} weaknesses were found.");
//                    }
//                    else if (countmatching == 2)
//                    {

//                        Console.WriteLine($"2/2 sensors matching Agent {name} weaknesses were found.");
//                        Console.WriteLine($"Agent {name} exposed");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("No matched sensors found.");
//                    }
//                }
//                else
//                {
//                    if (countmatching == 1)
//                    {
//                        Console.WriteLine($"1/2 sensors matching Agent {name} weaknesses were found.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("No matched sensors found.");
//                    }


//                }
//            }
//        }
//    }
//}
