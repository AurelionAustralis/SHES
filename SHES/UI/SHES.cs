using Common;
using Common.ElementLists;
using Common.SHES_Components;
using Common.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class SHES : BindableBase, ISHES 
    {
        private double currentPower;
        public double CurrentPower
        { get
            {
                return currentPower;
            }
            set
            {
                SetField(ref currentPower, value);
            }
        }

        public BatteryList Batteries { get; set; }
        public ConsumersList Consumers { get; set; }
        public SolarPanelList SolarPanels { get; set; }
        public Utility Utility { get; set; }

        public SHES()
        {
            CurrentPower = 0;
            Batteries = new BatteryList();
            Consumers = new ConsumersList();
            SolarPanels = new SolarPanelList();
            ShesDbContext context = new ShesDbContext();

            Batteries.List.AddRange(context.Battery.ToList());
            Consumers.List.AddRange(context.Consumers.ToList());
            SolarPanels.List.AddRange(context.SolarPanels.ToList());
            Utility = new Utility(15);

        }

    }
}
