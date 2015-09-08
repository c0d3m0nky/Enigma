using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Components.Reflectors;
using Components.Wheels;

using EnigmaMachine;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var wheel = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //while (true)
            //{
            //    var mapping = Console.ReadLine().ToCharArray();

            //    if (mapping.Length != 26)
            //    {
            //        Console.WriteLine("Bad Mapping");
            //        continue;
            //    }

            //    Console.Clear();
            //    for (int i = 0; i < 26; i++)
            //    {
            //        Console.WriteLine("new CylinderWire('{0}',{1}),", wheel[i], wheel.IndexOf(mapping[i]));
            //    }

            //}

            var machine = new SteckerbrettM3(new E1I('A'), new E1II('A'), new E1III('A'), new UkwB());

            var cnt = 0;
            var processing = false;

            machine.LightLit += c =>
                                {
                                    Console.CursorTop = 1;
                                    Console.CursorLeft = cnt - 1;
                                    Console.Write(c);
                                    Console.CursorTop = 0;
                                    Console.CursorLeft = cnt;
                                };
            var key = Console.ReadKey();

            while (key.Key != ConsoleKey.Escape)
            {
                var c = key.KeyChar.ToString().ToUpper()[0];

                //Console.Write(c);
                cnt++;
                machine.SendInput(c);

                key = Console.ReadKey();
            }

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
