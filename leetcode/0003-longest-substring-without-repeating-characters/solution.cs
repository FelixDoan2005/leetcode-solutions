public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        List<string> substrings = new List<string>();
        string substring = "";
        int substringLength = 0;

        for (int i=0; i < s.Length; i++) {
            if (!substring.Contains(s[i]) ){
                substring += s[i];
            } else {
                int iOfDup = substring.IndexOf(s[i]);
                substring = substring.Remove(0, iOfDup + 1);
                substring += s[i];
            }
            if (substringLength < substring.Length)
                substringLength = substring.Length;
        }
        return substringLength;
    }
}
