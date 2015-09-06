using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Components.Wheels;

using EnigmaMachine;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var wheel = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            while (true)
            {
                var mapping = Console.ReadLine().ToCharArray();

                if (mapping.Length != 26)
                {
                    Console.WriteLine("Bad Mapping");
                    continue;
                }

                Console.Clear();
                for (int i = 0; i < 26; i++)
                {
                    Console.WriteLine("new CylinderWire('{0}',{1}),", wheel[i], wheel.IndexOf(mapping[i]));
                }

            }

            //var machine = new SteckerbrettM3()
            //{
            //    Wheel0 = new E1I(0),
            //    Wheel1 = new E1II(0),
            //    Wheel2 = new E1III(0)
            //};

            //var aIsDone = false;
            //var aRestarted = false;

            //while (true)
            //{
            //    Console.WriteLine("{0}-{1}-{2}", machine.Wheel2, machine.Wheel1, machine.Wheel0);
            //    //Console.ReadLine();
            //    //Console.CursorTop--;
            //    machine.Wheel0.Up();
            //    if (!aIsDone && machine.Wheel2.ToString() != "A") aIsDone = true;
            //    else if (aIsDone && !aRestarted && machine.Wheel2.ToString() == "A")
            //    {
            //        aIsDone = false;
            //        aRestarted = true;
            //    }
            //    else if (aIsDone && aRestarted && machine.Wheel2.ToString() == "A") break;
            //}
            //Console.Read();
        }
    }
}
