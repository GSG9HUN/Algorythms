using BinarySearch;

namespace BinarySearchUnitTests;

[TestClass]
public class ContainerTest
{
    [TestMethod]
    public void BinarySearch1()
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Container container = new Container(list,3);

        int result = container.BinarySearch();

        Assert.AreEqual(2,result);

    }
    [TestMethod]
    public void BinarySearch2()
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
  
        Container container = new Container(list,6);

        int result = container.BinarySearch();

        Assert.AreEqual(5,result);
    }
    [TestMethod]
    public void BinarySearch3()
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
     
        Container container = new Container(list,9);

        int result = container.BinarySearch();

        Assert.AreEqual(8,result);
    }
    [TestMethod]
    public void BinarySearch4()
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
     
        Container container = new Container(list,10);

        int result = container.BinarySearch();

        Assert.AreEqual(-1,result);
    }
}