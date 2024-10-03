class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        for index, value in enumerate(nums):
            if value == target:
                return(index)
            else:
                nums.append(target)
                x = sorted(nums)
                for index, value in enumerate(x):
                    if value == target:
                        return(index)
        
                break

