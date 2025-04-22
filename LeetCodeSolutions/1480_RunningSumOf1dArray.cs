namespace LeetCodeSolutions;

public class RunningSumOf1dArray
{
    public static int[] RunningSum(int[] nums)
    {
        int[] result = new int[nums.Length];

        result[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i-1] + nums[i];
        }
        
        return result;
    }
}
