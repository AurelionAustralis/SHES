using Common.SHES_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Wrappers
{
    public class SolarPanelList
    {
        public List<SolarPanel> List { get; set; }
        public double SunPower { get; set; }

        public SolarPanelList()
        {
            List = new List<SolarPanel>();
        }

        public double Generate()
        {
            double retVal = 0;
            foreach (var solarPanel in List)
            {
                retVal += solarPanel.MaxPower * SunPower;
            }
            return retVal;
        }
    }
}
