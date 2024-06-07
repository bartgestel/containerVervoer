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
        
        public List<Container> NormalContainers { get; private set; } = new List<Container>();
        public List<Container> ValuableContainers { get; private set; } = new List<Container>();
        public List<Container> CooledContainers { get; private set; } = new List<Container>();
        public List<Container> CooledValuableContainers { get; private set; } = new List<Container>();
        public List<Container> LeftOverContainers { get; private set; } = new List<Container>();

        public void AddShip(int width, int length)
        {
            Ship = new Ship(width, length);
        }

        public void AddContainer(Container container)
        {
            Containers.Add(container);
        }

        public void SortContainers()
        {
            NormalContainers = Containers.Where(c => c.Type == ContainerType.Normal).ToList();
            ValuableContainers = Containers.Where(c => c.Type == ContainerType.Valuable).ToList();
            CooledContainers = Containers.Where(c => c.Type == ContainerType.Cooled).ToList();
            CooledValuableContainers = Containers.Where(c => c.Type == ContainerType.CooledValuable).ToList();
        }

        public bool CheckWeight()
        {
            int totalWeight = 0;
            foreach (Container container in Containers)
            {
                totalWeight += container.Weight;
            }
            if(totalWeight > Ship.MaxWeight)
            {
                MessageBox.Show("The ship is above max weight");
                return false;
            }
            if(totalWeight > Ship.MaxWeight * 0.5)
            {
                MessageBox.Show("The ship is above 50% of max weight");
                return true;
            }
            MessageBox.Show("The ship is below 50% of max weight");
            return false;
        }

        public void LoadContainers()
        {
            if (CheckWeight())
            {
                SortContainers();
                Ship.LoadCooledContainer(CooledContainers);
                Ship.LoadNormalContainer(NormalContainers);
                Ship.LoadCooledValuableContainers(CooledValuableContainers);
                Ship.LoadValuableContainers(ValuableContainers);
                Ship.LoadLeftOverContainers();
            }
        }
    }
}
