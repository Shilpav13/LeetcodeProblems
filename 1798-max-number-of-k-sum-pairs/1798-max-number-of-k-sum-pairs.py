class Solution:
    def maxOperations(self, nums: List[int], k: int) -> int:
        i = 0
        j= len(nums) - 1
        count = 0
        while j > i:
            if nums[i] + nums[j] == k:
                count= count + 1
            else:
                i= i+1
                j=j-1
                
        return count
        