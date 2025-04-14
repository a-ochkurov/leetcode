namespace LeetCodeSolutions.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        var class1 = new Class1();

        var testvalue = class1.Test();
        
        Assert.AreEqual(1, testvalue);
    }
}
