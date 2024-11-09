public class Solution {
    public int Jump(int[] nums) {
        int destination=nums.Length-1;
        int jumpIdx=0;
        int coverage=0;
        int totaljump=0;
        if(nums.Length==1)
        {
            return 0;

        }
        for(int i=0;i<=nums.Length;i++)
        {
            coverage=Math.Max(coverage,i+nums[i]);

            if(i==jumpIdx)
            {
                jumpIdx=coverage;
                totaljump++;


                if(coverage>=destination)
                {
                    return totaljump;
                }
            }
        }
        return totaljump;
    }
}