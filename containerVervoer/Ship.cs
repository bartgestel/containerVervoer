using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containerVervoer
{
    public class Ship
    {
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int MaxWeight { get; private set; }
        public List<Container> Containers { get; private set; } = new List<Container>();
        public List<ContainerStack> ContainerStacks { get; private set; } = new List<ContainerStack>();
        public Ship(int width, int length, int maxWeight) 
        {
            Width = width;
            Length = length;
            MaxWeight = maxWeight;
        }

        public void AddContainer(Container container)
        {
            Containers.Add(container);
        }

        public bool LoadCargo()
        {
            if (checkWeight())
            {
                //sort containers into types
                

            }
            else
            {
                return false;
            }
        }

        public bool checkWeight()
        {
            int totalWeight = 0;
            foreach (Container c in Containers)
            {
                totalWeight += c.Weight;
            }
            if (totalWeight > MaxWeight)
            {
                return false;
            }
            else if(totalWeight > MaxWeight * 0.5)
            {
                return true;
            }else
            {
                return false;
            }
        }


    }
}
