using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower{ get; }

        public override int Health
        {
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health = value;
            }
        }
        public override float Cost
        {
            get
            {
                return AttackPower + XP;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower}";
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Unit attackedUnit)
        {
            XP++;
            attackedUnit.Health -= AttackPower;
        }
    }
}