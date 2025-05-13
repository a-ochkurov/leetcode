namespace LeetCodeSolutions;

public class TwoSumClass
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var mapValue = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var res = target - nums[i];
            if (mapValue.ContainsKey(res))
            {
                return [i, mapValue[res]];
            }

            mapValue[nums[i]] = i;
        }
        
        return [];
    }
}
