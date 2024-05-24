using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containerVervoer
{
    public enum ContainerType
    {
        Normal,
        Valuable,
        Cooled,
        CooledValuable
    }

    public class Container
    {
        public int Weight { get; private set; } = 400;
        public ContainerType Type { get; private set; }

        public Container(int weight, ContainerType type)
        {
            Weight += weight;
            Type = type;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}, Type: {Type}";
        }
    }
}
