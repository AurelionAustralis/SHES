using Common.SHES_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ElementLists
{
    public class BatteryList
    {
        public List<Battery> List { get; set; }
        public BatteryList()
        {
            List = new List<Battery>();
        }

        public double Consume()
        {
            double retVal = 0;
            foreach(var battery in List)
            {
                retVal -= battery.MaxPower / (battery.Capacity * 60);
            }
            return retVal;
        }

        public double Generate()
        {
            double retVal = 0;
            foreach (var battery in List)
            {
                retVal += battery.MaxPower / (battery.Capacity * 60);
            }
            return retVal;
        }

    }
}
