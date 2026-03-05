public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        List<string> arr = new List<string>();
        List<string> answer = new List<string>();
        int minLength = strs[0].Length;

        foreach (string word in strs) {
            if (word.Length < minLength) {
                minLength = word.Length;
            }
        }
        
        for (int i=0; i<minLength; i++) { //char
            arr.Clear();
            for (int j=0; j<strs.Length; j++) //word
                arr.Add(strs[j][i].ToString());

            for (int q=0; q<arr.Count-1; q++) {
                if (arr[q] != arr[q+1]) {
                    return string.Join("", answer);
                } 
            }
            answer.Add(arr[0]);
        } 
        return string.Join("", answer);
    }
}
