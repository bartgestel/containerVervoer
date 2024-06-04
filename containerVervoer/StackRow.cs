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

        public bool AddContainer(Container container)
        {
            List<ContainerStack> copy = new List<ContainerStack>(ContainerStacks);
            for (int i = 0; i < copy.Count; i++)
            {
                //if (copy[i].AddContainer(container))
                //{
                //    if (IsBalanced(copy))
                //    {
                //        ContainerStacks[i].AddContainer(container);
                //        return true;
                //    }
                //    else
                //    {
                //        copy[i].Containers.Remove(container);
                //    }
                //}
                if (ContainerStacks[i].AddContainer(container))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddLeftOverContainer(Container container)
        {
            List<ContainerStack> copy = new List<ContainerStack>(ContainerStacks);
            for (int i = 0; i < copy.Count; i++)
            {
                if (copy[i].AddLeftOverContainer(container))
                {
                    if (IsBalanced(copy))
                    {
                        ContainerStacks[i].AddLeftOverContainer(container);
                    }
                    else
                    {
                        copy[i].Containers.Remove(container);
                    }
                }
            }
        }

        public bool IsBalanced(List<ContainerStack> stacks)
        {
            int firstHalfWeight = 0;
            int secondHalfWeight = 0;
            int half = stacks.Count / 2;

            if (stacks.Count % 2 != 0)
            {
                half--;
            }
            
            for (int i = 0; i < half; i++)
            {
                firstHalfWeight += stacks[i].Weight;
            }
            
            for (int i = half; i < stacks.Count; i++)
            {
                secondHalfWeight += stacks[i].Weight;
            }
            
            int totalWeight = firstHalfWeight + secondHalfWeight;
            int difference = Math.Abs(firstHalfWeight - secondHalfWeight);
            
            return difference <= totalWeight * 0.2;
        }
}
}
