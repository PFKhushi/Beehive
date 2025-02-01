using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    internal class Hive
    {
        private float honey = 25f;
        private float nectar = 100f;
        string statusReport { get; }

        public void CollectNectar(int amount)
        {
            honey += amount;
        }

        public void NectarToHoney()
        {
            nectar -= 1f;
            honey += 1.2f;
        }
        public bool ConsumeHoney(int amount)
        {
            if (amount < honey) 
            {
                honey -= amount;
                return true;
            }
            return false;
        }
    }
}
