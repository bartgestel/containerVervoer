using containerVervoer;

namespace containerVervoer_Test;

[TestClass]
public class ShipTests
{
    [TestMethod]
    public void GetClearanceRowsTest()
    {
        Ship ship = new Ship(5, 6);
        int[] expected = {2, 5};
            
        CollectionAssert.AreEqual(expected, ship.ClearanceRows);
    }

    [TestMethod]
    public void LoadCooledContainerTest()
    {
        Ship ship = new Ship(5, 6);
        var containers = new List<Container>{ new Container(26000, ContainerType.Cooled) };
        
        ship.LoadCooledContainer(containers);
        
        Assert.IsTrue(ship.Rows[0].ContainerStacks[0].Containers.Contains(containers[0]));
    }
    
    [TestMethod]
    public void LoadNormalContainerTest()
    {
        Ship ship = new Ship(5, 6);
        var containers = new List<Container>{ new Container(26000, ContainerType.Normal) };
        
        ship.LoadNormalContainer(containers);
        
        Assert.IsTrue(ship.Rows[0].ContainerStacks[0].Containers.Contains(containers[0]));
    }

    [TestMethod]
    public void LoadValuableContainerTest()
    {
        Ship ship = new Ship(5, 6);
        var containers = new List<Container>{ new Container(26000, ContainerType.Valuable) };
        
        ship.LoadValuableContainers(containers);
        
        Assert.IsTrue(ship.Rows[0].ContainerStacks[0].Containers.Contains(containers[0]));
    }
    
    [TestMethod]
    public void LoadCooledValuableContainerTest()
    {
        Ship ship = new Ship(5, 6);
        var containers = new List<Container>{ new Container(26000, ContainerType.CooledValuable) };
        
        ship.LoadCooledValuableContainers(containers);
        
        Assert.IsTrue(ship.Rows[0].ContainerStacks[0].Containers.Contains(containers[0]));
    }
}