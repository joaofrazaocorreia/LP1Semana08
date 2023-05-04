using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit()
        {
            base(movement) = 1;
            base(Health) = 2;
            Cost = 5;

        }
        public void Settle(Vector2 location)
        {

        }
    }
}