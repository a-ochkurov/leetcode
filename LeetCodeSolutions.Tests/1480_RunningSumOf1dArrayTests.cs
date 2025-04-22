namespace LeetCodeSolutions.Tests;

[TestClass]
public sealed class RunningSumOf1dArrayTests
{
    [TestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestMethod1(int[] input, int[] expectedResult)
    {
        var result = RunningSumOf1dArray.RunningSum(input);

        CollectionAssert.AreEqual(expectedResult, result);
    }
    
public static IEnumerable<object[]> GetTestData()
{
    yield return new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 } };
}
}
