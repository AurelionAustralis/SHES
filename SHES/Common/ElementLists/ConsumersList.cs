using Common.SHES_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ElementLists
{
    public class ConsumersList
    {
        public List<Consumer> List { get; set; }

        public ConsumersList()
        {
            List = new List<Consumer>();
        }

        public double Consume()
        {
            double retVal = 0;
            foreach (var consumer in List)
            {
                retVal -= consumer.Consumption;
            }
            return retVal;
        }
    }
}
