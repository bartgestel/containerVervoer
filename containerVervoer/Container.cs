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
        public int Weight { get; private set; } = 4000;
        public ContainerType Type { get; private set; }

        public Container(int weight, ContainerType type)
        {
            if(weight + Weight <= 30000)
            {
                Weight += weight;
                Type = type;
            }
            else
            {
                MessageBox.Show("Container is too heavy");
                throw new Exception("Container is too heavy");
            }        }

        public override string ToString()
        {
            return $"Weight: {Weight}, Type: {Type}";
        }
    }
}
