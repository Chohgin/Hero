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
        public void heroCreate(string name)
        {
            this.name = name;
            generateAbility();

        }
        //Generates random stats
        public void generateAbility()
        {
            Random stat = new Random();

            this.speed = stat.Next(0, 100);
            this.strength = stat.Next(0, 100);
            this.health = stat.Next(0, 100);
        }

    }
}
