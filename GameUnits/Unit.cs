using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        protected int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }
        public override string ToString()
        {
            return $"{GetType().Name} HP={Health} Cost={Cost.ToString("0.00")}";
        }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"The unit moved {movement} tiles!");
        }
    }
}