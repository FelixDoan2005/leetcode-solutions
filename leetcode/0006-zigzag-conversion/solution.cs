public class Solution {
    public string Convert(string s, int numRows) {
        string output = "";

        List<List<string>> rows = new List<List<string>>();

        if (numRows <= 1) {
            return s;
        }
        
        int currentRow = 0;
        int direction = 1;

        for (int i=0; i<numRows; i++) {
            rows.Add(new List<string>());
        }

        for (int j=0; j<s.Length; j++) {
            if (currentRow == 0) {
                direction = 1;
            }
            if (currentRow == numRows-1) {
                direction = -1;
            }
            rows[currentRow].Add(s[j].ToString());
            currentRow += direction;

        }

        foreach (List<string> row in rows) {
            foreach (string line in row) {
                output += line;
                }
            }
        return output;
    }
}
