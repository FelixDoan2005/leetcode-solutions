class Solution(object):
    def lengthOfLongestSubstring(self, s):
        max_len = 0
        for i in range(len(s)): 
            seen = set()
            for j in range (i, len(s)):
                if s[j] in seen:
                    break
                else:
                    seen.add(s[j])
            max_len = max(max_len, len(seen))
    
        return max_len
