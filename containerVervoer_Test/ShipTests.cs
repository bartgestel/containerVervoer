using containerVervoer;

namespace containerVervoer_Test;

public class ShipTests
{
    [TestMethod]
    public void GetClearanceRowsTest()
    {
        Ship ship = new Ship(5, 6);
        int[] expected = {2, 5};
            
        CollectionAssert.AreEqual(expected, ship.ClearanceRows);
    }
}