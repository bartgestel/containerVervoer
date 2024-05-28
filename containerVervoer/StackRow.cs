using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containerVervoer
{
    public class StackRow
    {
        public List<ContainerStack> ContainerStacks { get; private set; } = new List<ContainerStack>();

        public StackRow(int width)
        {
            for (int i = 0; i < width; i++)
            {
                ContainerStacks.Add(new ContainerStack());
            }
        }

        public int GetWeight()
        {
            int weight = 0;
            foreach (ContainerStack stack in ContainerStacks)
            {
                weight += stack.Weight;
            }
            return weight;
        }
    }
}
