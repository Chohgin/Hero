using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class SuperHero : Hero
    {
        //All powers
        private string[] superPowers = {"Super Speed","Super Strength","Body Armour","Flight","Fire Generation","Weather Control"};
      //Power holding point
        private string[] holding;
        //powers received
        private string[] finalPowers = new string[3];

       
            
        //SuperHero constructor
        public SuperHero(string name) : base (name)
        {
            //randomly generates the powers
            Random power = new Random();
            //Moves superPowers to the holding area    
            this.holding = new string[this.superPowers.Length];
               
             for (int i = 0; i < superPowers.Length; i++)
            {
                holding[i] = superPowers[i];
            }

            int randomPower;

            int count = 0;
            //determines which powers are received with no duplicates
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
        //generates the powers
        private int generateRandomPowers(Random power, int cap)
        {
                      
           
            int number;            

            number = power.Next(cap);
            return number;               
                  
            }
        //displays the powers
        public void showPowers()
        {
            Console.WriteLine("++++++++++++++");
            for (int i = 0; i < 3;i++)
            {
                Console.WriteLine("Power {1}: {0}",finalPowers[i],i+1);
            }
            
        }
         
        }


        
    

    }

