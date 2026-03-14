public class Solution {
    public string GetHappyString(int n, int k) {
        char[] letters = {'a','b','c'};
        List<string> allHappyStrings = new List<string>();

        GenerateHappyStrings (n, "", allHappyStrings, letters);

        if (allHappyStrings.Count < k) {
            return "";
        }

        allHappyStrings.Sort();
        
        return allHappyStrings[k-1];



    }
    private void GenerateHappyStrings (int n, string current, List<string> result, char[] letters) {
        if (current.Length == n) {
            result.Add(current);
            return;
        }

        for (int i=0; i<letters.Length; i++) {
            if (current.Length == 0 || current[current.Length-1] != letters[i]) {
                GenerateHappyStrings(n, current+letters[i], result, letters);
            }
        }
    }
}
