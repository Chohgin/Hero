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
      
        private string[] holding;

        private string[] finalPowers = new string[3];

       
            

        public SuperHero(string name) : base (name)
        {
            Random power = new Random();
            this.holding = new string[this.superPowers.Length];
                        
             for (int i = 0; i < superPowers.Length; i++)
            {
                holding[i] = superPowers[i];
            }

            int randomPower;

            int count = 0;

            while (count < finalPowers.Length)
            {
                randomPower = generateRandomPowers(power, superPowers.Length);

                if (holding[randomPower] != "taken")
                {
                    finalPowers[count] = holding[randomPower];

                    holding[randomPower] = "taken";

                    count++;
                }

            }

        }

        private int generateRandomPowers(Random power, int cap)
        {
                      
           
            int number;            

            number = power.Next(cap);
            return number;               
                  
            }

        public void showPowers(string finalPowers)
        {
            Console.WriteLine("++++++++++++++");
            for (int i = 1; i <=3;i++)
            {
                Console.WriteLine("Power 1: {0}",finalPowers[i]);
            }
            
        }
         
        }


        
    

    }

