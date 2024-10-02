class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        x = ""
        n = []

        for i in digits:
            x += str(i)

        y = int(x) + 1

        for i in str(y):
            n.append(i)

        final = [int(num) for num in n]
        
        return final



