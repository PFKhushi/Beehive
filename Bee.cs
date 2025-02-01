using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    internal class Bee
    {
        string job;
        protected virtual float CostPerShift { get; set; }

        public void WorkNextShift()
        {

        }
        public virtual void DoJob()
        {

        }
        

    }
    class Queen : Bee
    {
        protected override float CostPerShift { get; set; }

        public void AssignBee() 
        {
            
        }
        public void LayEggs() 
        {
        }
        public override void DoJob()
        {

        }


    }
    class EggCare : Bee
    {
        public override void DoJob() 
        { 
        
        }
        
    }
    class HoneyMaking : Bee
    {
        public override void DoJob()
        {

        }
    }
    class NectarCollection : Bee
    {
        public override void DoJob()
        {

        }
    }
}
