public class Solution {
    public string LongestPalindrome(string s) {
        
        List<string> x = new List<string>();
        int left;
        int right;

        string longest = "";
        string oddPalindrome = "";
        string evenPalindrome = "";

        if (s.Length == 1) {
            return s;
        }

        for (int i=1; i<s.Length ; i++) {
            left = i-1;
            right = i+1;
            oddPalindrome = s[i].ToString();
            evenPalindrome = "";

            //odd palindromes
            while (left>=0 && right<s.Length) {
                if (s[left] == s[right]) {
                    oddPalindrome = s[left] + oddPalindrome + s[right];
                    left--;
                    right++;
                } else {
                    break;
                }
            }
            x.Add(oddPalindrome);
            //even palindromes
            left = i-1;
            right = i;
            while (left>=0 && right<s.Length) {
                if (s[left] == s[right]) {
                    evenPalindrome = s[left] + evenPalindrome + s[right];
                    left--;
                    right++;
                } else {
                    break;
                }
            }
            x.Add(evenPalindrome);
        }
        foreach (string p in x) {
            if (p.Length > longest.Length){
                longest = p;
            }
        }
        return longest;
    }
}
