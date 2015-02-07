using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class SuperHero : Hero
    {
        private string[] superPowers = {"Super Speed","Super Strength","Body Armour","Flight","Fire Generation","Weather Control"};
        public SuperHero(string name) : base (name)
        {
            generateRandomPowers(superPowers);
        }

        private void generateRandomPowers(string[] superPowers)
        {
            Random power = new Random();
            int powerNum1 = 0;
            int powerNum2 = 0;
            int powerNum3 = 0;
            powerNum1 = power.Next(1, 6);

            do
            {
                powerNum2 = power.Next(1, 6);
            } while (powerNum2 == powerNum1);
            do
            {
                powerNum3 = power.Next(1, 6);
            } while (powerNum3 == powerNum1 || powerNum3 == powerNum2);
            //Console.WriteLine("{0,5}{1,5}{2,5}", power1, power2, power3);

            string power1 = superPowers[powerNum1];
            string power2 = superPowers[powerNum2];
            string power3 = superPowers[powerNum3];
        }
        public void showPowers()
        {

        }

    }
}
