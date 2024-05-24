using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containerVervoer
{
    public class ContainerStack
    {
        public List<Container> Containers { get; private set; } = new List<Container>();

        public int Weight { get; private set; } = 0;

        public bool canStack { get; private set; } = true;
        
        public bool AddContainer(Container container)
        {
            if (canStack)
            {
                if(ContainerWeightCheck(container))
                {
                    Containers.Add(container);
                    Weight += container.Weight;
                    if(container.Type == ContainerType.Valuable || container.Type == ContainerType.CooledValuable)
                    {
                        canStack = false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ContainerWeightCheck(Container container)
        {
            if (Containers.Count > 0)
            {
                int usedWeight = Weight - Containers[0].Weight;
                int containerWeight = container.Weight;
                if (usedWeight + containerWeight > 120000)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
