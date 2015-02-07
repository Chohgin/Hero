using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class SuperHero : Hero
    {
        private string[] superPowers;
        public SuperHero(string name) : base (name)
        {
            generateRandomPowers();
        }

        private void generateRandomPowers()
        {
            for (int i = 0; i < 300; i++)
            {
                Random power = new Random();
                int power1 = 0;
                int power2 = 0;
                int power3 = 0;
                while (power1 != power2 && power1 != power3 && power2 != power3)
                {
                    power1 = power.Next(1, 6);
                    power2 = power.Next(1, 6);
                    power3 = power.Next(1, 6);
                }
                Console.WriteLine("{0,5}{1,5}{2,5}", power1, power2, power3);
            }
        }

    }
}
