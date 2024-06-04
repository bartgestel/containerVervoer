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

        public override string ToString()
        {
            string containerString = "";
            foreach (Container c in Containers)
            {
                containerString += c.Weight + " ";
            }
            return $"Weight: {Weight}, Containers: {Containers.Count}";
        }
        
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
            }
            return false;
        }
        
        public bool AddLeftOverContainer(Container container)
        {
            if (canStack)
            {
                int usedWeight = Weight - Containers[0].Weight;
                int containerWeight = container.Weight;
                if (!(usedWeight + containerWeight > 120000))
                {
                    Containers.Add(container);
                    Weight += container.Weight;
                    return true;
                }
            }
            return false;
        }

        public bool ContainerWeightCheck(Container container)
        {
            if (Containers.Count > 0)
            {
                if(container.Type == ContainerType.Valuable || container.Type == ContainerType.CooledValuable)
                {
                    int usedWeight = Weight - Containers[0].Weight;
                    int containerWeight = container.Weight;
                    if (!(usedWeight + containerWeight > 120000))
                    {
                        return true;
                    }
                }
                else
                {
                    int usedWeight = Weight - Containers[0].Weight;
                    int containerWeight = container.Weight;
                    if (!(usedWeight + containerWeight > 90000))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }

            return false;
        }
    }
}
