using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containerVervoer
{
    public class Shipyard
    {
        public Ship Ship { get; private set; }

        public List<Container> Containers { get; private set; } = new List<Container>();

        public void AddShip(int width, int length)
        {
            Ship = new Ship(width, length);
        }

        public void AddContainer(Container container)
        {
            Containers.Add(container);
        }
    }
}
