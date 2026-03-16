public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (s.Length == 0 || t.Length == 0) return "";

        int[] count = new int[128];

        foreach (char c in t)
            count[c]++;

        int left = 0;
        int right = 0;
        int required = t.Length;

        int minLen = int.MaxValue;
        int start = 0;

        while (right < s.Length)
        {
            if (count[s[right]] > 0)
                required--;

            count[s[right]]--;
            right++;

            while (required == 0)
            {
                if (right - left < minLen)
                {
                    minLen = right - left;
                    start = left;
                }

                count[s[left]]++;

                if (count[s[left]] > 0)
                    required++;

                left++;
            }
        }

        return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
    }
}
