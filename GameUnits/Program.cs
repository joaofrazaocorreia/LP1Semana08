using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit[] unitList = new Unit[2];

            unitList[0] = new SettlerUnit();
            unitList[1] = new MilitaryUnit(2, 3, 1);

            for (int i = 0; i < unitList.Length; i++)
            {
                unitList[i].Move();
                Console.WriteLine("Health: "+ unitList[i].Health);
                Console.WriteLine("Cost: "+ unitList[i].Cost);
            }
        }
    }
}
