using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover lunokhod = new Rover("Lunokhod 1", 1970);
            Rover apollo = new Rover("Apollo 15", 1971);
            Rover sojourner = new Rover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = { lunokhod, apollo, sojourner };

            DirectAll(rovers);
            Object[] probes = { lunokhod, apollo, sojourner, sputnik };
            foreach (Object obj in probes)
            {
                Console.WriteLine($"Tracking a {obj.GetType()}...");
            }

            IDirectable[] directables = { lunokhod, apollo, sojourner, sputnik };
            DirectAll(directables);
        }


        public static void DirectAll(IDirectable[] r)
        {
            foreach (IDirectable i in r)
            {
                Console.WriteLine(i.GetInfo());
                Console.WriteLine(i.Explore());
                Console.WriteLine(i.Collect());
            }
        }
    }
}
