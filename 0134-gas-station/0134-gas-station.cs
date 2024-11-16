public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        int totaltank=0;
        int currenttank=0;
        int start=0;
        for(int i=0;i<gas.Length;i++)
        {
        int netgas = gas[i]-cost[i];
         totaltank=totaltank+netgas;
         currenttank=currenttank+netgas;
        
        
        if(currenttank<0)
        {
            
            start=i+1;
            currenttank=0;
        }
    }
        return totaltank>=0 ? start:-1;
    }
}