public class Solution {
    public bool IsPalindrome(int x) {

        string X = x.ToString();
        char[] arr = X.ToCharArray();
        char[] flipped = new char[arr.Length];

        for(int i=0; i<arr.Length; i++) {
            flipped [i] = arr[arr.Length - i -1];
        }

        return new string(arr) == new string(flipped);
    }
}
