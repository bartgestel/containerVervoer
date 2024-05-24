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
                var normalContainers = Containers.Where(c => c.Type == ContainerType.Normal).ToList();
                var valuableContainers = Containers.Where(c => c.Type == ContainerType.Valuable).ToList();
                var cooledContainers = Containers.Where(c => c.Type == ContainerType.Cooled).ToList();
                var cooledValuableContainers = Containers.Where(c => c.Type == ContainerType.CooledValuable).ToList();
                List<Container> leftOverContainers = new List<Container>();
                foreach(Container c in cooledContainers)
                {
                    if (!stackCheck())
                    {
                        ContainerStack stack = new ContainerStack();
                        stack.AddContainer(c);
                        ContainerStacks.Add(stack);
                        continue;
                    }
                    else
                    {
                        foreach(ContainerStack stack in ContainerStacks)
                        {
                            if (stack.ContainerWeightCheck(c))
                            {
                                int stackIndex = ContainerStacks.IndexOf(stack);
                                if (stackIndex > Width)
                                {
                                    return false;
                                }
                                else
                                {
                                    stack.AddContainer(c);
                                    continue;
                                }
                            }
                            else
                            {
                                if (AddStack(c))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                foreach (Container c in normalContainers)
                {
                    if (!stackCheck())
                    {
                        ContainerStack stack = new ContainerStack();
                        stack.AddContainer(c);
                        ContainerStacks.Add(stack);
                        continue;
                    }
                    else
                    {
                        foreach(ContainerStack stack in ContainerStacks)
                        {
                            if(stack.ContainerWeightCheck(c))
                            {
                                stack.AddContainer(c);
                                continue;
                            }
                            else
                            {
                                if(AddStack(c))
                                {
                                    continue;
                                }
                                else
                                {
                                    leftOverContainers.Add(c);
                                    continue;
                                }
                            }
                        }
                    }
                }
                foreach(Container c in cooledValuableContainers)
                {
                    if (!stackCheck())
                    {
                        ContainerStack stack = new ContainerStack();
                        stack.AddContainer(c);
                        ContainerStacks.Add(stack);
                        continue;
                    }
                    else
                    {
                        foreach (ContainerStack stack in ContainerStacks)
                        {
                            if (stack.ContainerWeightCheck(c))
                            {
                                int stackIndex = ContainerStacks.IndexOf(stack);
                                if (stackIndex > Width)
                                {
                                    return false;
                                }
                                else
                                {
                                    stack.AddContainer(c);
                                    continue;
                                }
                            }
                            else
                            {
                                if (AddStack(c))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                foreach(Container c in valuableContainers)
                {
                    if (!stackCheck())
                    {
                        ContainerStack stack = new ContainerStack();
                        stack.AddContainer(c);
                        ContainerStacks.Add(stack);
                    }
                    else
                    {
                        foreach (ContainerStack stack in ContainerStacks)
                        {
                            if (stack.ContainerWeightCheck(c))
                            {
                                stack.AddContainer(c);
                                continue;
                            }
                            else
                            {
                                if (AddStack(c))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                foreach (Container c in leftOverContainers)
                {
                    if (!stackCheck())
                    {
                        ContainerStack stack = new ContainerStack();
                        stack.AddContainer(c);
                        ContainerStacks.Add(stack);
                        continue;
                    }
                    else
                    {
                        foreach (ContainerStack stack in ContainerStacks)
                        {
                            if (stack.ContainerWeightCheck(c))
                            {
                                stack.AddContainer(c);
                                continue;
                            }
                            else
                            {
                                if (AddStack(c))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
            foreach(ContainerStack stack in ContainerStacks)
            {
                Debug.WriteLine(stack.Weight);
            }
            return true;
        }

        private bool AddStack(Container c)
        {
            if(ContainerStacks.Count < Width * Length)
            {
                ContainerStack newStack = new ContainerStack();
                newStack.AddContainer(c);
                ContainerStacks.Add(newStack);
                return true;
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

        public bool stackCheck()
        {
            if(ContainerStacks.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
