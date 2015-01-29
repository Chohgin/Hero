using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class Hero
    {
        private int speed;
        private int strength;
        private int health;
        public string name;

        //Constructor
        public Hero(string name)
        {
            this.name = name;
            generateAbility();

        }
        //Generates random stats
        public void generateAbility()
        {
            Random stat = new Random();
            //for (int i = 0; i <= 100; i++)
            //{
                this.speed = stat.Next(0, 100);
                this.strength = stat.Next(0, 100);
                this.health = stat.Next(0, 100);
                //Console.WriteLine("stats: Speed: {0}, Strength: {1}, Health: {2}", speed, strength, health);
            //}
            
        }

        public void fight()
        {
            bool hit;
            hit = hitAttempt();

            if (hit = true)
            {
                int damage = hitDamage();
                Console.WriteLine("{0} hit the enemy for {1} points", this.name, damage);
            }
            else
            {
                Console.WriteLine("{0} missed.", this.name);
            }
        }
        private bool hitAttempt()
        {
            bool hit = false;
            Random strike = new Random();
            int shot = strike.Next(1, 5);

            if (shot == 1)
            {
                hit = true;
            }
            else
            {
                hit = false;
            }
            return hit;
        }

        private int hitDamage()
        {
            Random multiplier = new Random();
            int damage = 0;

            damage = this.strength * multiplier.Next(1, 6);

            return damage;
        }
    }
}
