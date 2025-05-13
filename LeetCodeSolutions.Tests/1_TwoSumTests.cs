namespace LeetCodeSolutions.Tests;

[TestClass]
public class TwoSumTests
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = [3,2,4];
        var target = 6;
        int[] expectedResult = [1,2];

        var result = TwoSumClass.TwoSum(nums, target);

        CollectionAssert.AreEqual(expectedResult, result);
    }
}
