/* public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 1) return "";

        int start = 0, end = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandAroundCenter(s, i, i);
            int len2 = ExpandAroundCenter(s, i, i + 1);
            int len = Math.Max(len1, len2);

            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        return s.Substring(start, end - start + 1);
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
} */

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var resStart = 0;
        var resEnd = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var l = i;
            var r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l > resEnd - resStart)
                {
                    resEnd = r;
                    resStart = l;
                }
                l--;
                r++;
            }

            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l > resEnd - resStart)
                {
                    resEnd = r;
                    resStart = l;
                }
                l--;
                r++;
            }
        }
        return s[resStart..(resEnd + 1)];
    }
}