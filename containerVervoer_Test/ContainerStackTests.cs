using containerVervoer;

namespace containerVervoer_Test;

[TestClass]
public class ContainerStackTests
{
    [TestMethod]
    public void ContainerWeightCheckTest()
    {
        ContainerStack stack = new ContainerStack();
        Container container = new Container(26000, ContainerType.Normal);
        
        stack.AddContainer(container);
        
        Assert.IsTrue(stack.ContainerWeightCheck(container));
    }

    [TestMethod]
    public void ContainerWeightCheckTestCantStack()
    {
        ContainerStack stack = new ContainerStack();
        Container container = new Container(26000, ContainerType.Normal);

        stack.AddContainer(container);
        stack.AddContainer(container);
        stack.AddContainer(container);
        stack.AddContainer(container);
        
        Assert.IsFalse(stack.ContainerWeightCheck(container));
    }
}