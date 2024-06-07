using System.Windows.Forms;
using containerVervoer;

namespace containerVervoer_Test
{
    [TestClass]
    public class ShipyardTests
    {
        [TestMethod]
        public void AddShipTest()
        {
            var shipyard = new Shipyard();
            
            shipyard.AddShip(3,3);
            
            Assert.IsNotNull(shipyard.Ship);
        }

        [TestMethod]
        public void AddContainerToShipyardTest()
        {
            var shipyard = new Shipyard();
            var container = new Container(26000, ContainerType.Normal);
            
            shipyard.AddContainer(container);
            
            Assert.IsTrue(shipyard.Containers.Contains(container));
        }

        [TestMethod]
        public void SortContainersTest()
        {
            var shipyard = new Shipyard();
            var normalContainer = new Container(26000, ContainerType.Normal);
            var cooledContainer = new Container(26000, ContainerType.Cooled);
            var valuableContainer = new Container(26000, ContainerType.Valuable);
            var cooledValuableContainer = new Container(26000, ContainerType.CooledValuable);
            
            shipyard.AddContainer(normalContainer);
            shipyard.AddContainer(cooledContainer);
            shipyard.AddContainer(valuableContainer);
            shipyard.AddContainer(cooledValuableContainer);
            shipyard.SortContainers();
            
            Assert.IsTrue(shipyard.NormalContainers.Contains(normalContainer));
            Assert.IsTrue(shipyard.CooledContainers.Contains(cooledContainer));
            Assert.IsTrue(shipyard.ValuableContainers.Contains(valuableContainer));
            Assert.IsTrue(shipyard.CooledValuableContainers.Contains(cooledValuableContainer));
        }

        [TestMethod]
        public void CheckAboveHalfWeightTest()
        {
            var shipyard = new Shipyard();
            var container = new Container(26000, ContainerType.Normal);
            
            shipyard.AddShip(1,1);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            
            Assert.IsTrue(shipyard.CheckWeight());
        }

        [TestMethod]
        public void CheckBelowHalfWeightTest()
        {
            var shipyard = new Shipyard();
            var container = new Container(26000, ContainerType.Normal);
            
            shipyard.AddShip(1,1);
            shipyard.AddContainer(container);
            
            Assert.IsFalse(shipyard.CheckWeight());
        }

        [TestMethod]
        public void CheckAboveMaxWeightTest()
        {
            var shipyard = new Shipyard();
            var container = new Container(26000, ContainerType.Normal);
            
            shipyard.AddShip(1,1);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            shipyard.AddContainer(container);
            
            Assert.IsFalse(shipyard.CheckWeight());
        }
    }
}