public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> seen = new Dictionary<char, int>();
        int maxLength = 0;
        int start = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char curr = s[i];
            if (seen.ContainsKey(curr) && seen[curr] >= start)
            {
                start = seen[curr] + 1;
            }
            seen[curr] = i;
            maxLength = Math.Max(maxLength, i - start + 1);
        }
        return maxLength;
    }
}