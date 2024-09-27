public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexMap = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            var currentNum = nums[i];
            var remainder = target - nums[i];
            if (indexMap.ContainsKey(remainder))
            {
                var index = indexMap[remainder];
                return new int[] { index, i };
            }

            indexMap[currentNum] = i;
        }

        return default;
    }
}