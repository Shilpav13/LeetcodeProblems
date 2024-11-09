public class Solution {
    public int HIndex(int[] citations) {
        int n=citations.Length,i;
        Array.Sort(citations);
        
           for( i=1;i<=n;i++)
             if(citations[n-i]< i) break;
            return i-1;
            
        
    }
}