class Solution(object):
    def isPalindrome(self, x):
        y = str(x)[::-1]
        if str(x) == (y):
            return True
        else:
            return False
